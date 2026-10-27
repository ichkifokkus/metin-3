using UnityEngine;
using UnityEngine.InputSystem;

namespace FantasyOnline.Player
{
    /// <summary>
    /// WASD-Bewegung relativ zur Kamera, Springen mit Leertaste und Schwerkraft.
    /// Lokaler Prototyp (Phase 1) – noch ohne Netzwerk und Serverprüfung.
    /// </summary>
    [RequireComponent(typeof(CharacterController))]
    public class PlayerMovement : MonoBehaviour
    {
        [Tooltip("Leer lassen, dann wird automatisch die Main Camera verwendet.")]
        [SerializeField] private Transform cameraTransform;

        [Header("Bewegung")]
        [Min(0f)] [SerializeField] private float moveSpeed = 5f;
        [Tooltip("Grad pro Sekunde, mit denen sich die Figur in Laufrichtung dreht.")]
        [Min(0f)] [SerializeField] private float rotationSpeed = 720f;

        [Header("Springen und Schwerkraft")]
        [Min(0f)] [SerializeField] private float jumpHeight = 1.2f;
        [SerializeField] private float gravity = -20f;

        private CharacterController controller;
        private float verticalVelocity;

        private void Awake()
        {
            controller = GetComponent<CharacterController>();
            if (cameraTransform == null && Camera.main != null)
            {
                cameraTransform = Camera.main.transform;
            }
        }

        private void Update()
        {
            Vector3 move = ToWorldDirection(ReadMoveInput());

            if (move.sqrMagnitude > 0.0001f)
            {
                Quaternion targetRotation = Quaternion.LookRotation(move);
                transform.rotation = Quaternion.RotateTowards(
                    transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }

            if (controller.isGrounded)
            {
                // Kleiner negativer Wert hält die Figur zuverlässig am Boden.
                if (verticalVelocity < 0f)
                {
                    verticalVelocity = -2f;
                }

                if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
                {
                    verticalVelocity = Mathf.Sqrt(jumpHeight * -2f * gravity);
                }
            }

            verticalVelocity += gravity * Time.deltaTime;

            Vector3 velocity = move * moveSpeed + Vector3.up * verticalVelocity;
            controller.Move(velocity * Time.deltaTime);
        }

        private static Vector2 ReadMoveInput()
        {
            Keyboard keyboard = Keyboard.current;
            if (keyboard == null)
            {
                return Vector2.zero;
            }

            float x = (keyboard.dKey.isPressed ? 1f : 0f) - (keyboard.aKey.isPressed ? 1f : 0f);
            float y = (keyboard.wKey.isPressed ? 1f : 0f) - (keyboard.sKey.isPressed ? 1f : 0f);
            return Vector2.ClampMagnitude(new Vector2(x, y), 1f);
        }

        private Vector3 ToWorldDirection(Vector2 input)
        {
            if (cameraTransform == null)
            {
                return new Vector3(input.x, 0f, input.y);
            }

            // Kamerarichtung flach auf den Boden projizieren, damit Blick nach unten nicht bremst.
            Vector3 forward = Vector3.ProjectOnPlane(cameraTransform.forward, Vector3.up).normalized;
            Vector3 right = Vector3.ProjectOnPlane(cameraTransform.right, Vector3.up).normalized;
            return Vector3.ClampMagnitude(forward * input.y + right * input.x, 1f);
        }
    }
}

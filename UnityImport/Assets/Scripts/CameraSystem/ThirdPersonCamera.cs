using UnityEngine;
using UnityEngine.InputSystem;

namespace FantasyOnline.CameraSystem
{
    /// <summary>
    /// Kamera kreist per Maus um die Spielfigur, zoomt per Mausrad und
    /// weicht Hindernissen aus. Gehört auf die Main Camera.
    /// </summary>
    public class ThirdPersonCamera : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private CameraProfile profile;
        [Tooltip("Mauszeiger im Spiel ausblenden. Esc gibt ihn frei, Linksklick fängt ihn wieder ein.")]
        [SerializeField] private bool lockCursor = true;

        private float yaw;
        private float pitch = 15f;
        private float currentDistance;

        private void Start()
        {
            if (target == null || profile == null)
            {
                Debug.LogError("ThirdPersonCamera: Target oder Profile fehlt im Inspector.", this);
                enabled = false;
                return;
            }

            currentDistance = profile.defaultDistance;
            yaw = target.eulerAngles.y;
            SetCursorLocked(lockCursor);
        }

        private void LateUpdate()
        {
            ReadInput();
            PositionCamera();
        }

        private void ReadInput()
        {
            Mouse mouse = Mouse.current;
            if (mouse == null)
            {
                return;
            }

            Keyboard keyboard = Keyboard.current;
            if (keyboard != null && keyboard.escapeKey.wasPressedThisFrame)
            {
                SetCursorLocked(false);
            }
            else if (lockCursor && mouse.leftButton.wasPressedThisFrame)
            {
                SetCursorLocked(true);
            }

            // Nur drehen, solange der Mauszeiger eingefangen ist.
            if (Cursor.lockState == CursorLockMode.Locked)
            {
                Vector2 delta = mouse.delta.ReadValue();
                yaw += delta.x * profile.mouseSensitivity;
                pitch -= delta.y * profile.mouseSensitivity;
                pitch = Mathf.Clamp(pitch, profile.minPitch, profile.maxPitch);
            }

            // Nur die Richtung des Mausrads nutzen, da die Rohwerte je nach Gerät stark schwanken.
            float scroll = mouse.scroll.ReadValue().y;
            if (scroll != 0f)
            {
                currentDistance -= Mathf.Sign(scroll) * profile.zoomStep;
            }
            currentDistance = Mathf.Clamp(currentDistance, profile.minDistance, profile.maxDistance);
        }

        private void PositionCamera()
        {
            Quaternion rotation = Quaternion.Euler(pitch, yaw, 0f);
            Vector3 pivot = target.position + profile.targetOffset;
            Vector3 direction = rotation * Vector3.back;

            // Steht etwas zwischen Figur und Kamera, rückt die Kamera näher heran.
            float distance = currentDistance;
            if (Physics.SphereCast(pivot, profile.collisionRadius, direction, out RaycastHit hit,
                    currentDistance, profile.collisionLayers, QueryTriggerInteraction.Ignore))
            {
                distance = hit.distance;
            }

            transform.SetPositionAndRotation(pivot + direction * distance, rotation);
        }

        private static void SetCursorLocked(bool locked)
        {
            Cursor.lockState = locked ? CursorLockMode.Locked : CursorLockMode.None;
            Cursor.visible = !locked;
        }
    }
}

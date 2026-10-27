using UnityEngine;

namespace FantasyOnline.CameraSystem
{
    /// <summary>
    /// Einstellungen für die Third-Person-Kamera. Pro Spielmodus kann später
    /// ein eigenes Profil angelegt werden (MMORPG, Survival, MOBA).
    /// Anlegen in Unity: Rechtsklick im Project-Fenster → Create → Fantasy Online → Camera Profile.
    /// </summary>
    [CreateAssetMenu(fileName = "CameraProfile", menuName = "Fantasy Online/Camera Profile")]
    public class CameraProfile : ScriptableObject
    {
        [Header("Abstand")]
        [Min(0.5f)] public float defaultDistance = 5f;
        [Min(0.5f)] public float minDistance = 2f;
        [Min(0.5f)] public float maxDistance = 10f;
        [Tooltip("Wie viele Meter ein Mausrad-Schritt heran- oder herauszoomt.")]
        [Min(0f)] public float zoomStep = 1f;

        [Header("Drehung")]
        [Tooltip("Grad pro Pixel Mausbewegung.")]
        [Min(0f)] public float mouseSensitivity = 0.15f;
        [Range(-89f, 0f)] public float minPitch = -30f;
        [Range(0f, 89f)] public float maxPitch = 70f;

        [Header("Ausrichtung")]
        [Tooltip("Punkt relativ zur Spielfigur, um den die Kamera kreist (etwa Kopfhöhe).")]
        public Vector3 targetOffset = new Vector3(0f, 1.6f, 0f);

        [Header("Kollision")]
        [Tooltip("Radius der Prüfkugel, damit die Kamera nicht in Wände rutscht.")]
        [Min(0f)] public float collisionRadius = 0.25f;
        public LayerMask collisionLayers = ~0;
    }
}

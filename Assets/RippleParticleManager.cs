using UnityEngine;

public class RippleParticleManager : MonoBehaviour
{
    public ParticleSystem rippleEffect;  // Le Particle System pour l'effet ripple
    public Camera mainCamera;            // La caméra principale (Main Camera)

    private void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main;  // Assigne automatiquement la caméra principale
        }

        rippleEffect.Stop();  // Assurez-vous que le Particle System est arrêté au début
    }

    private void Update()
    {
        // Si un clic gauche de la souris est détecté
        if (Input.GetMouseButtonDown(0))
        {
            TriggerRippleEffect();
        }
    }

    void TriggerRippleEffect()
    {
        // Obtenir la position du clic en coordonnées écran (Screen Space)
        Vector3 mousePosition = Input.mousePosition;

        // Définir la profondeur (distance entre la caméra et le point de clic dans l'espace monde)
        mousePosition.z = mainCamera.nearClipPlane + 1f;  // Un petit ajustement pour placer le ripple juste devant la caméra

        // Convertir la position en coordonnées monde (World Space)
        Vector3 worldPosition = mainCamera.ScreenToWorldPoint(mousePosition);

        // Déplacer le Particle System à la position du clic
        rippleEffect.transform.position = worldPosition;

        // Activer et jouer le Particle System
        rippleEffect.Play();
    }
}

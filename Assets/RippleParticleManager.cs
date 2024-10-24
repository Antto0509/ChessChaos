using UnityEngine;
using UnityEngine.EventSystems;

public class RippleParticleManager : MonoBehaviour
{
    public ParticleSystem rippleEffect;   // Le Particle System pour l'effet ripple
    public Canvas canvas;                 // Le Canvas contenant l'UI

    // Méthode publique que vous pouvez appeler à partir de l'Event Trigger
    public void TriggerRippleEffect(BaseEventData data)
    {
        PointerEventData pointerData = (PointerEventData)data;

        // Convertir la position du clic en espace monde
        Vector2 clickPosition;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            canvas.transform as RectTransform, 
            pointerData.position, 
            canvas.worldCamera, 
            out clickPosition
        );

        // Positionner le Particle System à l'endroit du clic
        rippleEffect.transform.position = canvas.transform.TransformPoint(clickPosition);

        // Jouer l'effet ripple
        rippleEffect.Play();
    }
}
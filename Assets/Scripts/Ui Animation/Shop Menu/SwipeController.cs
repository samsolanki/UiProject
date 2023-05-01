using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeController : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public float swipeThreshold = 50f;
    public float swipeSpeed = 10f;

    private Vector2 startPosition;
    private Vector2 endPosition;

    public void OnDrag(PointerEventData eventData)
    {
        // Get the current position of the drag
        endPosition = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Calculate the distance of the swipe
        float swipeDistance = Vector2.Distance(startPosition, endPosition);

        // Check if the swipe is above the swipe threshold
        if (swipeDistance > swipeThreshold)
        {
            // Calculate the direction of the swipe
            Vector2 swipeDirection = (endPosition - startPosition).normalized;

            // Move the image in the direction of the swipe
            transform.Translate(swipeDirection * swipeSpeed);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        // Get the starting position of the drag
        startPosition = eventData.position;
    }
}

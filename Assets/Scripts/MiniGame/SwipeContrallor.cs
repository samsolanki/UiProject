using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeContrallor : MonoBehaviour
{
    private bool swipeLeft, swipeRight, swipeUp, swipeDown;
    private bool isDragging = false;
    private Vector2 startTouch, swipeDelta;

    // Reference to the player transform
    public Transform playerTransform;

    // Rotation speed for the player
    public float rotationSpeed = 5f;

    // Update is called once per frame
    void Update()
    {

        swipeLeft = swipeRight = swipeUp = swipeDown = false;

        #region Standalone Inputs
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            startTouch = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Reset();
        }
        #endregion

        #region Mobile Inputs
        if (Input.touches.Length > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                isDragging = true;
                startTouch = Input.touches[0].position;
            }
            else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                Reset();
            }
        }
        #endregion

        // Calculate the distance of swipe
        swipeDelta = Vector2.zero;
        if (isDragging)
        {
            if (Input.touches.Length > 0)
                swipeDelta = Input.touches[0].position - startTouch;
            else if (Input.GetMouseButton(0))
                swipeDelta = (Vector2)Input.mousePosition - startTouch;
        }

        // Did we cross the deadzone?
        if (swipeDelta.magnitude > 125)
        {

            // Which direction?
            float x = swipeDelta.x;
            float y = swipeDelta.y;
            if (Mathf.Abs(x) > Mathf.Abs(y))
            {
                // Left or Right
                if (x < 0)
                    swipeLeft = true;
                else
                    swipeRight = true;
            }
            else
            {
                // Up or Down
                if (y < 0)
                    swipeDown = true;
                else
                    swipeUp = true;
            }

            // Rotate the player in the Y axis based on the swipe direction
            Quaternion newRotation = Quaternion.identity;
            if (swipeLeft)
                newRotation = Quaternion.Euler(playerTransform.rotation.eulerAngles + Vector3.up * -90f);
            else if (swipeRight)
                newRotation = Quaternion.Euler(playerTransform.rotation.eulerAngles + Vector3.up * 90f);

            playerTransform.rotation = Quaternion.Slerp(playerTransform.rotation, newRotation, rotationSpeed * Time.deltaTime);

            Reset();
        }
    }

    private void Reset()
    {
        startTouch = swipeDelta = Vector2.zero;
        isDragging = false;
    }

    public bool SwipeLeft
    {
        get { return swipeLeft; }
    }

    public bool SwipeRight
    {
        get { return swipeRight; }
    }

    public bool SwipeUp
    {
        get { return swipeUp; }
    }

    public bool SwipeDown
    {
        get { return swipeDown; }
    }
}

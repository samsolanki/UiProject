using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ImageSwipeContrallorUI : MonoBehaviour , IDragHandler ,IBeginDragHandler , IEndDragHandler
{

    [SerializeField] private float flt_DiffrentBetweenTwoSlide; //DIFFRENCE BETWEEN TO IMAGES
    [SerializeField] private int int_NumberOfImages; //COUNT OF ALL IMAGE IN SLIDER 

    private Vector3 tempLocation;

    private void Start()
    {
        tempLocation = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        float diffrence = eventData.pressPosition.x - eventData.position.x;

        if(diffrence > flt_DiffrentBetweenTwoSlide / 2)
        {
            this.transform.position =  new Vector2(diffrence, -753f);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
    }
}

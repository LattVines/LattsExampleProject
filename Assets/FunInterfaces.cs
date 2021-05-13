using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FunInterfaces : MonoBehaviour, IPointerClickHandler, IDragHandler, IPointerEnterHandler, IPointerExitHandler, IEndDragHandler, IBeginDragHandler
{

    //FUN INTERFACES FOR THE UNITY CANVAS OBJECTS ONLY

    public void OnPointerClick(PointerEventData eventData)
    {
        print("OnPointerClick");
    }

    public void OnDrag(PointerEventData eventData)
    {
        print("OnDrag");

    }


    public void OnEndDrag(PointerEventData eventData)
    {
        print("OnEndDrag");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        print("OnBeginDrag");
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        print("OnPointerEnter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        print("OnPinterExit");
    }
}

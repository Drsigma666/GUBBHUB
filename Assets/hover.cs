using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    
    public GameObject radio;

    public void OnPointerEnter(PointerEventData eventData)
    {
        radio.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        radio.SetActive(false);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Radio_hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject Pre;
    public void OnPointerEnter(PointerEventData eventData)
    {
        Pre.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Pre.SetActive(false);
    }
}

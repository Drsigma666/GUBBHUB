using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject Radio;
    public void OnPointerEnter(PointerEventData eventData)
    {
        Radio.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Radio.SetActive(false);
    }
}

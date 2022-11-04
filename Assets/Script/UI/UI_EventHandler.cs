using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class UI_EventHandler : MonoBehaviour, IPointerClickHandler
{
    public Action<PointerEventData> OnClicked = null; 
    public void OnPointerClick(PointerEventData eventData)
    {
        if (OnClicked != null)
            OnClicked.Invoke(eventData);
    }
}

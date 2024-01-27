using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class UIEvenTrigger : MonoBehaviour, IPointerClickHandler
{
    public Action<GameObject, PointerEventData> onClick;

    public static UIEvenTrigger Get(GameObject go)
    {
        UIEvenTrigger trigger = go.GetComponent<UIEvenTrigger>();
        if(trigger == null)
        {
            trigger = go.AddComponent<UIEvenTrigger>();
        }

        return trigger;
    }

    public void SetClickCallback(Action<GameObject, PointerEventData> callback)
    {
        this.onClick = callback;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        if(onClick != null)
        {
            Debug.Log("[UIEvenTrigger] onClick ");
            onClick(this.gameObject, eventData);
        }
        else
        {
            Debug.Log("[UIEvenTrigger] onClick is null");
        }
    }
}

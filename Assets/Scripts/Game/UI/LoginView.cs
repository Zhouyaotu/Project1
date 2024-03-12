using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LoginView : UIBase
{
    private UIEvenTrigger btnStartEventTrigger;

    private void Awake()
    {
        this.btnStartEventTrigger = ClickEventRegister("bg/startBtn");
        if (this.btnStartEventTrigger != null)
        {
            this.btnStartEventTrigger.onClick = OnClick;
        }
        else
        {
            Debug.Log("btnStartEventTrigger is null !");
        }
        //this.btnStartEventTrigger.SetClickCallback(this.OnClick);
    }

    protected override void OnShow()
    {
        this.gameObject.SetActive(true);
    }

    protected override void OnHide()
    {
        this.gameObject.SetActive(false);
    }

    protected override void OnDestroyUI()
    {
        
    }

    private void OnClick(GameObject go, PointerEventData pData)
    {
        Debug.Log("Start OnClick !");
        this.Hide();
        FightStatManager.Instance.SwitchFightStat(FightStat.Begin);
    }
}

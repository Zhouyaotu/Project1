using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 界面基类
 */ 

public abstract class UIBase : MonoBehaviour
{
    // TODO：UIBase应该拥有两个Static属性：name和address
    // 添加一个纯虚函数，保证每一个子类都需要实现，内容为注册name和address
    public virtual void Show()
    {
        this.OnShow();
    }

    public virtual void Hide()
    {
        this.OnHide();
    }

    public void Destroy()
    {
        this.OnDestroyUI();
    }

    protected abstract void OnShow();

    protected abstract void OnHide();

    protected abstract void OnDestroyUI();


    public UIEvenTrigger ClickEventRegister(string name)
    {
        var tsf = this.transform.Find(name);
        return UIEvenTrigger.Get(tsf.gameObject);
    }
}

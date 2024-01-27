using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 界面基类
 */ 

public class UIBase : MonoBehaviour
{
    // TODO：UIBase应该拥有两个Static属性：name和address
    // 添加一个纯虚函数，保证每一个子类都需要实现，内容为注册name和address
    public virtual void Show()
    {
        this.gameObject.SetActive(true);
    }

    public virtual void Hide()
    {
        this.gameObject.SetActive(false);
    }

    public virtual void Close()
    {

    }

    public virtual void Reset()
    {

    }

    public void OnDestroy()
    {

    }

    public UIEvenTrigger ClickEventRegister(string name)
    {
        var tsf = this.transform.Find(name);
        return UIEvenTrigger.Get(tsf.gameObject);
    }
}

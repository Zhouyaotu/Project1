using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * �������
 */ 

public abstract class UIBase : MonoBehaviour
{
    // TODO��UIBaseӦ��ӵ������Static���ԣ�name��address
    // ���һ�����麯������֤ÿһ�����඼��Ҫʵ�֣�����Ϊע��name��address
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

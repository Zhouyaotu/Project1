using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * �������
 */ 

public class UIBase : MonoBehaviour
{
    // TODO��UIBaseӦ��ӵ������Static���ԣ�name��address
    // ���һ�����麯������֤ÿһ�����඼��Ҫʵ�֣�����Ϊע��name��address
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

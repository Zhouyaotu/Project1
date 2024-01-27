using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * UI管理类
 */

public class UIManager : MonoBehaviour
{
    // TODO：简单实现一个单例（in common）
    public static UIManager Instance;

    private Transform uiRootTrf;

    private Dictionary<string, UIBase> uiList = new Dictionary<string, UIBase>();

    void Awake()
    {
        Instance = this;
    }

    public void Init()
    {
        uiRootTrf = GameObject.Find("UI").transform;
    }

    public UIBase ShowUI<T>(string name) where T:UIBase
    {
        UIBase ui = null;
        if(!uiList.TryGetValue(name, out ui))
        {
            // TODO: 实现一个资源管理类，加载addressable资源
            GameObject uiGO = Instantiate( Resources.Load("Prefabs/UI/" + name)) as GameObject;
            if(uiGO)
            {
                uiGO.transform.SetParent(uiRootTrf, false);
                uiGO.name = name;
                ui = uiGO.AddComponent<T>();
                uiList.Add(name, ui);
            }
            else
            {
                return null;
            }
            
        }

        if (ui != null)
        {
            ui.Show();
        }
        return ui;
    }

    public void HideUI(string name)
    {
        if (uiList.TryGetValue(name, out UIBase ui))
        {
            ui.Hide();
        }
    }

    public void DestoryUI(string name)
    {
        if (uiList.TryGetValue(name, out UIBase ui))
        {
            uiList.Remove(name);
            ui.OnDestroy();
            Destroy(ui.gameObject);
        }
    }

    public void ClearAll()
    {
        foreach (var item in uiList)
        {
            UIBase ui = item.Value;
            ui.OnDestroy();
            Destroy(ui.gameObject);
        }
        uiList.Clear();
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class AppMain : MonoBehaviour
{
    private void Awake()
    {
        // TODO 各种单例类应该单独管理，而不是挂到GameRoot上
        this.gameObject.AddComponent<UIManager>();
    }

    void Start()
    {
        //Init config table
        GameConfigManager.Instance.init();

        // NOTE：这里的名字要和prefab的名字一致
        // 应该改为每一个UI脚本都有一个名字，用于注册Dict
        // 文件使用addressable管理（注意理解异步加载）
        UIManager.Instance.ShowUI<LoginView>("LoginUI");

        //Test
        string name = GameConfigManager.Instance.GetCardById("10001")["name"];
        UnityEngine.Debug.Log("test:"+name);
        //print(name);
    }

    void Update()
    {
        
    }
}

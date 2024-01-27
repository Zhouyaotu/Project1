using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppMain : MonoBehaviour
{
    private void Awake()
    {
        // 单例统一加载
        // TODO 各种单例类应该单独管理，而不是挂到GameRoot上

        // Common
        this.gameObject.AddComponent<UIManager>();
        this.gameObject.AddComponent<AudiManager>();

        // GamePlay
        this.gameObject.AddComponent<RoleManager>();
        this.gameObject.AddComponent<FightManager>();
    }

    void Start()
    {
        // 单例初始化
        UIManager.Instance.Init();
        AudiManager.Instance.Init();
        RoleManager.Instance.Init();

        // NOTE：这里的名字要和prefab的名字一致
        // 应该改为每一个UI脚本都有一个名字，用于注册Dict
        // 文件使用addressable管理（注意理解异步加载）
        UIManager.Instance.ShowUI<LoginView>("LoginUI");
        AudiManager.Instance.PlayBGM("bgm1");
    }

    void Update()
    {
        
    }
}

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
        this.gameObject.AddComponent<GameConfigManager>();

        // GamePlay
        this.gameObject.AddComponent<PlayerManager>();
        this.gameObject.AddComponent<FightStatManager>();
        this.gameObject.AddComponent<EnemyManager>();
        this.gameObject.AddComponent<FightCardManager>();
    }

    void Start()
    {
        // 单例初始化
        UIManager.Instance.Init();
        AudiManager.Instance.Init();
        GameConfigManager.Instance.init();

        PlayerManager.Instance.Init();
        FightStatManager.Instance.Init();
        EnemyManager.Instance.Init();
        FightCardManager.Instance.Init();

        // 游戏初始化加载 
        AudiManager.Instance.PlayBGM("bgm1");
        UIManager.Instance.ShowUI<LoginView>("LoginUI");// NOTE：这里的名字要和prefab的名字一致
        // TODO 应该改为每一个UI脚本都有一个名字，用于注册Dict
        // 文件使用addressable管理（注意理解异步加载）
        

        //Test
        string name = GameConfigManager.Instance.GetCardDataById("10001",PropertyType.name);
        UnityEngine.Debug.Log("Newest version test:" + name);
        //print(name);
    }

    void Update()
    {
        
    }
}

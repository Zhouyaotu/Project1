using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppMain : MonoBehaviour
{
    private void Awake()
    {
        // ����ͳһ����
        // TODO ���ֵ�����Ӧ�õ������������ǹҵ�GameRoot��

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
        // ������ʼ��
        UIManager.Instance.Init();
        AudiManager.Instance.Init();
        GameConfigManager.Instance.init();

        PlayerManager.Instance.Init();
        FightStatManager.Instance.Init();
        EnemyManager.Instance.Init();
        FightCardManager.Instance.Init();

        // NOTE�����������Ҫ��prefab������һ��
        // Ӧ�ø�Ϊÿһ��UI�ű�����һ�����֣�����ע��Dict
        // �ļ�ʹ��addressable����ע������첽���أ�
        UIManager.Instance.ShowUI<LoginView>("LoginUI");
        AudiManager.Instance.PlayBGM("bgm1");

        //Test
        string name = GameConfigManager.Instance.GetCardDataById("10001",PropertyType.name);
        UnityEngine.Debug.Log("Newest version test:" + name);
        //print(name);
    }

    void Update()
    {
        
    }
}

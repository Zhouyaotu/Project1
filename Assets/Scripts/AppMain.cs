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

        // GamePlay
        this.gameObject.AddComponent<RoleManager>();
        this.gameObject.AddComponent<FightManager>();
    }

    void Start()
    {
        // ������ʼ��
        UIManager.Instance.Init();
        AudiManager.Instance.Init();
        RoleManager.Instance.Init();
        GameConfigManager.Instance.init();

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

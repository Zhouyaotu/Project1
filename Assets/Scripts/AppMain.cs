using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppMain : MonoBehaviour
{
    private void Awake()
    {
        // ����ͳһ����
        // TODO ���ֵ�����Ӧ�õ������������ǹҵ�GameRoot��
        this.gameObject.AddComponent<UIManager>();
        this.gameObject.AddComponent<AudiManager>();
    }

    void Start()
    {
        // ������ʼ��
        UIManager.Instance.Init();
        AudiManager.Instance.Init();

        // NOTE�����������Ҫ��prefab������һ��
        // Ӧ�ø�Ϊÿһ��UI�ű�����һ�����֣�����ע��Dict
        // �ļ�ʹ��addressable����ע������첽���أ�
        UIManager.Instance.ShowUI<LoginView>("LoginUI");
        AudiManager.Instance.PlayBGM("bgm1");
    }

    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class AppMain : MonoBehaviour
{
    private void Awake()
    {
        // TODO ���ֵ�����Ӧ�õ������������ǹҵ�GameRoot��
        this.gameObject.AddComponent<UIManager>();
    }

    void Start()
    {
        //Init config table
        GameConfigManager.Instance.init();

        // NOTE�����������Ҫ��prefab������һ��
        // Ӧ�ø�Ϊÿһ��UI�ű�����һ�����֣�����ע��Dict
        // �ļ�ʹ��addressable����ע������첽���أ�
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

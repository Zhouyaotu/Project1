using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleManager : MonoBehaviour
{
    public static RoleManager Instance;

    List<string> cardList = new List<string>(); // �����ʼ����ʲôʱ��ִ�У�

    private void Awake()
    {
        RoleManager.Instance = this;
    }

    public void Init()
    {
        this.cardList = new List<string>();
    }
}

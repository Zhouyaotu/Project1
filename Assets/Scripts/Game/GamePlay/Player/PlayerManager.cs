using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;

    private List<string> cardList = new List<string>(); // �����ʼ����ʲôʱ��ִ�У�

    private void Awake()
    {
        PlayerManager.Instance = this;
    }

    public void Init()
    {
        this.cardList = new List<string>();
    }

    public List<string> GetCardPile()
    {
        return this.cardList;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * PlayerManager
 * �����������/���ߵ�
 */
public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;

    private List<string> cardList = new List<string>(); // TODO �������⣺�����ʼ����ʲôʱ��ִ�У�

    private void Awake()
    {
        PlayerManager.Instance = this;
    }

    public void Init()
    {
        this.cardList = new List<string>(); // ��card list�����card id
        this.cardList.Add("10001");
    }

    public List<string> GetCardPile()
    {
        return this.cardList;
    }
}

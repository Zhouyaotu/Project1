using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightCardManager : MonoBehaviour
{
    public static FightCardManager Instance;

    private List<string> cardPile;
    private List<string> usedCardPile;

    private void Awake()
    {
        FightCardManager.Instance = this;
    }

    public void Init()
    {
        cardPile = new List<string>();
        usedCardPile = new List<string>();

        var playerCardPile = new List<string>(PlayerManager.Instance.GetCardPile());
        // �������õ�����ϴ����Ϸ�ƶ���
        while (playerCardPile.Count > 0)
        {
            int randomIdx = Random.Range(0, playerCardPile.Count);
            cardPile.Add(playerCardPile[randomIdx]);
            playerCardPile.RemoveAt(randomIdx);
        }
    }

    public int cardCount{
        get { return this.cardPile.Count; }
    }

    public int usedCardCount
    {
        get { return this.usedCardPile.Count; }
    }
}

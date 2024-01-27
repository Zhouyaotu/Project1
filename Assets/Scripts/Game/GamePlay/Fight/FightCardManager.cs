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

        var tempCardPile = new List<string>(PlayerManager.Instance.GetCardPile());
        // 将玩家配好的牌组洗入游戏牌堆中
        while(tempCardPile.Count > 0)
        {
            int randomIdx = Random.Range(0, tempCardPile.Count);
            cardPile.Add(tempCardPile[randomIdx]);
            tempCardPile.RemoveAt(randomIdx);
        }
    }
}

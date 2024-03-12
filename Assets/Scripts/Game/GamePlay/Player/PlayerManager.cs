using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * PlayerManager
 * 管理玩家牌组/道具等
 */
public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;

    private List<string> cardList = new List<string>(); // TODO 遗留问题：这个初始化在什么时候执行？

    private void Awake()
    {
        PlayerManager.Instance = this;
    }

    public void Init()
    {
        this.cardList = new List<string>(); // 往card list里添加card id
        this.cardList.Add("10001");
    }

    public List<string> GetCardPile()
    {
        return this.cardList;
    }
}

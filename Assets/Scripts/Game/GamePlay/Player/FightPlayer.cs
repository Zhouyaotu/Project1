using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Player类主要管理对局中玩家状态，永远只被FightStateManager持有
public class FightPlayer
{
    public int maxHp;
    public int curHp;

    public int maxPower;
    public int curPower;

    public int defense;

    public void Init(int maxHp, int maxPower, int defense)
    {
        this.maxHp = maxHp;
        this.curHp = maxHp;

        this.maxPower = maxPower;
        this.curPower = maxPower;

        this.defense = defense;
    }
}

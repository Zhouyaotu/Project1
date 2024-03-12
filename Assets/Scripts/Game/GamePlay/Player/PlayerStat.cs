using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 *  PlayerStat
 *  Player����Ҫ����Ծ������״̬����Զֻ��FightStateManager����
 */
public class PlayerStat
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

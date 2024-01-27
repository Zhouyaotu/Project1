using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FightStat
{
    None,
    Start,
    PlayerTurn,
    EnemyTurn,
    Win,
    Lose,
}

public class FightStatManager : MonoBehaviour
{
    public static FightStatManager Instance;

    private FightUnit currentFightStat;

    private FightPlayer fightPlayer;

    private void Awake()
    {
        FightStatManager.Instance = this;
    }

    public void Init()
    {
        this.fightPlayer = new FightPlayer();
        
    }

    // �л��Ծ�״̬��״̬�����ҷ��غ�-�Է��غ�-ʤ��-ʧ�ܣ�
    public void SwitchFightStat(FightStat stat)
    {
        switch (stat)
        {
            case FightStat.Start:
                this.currentFightStat = new FightBegin();
                break;
            case FightStat.PlayerTurn:
                this.currentFightStat = new FightPlayerTurn();
                break;
            case FightStat.EnemyTurn:
                this.currentFightStat = new FightEnemyTurn();
                break;
            case FightStat.Win:
                this.currentFightStat = new FightWin();
                break;
            case FightStat.Lose:
                this.currentFightStat = new FightLose();
                break;
            default:
                break;
        }
        currentFightStat.Init();
    }

    private void Update()
    {
        if(this.currentFightStat != null)
        {
            this.currentFightStat.OnUpdate();
        }
    }

    public void InitPlayer()
    {
        this.fightPlayer.Init(10,10,10);
    }

    #region ����Ծ���Player״̬
    //======================
    // ����Ծ���Player״̬
    //======================
    int PlayerMaxHp
    {
        get
        {
            return this.fightPlayer.maxHp;
        }
        set
        {
            this.fightPlayer.maxHp = value;
        }
    }
    int PlayerCurHp
    {
        get
        {
            return this.fightPlayer.curHp;
        }
        set
        {
            this.fightPlayer.curHp = value;
        }
    }
    int PlayerMaxPower
    {
        get
        {
            return this.fightPlayer.maxPower;
        }
        set
        {
            this.fightPlayer.maxPower = value;
        }
    }
    int PlayerCurPower
    {
        get
        {
            return this.fightPlayer.curPower;
        }
        set
        {
            this.fightPlayer.curPower = value;
        }
    }
    int PlayerDefense
    {
        get
        {
            return this.fightPlayer.defense;
        }
        set
        {
            this.fightPlayer.defense = value;
        }
    }
    #endregion
}

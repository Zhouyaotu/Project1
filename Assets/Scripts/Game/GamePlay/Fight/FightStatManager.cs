using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FightStat
{
    None,
    Begin,
    PlayerTurn,
    EnemyTurn,
    Win,
    Lose,
}

public class FightStatManager : MonoBehaviour
{
    public static FightStatManager Instance;

    // 当前战斗状态
    private FightUnit curFightStat;

    // 当前进行战斗的玩家
    private PlayerStat curPlayerStat;

    private void Awake()
    {
        FightStatManager.Instance = this;
    }

    public void Init()
    {
        this.curPlayerStat = new PlayerStat();
        
    }

    // 切换对局状态（状态机：我方回合-对方回合-胜利-失败）
    public void SwitchFightStat(FightStat stat)
    {
        switch (stat)
        {
            case FightStat.Begin:
                this.curFightStat = new FightBegin();
                break;
            case FightStat.PlayerTurn:
                this.curFightStat = new FightPlayerTurn();
                break;
            case FightStat.EnemyTurn:
                this.curFightStat = new FightEnemyTurn();
                break;
            case FightStat.Win:
                this.curFightStat = new FightWin();
                break;
            case FightStat.Lose:
                this.curFightStat = new FightLose();
                break;
            default:
                break;
        }
        curFightStat.Init();
    }

    private void Update()
    {
        if(this.curFightStat != null)
        {
            this.curFightStat.OnUpdate();
        }
    }

    public void InitGameFight(string levelID)
    {
        // 初始化加载关卡敌人（按照关卡ID加载）
        InitEnemys(levelID);

        // 初始化关卡玩家数据
        InitPlayer();

        // 初始化关卡中牌组数据
        InitPlayerCardPile();
    }

    public void InitPlayer()
    {
        // TODO 通过PlayerMgr获取角色的状态
        this.curPlayerStat.Init(10,10,10);
    }

    public void InitPlayerCardPile()
    {
        FightCardManager.Instance.Init();
    }

    public void InitEnemys(string levelID)
    {
        EnemyManager.Instance.LoadEnemyResources(levelID);
    }

    #region 管理对局中Player状态
    //======================
    // 管理对局中Player状态
    //======================
    public int PlayerMaxHp
    {
        get
        {
            return this.curPlayerStat.maxHp;
        }
        set
        {
            this.curPlayerStat.maxHp = value;
        }
    }
    public int PlayerCurHp
    {
        get
        {
            return this.curPlayerStat.curHp;
        }
        set
        {
            this.curPlayerStat.curHp = value;
        }
    }
    public int PlayerMaxPower
    {
        get
        {
            return this.curPlayerStat.maxPower;
        }
        set
        {
            this.curPlayerStat.maxPower = value;
        }
    }
    public int PlayerCurPower
    {
        get
        {
            return this.curPlayerStat.curPower;
        }
        set
        {
            this.curPlayerStat.curPower = value;
        }
    }
    public int PlayerDefense
    {
        get
        {
            return this.curPlayerStat.defense;
        }
        set
        {
            this.curPlayerStat.defense = value;
        }
    }
    #endregion
}

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

    // ��ǰս��״̬
    private FightUnit curFightStat;

    // ��ǰ����ս�������
    private PlayerStat curPlayerStat;

    private void Awake()
    {
        FightStatManager.Instance = this;
    }

    public void Init()
    {
        this.curPlayerStat = new PlayerStat();
        
    }

    // �л��Ծ�״̬��״̬�����ҷ��غ�-�Է��غ�-ʤ��-ʧ�ܣ�
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
        // ��ʼ�����عؿ����ˣ����չؿ�ID���أ�
        InitEnemys(levelID);

        // ��ʼ���ؿ��������
        InitPlayer();

        // ��ʼ���ؿ�����������
        InitPlayerCardPile();
    }

    public void InitPlayer()
    {
        // TODO ͨ��PlayerMgr��ȡ��ɫ��״̬
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

    #region ����Ծ���Player״̬
    //======================
    // ����Ծ���Player״̬
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

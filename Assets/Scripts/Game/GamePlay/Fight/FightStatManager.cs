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

    private void Awake()
    {
        FightStatManager.Instance = this;
    }
    public void Init()
    {

    }

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
}

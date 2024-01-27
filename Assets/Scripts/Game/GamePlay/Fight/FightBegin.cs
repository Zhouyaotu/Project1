using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 游戏中任何一场Fight的初始状态
public class FightBegin : FightUnit
{
    public override void Init()
    {
        // 播放战斗BGM
        AudiManager.Instance.PlayBGM("battle");

        // 切换战斗UI
        UIManager.Instance.ShowUI<FightView>("FightUI");

        // 加载关卡敌人 TODO
        EnemyManager.Instance.LoadEnemyResources("某个LevelID");

        // 初始化关卡玩家数据
        FightStatManager.Instance.InitPlayer();

        // 开始游戏-进入玩家回合
        FightStatManager.Instance.SwitchFightStat(FightStat.PlayerTurn);
    }

    public override void OnUpdate()
    {
       
    }
}

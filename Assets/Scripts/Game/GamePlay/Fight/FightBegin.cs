using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightBegin : FightUnit
{
    public override void Init()
    {
        // 播放战斗BGM
        AudiManager.Instance.PlayBGM("battle");

        // 加载关卡敌人
        EnemyManager.Instance.LoadEnemyResources("某个LevelID");

        // 初始化关卡玩家数据
        FightStatManager.Instance.InitPlayer();

        // 切换战斗UI
        UIManager.Instance.ShowUI<FightView>("FightUI");
    }

    public override void OnUpdate()
    {
       
    }
}

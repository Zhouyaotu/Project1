using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightStart : FightUnit
{
    public override void Init()
    {
        // 播放战斗BGM
        AudiManager.Instance.PlayBGM("battle");

        // 加载关卡敌人
        EnemyManager.Instance.LoadEnemyRes("某个LevelID");

        // 切换战斗UI
    }

    public override void OnUpdate()
    {
       
    }
}

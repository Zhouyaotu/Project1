using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightBegin : FightUnit
{
    public override void Init()
    {
        // 初始化加载关卡（按照关卡ID加载）
        FightStatManager.Instance.InitGameFight("10001");

        // 切换战斗UI
        UIManager.Instance.ShowUI<FightView>("FightUI");
        
        // 播放战斗BGM
        AudiManager.Instance.PlayBGM("battle");
    }

    public override void OnUpdate()
    {
       
    }
}

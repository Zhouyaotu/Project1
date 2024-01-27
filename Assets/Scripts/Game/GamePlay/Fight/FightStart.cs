using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightStart : FightUnit
{
    public override void Init()
    {
        AudiManager.Instance.PlayBGM("battle");
    }

    public override void OnUpdate()
    {
       
    }
}

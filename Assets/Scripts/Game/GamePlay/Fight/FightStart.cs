using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightStart : FightUnit
{
    public override void Init()
    {
        // ����ս��BGM
        AudiManager.Instance.PlayBGM("battle");

        // ���عؿ�����
        EnemyManager.Instance.LoadEnemyRes("ĳ��LevelID");

        // �л�ս��UI
    }

    public override void OnUpdate()
    {
       
    }
}

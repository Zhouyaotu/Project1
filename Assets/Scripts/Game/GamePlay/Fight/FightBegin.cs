using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightBegin : FightUnit
{
    public override void Init()
    {
        // ����ս��BGM
        AudiManager.Instance.PlayBGM("battle");

        // ���عؿ�����
        EnemyManager.Instance.LoadEnemyResources("ĳ��LevelID");

        // ��ʼ���ؿ��������
        FightStatManager.Instance.InitPlayer();

        // �л�ս��UI
        UIManager.Instance.ShowUI<FightView>("FightUI");
    }

    public override void OnUpdate()
    {
       
    }
}

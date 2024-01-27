using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��Ϸ���κ�һ��Fight�ĳ�ʼ״̬
public class FightBegin : FightUnit
{
    public override void Init()
    {
        // ����ս��BGM
        AudiManager.Instance.PlayBGM("battle");

        // �л�ս��UI
        UIManager.Instance.ShowUI<FightView>("FightUI");

        // ���عؿ����� TODO
        EnemyManager.Instance.LoadEnemyResources("ĳ��LevelID");

        // ��ʼ���ؿ��������
        FightStatManager.Instance.InitPlayer();

        // ��ʼ��Ϸ-������һغ�
        FightStatManager.Instance.SwitchFightStat(FightStat.PlayerTurn);
    }

    public override void OnUpdate()
    {
       
    }
}

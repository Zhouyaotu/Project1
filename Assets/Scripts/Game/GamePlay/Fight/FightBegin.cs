using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightBegin : FightUnit
{
    public override void Init()
    {
        // ��ʼ�����عؿ������չؿ�ID���أ�
        FightStatManager.Instance.InitGameFight("10001");

        // �л�ս��UI
        UIManager.Instance.ShowUI<FightView>("FightUI");
        
        // ����ս��BGM
        AudiManager.Instance.PlayBGM("battle");
    }

    public override void OnUpdate()
    {
       
    }
}

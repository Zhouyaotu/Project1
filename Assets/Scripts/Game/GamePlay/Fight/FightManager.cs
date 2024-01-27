using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManager : MonoBehaviour
{
    public static FightManager Instance;

    private FightUnit currentFightStat;

    private void Awake()
    {
        FightManager.Instance = this;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // TODO：简单实现一个单例（in common）
    public static UIManager Instance;

    private Transform UITrf; 

    void Awake()
    {
        Instance = this;
        UITrf = GameObject.Find("UI/GameUI").transform;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected Dictionary<string, string> data;

    public void Init(Dictionary<string, string> enemyData)
    {
        this.data = enemyData;
    }

    public void Destory()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected Dictionary<string, string> data;

    public virtual void Init(Dictionary<string, string> enemyData)
    {
        this.data = enemyData;
    }

    public virtual void Destory()
    {

    }
}

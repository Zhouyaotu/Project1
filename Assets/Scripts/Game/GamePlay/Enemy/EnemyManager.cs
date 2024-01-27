using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager Instance;

    private List<Enemy> enemyList;

    private void Awake()
    {
        EnemyManager.Instance = this;
    }

    public void Init()
    {
        this.enemyList = new List<Enemy>();
    }

    public void ResetEnemies()
    {
        foreach(var enemy in enemyList)
        {
            enemy.Destory();
        }
        this.enemyList.Clear();
    }

    // ����������ڵ���ִ�е�ʱ��ѹؿ��е����е��˼��ؽ���
    public void LoadEnemyRes(string levelID)
    {
        this.ResetEnemies();

        Dictionary<string, string> levelData;

        string[] enemyIDList;
        string[] enemyPosList;

        //=== foreach enemyIDList ===
        string enemyID;
        Vector3 enemyPos;
        Dictionary<string, string> enemyData;

        // Instantiate from Resource.Load(enemyData.Model)
        GameObject enemyGO;
        //enemyGO.transform.position = enemyPos;

        //Enemy enemy = enemyGO.AddComponent<Enemy>();
        //enemy.Init(enemyData);

        //enemyList.Add(enemy);
        //=== end foreach ===

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.LightingExplorerTableColumn;

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

    // 这个函数会在单次执行的时候把关卡中的所有敌人加载进来
    public void LoadEnemyResources(string levelID)
    {
        this.ResetEnemies();

        //Dictionary<string, string> levelData;
        //levelData = GameConfigManager.Instance.GetLevelDataDics()[levelID];

        UnityEngine.Debug.Log("Reading enemyIdList..." );
        string[] enemyIdList = GameConfigManager.Instance.GetLevelById(levelID, PropertyType.enemyIdList).Split('/');

        UnityEngine.Debug.Log("Reading enemyPosList...");
        string[] enemyPositionList = GameConfigManager.Instance.GetLevelById(levelID, PropertyType.enemyPositionList).Split('/');

        for(int i=0;i<enemyIdList.Length;i++)
        {
            string[] posCoord = enemyPositionList[i].Split(",");

            float x = float.Parse(posCoord[0]);
            float y = float.Parse(posCoord[1]);
            float z = float.Parse(posCoord[2]);

            Dictionary<string,string> enemyData = GameConfigManager.Instance.GetEnemyLineById(enemyIdList[i]);

            GameObject gameObject = Object.Instantiate(Resources.Load(enemyData[PropertyType.model])) as GameObject;

            Enemy enemy=gameObject.AddComponent<Enemy>();

            enemy.Init(enemyData);

            gameObject.transform.position = new Vector3(x, y, z);

            enemyList.Add(enemy);
        }
        /*
        //=== foreach enemyIDList ===
        string enemyID;
        Vector3 enemyPos;
        //Dictionary<string, string> enemyData;

        // Instantiate from Resource.Load(enemyData.Model)
        GameObject enemyGO;
        //enemyGO.transform.position = enemyPos;

        //Enemy enemy = enemyGO.AddComponent<Enemy>();
        //enemy.Init(enemyData);

        //enemyList.Add(enemy);
        //=== end foreach ===
        */
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.LightingExplorerTableColumn;

/**
 * EnemyManager
 * ������˼��ص�
 */
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
    public void LoadEnemyResources(string levelID)
    {
        // ÿ�μ��عؿ�����ʱ��������п��ܵĵ�������
        this.ResetEnemies();

        //Dictionary<string, string> levelData;
        //levelData = GameConfigManager.Instance.GetLevelDataDics()[levelID];

        UnityEngine.Debug.Log("Reading enemyIdList..." );
        // ע��Ǳ����Ĭ�Ϸָ������ ��/��
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
    }
}

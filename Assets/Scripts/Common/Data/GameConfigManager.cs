using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//������Ϸ���ñ�Ĺ�����
public class GameConfigManager
{
    public static GameConfigManager Instance =new GameConfigManager();

    private GameConfigData cardData;
    private GameConfigData enemyData;
    private GameConfigData levelData;

    private TextAsset textAsset;

    //��ʼ��txt�����ļ�������
    public void init()
    {
        textAsset = Resources.Load<TextAsset>("Data/card");
        cardData=new GameConfigData(textAsset.text);

        textAsset = Resources.Load<TextAsset>("Data/enemy");
        enemyData = new GameConfigData(textAsset.text);

        textAsset = Resources.Load<TextAsset>("Data/level");
        levelData = new GameConfigData(textAsset.text);
    }

    public List<Dictionary<string,string>> GetCardLines()
    {
        return cardData.GetLines();
    }

    public List<Dictionary<string, string>> GetEnemyLines()
    {
        return enemyData.GetLines();
    }

    public List<Dictionary<string, string>> GetLevelLines()
    {
        return levelData.GetLines();
    }

    public Dictionary<string, string> GetCardById(string id)
    {
        return cardData.GetOneById(id);
    }

    public Dictionary<string, string> GetEnemyById(string id)
    {
        return enemyData.GetOneById(id);
    }

    public Dictionary<string, string> GetLevelById(string id)
    {
        return levelData.GetOneById(id);
    }
}

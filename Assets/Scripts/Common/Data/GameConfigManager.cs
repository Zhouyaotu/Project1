using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
public class CardConfigManager
{
    enum cardDataType
    {
        Name,
        Idx
    };
    Dictionary<cardDataType, string> typeDic;


}
*/

public class PropertyType
{
    //Common data type
    public const string name = "name";
    public const string idx = "index";
}


//整个游戏配置表的管理器
public class GameConfigManager : MonoBehaviour
{
    public static GameConfigManager Instance;

    private GameConfigData cardData;
    private GameConfigData enemyData;
    private GameConfigData levelData;

    private void Awake()
    {
        GameConfigManager.Instance = this;
    }

    //初始化txt配置文件并加载
    public void init()
    {
        TextAsset textAsset;

        textAsset = Resources.Load<TextAsset>("Data/card");
        cardData=new GameConfigData(textAsset.text);

        textAsset = Resources.Load<TextAsset>("Data/enemy");
        enemyData = new GameConfigData(textAsset.text);

        textAsset = Resources.Load<TextAsset>("Data/level");
        levelData = new GameConfigData(textAsset.text);
    }


    public Dictionary<string, Dictionary<string,string>> GetCardDataDics()
    {
        return cardData.GetDataDics();
    }

    public Dictionary<string, Dictionary<string, string>> GetEnemyDataDics()
    {
        return enemyData.GetDataDics();
    }

    public Dictionary<string, Dictionary<string, string>> GetLevelDataDics()
{
        return levelData.GetDataDics();
    }

    public string GetCardDataById(string id,string dataType)
    {
        return cardData.GetDataById(id,dataType);
    }

    public string GetEnemyDataById(string id, string dataType)
    {
        return enemyData.GetDataById(id, dataType);
    }

    public string GetLevelById(string id, string dataType)
    {
        return levelData.GetDataById(id, dataType);
    }
}

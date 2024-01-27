using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//游戏配置表类，每个对象对应一个txt配置表
public class GameConfigData
{
    //存储配置表中的所有数据
    private List<Dictionary<string, string>> dicList;
    private Dictionary<string, Dictionary<string, string>> dataDics;

    public GameConfigData(string str)
    {
        dicList = new List<Dictionary<string, string>>();
        dataDics = new Dictionary<string, Dictionary<string, string>>();

        //换行切割
        string[] lines = str.Split('\n');
        //第一行存储数据类型
        string[] title = lines[0].Trim().Split('\t');

        for(int j=1; j<title.Length; j++)
        {
            dataDics.Add(title[j], new Dictionary<string, string>());
        }

        for(int i=1;i<lines.Length; i++)
        {
            string[] tmpArr = lines[i].Trim().Split('\t');
            
            for(int j = 1; j < tmpArr.Length; j++)
            {
                dataDics[title[j]].Add(tmpArr[0], tmpArr[j]);
            }
        }
    }


    public Dictionary<string, Dictionary<string, string>> GetDataDics()
    {
        return dataDics;
    }



    public string GetDataById(string id,string dataType)
    {
        if (!dataDics.TryGetValue(dataType, out Dictionary<string, string> dict))
        {
            UnityEngine.Debug.Log("Cann't Find Data Type: "+dataType);
            return null;
        }else if(!dict.TryGetValue(id, out string targetData)){
            UnityEngine.Debug.Log("Cann't Find ID: " + id);
            return null;
        }

        return dataDics[dataType][id];
    }
}



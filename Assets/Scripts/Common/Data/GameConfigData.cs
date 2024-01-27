using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��Ϸ���ñ��࣬ÿ�������Ӧһ��txt���ñ�
public class GameConfigData
{
    //�洢���ñ��е���������
    private List<Dictionary<string, string>> dicList;
    private Dictionary<string, Dictionary<string, string>> dataDics;

    public GameConfigData(string str)
    {
        dicList = new List<Dictionary<string, string>>();
        dataDics = new Dictionary<string, Dictionary<string, string>>();

        //�����и�
        string[] lines = str.Split('\n');
        //��һ�д洢��������
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



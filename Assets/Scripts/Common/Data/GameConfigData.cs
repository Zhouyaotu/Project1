using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//游戏配置表类，每个对象对应一个txt配置表
public class GameConfigData
{
    //存储配置表中的所有数据
    private List<Dictionary<string, string>> dataDic;

    public GameConfigData(string str)
    {
        dataDic = new List<Dictionary<string, string>>();

        //换行切割
        string[] lines = str.Split('\n');
        //第一行存储数据类型
        string[] title = lines[0].Trim().Split('\t');
        //第三行开始遍历数据
        for(int i=2; i<lines.Length; i++)
        {
            Dictionary<string,string> dic= new Dictionary<string,string>();

            string[] tmpArr = lines[i].Trim().Split('\t');

            for(int j=0; j<tmpArr.Length; j++)
            {
                dic.Add(title[j], tmpArr[j]);
            }

            dataDic.Add(dic);
        }
    }

    public List<Dictionary<string,string>> GetLines()
    {
        return dataDic;
    }

    public Dictionary<string,string> GetOneById(string id)
    {
        for(int i=0; i<dataDic.Count; i++)
        {
            Dictionary<string,string> dic= dataDic[i];
            if (id == dic["ID"])
            {
                return dic;
            }
        }

        return null;
    }
}

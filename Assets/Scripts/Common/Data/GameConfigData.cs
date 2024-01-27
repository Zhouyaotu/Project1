using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��Ϸ���ñ��࣬ÿ�������Ӧһ��txt���ñ�
public class GameConfigData
{
    //�洢���ñ��е���������
    private List<Dictionary<string, string>> dataDic;

    public GameConfigData(string str)
    {
        dataDic = new List<Dictionary<string, string>>();

        //�����и�
        string[] lines = str.Split('\n');
        //��һ�д洢��������
        string[] title = lines[0].Trim().Split('\t');
        //�����п�ʼ��������
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

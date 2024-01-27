using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using Excel;
using System.Data;

public static class MyEditor
{
    [MenuItem("我的工具/excel转txt")]
    public static void ExportExcelToText()
    {
        string assetPath = Application.dataPath + "/_Excel";

        string[] files = Directory.GetFiles(assetPath, "*.xlsx");

        for(int i = 0; i < files.Length; i++)
        {
            files[i] = files[i].Replace("\\", "/");
            //Debug.Log(files[i]);
            using (FileStream fs = File.Open(files[i], FileMode.Open, FileAccess.Read))
            {
                //FS to Excel
                var excelDataReader = ExcelReaderFactory.CreateOpenXmlReader(fs);

                //get excel data
                DataSet dataset=excelDataReader.AsDataSet();

                DataTable table = dataset.Tables[0];

                //store as txt
                readTableToTxt(files[i],table);
            }
        }

        //refresh
        AssetDatabase.Refresh();
    }

    private static void readTableToTxt(string filePath,DataTable table)
    {
        //获取文件名（不含后缀 生成同名txt）
        string fileName=Path.GetFileNameWithoutExtension(filePath);
        string path = Application.dataPath + "/Resources/Data/" + fileName + ".txt";

        //判重复
        if(File.Exists(path))
        {
            File.Delete(path);
        }

        //FS create txt
        using (FileStream fs = new FileStream(path, FileMode.Create))
        {
            //文件流转写入流 便于写入字符串
            using(StreamWriter sw = new StreamWriter(fs))
            {
                for(int row=0; row < table.Rows.Count; row++)
                {
                    DataRow dataRow = table.Rows[row];

                    string str = "";
                    for(int col=0;col<table.Columns.Count; col++)
                    {
                        string val = dataRow[col].ToString();

                        //seg per tab
                        str = str + val + "\t";
                    }

                    //write
                    sw.Write(str);

                    //if not last line, cr
                    if(row!=table.Rows.Count-1) 
                    { 
                        sw.WriteLine();
                    }
                }
            }
        }
    }
}
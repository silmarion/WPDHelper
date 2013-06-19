
using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataLibrary
{
    public class ChapterSixPartTwoThree : IClear
    {
        public string SubHeader1 { get; set; }
        public string SubHeader2 { get; set; }

        public DataTable IndependentWork { get; set; }
        public List<DataTable> HomeWork { get; set; }

        public ChapterSixPartTwoThree()
        {
            SubHeader1 = "6.2	Тематика самостоятельных работ";
            SubHeader2 = "6.3	Перечень тем домашних заданий:";

            IndependentWork = new DataTable { TableName = "IndependentWorks" };
            IndependentWork.Columns.Add("Text");

            HomeWork = new List<DataTable>();
        }

        public void Initialize()
        {
            if (HomeWork.Count == 0)
            {
                var table = new DataTable { TableName = "HomeWork" };
                table.Columns.Add("Text");
                table.Columns.Add("Header");
                table.Rows.Add();
                HomeWork.Add(table);
            }
        }

        public void InitializeNewHomeWorkTable(int positionInList)
        {
            if (HomeWork[positionInList].TableName == String.Empty)
            {
                HomeWork[positionInList].TableName = "HomeWork";
                HomeWork[positionInList].Columns.Add("Text");
                HomeWork[positionInList].Columns.Add("Header");
                HomeWork[positionInList].Rows.Add();
            }
        }

        public void ClearHomeWork()
        {
            HomeWork.Clear();
            Initialize();
        }

        public void Validate()
        {
            for (var i = 0; i < HomeWork.Count; i++)
            {
                for (var j = 0; j < HomeWork[i].Rows.Count; j++)
                {
                    if (HomeWork[i].Rows[j]["Text"] == String.Empty && HomeWork[i].Rows[j]["Header"] == String.Empty)
                    {
                        HomeWork[i].Rows.RemoveAt(j);
                    }
                }
            }
            ////проверка на пустые строки в таблице и наименования тем
            //for (var i = 0; i < HomeWork.Count; i++)
            //{
            //    if (HomeWork[i].Rows.Count == 0 && HomeWorkHeader.Rows[i]["Text"] == String.Empty)
            //    {
            //        HomeWork.RemoveAt(i);
            //        HomeWorkHeader.Rows.RemoveAt(i);
            //        i--;
            //        continue;
            //    }
            //    if (HomeWork[i].Rows.Count == 0 && HomeWorkHeader.Rows[i]["Text"] != String.Empty)
            //    {
            //        var str = String.Format("Нет описания домашних работ по теме {0}", HomeWorkHeader.Rows[i]["Text"]);
            //        throw new Exception(str);
            //    }
            //    if (HomeWork[i].Rows.Count != 0 && HomeWorkHeader.Rows[i]["Text"] == String.Empty)
            //    {
            //        var str = String.Format("Нет темы домашних работ с индексом {0}", i + 1);
            //        throw new Exception(str);
            //    }
            //}
        }

        public void Clear()
        {
            IndependentWork.Clear();
            HomeWork.Clear();
        }
    }
}

using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataLibrary
{
    public class ChapterSixPartFourFive : IClear
    {
        public string SubHeader1 { get; set; }
        public string SubHeader2 { get; set; }

        public DataTable TestWork { get; set; }
        public List<DataTable> TrainingForExam { get; set; }

        public ChapterSixPartFourFive()
        {
            SubHeader1 = "6.4	Перечень тем контрольных работ:";
            SubHeader2 = "6.5	Вопросы для самоподготовки к экзамену (зачету)";

            TestWork = new DataTable { TableName = "TestWork" };
            TestWork.Columns.Add("Text");

            TrainingForExam = new List<DataTable>();
        }

        public void Initialize()
        {
            if (TrainingForExam.Count == 0)
            {
                var table = new DataTable { TableName = "TrainingForExam" };
                table.Columns.Add("Text");
                table.Columns.Add("Header");
                table.Rows.Add();
                TrainingForExam.Add(table);
            }
        }

        public void InitializeNewHomeWorkTable(int positionInList)
        {
            if (TrainingForExam[positionInList].TableName == String.Empty)
            {
                TrainingForExam[positionInList].TableName = "TrainingForExam";
                TrainingForExam[positionInList].Columns.Add("Text");
                TrainingForExam[positionInList].Columns.Add("Header");
                TrainingForExam[positionInList].Rows.Add();
            }
        }

        public void ClearTrainingForExam()
        {
            TrainingForExam.Clear();
            Initialize();
        }

        public void Validate()
        {
            for (var i = 0; i < TrainingForExam.Count; i++)
            {
                for(var j = 0; j < TrainingForExam[i].Rows.Count; j++)
                {
                    if (TrainingForExam[i].Rows[j]["Text"] == String.Empty && TrainingForExam[i].Rows[j]["Header"] == String.Empty)
                    {
                        TrainingForExam[i].Rows.RemoveAt(j);
                    }
                }
            }

            //проверка на пустые строки в таблице и наименования тем
            //for (var i = 0; i < TrainingForExam.Count; i++)
            //{
            //    if (TrainingForExam[i].Rows.Count == 0 && TrainingForExamHeader.Rows[i]["Text"] == String.Empty)
            //    {
            //        TrainingForExam.RemoveAt(i);
            //        TrainingForExamHeader.Rows.RemoveAt(i);
            //        i--;
            //        continue;
            //    }
            //    if (TrainingForExam[i].Rows.Count == 0 && TrainingForExamHeader.Rows[i]["Text"] != String.Empty)
            //    {
            //        var str = String.Format("Нет описания домашних работ по теме {0}", TrainingForExamHeader.Rows[i]["Text"]);
            //        throw new Exception(str);
            //    }
            //    if (TrainingForExam[i].Rows.Count != 0 && TrainingForExamHeader.Rows[i]["Text"] == String.Empty)
            //    {
            //        var str = String.Format("Нет темы домашних работ с индексом {0}", i + 1);
            //        throw new Exception(str);
            //    }
            //}
        }

        public void Clear()
        {
            TestWork.Clear();
            TrainingForExam.Clear();
        }
    }
}

using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataLibrary
{
    [Serializable]
    public class ChapterFourPartTwo : IClear
    {
        //Уже не помню зачем тут столько функций
        public string SubHeader { get; set; }

        public DataTable Themes { get; set; }
        public List<DataTable> ListOfLectures { get; set; }
        public List<DataTable> ListOfPracticals { get; set; }

        public ChapterFourPartTwo()
        {
            SubHeader = "4.2. Содержание разделов, тем, учебных занятий";

            Themes = new DataTable();
            Themes.TableName = "Themes";
            Themes.Columns.Add("ChapterIndex");
            Themes.Columns.Add("Name");
            Themes.Columns.Add("Hours");

            ListOfLectures = new List<DataTable>();

            ListOfPracticals = new List<DataTable>();
        }

        public void ClearLectures()
        {
            ListOfLectures.Clear();
        }

        public void ClearPracticals()
        {
            ListOfPracticals.Clear();
        }

        public void Update(DataTable distributionStudyTime, DataTable distributionStudyTimeSumm)
        {
            var dst = distributionStudyTime.AsEnumerable().
                    Select(table => new
                    {
                        a = table.Field<string>("Наименование темы"),
                        b = table.Field<string>("Номер раздела"),
                        c = table.Field<string>("Лекции (час.)"),
                        d = table.Field<string>("Практические занятия (час.)")
                    }).ToArray();
            var themeHours = distributionStudyTimeSumm.AsEnumerable().
                    Select(table => new
                    {
                        a = table.Field<string>("AuditorySumm")
                    }).ToArray();

            if (!CheckThemes(distributionStudyTime))
            {
                Themes.Clear();
                for (var i = 0; i < dst.Length; i++)
                {
                    this.Themes.Rows.Add(dst[i].b, dst[i].a, themeHours[i].a);
                }
            }

            if (!CheckLectures(distributionStudyTime))
            {
                BalanceByCountThemes(ListOfLectures, "Lectures");
                for (var i = 0; i < ListOfLectures.Count; i++)
                {
                    if (ListOfLectures[i].Rows.Count == 0)
                    {
                        ListOfLectures[i].Rows.Add();
                    }
                }
            }

            if (!CheckPracticals(distributionStudyTime))
            {
                BalanceByCountThemes(ListOfPracticals, "Practicals");
                for(var i = 0; i < ListOfPracticals.Count; i++)
                {
                    if (ListOfPracticals[i].Rows.Count == 0)
                    {
                        ListOfPracticals[i].Rows.Add();
                    }
                }
            }
        }
        
        private DataTable CreateTable(string tableName, int themeIndex)
        {
            var result = new DataTable();
            result.TableName = tableName + themeIndex;
            result.Columns.Add("Name");
            result.Columns.Add("Text");
            result.Columns.Add("Hours");
            return result;
        }

        public bool CheckThemes(DataTable distributionStudyTime, bool exception = false)
        {
            var themes = distributionStudyTime.AsEnumerable().
               Select(table => new
               {
                   a = table.Field<string>("Наименование темы"),
               }).ToArray();

            if (themes.Length != this.Themes.Rows.Count)
            {
                if (exception)
                {
                    throw new Exception("Раздел 4.2. Критическая ошибка. ChapterFourPartTwo.CheckThemes");
                }
                return false;
            }
            return true;
        }

        public bool CheckLectures(DataTable distributionStudyTime, bool exception = false)
        {
            if (ListOfLectures.Count != this.Themes.Rows.Count)
            {
                return false;
            }

            var dst = distributionStudyTime.AsEnumerable().
                    Select(table => new
                    {
                        a = table.Field<string>("Лекции (час.)"),
                        b = table.Field<string>("Наименование темы"),
                    }).ToArray();
            for (var i = 0; i < dst.Length; i++)
            {
                if (dst[i].a != "" && i < ListOfLectures.Count)
                {
                    var summ = 0;
                    for (var j = 0; j < ListOfLectures[i].Rows.Count; j++)
                    {
                        summ += Helper.ConvertObjectToInt(ListOfLectures[i].Rows[j]["Hours"]);
                    }
                    if (summ > Helper.ConvertStringToInt(dst[i].a))
                    {
                        if (exception)
                        {
                            var str = String.Format("Раздел 4.2. Часы лекций не совпадают с распределенным учебный временем по теме '{0}'", dst[i].b);
                            throw new Exception(str);
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        public bool CheckPracticals(DataTable distributionStudyTime, bool exception = false)
        {
            if (ListOfPracticals.Count != this.Themes.Rows.Count)
            {
                return false;
            }

            var dst = distributionStudyTime.AsEnumerable().
                    Select(table => new
                    {
                        a = table.Field<string>("Практические занятия (час.)"),
                        b = table.Field<string>("Наименование темы"),
                    }).ToArray();
            for(var i = 0; i < dst.Length; i++)
            {
                if(dst[i].a != "" && i < ListOfPracticals.Count)
                {
                    var summ = 0;
                    for (var j = 0; j < ListOfPracticals[i].Rows.Count; j++)
                    {
                        summ += Helper.ConvertObjectToInt(ListOfPracticals[i].Rows[j]["Hours"]);
                    }
                    if (summ > Helper.ConvertStringToInt(dst[i].a))
                    {
                        if (exception)
                        {
                            var str = String.Format("Раздел 4.2. Часы практических занятий не совпадают с расперделенным учебный временем по теме '{0}'", dst[i].b);
                            throw new Exception(str);
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        public void Validate(DataTable distributionStudyTime, DataTable distributionStudyTimeSumm)
        {
            CheckThemes(distributionStudyTime, true);
            CheckLectures(distributionStudyTime, true);
            CheckPracticals(distributionStudyTime, true);

            HoursCorrect(ListOfLectures);
            HoursCorrect(ListOfPracticals);

            //проверяем сумму всех часов по темам
            var themeHours = distributionStudyTimeSumm.AsEnumerable().
                    Select(table => new
                    {
                        a = table.Field<string>("AuditorySumm")
                    }).ToArray();
            for (var i = 0; i < themeHours.Length; i++)
            {
                var summ = 0.0;
                for (var j = 0; j < ListOfLectures[i].Rows.Count; j++)
                {
                    summ += Helper.ConvertObjectToInt(ListOfLectures[i].Rows[j]["Hours"]);
                }
                for (var j = 0; j < ListOfPracticals[i].Rows.Count; j++)
                {
                    summ += Helper.ConvertObjectToDouble(ListOfPracticals[i].Rows[j]["Hours"]);
                }
                
                var themeH = Helper.ConvertStringToInt(themeHours[i].a);
                var intSumm = (int)Math.Floor(summ);
                if (themeH != intSumm)
                {
                    var fStr = String.Format("Раздел 4.2. Сумма часов лекций и практических ({0} час.) не совпадает с суммой часов аудиторных занятий по данной теме '{1}' ({2} час.).",
                        intSumm,
                        distributionStudyTime.Rows[i]["Наименование темы"],
                        themeH);
                    throw new Exception(fStr);
                }
            }
        }

        public double GetPracticalSummHours(int numberOfTheme, int changingPracticalRow, string number)
        {
            return GetSummHours(ListOfPracticals[numberOfTheme], changingPracticalRow, number);
        }

        public double GetLecturesSummHours(int numberOfTheme, int changingLectureRow, string number)
        {
            return GetSummHours(ListOfLectures[numberOfTheme], changingLectureRow, number);
        }

        private double GetSummHours(DataTable table, int changingRow, string number)
        {
            double result = 0.0;
            if (table.Rows.Count == changingRow)
            {
                table.Rows.Add();
            }
            table.Rows[changingRow]["Hours"] = Helper.ConvertObjectToDouble(number);

            for (var i = 0; i < table.Rows.Count; i++)
            {
                if (i != changingRow)
                {
                    result += Helper.ConvertObjectToDouble(table.Rows[i]["Hours"]);
                }
                else
                {
                    result += Helper.ConvertObjectToDouble(number);
                }
            }
            return result;
        }

        private void BalanceByCountThemes(List<DataTable> list, string tableName)
        {
            var dif = list.Count - this.Themes.Rows.Count;
            if (dif > 0)
            {
                dif = Math.Abs(dif);
                for (var i = 0; i < dif; i++)
                {
                    list.RemoveAt(list.Count - 1);
                }
            }
            else
            {
                dif = Math.Abs(dif);
                for (var i = 0; i < dif; i++)
                {
                    list.Add(CreateTable(tableName, list.Count));
                }
            }
        }
        
        // корректировка часов в таблицах. если привести к double не удается, то записывает пустую строку
        private void HoursCorrect(List<DataTable> listOfTable)
        {
            for (var i = 0; i < listOfTable.Count; i++)
            {
                for (var j = 0; j < listOfTable[i].Rows.Count; j++)
                {
                    var num = Helper.ConvertObjectToDouble(listOfTable[i].Rows[j]["Hours"]);
                    if (num == 0.0)
                    {
                        listOfTable[i].Rows[j]["Hours"] = String.Empty;
                    }
                    else
                    {
                        listOfTable[i].Rows[j]["Hours"] = num;
                    }
                }
            }
        }

        public void Clear()
        {
            Themes.Clear();
            ListOfLectures.Clear();
            ListOfPracticals.Clear();
        }
    }
}

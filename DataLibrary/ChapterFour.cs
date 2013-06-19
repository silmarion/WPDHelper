using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;

namespace DataLibrary
{
    [Serializable]
    public class ChapterFour : IClear
    {
        //подраздел 4.1
        public string Header { get; set; }
        public string SubHeader1 { get; set; }
        public string Info { get; set; }

        public DataTable AuditoriumHours { get; set; }
        public DataTable IndependentHours { get; set; }
        public DataTable Validation { get; set; }

        public DataTable Chapters { get; set; }
        public DataTable ChaptersSumm { get; set; }

        public DataTable DistributionStudyTime { get; set; }
        public DataTable DistributionStudyTimeSumm { get; set; }
        public DataTable DistributionStudyTimeCheckSumm { get; set; }
        public DataTable ValidationStudyTime { get; set; }

        public ChapterFourPartTwo PartTwo { get; set; }

        public ChapterFour()
        {
            Header = "4.	Структура и содержание дисциплины";
            SubHeader1 = "4.1.	Распределение учебного времени по семестрам, разделам, темам и видам учебных занятий";

            AuditoriumHours = new DataTable();
            AuditoriumHours.TableName = "AuditoriumHours";

            IndependentHours = new DataTable();
            IndependentHours.TableName = "IndependentHours";

            Validation = new DataTable();
            Validation.TableName = "Validation";

            Chapters = new DataTable();
            Chapters.TableName = "Chapters";
            Chapters.Columns.Add("Наименование");

            ChaptersSumm = new DataTable();
            ChaptersSumm.TableName = "ChaptersSumm";
            ChaptersSumm.Columns.Add("ChapterIndex");
            ChaptersSumm.Columns.Add("ChapterName");
            ChaptersSumm.Columns.Add("All");
            ChaptersSumm.Columns.Add("Auditory");
            ChaptersSumm.Columns.Add("Lecrute");
            ChaptersSumm.Columns.Add("Practical");
            ChaptersSumm.Columns.Add("Independant");
            ChaptersSumm.Columns.Add("Validation");

            DistributionStudyTime = new DataTable();
            DistributionStudyTime.TableName = "DistributionStudyTime";
            DistributionStudyTime.Columns.Add("Наименование темы");
            DistributionStudyTime.Columns.Add("Номер раздела");
            DistributionStudyTime.Columns.Add("Компетенции");
            DistributionStudyTime.Columns.Add("Семестр");
            DistributionStudyTime.Columns.Add("Неделя семестра");
            DistributionStudyTime.Columns.Add("Лекции (час.)");
            DistributionStudyTime.Columns.Add("Практические занятия (час.)");
            DistributionStudyTime.Columns.Add("Самостоятельная работа (час.)");

            DistributionStudyTimeSumm = new DataTable();
            DistributionStudyTimeSumm.TableName = "DistributionStudyTimeSumm";
            DistributionStudyTimeSumm.Columns.Add("Semester");
            DistributionStudyTimeSumm.Columns.Add("AllSumm");
            DistributionStudyTimeSumm.Columns.Add("AuditorySumm");
            DistributionStudyTimeSumm.Columns.Add("ChapterIndex");

            DistributionStudyTimeCheckSumm = new DataTable();
            DistributionStudyTimeCheckSumm.TableName = "DistributionStudyTimeCheckSumm";
            DistributionStudyTimeCheckSumm.Columns.Add("Info");
            DistributionStudyTimeCheckSumm.Columns.Add("All");
            DistributionStudyTimeCheckSumm.Columns.Add("Auditory");
            DistributionStudyTimeCheckSumm.Columns.Add("Lecrute");
            DistributionStudyTimeCheckSumm.Columns.Add("Practical");
            DistributionStudyTimeCheckSumm.Columns.Add("Independant");
            DistributionStudyTimeCheckSumm.Columns.Add("Validation");

            PartTwo = new ChapterFourPartTwo();
        }

        public string GetChapterName(int chapterIndex)
        {
            if (chapterIndex < 0 || chapterIndex > Chapters.Rows.Count)
            {
                return "";
            }
            return Chapters.Rows[chapterIndex - 1][0].ToString();
        }

        public void Update(Discipline discipline)
        {
            if (discipline == null)
            {
                return;
            }
            Info = string.Format("Общая трудоемкость дисциплины составляет {0} з.e., {1} час.", discipline.CreditUnitsCount, discipline.TotalHours);

            #region аудиторные занятия
            AuditoriumHours.Clear();
            AuditoriumHours.Columns.Clear();
            AuditoriumHours.Columns.Add("Вид учебной работы");
            for (var i = 0; i < discipline.Semesters.Count; i++)
            {
                AuditoriumHours.Columns.Add("Семестр " + discipline.Semesters[i].Number + " (час.)");
            }
            //всего
            var parameters = new string[AuditoriumHours.Columns.Count];
            parameters[0] = "Аудиторные занятия (всего)";
            for (var i = 0; i < discipline.Semesters.Count; i++)
            {
                parameters[i + 1] = (discipline.Semesters[i].Lecture + discipline.Semesters[i].Laboratory).ToString();
            }
            AuditoriumHours.Rows.Add(parameters);
            //лекции
            parameters = new string[AuditoriumHours.Columns.Count];
            parameters[0] = "Лекции";
            for (var i = 0; i < discipline.Semesters.Count; i++)
            {
                parameters[i + 1] = (discipline.Semesters[i].Lecture - discipline.Semesters[i].InteractiveLecture).ToString();
            }
            AuditoriumHours.Rows.Add(parameters);
            //интерактичные лекции
            parameters = new string[AuditoriumHours.Columns.Count];
            parameters[0] = "Интерактивные и активные формы работы на лекциях";
            for (var i = 0; i < discipline.Semesters.Count; i++)
            {
                parameters[i + 1] = discipline.Semesters[i].InteractiveLecture.ToString();
            }
            AuditoriumHours.Rows.Add(parameters);
            //практические
            parameters = new string[AuditoriumHours.Columns.Count];
            parameters[0] = "Практические занятия";
            for (var i = 0; i < discipline.Semesters.Count; i++)
            {
                parameters[i + 1] = (discipline.Semesters[i].Laboratory - discipline.Semesters[i].InteractiveLaboratory).ToString();
            }
            AuditoriumHours.Rows.Add(parameters);
            //интерактивные практические
            parameters = new string[AuditoriumHours.Columns.Count];
            parameters[0] = "Интерактивные и активные формы работы на практических занятиях";
            for (var i = 0; i < discipline.Semesters.Count; i++)
            {
                parameters[i + 1] = discipline.Semesters[i].InteractiveLaboratory.ToString();
            }
            AuditoriumHours.Rows.Add(parameters);
            #endregion

            #region самостоятельная работа
            //балансировка таблицы
            IndependentHours.Clear();
            IndependentHours.Columns.Clear();
            IndependentHours.Columns.Add("Вид учебной работы");
            for (var i = 0; i < discipline.Semesters.Count; i++)
            {
                IndependentHours.Columns.Add("Семестр " + discipline.Semesters[i].Number + " (час.)");
            }
            //всего
            parameters = new string[IndependentHours.Columns.Count];
            parameters[0] = "Самостоятельная работа (всего)";
            for (var i = 0; i < discipline.Semesters.Count; i++)
            {
                parameters[i + 1] = (discipline.Semesters[i].Independent).ToString();
            }
            IndependentHours.Rows.Add(parameters);
            //курсовая
            parameters = new string[IndependentHours.Columns.Count];
            parameters[0] = "Курсовой проект";
            var isNeed = false;
            for (var i = 0; i < discipline.Semesters.Count; i++)
            {
                if (discipline.Semesters[i].CourseWork != 0)
                {
                    isNeed = true;
                    parameters[i + 1] = discipline.Semesters[i].CourseWork.ToString();
                }
            }
            if (isNeed)
            {
                IndependentHours.Rows.Add(parameters);
            }
            #endregion

            #region аттестация
            Validation.Clear();
            Validation.Columns.Clear();
            Validation.Columns.Add("Вид учебной работы");
            for (var i = 0; i < discipline.Semesters.Count; i++)
            {
                Validation.Columns.Add("Семестр " + discipline.Semesters[i].Number + " (час.)");
            }

            parameters = new string[Validation.Columns.Count];
            parameters[0] = "Вид промежуточной аттестации";
            for (var i = 0; i < discipline.Semesters.Count; i++)
            {
                parameters[i + 1] = discipline.Semesters[i].Validation;
            }
            Validation.Rows.Add(parameters);
            //часы на подготовку к экзамену
            parameters = new string[IndependentHours.Columns.Count];
            parameters[0] = "Подготовка к экзамену";
            isNeed = false;
            for (var i = 0; i < discipline.Semesters.Count; i++)
            {
                if (discipline.Semesters[i].ValidationHours != 0)
                {
                    isNeed = true;
                    parameters[i + 1] = discipline.Semesters[i].ValidationHours.ToString();
                }
            }
            if (isNeed)
            {
                Validation.Rows.Add(parameters);
            }
            #endregion
        }

        public void Validate(Discipline discipline)
        {
            Thread.Sleep(100);

            #region table1
            var items = new int[AuditoriumHours.Rows.Count];
            //проверка часов аудиторных занятий
            var totalCols = 0;
            for (var i = 1; i < AuditoriumHours.Columns.Count; i++)
            {
                var summCol = 0;
                for (var j = 1; j < AuditoriumHours.Rows.Count; j++)
                {
                    try
                    {
                        summCol += int.Parse(AuditoriumHours.Rows[j][i].ToString());
                    }
                    catch
                    {
                        summCol += 0;
                    }
                }
                var auditorySemester = discipline.Semesters[i - 1].Lecture + discipline.Semesters[i - 1].Laboratory;
                if (summCol != auditorySemester)
                {
                    throw new Exception(string.Format("Раздел 4. Количество часов аудиторных занятий ({0}) в {1} семестре не совпадает с планом ({2} ч.)",
                        summCol,  discipline.Semesters[i - 1].Number, auditorySemester));
                }
                totalCols += summCol + discipline.Semesters[i -1].ValidationHours;
            }
            var auditoryTotal = discipline.TotalHours - discipline.IndependentWork;
            if (totalCols != auditoryTotal)
            {
                throw new Exception(string.Format("Раздел 4. Общее количество часов аудиторных занятий ({0}) не совпадает с планом ({1} ч.)",
                    totalCols, auditoryTotal));
            }

            // проверка часов самостоятельной работы
            totalCols = 0;
            for (var i = 1; i < IndependentHours.Columns.Count; i++)
            {
                var independantSummCol = 0;
                for (var j = 1; j < IndependentHours.Rows.Count; j++)
                {
                    independantSummCol += Helper.ConvertObjectToInt(IndependentHours.Rows[j][i]);
                }
                var validationSummCol = 0;
                totalCols += independantSummCol;
                if (independantSummCol + validationSummCol != discipline.Semesters[i - 1].Independent)
                {
                    throw new Exception(string.Format("Раздел 4. Количество часов самостоятельной работы ({0}) в {1} семестре не совпадает с планом ({2} ч.)",
                        independantSummCol, discipline.Semesters[i - 1].Number, discipline.IndependentWork));
                }
            }
            if (totalCols != discipline.IndependentWork)
            {
                throw new Exception(string.Format("Раздел 4. Общее количество часов самостоятельной работы ({0}) не совпадает с планом ({1} ч.)",
                    totalCols, discipline.IndependentWork));
            }
            #endregion

            #region table2
            DistributionStudyTimeSumm.Clear();
            var summTable = DistributionStudyTimeSumm;

            for (var i = 0; i < DistributionStudyTime.Rows.Count; i++)
            {
                var row = DistributionStudyTime.Rows[i];
                var semestr = Helper.ConvertObjectToInt(row[3]);
                if (semestr == 0)
                {
                    throw new Exception("Не указан номер семестра. Строка " + (i + 1));
                }

                var chapterIndex = Helper.ConvertObjectToInt(row[1]);
                if (chapterIndex < 1 || chapterIndex > Chapters.Rows.Count)
                {
                    throw new Exception("Неверно указан номер раздела. Возможно он пропущен. Строка " + (i + 1));
                }
            }

            for (var i = 0; i < DistributionStudyTime.Rows.Count; i++)
            {
                var auditory = 0;
                var independent = 0;
                var semester = 0;
                DataRow row = DistributionStudyTime.Rows[i];
                semester = Helper.ConvertObjectToInt(row["Семестр"]);
                auditory += Helper.ConvertObjectToInt(row["Лекции (час.)"]) + Helper.ConvertObjectToInt(row["Практические занятия (час.)"]);
                independent += Helper.ConvertObjectToInt(row["Самостоятельная работа (час.)"]);// + Helper.ConvertObjectToInt(row[8]);
                summTable.Rows.Add(semester, auditory + independent, auditory);
            }

            for (var i = 0; i < discipline.Semesters.Count; i++)
            {
                var summSemester = 0;
                foreach (DataRow row in summTable.Rows)
                {
                    var semesterNumber = Helper.ConvertObjectToInt(row[0]);
                    if (discipline.Semesters[i].Number == semesterNumber)
                    {
                        summSemester += Helper.ConvertObjectToInt(row[1]);
                    }
                }
                if (summSemester != discipline.Semesters[i].TotalHours)
                {
                    var str = String.Format("Количество часов ({0} час.) в {1} семестре не совпадает с планом ({2} час.).",
                        summSemester, discipline.Semesters[i].Number, discipline.Semesters[i].TotalHours);
                    throw new Exception("Раздел 4.1. Тематический план. " + str);
                }
            }

            #region итоговая сумма часов
            DistributionStudyTimeCheckSumm.Clear();
            var allSummTable = DistributionStudyTimeCheckSumm;

            for (var j = 0; j < discipline.Semesters.Count; j++)
            {
                var lectuture = 0;
                var practical = 0;
                var independent = 0;
                var validation = 0;
                for (var i = 0; i < DistributionStudyTime.Rows.Count; i++)
                {
                    DataRow rowSumm = DistributionStudyTimeSumm.Rows[i];
                    DataRow row = DistributionStudyTime.Rows[i];

                    if (discipline.Semesters[j].Number == Helper.ConvertObjectToInt(row[3]))
                    {
                        lectuture += Helper.ConvertObjectToInt(row["Лекции (час.)"]);
                        practical += Helper.ConvertObjectToInt(row["Практические занятия (час.)"]);
                        independent += Helper.ConvertObjectToInt(row["Самостоятельная работа (час.)"]);
                    }
                }
                validation = (from table in Validation.AsEnumerable()
                              select Helper.ConvertObjectToInt(table.Field<string>("Семестр " + discipline.Semesters[j].Number + " (час.)"))).Sum();
                var str = String.Format("Всего за {0} семестр", discipline.Semesters[j].Number);
                var allAuditory = lectuture + practical;
                var allSumm = allAuditory + independent + validation;
                allSummTable.Rows.Add(str, allSumm, allAuditory, lectuture, practical, independent, validation);
            }

            {
                var lectuture = 0;
                var practical = 0;
                var independent = 0;
                var validation = 0;
                var allAuditory = 0;
                var allSumm = 0;
                for (var i = 0; i < allSummTable.Rows.Count; i++)
                {
                    DataRow row = allSummTable.Rows[i];
                    allSumm += Helper.ConvertObjectToInt(row["All"]);
                    allAuditory += Helper.ConvertObjectToInt(row["Auditory"]);
                    lectuture += Helper.ConvertObjectToInt(row["Lecrute"]);
                    practical += Helper.ConvertObjectToInt(row["Practical"]);
                    independent += Helper.ConvertObjectToInt(row["Independant"]);
                    validation += Helper.ConvertObjectToInt(row["Validation"]);
                }
                allSummTable.Rows.Add("Всего", allSumm, allAuditory, lectuture, practical, independent, validation);
            }
            #endregion

            #region заполнение таблицы ChapterSumm
            ChaptersSumm.Clear();
            for (var i = 0; i < Chapters.Rows.Count; i++)
            {
                ChaptersSumm.Rows.Add();
                ChaptersSumm.Rows[i]["ChapterIndex"] = i + 1;
                ChaptersSumm.Rows[i]["ChapterName"] = Chapters.Rows[i]["Наименование"];
            }

            var dstTable = DistributionStudyTime;
            for (var i = 0; i < ChaptersSumm.Rows.Count; i++)
            {
                var lecture = 0;
                var practical = 0;
                var independant = 0;
                var validation = 0;
                for (var j = 0; j < dstTable.Rows.Count; j++)
                {
                    var chapterIndex = Helper.ConvertObjectToInt(dstTable.Rows[j]["Номер раздела"]);
                    if (chapterIndex == Helper.ConvertObjectToInt(ChaptersSumm.Rows[i]["ChapterIndex"]))
                    {
                        lecture += Helper.ConvertObjectToInt(dstTable.Rows[j]["Лекции (час.)"]);
                        practical += Helper.ConvertObjectToInt(dstTable.Rows[j]["Практические занятия (час.)"]);
                        independant += Helper.ConvertObjectToInt(dstTable.Rows[j]["Самостоятельная работа (час.)"]);
                    }
                }
                ChaptersSumm.Rows[i]["Lecrute"] = lecture;
                ChaptersSumm.Rows[i]["Practical"] = practical;
                ChaptersSumm.Rows[i]["Independant"] = independant;
                ChaptersSumm.Rows[i]["Auditory"] = lecture + practical;
                ChaptersSumm.Rows[i]["All"] = lecture + practical + independant + validation;
            }

            //for (var i = 0; i < discipline.Semesters.Count; i++)
            //{
            //    var z = ChaptersSumm.Rows.Count;
            //    ChaptersSumm.Rows.Add();
            //    ChaptersSumm.Rows[z]["ChapterIndex"] = z;
            //    if (discipline.Semesters[i].Validation == "Экзамен")
            //    {
            //        ChaptersSumm.Rows[z]["ChapterName"] = "Подготовка к экзамену";
            //    }
            //    else
            //    {
            //        ChaptersSumm.Rows[z]["ChapterName"] = "Подготовка к зачету";
            //    }
            //    ChaptersSumm.Rows[z]["ChapterName"]

            //    ChaptersSumm.Columns.Add("ChapterIndex");
            //    ChaptersSumm.Columns.Add("ChapterName");
            //    ChaptersSumm.Columns.Add("All");
            //    ChaptersSumm.Columns.Add("Auditory");
            //    ChaptersSumm.Columns.Add("Lecrute");
            //    ChaptersSumm.Columns.Add("Practical");
            //    ChaptersSumm.Columns.Add("Independant");
            //    ChaptersSumm.Columns.Add("Validation");
            //}

            //надо запихнуть в столбец в ворде из таблицы validation
            #endregion

            #endregion
        }

        public void Clear()
        {
            Info = String.Empty;
            AuditoriumHours.Clear();
            IndependentHours.Clear();
            Validation.Clear();
            Chapters.Clear();
            ChaptersSumm.Clear();
            DistributionStudyTime.Clear();
            DistributionStudyTimeSumm.Clear();
            DistributionStudyTimeCheckSumm.Clear();
            PartTwo.Clear();
        }
    }
}

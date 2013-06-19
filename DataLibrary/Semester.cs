using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLibrary
{
    public class Semester
    {
        /// <summary>
        /// номер семестра
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// общее количество часов
        /// </summary>
        public int TotalHours { get; set; }
        /// <summary>
        /// количество часов лекций
        /// </summary>
        public int Lecture { get; set; }
        /// <summary>
        /// количество часов лабораторных (практических)
        /// </summary>
        public int Laboratory { get; set; }
        /// <summary>
        /// количество часов самостоятельной работы
        /// </summary>
        public int Independent { get; set; }
        /// <summary>
        /// число зачетных единиц
        /// </summary>
        public int CreditUnitsCount { get; set; }
        /// <summary>
        /// количество часов интерактивных лекций
        /// </summary>
        public int InteractiveLecture { get; set; }
        /// <summary>
        /// количество часов интерактивных практических
        /// </summary>
        public int InteractiveLaboratory { get; set; }
        /// <summary>
        /// вид аттестации
        /// </summary>
        public string Validation { get; set; }
        /// <summary>
        /// часы, отводящиеся на аттестацию
        /// </summary>
        public int ValidationHours { get; set; }
        /// <summary>
        /// часы на курсовую работу
        /// </summary>
        public int CourseWork { get; set; }
    }
}

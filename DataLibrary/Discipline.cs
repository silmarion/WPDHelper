using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLibrary
{
    public class Discipline
    {
        /// <summary>
        /// название дисциплины
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// код дисциплины
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// число зачетных единиц
        /// </summary>
        public int CreditUnitsCount { get; set; }
        /// <summary>
        /// число часов в зачетной единице
        /// </summary>
        public int CreditUnit { get; set; }
        /// <summary>
        /// общее количество часов
        /// </summary>
        public int TotalHours { get; set; }
        /// <summary>
        /// самстоятельная работа
        /// </summary>
        public int IndependentWork { get; set; }
        /// <summary>
        /// семестры
        /// </summary>
        public List<Semester> Semesters { get; set; }

        public Discipline()
        {
            Semesters = new List<Semester>();
        }
    }
}

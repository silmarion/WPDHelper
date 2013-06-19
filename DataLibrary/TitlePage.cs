
using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLibrary
{
    [Serializable]
    public class TitlePage : IClear
    {
        /// <summary>
        /// название ВУЗа
        /// </summary>
        public string University { get; set; }
        /// <summary>
        /// утверждено. должность
        /// </summary>
        public string CreatorPost { get; set; }
        /// <summary>
        /// утверждено. фио
        /// </summary>
        public string CreatorName { get; set; }
        /// <summary>
        /// название дисциплины
        /// </summary>
        public string Discipline { get; set; }
        /// <summary>
        /// код дисциплины
        /// </summary>
        public string DisciplineCode { get; set; }
        /// <summary>
        /// направление подготовки
        /// </summary>
        public string TrainingDirection { get; set; }
        /// <summary>
        /// профиль подготовки
        /// </summary>
        public string ProfileTraining { get; set; }
        /// <summary>
        /// квалификация (степень)
        /// </summary>
        public string Qualification { get; set; }
        /// <summary>
        /// форма обучения
        /// </summary>
        public string FormOfTraining { get; set; }
        /// <summary>
        /// название кафедры
        /// </summary>
        public string Сathedra { get; set; }
        /// <summary>
        /// город
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// год
        /// </summary>
        public string Year { get; set; }

        public void Clear()
        {
            University = String.Empty;
            CreatorPost = String.Empty;
            CreatorName = String.Empty;
            DisciplineCode = String.Empty;
            TrainingDirection = String.Empty;
            ProfileTraining = String.Empty;
            Qualification = String.Empty;
            FormOfTraining = String.Empty;
            Сathedra = String.Empty;
            City = String.Empty;
            Year = String.Empty;
        }
    }
}

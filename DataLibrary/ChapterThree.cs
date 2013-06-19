
using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataLibrary
{
    [Serializable]
    public class ChapterThree : IClear
    {
        /// <summary>
        /// заголовок
        /// </summary>
        public string Header { get; set; }
        /// <summary>
        /// обзац 1. Выпускник по направлению подготовки ...
        /// </summary>
        public string Paragraph1 { get; set; }
        /// <summary>
        /// список компетенций
        /// </summary>
        public SerializableDictionary<string, string> Competence { get; set; }
        /// <summary>
        /// обзац 2. В частности, в результате изучения дисциплины ...
        /// </summary>
        public string Paragraph2 { get; set; }
        /// <summary>
        /// знать
        /// </summary>
        public DataTable Know { get; set; }
        /// <summary>
        /// уметь
        /// </summary>
        public DataTable Reduced { get; set; }
        /// <summary>
        /// владеть
        /// </summary>
        public DataTable Own { get; set; }

        public ChapterThree()
        {
            Header = "3.	Компетенции обучающегося, формируемые в результате освоения дисциплины";

            Competence = new SerializableDictionary<string, string>();

            Know = new DataTable();
            Know.TableName = "Know";
            Know.Columns.Add();

            Reduced = new DataTable();
            Reduced.TableName = "Reduced";
            Reduced.Columns.Add();

            Own = new DataTable();
            Own.TableName = "Own";
            Own.Columns.Add();
        }

        public void Update(string trainingDirection, string qualification, Dictionary<string, string> disciplineCompetence)
        {
            Paragraph1 = string.Format("Выпускник по направлению подготовки {0} с квалификацией (степенью) {1} должен обладать следующими компетенциями:",
                trainingDirection, qualification);

            if (disciplineCompetence != null)
            {
                Competence = SerializableDictionary<string, string>.ConvertFromDictionary(disciplineCompetence);
            }
        }

        public void Clear()
        {
            Paragraph1 = String.Empty;
            Competence.Clear();
            Paragraph2 = String.Empty;
            Know.Clear();
            Reduced.Clear();
            Own.Clear();
        }
    }
}

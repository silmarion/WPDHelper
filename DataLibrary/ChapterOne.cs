using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataLibrary
{
    [Serializable]
    public class ChapterOne : IClear
    {
        /// <summary>
        /// Цели освоения дисциплины
        /// </summary>
        public string DisciplineMission { get; set; }
        /// <summary>
        /// Профессиональная деятельность
        /// </summary>
        public DataTable ProfessionalActivity { get; set; }
        /// <summary>
        /// Производственно-технологическая деятельность
        /// </summary>
        public DataTable TechnologicalActivity { get; set; }
        /// <summary>
        /// Организационно-управленческая деятельноть
        /// </summary>
        public DataTable AdministrativeActivity { get; set; }
        /// <summary>
        /// Аналитическая деятельность
        /// </summary>
        public DataTable AnalyticalActivity { get; set; }
        /// <summary>
        /// Научно-исследовательская деятельность
        /// </summary>
        public DataTable ResearchActivity { get; set; }
        /// <summary>
        /// В частности, дать основы
        /// </summary>
        public DataTable GiveTheBasics { get; set; }

        public ChapterOne()
        {
            ProfessionalActivity = new DataTable();
            ProfessionalActivity.TableName = "ProfessionalOccupation";
            ProfessionalActivity.Columns.Add();

            TechnologicalActivity = new DataTable();
            TechnologicalActivity.TableName = "TechnologicalActivities";
            TechnologicalActivity.Columns.Add();

            AdministrativeActivity = new DataTable();
            AdministrativeActivity.TableName = "AdministrativeActivity";
            AdministrativeActivity.Columns.Add();

            AnalyticalActivity = new DataTable();
            AnalyticalActivity.TableName = "AnalyticalActivity";
            AnalyticalActivity.Columns.Add();

            ResearchActivity = new DataTable();
            ResearchActivity.TableName = "ResearchActivities";
            ResearchActivity.Columns.Add();

            GiveTheBasics = new DataTable();
            GiveTheBasics.TableName = "GiveTheBasics";
            GiveTheBasics.Columns.Add();
        }

        public void Clear()
        {
            DisciplineMission = String.Empty;
            ProfessionalActivity.Clear();
            TechnologicalActivity.Clear();
            AdministrativeActivity.Clear();
            AnalyticalActivity.Clear();
            ResearchActivity.Clear();
            GiveTheBasics.Clear();
        }
    }
}

using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataLibrary
{
    public class ChapterNine : IClear
    {
        public string Header {get; set;}
        public string SubHeader1 { get; set; }
        public string SubHeader2 { get; set; }
        public string SubHeader3 { get; set; }

        public string General { get; set; }
        public string Teacher { get; set; }
        public string Student { get; set; }
        public DataTable Recommendations { get; set; }

        public ChapterNine()
        {
            Header = "9. Методические рекомендации по организации изучения дисциплины";
            SubHeader1 = "9.1 Общие рекомендации по структуре дисциплины";
            SubHeader2 = "9.2 Методические указания преподавателю";
            SubHeader3 = "9.3 Методические указания студентам";

            General = String.Empty;

            Recommendations = new DataTable { TableName = "Recommendations" };
            Recommendations.Columns.Add("General");
            Recommendations.Columns.Add("Teacher");
            Recommendations.Columns.Add("Student");
        }

        public void Clear()
        {
            Recommendations.Clear();
        }
    }
}

using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataLibrary
{
    public class ChapterSeven : IClear
    {
        public string Header { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public DataTable PrimaryLiterature { get; set; }
        public DataTable AdditionalLiterature { get; set; }
        public DataTable Software { get; set; }

        public ChapterSeven()
        {
            Header = "7. Учебно-методическое и информационное обеспечение дисциплины:";
            Line1 = "а) основная литература";
            Line2 = "б) дополнительная литература";
            Line3 = "в) программное обеспечение";

            PrimaryLiterature = new DataTable { TableName = "PrimaryLiterature" };
            PrimaryLiterature.Columns.Add("Books");

            AdditionalLiterature = new DataTable { TableName = "AdditionalLiterature" };
            AdditionalLiterature.Columns.Add("Books");

            Software = new DataTable { TableName = "Software" };
            Software.Columns.Add("Programs");
        }

        public void Clear()
        {
            PrimaryLiterature.Clear();
            AdditionalLiterature.Clear();
            Software.Clear();
        }
    }
}

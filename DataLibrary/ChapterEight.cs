using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataLibrary
{
    public class ChapterEight : IClear
    {
        public string Header { get; set; }
        public DataTable Provision { get; set; }

        public ChapterEight()
        {
            Header = "8. Материально-техническое обеспечение дисциплины";

            Provision = new DataTable { TableName = "Provision" };
            Provision.Columns.Add("Text");
        }

        public void Clear()
        {
            Provision.Clear();
        }
    }
}

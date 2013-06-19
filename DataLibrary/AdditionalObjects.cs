using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLibrary
{
    public class AdditionalData
    {
        public Dictionary<string, string> Сompetence { get; set; }
        public Discipline Discipline {get; set;}

        public AdditionalData()
        {
            Сompetence = new Dictionary<string, string>();
            Discipline = new Discipline();
        }
    }
}

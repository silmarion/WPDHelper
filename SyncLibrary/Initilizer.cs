using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XLibrary;

namespace SessionLibrary
{
    public class Initilizer
    {
        private XParser _parser;

        public Initilizer(XParser parser)
        {
            _parser = parser;
        }

        public Dictionary<string, string> GetCreators()
        {
            return _parser.GetCreators();
        }

        public List<string> GetDisciplineName()
        {
            return _parser.GetDisciplineName();
        }

        public List<string> GetTrainingDirection()
        {
            return _parser.GetTrainingDirection();
        }

        public string GetDisciplineCode(string disciplineName)
        {
            return _parser.GetDisciplineCode(disciplineName);
        }

        public string GetUniversityName()
        {
            return _parser.GetUniversityName().FirstOrDefault();
        }

        public string GetQualification()
        {
            return _parser.GetQualification().FirstOrDefault();
        }

        public string GetFormOfTraining()
        {
            return _parser.GetFormOfTraining().FirstOrDefault();
        }
    }
}

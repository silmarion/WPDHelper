using DataLibrary;
using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace XLibrary
{ 
    /// <summary>
    /// Класс-помощник для создания РПД
    /// </summary>
    public class XParser
    {
        private XWorker _xWorker;
       
        /// <summary>
        /// </summary>
        /// <param name="path">путь к XML РУПа</param>
        public XParser(string path)
        {
            _xWorker = new XWorker(path);
            var atts = _xWorker.GetAttributeValues("Документ", "Тип");
            
            var error = true;
            foreach(var att in atts)
            {
                if (att == "рабочий учебный план")
                {
                    error = false;
                }
            }
            if (error)
            {
                throw new Exception("XML документ не опознан.");
            }
        }

        /// <summary>
        /// Получить название ВУЗа
        /// </summary>
        /// <returns></returns>
        public List<string> GetUniversityName()
        {
            return _xWorker.GetAttributeValues("Титул", "ИмяВуза");
        }

        /// <summary>
        /// Получить список разработчиков
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> GetCreators()
        {
            var result = new Dictionary<string, string>();
            var post = _xWorker.GetAttributeValues("Разработчик", "Должность");
            var name = _xWorker.GetAttributeValues("Разработчик", "ФИО");
            if(post.Count == name.Count)
            {
                var i = 0;
                foreach (var p in post)
                {
                    result.Add(p, name[i]);
                    i++;
                }
            }
            return result;
        }

        /// <summary>
        /// Получить названия дисциплин
        /// </summary>
        /// <returns></returns>
        public List<string> GetDisciplineName()
        {
            return _xWorker.GetAttributeValues("Строка", "Дис");
        }

        public string GetDisciplineCode(string disciplineName)
        {
            var dis = GetDiscipline(disciplineName);
            return dis.Code;
        }

        /// <summary>
        /// Получить направление подготовки
        /// </summary>
        public List<string> GetTrainingDirection()
        {
            return _xWorker.GetAttributeValues("Специальность", "Название");
        }

        public List<string> GetQualification()
        {
            return _xWorker.GetAttributeValues("Квалификация", "Название");
        }

        public List<string> GetFormOfTraining()
        {
            return _xWorker.GetAttributeValues("План", "ФормаОбучения");
        }

        public Dictionary<string, string> GetAllСompetence()
        {
            var result = new Dictionary<string, string>();
            var elements = _xWorker.GetElementsByName("Компетенции");
            foreach (var element in elements)
            {
                if (element.HasElements)
                {
                    var attributes = _xWorker.GetAttributesInElement("Строка", element);
                    var keys = _xWorker.GetAttributeValuesInAttributes("Индекс", attributes);
                    var values = _xWorker.GetAttributeValuesInAttributes("Содержание", attributes);
                    var length = keys.Count > values.Count ? keys.Count : values.Count;
                    for (var i = 0; i < length; i++)
                    {
                        result.Add((keys[i] ?? ""), (values[i] ?? ""));
                    }
                }
            }
            return result;
        }

        public Dictionary<string, string> GetСompetenceInDiscipline(string discipline)
        {
            var result = new Dictionary<string, string>();
            var elements = _xWorker.GetElementsByAttributeValueInElement("Строка", discipline);
            var currentCompetenceIndex = new List<string>();
            foreach(var el in elements)
            {
                var attValues = el.Attribute("Компетенции").Value.Split(',');
                for (var i = 0; i < attValues.Length; i++)
                {
                    var str = attValues[i].Trim();
                    currentCompetenceIndex.Add(str);
                }
            }
            var competence = GetAllСompetence();
            foreach (var index in currentCompetenceIndex)
            {
                if (competence.ContainsKey(index))
                {
                    result.Add(index, competence[index]);
                }
            }
            return result;
        }

        public Discipline GetDiscipline(string disciplineName)
        {
            var result = new Discipline();
            if (disciplineName != null)
            {
                var element = _xWorker.GetElements("Строка", disciplineName);
                if (element.Count > 1)
                {
                    throw new Exception("2 дисциплины с одинаковыми именами в одном плане. Я не буду так работать!");
                }
                result.Name = disciplineName;
                result.Code = element[0].Attribute("НовИдДисциплины").Value;
                result.CreditUnitsCount = _xWorker.GetAttributeInt32Value("КредитовНаДисциплину", element[0]);
                result.TotalHours = _xWorker.GetAttributeInt32Value("ГОС", element[0]);
                result.IndependentWork = _xWorker.GetAttributeInt32Value("СР", element[0]);
                result.CreditUnit = _xWorker.GetAttributeInt32Value("ЧасовВЗЕТ", element[0]);
                var nodes = element[0].Nodes();
                foreach (XElement el in nodes)
                {
                    if (el.Name == "Сем")
                    {
                        var sem = GetSemester(el);
                        sem.TotalHours = sem.CreditUnitsCount * result.CreditUnit;
                        result.Semesters.Add(sem);
                    }
                }
            }
            return result;
        }

        private Semester GetSemester(XElement element)
        {
            var result = new Semester();
            result.Number = _xWorker.GetAttributeInt32Value("Ном", element);
            result.Lecture = _xWorker.GetAttributeInt32Value("Лек", element);
            result.Laboratory = _xWorker.GetAttributeInt32Value("Лаб", element);
            result.Independent = _xWorker.GetAttributeInt32Value("СРС", element);
            result.CreditUnitsCount = _xWorker.GetAttributeInt32Value("ЗЕТ", element);
            result.InteractiveLecture = _xWorker.GetAttributeInt32Value("ИнтЛек", element);
            result.InteractiveLaboratory = _xWorker.GetAttributeInt32Value("ИнтЛаб", element);
            result.CourseWork = _xWorker.GetAttributeInt32Value("КСР", element);
            var credit = _xWorker.GetAttributeInt32Value("Зач", element) == 0 ? false : true;
            var exam = _xWorker.GetAttributeInt32Value("Экз", element) == 0 ? false : true;
            if(credit && exam)
            {
                throw new Exception("Поддерживается только один вид аттестации в семестре (зачет/экзамен)");
            }
            if (credit)
            {
                result.Validation = "Зачет";
            }
            else
            {
                result.Validation = "Экзамен";
            }
            result.ValidationHours = _xWorker.GetAttributeInt32Value("ЧасЭкз", element);
            return result;
        }
    }
}

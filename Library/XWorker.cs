using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace XLibrary
{
    /// <summary>
    /// Класс для работы с XML
    /// </summary>
    internal class XWorker
    {
        #region конструкторы
        /// <summary>
        /// конструктор
        /// </summary>
        public XWorker()
        {
            Path = "";
            XDoc = null;
        }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="fullPath">путь к XML</param>
        public XWorker(string fullPath)
        {
            Path = fullPath;
            try
            {
                XDoc = XDocument.Load(fullPath);
            }
            catch (Exception ex)
            {
                throw new Exception("Can't load XML.");
            }
        }
        #endregion

        #region поля и свойства
        private XDocument _xDoc;
        /// <summary>
        /// загруженный XML документ
        /// </summary>
        public XDocument XDoc
        {
            get
            {
                if (_xDoc == null)
                {
                    throw new Exception("No XML data.");
                }
                return _xDoc;
            }
            private set
            {
                _xDoc = value;
            }
        }

        private string _path;
        /// <summary>
        /// пусть к XML документу
        /// </summary>
        public string Path 
        {
            get
            {
                if(_path == "")
                {
                    throw new Exception("No path to XML.");
                }
                return _path;
            }
            private set
            {
                _path = value;
            }
        }
        #endregion

        #region методы
        /// <summary>
        /// Получить набор атрибутов всех найденных элементов с заданным именем
        /// </summary>
        /// <param name="elementName"></param>
        /// <returns></returns>
        public List<IEnumerable<XAttribute>> GetAttributes(string elementName, XDocument document = null)
        {
            var result = new List<IEnumerable<XAttribute>>();
            document = document ?? this.XDoc;
            var query = from t in document.Descendants(elementName) select t.Attributes();
            return result = query.ToList();
        }

        /// <summary>
        /// Получить набор значений атрибутов в найденных элементах с заданным именем
        /// </summary>
        /// <param name="elementName"></param>
        /// <param name="attributeName"></param>
        /// <returns></returns>
        public List<string> GetAttributeValues(string elementName, string attributeName, XDocument document = null)
        {
            var result = new List<string>();
            document = document ?? this.XDoc;
            var query = from t in document.Descendants(elementName).Attributes() select t into w where w.Name == attributeName select w;
            foreach (var att in query)
            {
                result.Add(att.Value);
            }
            return result;
        }

        public List<string> GetAttributeValuesInAttributes(string attributeName, List<XAttribute> attributes)
        {
            var result = new List<string>();
            foreach (var att in attributes)
            {
                if (att.Name == attributeName)
                {
                    result.Add(att.Value);
                }
            }
            return result;
        }

        public List<XAttribute> GetAttributesInElement(string elementName, XElement element)
        {
            var result = new List<XAttribute>();
            var document = new XDocument();
            document.Add(element);
            var query = from t in document.Descendants(elementName).Attributes() select t;
            result = query.ToList();
            return result;
        }

        /// <summary>
        /// Получить набор елементов с заданным именем
        /// </summary>
        /// <param name="elementName">название элемента</param>
        /// <param name="document">Определяет новый документ для поиска</param>
        /// <returns></returns>
        public List<XElement> GetElementsByName(string elementName, XDocument document = null)
        {
            document = document ?? this.XDoc;
            var result = new List<XElement>();
            var query = from t in document.Descendants(elementName) select t;
            return result = query.ToList();
        }

        /// <summary>
        /// получитьед  елементы по названию и значению атрибута
        /// </summary>
        /// <param name="elementName">название элемента</param>
        /// /// <param name="attributeValue">значение атрибута</param>
        /// <param name="document">Определяет новый документ для поиска</param>
        /// <returns></returns>
        public List<XElement> GetElementsByAttributeValueInElement(string elementName, string attributeValue, XDocument document = null)
        {
            document = document ?? this.XDoc;
            var result = new List<XElement>();
            var query = from e in document.Descendants(elementName)
                        from t in e.Attributes()
                        where t.Value == attributeValue
                        select e;
            return result = query.ToList();
        }

        /// <summary>
        /// получить дерево елементов с заданным значением атрибута у корневого элмента искомого дерева
        /// </summary>
        /// <param name="elementName">название элемента</param>
        /// /// <param name="attributeValue">значение атрибута</param>
        /// <param name="document">Определяет новый документ для поиска</param>
        /// <returns></returns>
        public List<XElement> GetElements(string elementName, string attributeValue, XDocument document = null)
        {
            var result = new List<XElement>();
            var query = GetElementsByAttributeValueInElement(elementName, attributeValue);
            return result = query.ToList();
        }

        public int GetAttributeInt32Value(string attributeName, XElement element)
        {
            var result = 0;
            var att = element.Attribute(attributeName);
            if (att != null)
            {
                try
                {
                    result = Int32.Parse(att.Value);
                }
                catch
                {
                }
            }
            return result;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace HelperLibrary
{
    public static class SerializeHelper
    {
        public static void Serialize<T>(T ob, string folderPath, string fileName = "")
        {
            var type = ob.GetType();
            if (fileName == "")
            {
                fileName = type.Name;
            }
            var ser = new XmlSerializer(type);
            using (var writer = new StreamWriter(folderPath + fileName + ".xml"))
            {
                ser.Serialize(writer, ob);
                writer.Close();
            }
        }

        public static T Deserialize<T>(T ob, string fullPath)
        {
            var type = ob.GetType();
            using (var reader = new StreamReader(fullPath))
            {
                var ser = new XmlSerializer(type);
                T result = (T)ser.Deserialize(reader);
                reader.Close();
                return result;
            }
        }
    }
}

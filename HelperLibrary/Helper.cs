using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace HelperLibrary
{
    public static class Helper
    {
        public static int ConvertStringToInt(string str)
        {
            var result = 0;
            if (str != "")
            {
                var parsed = Int32.TryParse(str, out result);
                if (!parsed)
                {
                    result = 0;
                }
            }
            return result;
        }

        /// <summary>
        /// Преобразует объект в целое число.
        /// </summary>
        /// <param name="obj">ячейка</param>
        /// <returns>Если конвертация невозможна возвращает 0.</returns>
        public static int ConvertObjectToInt(object obj)
        {
            int result = 0;
            if (obj != null)
            {
                var parsed = Int32.TryParse(obj.ToString(), out result);
            }
            return result;
        }

        /// <summary>
        /// Преобразует объект в десятичное число. Если преобразование не удалось, то результат будет равен 0.0
        /// </summary>
        /// <param name="obj">объект</param>
        /// <param name="safe">true - без выброса исключения</param>
        /// <returns></returns>
        public static double ConvertObjectToDouble(object obj, bool safe = true)
        {
            double result;
            var number = obj.ToString();
            var parsed = Double.TryParse(number, out result);
            if (!parsed)
            {
                number = number.Replace('.', ',');
                parsed = Double.TryParse(number, out result);
                if (!parsed && safe)
                {
                    result = 0.0;
                }
                if (!parsed && !safe)
                {
                    var str = String.Format("Не удалось преобразовать '{0}' в тип double", obj.ToString());
                    throw new Exception(str);
                }
            }
            return result;
        }

        public static string CreateDir(string path)
        {
            for (var i = 0; i < 10; i++)
            {
                if (Directory.Exists(path))
                {
                    var rnd = new Random();
                    path += rnd.Next();
                    continue;
                }
                Directory.CreateDirectory(path);
                return path;
            }
            return path;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HelperLibrary
{
    public class Searcher : IClear
    {
        private List<string> _library;
        public List<string> Library{ get{ return _library; } }
        private bool _loaded; 
        public bool Loaded { get{ return _loaded;} }

        private string _file;

        public Searcher(string folderPath)
        {
            _loaded = false;
            _library = new List<string>();
            if (folderPath == "")
            {
                _file = String.Empty;
            }
            else
            {
                var files = Directory.GetFiles(folderPath);
                foreach (var f in files)
                {
                    if (f.Substring(f.Length - 4).ToLower() == ".txt")
                    {
                        _file = f;
                        if (LoadFile(_file))
                        {
                            _loaded = true;
                        }
                        break;
                    }
                }
            }
        }

        public bool LoadFile(string path)
        {
            if (path.Substring(path.Length - 4).ToLower() == ".txt")
            {
                _file = path;
                var text = File.ReadAllLines(_file, Encoding.Default);
                Trim(text);
                return _loaded = true;
            }
            else
            {
                return false;
            }
        }

        public List<string> Search(string text)
        {
            text = text.ToUpper();
            var result = new List<string>();
            if (_library.Count != 0)
            {
                foreach(var str in _library)
                {
                    if (str.ToUpper().Contains(text))
                    {
                        result.Add(str);
                    }
                }
            }
            return result;
        }

        private void Trim(string[] text)
        {
            for (var i = 0; i < text.Length; i++)
            {
                if (text[i] != String.Empty)
                {
                    var disc = text[i].Distinct().ToArray();
                    if (disc.Length == 1)
                    {
                        text[i] = String.Empty;
                        continue;
                    }
                    var str = text[i];
                    var j = 0;
                    while(j < str.Length - 1)
                    {
                        if ((str[j] == ' ' && j == 0) || (str[j] == ' ' && str[j + 1] == ' '))
                        {
                            str = str.Remove(j, 1);
                        }
                        else
                        {
                            j++;
                        }
                    }
                    text[i] = str;
                }
            }

            var s = String.Empty;
            for (var i = 0; i < text.Length; i++)
            {
                if (text[i] != String.Empty)
                {
                    s += text[i];
                }
                else
                {
                    if (s != String.Empty)
                    {
                        _library.Add(s);
                        s = String.Empty;
                    }
                }
            }
        }

        public List<string> SuperSearch(string target)
        {
            var result = new List<string>();
            var splitTarget = target.ToUpper().Split(' ');
            var numberOfString = new List<int>();
            if (_library.Count == 0)
            {
                return result;
            }
            for (var i = 0; i < _library.Count; i++)
            {
                var splitSource = _library[i].ToUpper().Split(' ');
                //поиск 
                foreach (var t in splitTarget)
                {
                    foreach (var s in splitSource)
                    {
                        var res = DamerauLevenshteinDistance(s, t);
                        if (res <= t.Length / 2)
                        {
                            numberOfString.Add(i);
                        }
                    }
                }
            }
            //отсеиваем повторяющиеся результаты
            var distinctNumbers = numberOfString.Distinct();
            foreach (var num in distinctNumbers)
            {
                result.Add(_library[num]);
            }
            return result;
        }

        public static int DamerauLevenshteinDistance(string source, string target)
        {
            if (String.IsNullOrEmpty(source))
            {
                if (String.IsNullOrEmpty(target))
                {
                    return 0;
                }
                else
                {
                    return target.Length;
                }
            }
            else if (String.IsNullOrEmpty(target))
            {
                return source.Length;
            }

            var score = new int[source.Length + 2, target.Length + 2];

            var INF = source.Length + target.Length;
            score[0, 0] = INF;
            for (var i = 0; i <= source.Length; i++) 
            { 
                score[i + 1, 1] = i; score[i + 1, 0] = INF; 
            }
            for (var j = 0; j <= target.Length; j++) 
            { 
                score[1, j + 1] = j; score[0, j + 1] = INF; 
            }

            var sd = new SortedDictionary<char, int>();
            foreach (var letter in (source + target))
            {
                if (!sd.ContainsKey(letter))
                {
                    sd.Add(letter, 0);
                }
            }

            for (var i = 1; i <= source.Length; i++)
            {
                var DB = 0;
                for (var j = 1; j <= target.Length; j++)
                {
                    var i1 = sd[target[j - 1]];
                    var j1 = DB;
                    if (source[i - 1] == target[j - 1])
                    {
                        score[i + 1, j + 1] = score[i, j];
                        DB = j;
                    }
                    else
                    {
                        score[i + 1, j + 1] = Math.Min(score[i, j], Math.Min(score[i + 1, j], score[i, j + 1])) + 1;
                    }

                    score[i + 1, j + 1] = Math.Min(score[i + 1, j + 1], score[i1, j1] + (i - i1 - 1) + 1 + (j - j1 - 1));
                }

                sd[source[i - 1]] = i;
            }
            return score[source.Length + 1, target.Length + 1];
        }

        public void Clear()
        {
            _file = String.Empty;
            _library = new List<string>();
        }
    }
}

using DataLibrary;
using DocLibrary;
using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using XLibrary;

namespace SessionLibrary
{
    /// <summary>
    /// класс-singletone для работы приложения
    /// </summary>
    public class Manager
    {
        //путь к папке текущей сессии
        private string _sessionPath;
        public string SessionPath { get { return _sessionPath; } }
        //путь к папке незавершенных сессий (без создания .docx)
        private string _startDir;
        //путь к папке завершенных сессий
        private string _completeDir;
        //парсер
        private XParser _parser;
        //в процессе загрузки данных.
        private bool _loading;
        //показ демонстрационного примера
        private bool _demo;
        
        private bool _newSession;
        /// <summary>
        /// признак новой сессии
        /// </summary>
        public bool NewSession { get { return _newSession; } }

        private string _planPath;
        /// <summary>
        /// FullName плана
        /// </summary>
        public string PlanPath { get { return _planPath; } }

        private bool _newPlan;

        private bool _readyToWork;
        /// <summary>
        /// готовность к работе
        /// </summary>
        public bool ReadyToWork { get { return _readyToWork; } }

        public Initilizer FormDataInitilizer { get; set; }

        //словарь объектов для поддержания сессий (все, что находится на табах)
        public SessionData SessionObjects { get; set; }
        //дополнительные независимые от сессии объекты 
        public AdditionalData AdditionalObjects { get; set; }

        public Searcher SearchEngine { get; set; }

        public Manager()
        {
            
            _startDir = Directory.GetCurrentDirectory() + @"\Sessions\Start";
            _completeDir = Directory.GetCurrentDirectory() + @"\Sessions\Complete";
            if (!Directory.Exists("Sessions"))
            {
                Directory.CreateDirectory("Sessions");
            }
            if (!Directory.Exists(_startDir))
            {
                Directory.CreateDirectory(_startDir);
            }
            if (!Directory.Exists(_completeDir))
            {
                Directory.CreateDirectory(_completeDir);
            }
            SessionObjects = new SessionData();
            AdditionalObjects = new AdditionalData();
            ClearSession();
        }

        public void ClearSession()
        {
            _readyToWork = false;
            _loading = false;
            _sessionPath = String.Empty;
            _planPath = String.Empty;
            SearchEngine = new Searcher("");
            _newSession = true;
            _newPlan = false;
            _demo = false;

            //вызов метода Clear()
            var sesProperties = SessionObjects.GetType().GetProperties();
            foreach (var p in sesProperties)
            {
                var interfaces = p.PropertyType.GetInterfaces();
                foreach(var i in interfaces)
                {
                    if (i.Name == "IClear")
                    {
                        ((IClear)p.GetValue(SessionObjects, null)).Clear();
                    }
                }
            }
            var addProperties = AdditionalObjects.GetType().GetProperties();
            foreach (var p in addProperties)
            {
                var interfaces = p.PropertyType.GetInterfaces();
                foreach (var i in interfaces)
                {
                    if (i.Name == "IClear")
                    {
                        ((IClear)p.GetValue(AdditionalObjects, null)).Clear();
                    }
                }
            }
        }

        /// <summary>
        /// проверка файла плана
        /// </summary>
        public void ValidatePlan()
        {
            try
            {
                LoadCompetence();
            }
            catch
            {
                throw new Exception("Недействительный файл плана.");
            }
        }

        /// <summary>
        /// загрузить список всех компетенций
        /// </summary>
        private void LoadCompetence()
        {
            AdditionalObjects.Сompetence.Clear();
            var competence = _parser.GetAllСompetence();
            foreach (var c in competence)
            {
                AdditionalObjects.Сompetence.Add(c.Key, c.Value);
            }
            
        }

        /// <summary>
        /// получить информацию о сессиях
        /// </summary>
        /// <param name="sesType">Start или Complete</param>
        /// <returns></returns>
        public List<SessionDirInfo> GetDisciplinesFromSessions(SessionType sesType)
        {
            var result = new List<SessionDirInfo>();
            var path = "";
            switch (sesType)
            {
                case SessionType.Start: path = _startDir; break;
                case SessionType.Complete: path = _completeDir; break;
                default: path = _startDir; break;
            }
            var childDirs = new DirectoryInfo(path).GetDirectories();
            _loading = true;
            foreach (var d in childDirs)
            {
                var files = new DirectoryInfo(d.FullName).GetFiles();
                foreach (var f in files)
                {
                    var titlePage = new TitlePage();
                    if (f.Name.Substring(0, f.Name.Length - 4) == titlePage.GetType().Name)
                    {
                        try
                        {
                            var ob = Activator.CreateInstance(titlePage.GetType());
                            ob = SerializeHelper.Deserialize(ob, f.FullName);
                            titlePage = ob as TitlePage;
                        }
                        catch
                        {
                            continue;
                        }
                        if (titlePage.Discipline != String.Empty)
                        {
                            result.Add(
                                new SessionDirInfo
                                {
                                    CreationDate = d.CreationTime,
                                    DisciplineName = titlePage.Discipline,
                                    Path = d.FullName,
                                    DisciplineCode = titlePage.DisciplineCode,
                                    FormOftraining = titlePage.FormOfTraining
                                });
                        }
                        break;
                    }
                }
            }
            _loading = false;
            return result;
        }
        
        /// <summary>
        /// создает новую сессию
        /// </summary>
        public void CreateSession(string planFileName)
        {
            _sessionPath = _startDir + "\\";
            if (!Directory.Exists(_sessionPath))
            {
                Directory.CreateDirectory(_sessionPath);
                _sessionPath += "\\S1";
            }
            else
            {
                var childDirs = new DirectoryInfo(_sessionPath).GetDirectories();
                _sessionPath += "S" + (childDirs.Length + 1).ToString();    
            }
            _sessionPath = Helper.CreateDir(_sessionPath);
            _sessionPath += "\\";
            _planPath = _sessionPath + new FileInfo(planFileName).Name;
            File.Copy(planFileName, _planPath);
            _parser = new XParser(_planPath);
            FormDataInitilizer = new Initilizer(_parser);
            _newSession = true;
            #region titlePage
            SessionObjects.TitlePage.University = FormDataInitilizer.GetUniversityName();
            SessionObjects.TitlePage.Qualification = FormDataInitilizer.GetQualification();
            SessionObjects.TitlePage.FormOfTraining = FormDataInitilizer.GetFormOfTraining();
            #endregion
            SearchEngine = new Searcher(_sessionPath);
            ValidatePlan();
            _readyToWork = true;
        }

        public void CreateSessionOn(string path)
        {
            var files = new DirectoryInfo(path).GetFiles();
            foreach (var file in files)
            {
                var extension = file.FullName.Substring(file.FullName.Length - 7);
                if (extension == "plm.xml" || extension == "pli.xml")
                {
                    CreateSession(file.FullName);
                    break;
                }
            }
            if (!_readyToWork)
            {
                throw new Exception("Не удалось создать новый сеанс.");
            }
            try
            {
                CopySession(path, _sessionPath);
                LoadSession(_sessionPath);
            }
            catch(IOException ex)
            {
                var delPath = _sessionPath;
                CloseSession();
                try
                {
                    DeleteSession(delPath);
                }
                catch
                {
                }
                throw new Exception("Не удалось создать новый сеанс.\n" + ex.Message);
            }
        }

        public void CopySession(string source, string destination)
        {
            var files = new DirectoryInfo(source).GetFiles();
            foreach (var file in files)
            {
                File.Copy(file.FullName, destination + file.Name, true);
            }
        }

        /// <summary>
        /// удаляет сессию
        /// </summary>
        /// <param name="path"></param>
        public void DeleteSession(string path)
        {
            if (path == _sessionPath)
            {
                throw new Exception("Невозможно удалить открытый сеанс.");
            }
            else
            {
                var files = Directory.GetFiles(path);
                foreach (var file in files)
                {
                    File.Delete(file);
                }
                Directory.Delete(path);
            }
        }

        /// <summary>
        /// сохраняет и закрывает сессию
        /// </summary>
        public void CloseSession()
        {
            if (_readyToWork)
            {
                SaveSession();
                ClearSession();
            }
        }

        /// <summary>
        /// загружает сессию
        /// </summary>
        /// <param name="path">путь к папке</param>
        public void LoadSession(string path)
        {
            if (Directory.Exists(path))
            {
                if (path.Contains("\\Resources\\Demo"))
                {
                    _demo = true;
                }
                _loading = true;
                _sessionPath = path + "\\";
                var files = new DirectoryInfo(_sessionPath).GetFiles();
                foreach (var file in files)
                {
                    var extension = file.FullName.Substring(file.FullName.Length - 7);
                    if (extension == "plm.xml" || extension == "pli.xml")
                    {
                        _planPath = file.FullName;
                        _parser = new XParser(_planPath);
                        FormDataInitilizer = new Initilizer(_parser);
                        continue;
                    }
                    var typeName = file.Name.Substring(0, file.Name.Length - 4);
                    var type = Type.GetType("DataLibrary." + typeName + ",DataLibrary");
                    if (type != null)
                    {
                        try
                        {
                            var ob = Activator.CreateInstance(type);
                            ob = SerializeHelper.Deserialize(ob, file.FullName);
                            SessionObjects.SetProperty(type, ob);
                        }
                        catch
                        {
                        }
                    }
                }
                _loading = false;
                if (_planPath == String.Empty)
                {
                    throw new IOException("В папке с сеансом нет файла с планом. Обновите учебный план." + path);
                }
                UpdateObjects();
                SearchEngine = new Searcher(_sessionPath);
                _readyToWork = true;
                _newSession = false;
            }
            else
            {
                ClearSession();
                throw new IOException("Невозможно найти путь: " + path);
            }
        }

        /// <summary>
        /// сохраняет сессию
        /// </summary>
        public void SaveSession()
        {
            if (_readyToWork && !_demo)
            {
                var sesProperties = SessionObjects.GetType().GetProperties();
                foreach (var p in sesProperties)
                {
                    SerializeHelper.Serialize(p.GetValue(SessionObjects, null), _sessionPath);
                }
            }
        }

        public void UpdatePlan(string updateSessionPath, string planPath)
        {
            var newFileExt = planPath.Substring(planPath.Length - 8).ToLower();
            if (newFileExt != ".plm.xml" && newFileExt != ".pli.xml")
            {
                throw new Exception("Выбранный файл не является файлом плана. "
                    + "Поддерживаются файлы планов с расширением \".plm.xml\" и \".pli.xml\".");
            }
            var files = new DirectoryInfo(updateSessionPath).GetFiles();
            foreach (var file in files)
            {
                var extension = (file.FullName.Substring(file.FullName.Length - 8)).ToLower();
                if(extension == ".plm.xml" || extension == ".pli.xml")
                {
                    File.Delete(file.FullName);
                }
            }
            _planPath = updateSessionPath + "\\" + (new FileInfo(planPath)).Name;
            File.Copy(planPath, _planPath, true);
            _newPlan = true;
        }

        public void UpdateLibrary(string filePath)
        {
            if (!_readyToWork)
            {
                return;
            }
            if (new FileInfo(filePath).Extension.ToLower() != ".txt")
            {
                throw new Exception("Выбранный файл не является файлом списка литературы. "
                    + "Поддерживаются файлы с расширением \".txt\".");
            }
            var files = new DirectoryInfo(_sessionPath).GetFiles();
            foreach (var file in files)
            {
                if (file.Extension.ToLower() == ".txt")
                {
                    File.Delete(file.FullName);
                }
            }
            var _libraryPath = _sessionPath + new FileInfo(filePath).Name;
            File.Copy(filePath, _libraryPath);
            SearchEngine.LoadFile(_libraryPath);
        }

        public void OpenSessionFolder()
        {
            Process.Start(_sessionPath);
        }

        /// <summary>
        /// обновление объектов сессии при изменении дисциплины
        /// </summary>
        public void UpdateObjects ()
        {
            if (!_readyToWork)
            {
                return;
            }
            var titlePage = SessionObjects.TitlePage;

            #region SessionChapterThree
            var chapterThree = SessionObjects.ChapterThree;
            chapterThree.Update(titlePage.TrainingDirection, titlePage.Qualification, _parser.GetСompetenceInDiscipline(titlePage.Discipline));
            #endregion

            #region Discipline & SessionChapterFour
            var discipline = AdditionalObjects.Discipline;
            var chapterFour = SessionObjects.ChapterFour;

            if (discipline.Name != titlePage.Discipline)
            {
                discipline.Name = titlePage.Discipline;
                discipline = _parser.GetDiscipline(discipline.Name);
                AdditionalObjects.Discipline = discipline;

                if (!_loading && _newSession || _newPlan)
                {
                    chapterFour.Update(discipline);
                }
            }
            #endregion
        }

        /// <summary>
        /// проверка на соответствие данным из плана
        /// </summary>
        public void Validate()
        {
            if (SessionObjects.TitlePage.Discipline != null && SessionObjects.TitlePage.Discipline != String.Empty)
            {
                SessionObjects.ChapterFour.Validate(AdditionalObjects.Discipline);
                SessionObjects.ChapterFour.PartTwo.Validate(SessionObjects.ChapterFour.DistributionStudyTime, 
                    SessionObjects.ChapterFour.DistributionStudyTimeSumm);
            }
            else
            {
                throw new Exception("Не выбрана дисциплина.");
            }
        }

        public void GenerateDocument()
        {
            //TODO: добавить проверку на демо
            if (!_readyToWork)
            {
                return;
            }
            SaveSession();
            Validate();
            var doc = new DocBuilder();
            doc.GenerateWordDocument(_sessionPath + SessionObjects.TitlePage.Discipline + ".docx", SessionObjects, AdditionalObjects);

            if (_sessionPath.Contains("Start"))
            {
                var childDirs = new DirectoryInfo(_completeDir).GetDirectories();
                var newDir = _completeDir + "\\S" + (childDirs.Length + 1).ToString();
                newDir = Helper.CreateDir(newDir);
                newDir += "\\";
                var files = new DirectoryInfo(_sessionPath).GetFiles();
                foreach (var f in files)
                {
                    f.CopyTo(newDir + f.Name, true);
                }
                var oldSessionPath = _sessionPath;
                _sessionPath = newDir;
                foreach (var f in files)
                {
                    f.Delete();
                }
                Directory.Delete(oldSessionPath);
            }
            Process.Start(_sessionPath + SessionObjects.TitlePage.Discipline + ".docx");
        }
    }
}

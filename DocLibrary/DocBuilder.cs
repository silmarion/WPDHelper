using DataLibrary;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DocLibrary
{
    public partial class DocBuilder
    {
        private DocSettings _docSettings;

        private WordprocessingDocument _wordDocument;
        private Numbering _numbering;
        private MainDocumentPart _mainPart;
        private Body _body;

        private SessionData _sessionObjects{get; set;}
        private AdditionalData _additionalObjects { get; set; }

        public DocBuilder()
        {
        }

        public void GenerateWordDocument(string docName, SessionData sessionObjects, AdditionalData additionalObjects)
        {
            _sessionObjects = sessionObjects;
            _additionalObjects = additionalObjects;
            //var openS = new OpenSettings();
            //openS.MarkupCompatibilityProcessSettings = new MarkupCompatibilityProcessSettings(
            //    MarkupCompatibilityProcessMode.ProcessAllParts, FileFormatVersions.Office2007);
            //using (_wordDocument = WordprocessingDocument.Open(docName, true, openS))
            using (_wordDocument = WordprocessingDocument.Create(docName, WordprocessingDocumentType.Document))
            {
                InitilizeDocument();

                GenerateTitlePage();
                GeneratePageTwo();
                GenerateChapterOne();
                GenerateChapterTwo();
                GenerateChapterThree();
                GenerateChapterFour();
                GenerateChapterFive();
                GenerateChapterSix();
                GenerateChapterSeven();
                GenerateChapterEight();
                GenerateChapterNine();
                GenerateChapterTen();
                var numberingDefinitionsPart = _mainPart.AddNewPart<NumberingDefinitionsPart>();
                numberingDefinitionsPart.Numbering = _numbering;
            }
            
        }

        private void InitilizeDocument()
        {
            //создаем класс настроек документа
            _docSettings = new DocSettings();

            _mainPart = _wordDocument.AddMainDocumentPart();
            //устанавливаем стили
            var styleDefinitionsPart = _mainPart.AddNewPart<StyleDefinitionsPart>();
            styleDefinitionsPart.Styles = new Styles();
            foreach (var style in _docSettings.Styles)
            {
                styleDefinitionsPart.Styles.Append(style);
            }
            //устанавливаем разметку списков
            _numbering = new Numbering();
            _docSettings.GenerateListNumbering(ref _numbering);
            //numberingDefinitionsPart.Numbering = _docSettings.ListNumbering;
            //_numberingDefinitionsPart.Numbering = _docSettings.Numbering;

            _mainPart.Document = new Document();
            _body = _mainPart.Document.AppendChild(new Body());
        }

        #region генерация документа
        //генерирует титульную страницу 
        private void GenerateTitlePage()
        {
            var titlePage = _sessionObjects.TitlePage;

            var paragraph = new Paragraph();
            var paraProp = GetParagraphProperties("StyleWithoutIndentation");
            var runProp = new RunProperties();
            var run = new Run();
            var runs = new List<Run>();

            runProp = new RunProperties();
            runProp.Append(new Bold());
            run = new Run();
            run.Append(runProp);
            //TODO: поменять " на "«" "»"
            run.Append(new Text(titlePage.University.ToUpper()));   
            GenerateParagraph(run, paraProp);

            GenerateParagraph();
            GenerateParagraph();

            runProp = new RunProperties();
            runProp.Append(new Bold());
            run = new Run();
            run.Append(runProp);
            run.Append(new Text("УТВЕРЖДАЮ:"));
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            paraProp.Append(new Indentation() { Left = "5812" });
            GenerateParagraph(run, paraProp);


            run = new Run();
            run.Append(new Text(titlePage.CreatorPost));  
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            paraProp.Append(new Indentation() { Left = "5812" });
            GenerateParagraph(run, paraProp);

            run = new Run();
            run.Append(new Text("_________________________"));
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            paraProp.Append(new Indentation() { Left = "5812" });
            GenerateParagraph(run, paraProp);

            run = new Run();
            run.Append(new Text(titlePage.CreatorName));  
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            paraProp.Append(new Justification() { Val = JustificationValues.Right });
            GenerateParagraph(run, paraProp);

            run = new Run();
            run.Append(new Text("«__»______________ 2012 г."));
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            paraProp.Append(new Indentation() { Left = "5812" });
            GenerateParagraph(run, paraProp);  

            GenerateParagraph();
            GenerateParagraph();
            GenerateParagraph();

            runProp = new RunProperties();
            runProp.Append(new Bold());
            run = new Run();
            run.Append(runProp);
            run.Append(new Text("РАБОЧАЯ ПРОГРАММА ДИСЦИПЛИНЫ"));
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            paraProp.Append(new Justification() { Val = JustificationValues.Center });
            GenerateParagraph(run, paraProp);

            runProp = new RunProperties();
            runProp.Append(new Bold());
            run = new Run();
            run.Append(runProp);
            run.Append(new Text("«" + titlePage.Discipline + "»"));   
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            paraProp.Append(new Justification() { Val = JustificationValues.Center });
            GenerateParagraph(run, paraProp);  

            GenerateParagraph();

            runProp = new RunProperties();
            runProp.Append(new Bold());
            run = new Run();
            run.Append(runProp);
            run.Append(new Text(titlePage.DisciplineCode)); 
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            paraProp.Append(new Justification() { Val = JustificationValues.Center });
            GenerateParagraph(run, paraProp);   

            GenerateParagraph();

            runProp = new RunProperties();
            runProp.Append(new Bold());
            runs = new List<Run>();
            run = new Run();
            run.Append(runProp);
            run.Append(new Text("Направление подготовки: ") { Space = SpaceProcessingModeValues.Preserve });
            runs.Add(run);
            run = new Run();
            run.Append(new Text(titlePage.TrainingDirection));  
            runs.Add(run);
            GenerateParagraph(runs);

            runProp = new RunProperties();
            runProp.Append(new Bold());
            runs = new List<Run>();
            run = new Run();
            run.Append(runProp);
            run.Append(new Text("Профиль подготовки: ") { Space = SpaceProcessingModeValues.Preserve });
            runs.Add(run);
            run = new Run();
            run.Append(new Text(titlePage.ProfileTraining));  
            runs.Add(run);
            GenerateParagraph(runs);  

            runProp = new RunProperties();
            runProp.Append(new Bold());
            runs = new List<Run>();
            run = new Run();
            run.Append(runProp);
            run.Append(new Text("Квалификация (степень) выпускника: ") { Space = SpaceProcessingModeValues.Preserve });
            runs.Add(run);
            run = new Run();
            run.Append(new Text(titlePage.Qualification));    
            runs.Add(run);
            GenerateParagraph(runs);

            runProp = new RunProperties();
            runProp.Append(new Bold());
            runs = new List<Run>();
            run = new Run();
            run.Append(runProp);
            run.Append(new Text("Форма обучения: ") { Space = SpaceProcessingModeValues.Preserve });
            runs.Add(run);
            run = new Run();
            run.Append(new Text(titlePage.FormOfTraining));   
            runs.Add(run);
            GenerateParagraph(runs);

            GenerateParagraph();
            GenerateParagraph();
            GenerateParagraph();

            run = new Run();
            run.Append(new Text(titlePage.Сathedra)); 
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            paraProp.Append(new Justification() { Val = JustificationValues.Center });
            GenerateParagraph(run, paraProp);

            GenerateParagraph();
            GenerateParagraph();

            runProp = new RunProperties();
            runProp.Append(new Bold());
            run = new Run();
            run.Append(runProp);
            run.Append(new Text(titlePage.City));     
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            paraProp.Append(new Justification() { Val = JustificationValues.Center });
            GenerateParagraph(run, paraProp);

            runProp = new RunProperties();
            runProp.Append(new Bold());
            run = new Run();
            run.Append(runProp);
            run.Append(new Text(titlePage.Year));     
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            paraProp.Append(new Justification() { Val = JustificationValues.Center });
            GenerateParagraph(run, paraProp);

            run = new Run();
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            run.Append(new RunProperties());
            run.Append(new Break { Type = BreakValues.Page });
            GenerateParagraph(run, paraProp);
        }

        private void GeneratePageTwo()
        {
            var titlePage = _sessionObjects.TitlePage;

            var paragraph = new Paragraph();
            var paraProp = GetParagraphProperties("StyleWithoutIndentation");
            var runProp = new RunProperties();
            var run = new Run();
            run.Append(runProp);
            var str = String.Format("Программа учебной дисциплины «{0}» составлена в соответствии с требованиями ФГОС по направлению «{1}» "
                + "и профилю подготовки «", titlePage.Discipline, titlePage.TrainingDirection);
            run.Append(new Text(str));
            paragraph.Append(paraProp);
            paragraph.Append(run);

            run = new Run();
            runProp = new RunProperties{ Color = new Color{ Val = "FF0000" } };
            run.Append(runProp);
            run.Append(new Text("{вставить профиль подготовки}"));
            paragraph.Append(run);

            run = new Run();
            run.Append(new RunProperties());
            str = String.Format("» в соответствии с рабочим учебным планом, утвержденным ректором {0}.", titlePage.University);
            run.Append(new Text(str));
            paragraph.Append(run);
            _body.Append(paragraph);

            GenerateParagraph();

            run = new Run();
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            run.Append(new RunProperties());
            run.Append(new Text("Автор(ы):"));
            GenerateParagraph(run, paraProp);

            run = new Run();
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            paraProp.Append(new Indentation { Left = "4253" });
            run.Append(new RunProperties());
            GenerateParagraph(run, paraProp);
            GenerateParagraph();

            run = new Run();
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            run.Append(new RunProperties());
            run.Append(new Text("Эксперты:"));
            GenerateParagraph(run, paraProp);

            for (var i = 0; i < 6; i++)
            {
                run = new Run();
                paraProp = GetParagraphProperties("StyleWithoutIndentation");
                paraProp.Append(new Indentation { Left = "4253" });
                run.Append(new RunProperties());
                GenerateParagraph(run, paraProp);
            }

            run = new Run();
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            run.Append(new RunProperties());
            run.Append(new Text("ОБСУЖДЕНО"));
            GenerateParagraph(run, paraProp);

            paragraph = new Paragraph();
            paragraph.Append(GetParagraphProperties("StyleWithoutIndentation"));
            run = new Run();
            run.Append(new RunProperties());
            run.Append(new Text("на заседании кафедры "));
            paragraph.Append(run);
            run = new Run();
            runProp = new RunProperties { Color = new Color { Val = "FF0000" } };
            run.Append(runProp);
            run.Append(new Text("{название кафедры, дата и номер протокола}"));
            paragraph.Append(run);
            _body.Append(paragraph);

            run = new Run();
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            run.Append(new RunProperties());
            run.Append(new Text("ОДОБРЕНО"));
            GenerateParagraph(run, paraProp);

            run = new Run();
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            runProp = new RunProperties { Color = new Color { Val = "FF0000" } };
            run.Append(runProp);
            run.Append(new Text("{кем одобрено, дата}"));
            GenerateParagraph(run, paraProp);

            run = new Run();
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            run.Append(new Break { Type = BreakValues.Page });
            GenerateParagraph(run, paraProp);
        }

        private void GenerateChapterOne()
        {
            var cos = _sessionObjects.ChapterOne;

            var paragraph = new Paragraph();
            var runProp = new RunProperties();
            var run = new Run();
            var runs = new List<Run>();

            run.Append(new Text("1. Цели освоения дисциплины"));
            var paraProp = GetParagraphProperties("Header1");
            GenerateParagraph(run, paraProp);

            runProp = new RunProperties();
            runProp.Append(new Bold());
            runs = new List<Run>();
            run = new Run();
            run.Append(runProp);
            run.Append(new Text("Целями освоения дисциплины ") { Space = SpaceProcessingModeValues.Preserve });
            runs.Add(run);
            run = new Run();
            var discipName = _sessionObjects.TitlePage.Discipline;
            run.Append(new Text("«" + discipName + "» является ") { Space = SpaceProcessingModeValues.Preserve });
            runs.Add(run);
            run = new Run();
            run.Append( new Text(cos.DisciplineMission) );
            runs.Add(run);
            GenerateParagraph(runs);
            GenerateParagraph();

            runProp = new RunProperties { Bold = new Bold ()};
            run = new Run { RunProperties = runProp };
            run.Append(new Text("Основными обобщенными задачами дисциплины являются:"));
            GenerateParagraph(run);

            runProp = new RunProperties { Italic = new Italic() };
            run = new Run { RunProperties = runProp };
            run.Append(new Text("Профессиональная деятельность"));
            GenerateParagraph(run);
            for(var i = 0; i < cos.ProfessionalActivity.Rows.Count; i++)
            {
                paraProp = GetListProperties();
                run = new Run();
                var row = cos.ProfessionalActivity.Rows[i][0];
                run.Append(new Text(Convert.ToString(row)) );
                GenerateParagraph(run, paraProp);
            }

            runProp = new RunProperties { Italic = new Italic() };
            run = new Run { RunProperties = runProp };
            run.Append(new Text("Производственно-технологическая деятельность"));
            GenerateParagraph(run);
            for (var i = 0; i < cos.TechnologicalActivity.Rows.Count; i++)
            {
                paraProp = GetListProperties();
                run = new Run();
                var row = cos.TechnologicalActivity.Rows[i][0];
                run.Append(new Text(Convert.ToString(row)));
                GenerateParagraph(run, paraProp);
            }

            runProp = new RunProperties { Italic = new Italic() };
            run = new Run { RunProperties = runProp };
            run.Append(new Text("Организационно-управленческая деятельность"));
            GenerateParagraph(run);
            for (var i = 0; i < cos.AdministrativeActivity.Rows.Count; i++)
            {
                paraProp = GetListProperties();
                run = new Run();
                var row = cos.AdministrativeActivity.Rows[i][0];
                run.Append(new Text(Convert.ToString(row)));
                GenerateParagraph(run, paraProp);
            }

            runProp = new RunProperties { Italic = new Italic() };
            run = new Run { RunProperties = runProp };
            run.Append(new Text("Аналитическая деятельность"));
            GenerateParagraph(run);
            for (var i = 0; i < cos.AnalyticalActivity.Rows.Count; i++)
            {
                paraProp = GetListProperties();
                run = new Run();
                var row = cos.AnalyticalActivity.Rows[i][0];
                run.Append(new Text(Convert.ToString(row)));
                GenerateParagraph(run, paraProp);
            }

            runProp = new RunProperties { Italic = new Italic() };
            run = new Run { RunProperties = runProp };
            run.Append(new Text("Научно-исследовательская деятельность"));
            GenerateParagraph(run);
            for (var i = 0; i < cos.ResearchActivity.Rows.Count; i++)
            {
                paraProp = GetListProperties();
                run = new Run();
                var row = cos.ResearchActivity.Rows[i][0];
                run.Append(new Text(Convert.ToString(row)));
                GenerateParagraph(run, paraProp);
            }

            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            runProp = new RunProperties { Italic = new Italic() };
            run = new Run { RunProperties = runProp };
            run.Append(new Text("В частности, дать основы:"));
            GenerateParagraph(run, paraProp);
            for (var i = 0; i < cos.GiveTheBasics.Rows.Count; i++)
            {
                paraProp = GetListProperties();
                paraProp.Indentation = new Indentation() { Left = "1084" };
                run = new Run();
                var row = cos.GiveTheBasics.Rows[i][0];
                run.Append(new Text(Convert.ToString(row)));
                GenerateParagraph(run, paraProp);
            }
        }

        private void GenerateChapterTwo() 
        {
            var titlePage = _sessionObjects.TitlePage;

            var paragraph = new Paragraph();
            var runProp = new RunProperties();
            var run = new Run();
            var runs = new List<Run>();

            run.Append(new Text("2. Место учебной дисциплины в структуре основной образовательной программы"));
            var paraProp = GetParagraphProperties("Header1");
            GenerateParagraph(run, paraProp);

            paragraph = new Paragraph();
            paragraph.Append(GetParagraphProperties());
            run = new Run();
            var str = String.Format("Учебная дисциплина «{0}» – дисциплина ", titlePage.Discipline);
            run.Append(new Text(str) { Space = SpaceProcessingModeValues.Preserve });
            paragraph.Append(run);
            run = new Run();
            runProp = new RunProperties { Color = new Color { Val = "FF0000" } };
            run.Append(runProp);
            run.Append(new Text("{описать к какому блоку и циклу принадлежит дисциплина}" ){ Space = SpaceProcessingModeValues.Preserve });
            paragraph.Append(run);
            run = new Run();
            str = String.Format(" федерального государственного образовательного стандарта подготовки {0}ов по направлению «", titlePage.Qualification);
            run.Append(new Text(str) { Space = SpaceProcessingModeValues.Preserve });
            paragraph.Append(run);
            run = new Run();
            runProp = new RunProperties { Color = new Color { Val = "FF0000" } };
            run.Append(runProp);
            run.Append(new Text("{написать направление}") { Space = SpaceProcessingModeValues.Preserve });
            paragraph.Append(run);
            run = new Run();
            str = String.Format("».", titlePage.Qualification);
            run.Append(new Text(str) { Space = SpaceProcessingModeValues.Preserve });
            paragraph.Append(run);
            _body.Append(paragraph);

            var discipline = _additionalObjects.Discipline;
            var num = 0;
            if(discipline.Semesters.Count != 0)
            {
                for(var i = 0; i < discipline.Semesters.Count; i++)
                {
                    num += discipline.Semesters[i].Number;
                }
            }
            var courseNumber = Math.Ceiling( (double)(num / 2) );
            paragraph = new Paragraph();
            paragraph.Append(GetParagraphProperties());
            run = new Run();
            str = String.Format("Дисциплина изучается на {0} курсе, базируется на знаниях студентов, полученных в процессе изучения дисциплин: ", courseNumber);
            run.Append(new Text(str) { Space = SpaceProcessingModeValues.Preserve });
            paragraph.Append(run);
            run = new Run();
            runProp = new RunProperties { Color = new Color { Val = "FF0000" } };
            run.Append(runProp);
            run.Append(new Text("{название дисциплин}") { Space = SpaceProcessingModeValues.Preserve });
            paragraph.Append(run);
            run = new Run();
            str = String.Format(" и может служить основой для изучения следующих учебных дисциплин: ");
            run.Append(new Text(str) { Space = SpaceProcessingModeValues.Preserve });
            paragraph.Append(run);
            run = new Run();
            runProp = new RunProperties { Color = new Color { Val = "FF0000" } };
            run.Append(runProp);
            run.Append(new Text("{название дисциплин}") { Space = SpaceProcessingModeValues.Preserve });
            paragraph.Append(run);

            GenerateParagraph();

            #region table
            var chapterFour = _sessionObjects.ChapterFour;
            var numOfColumn = 10;
            if (chapterFour.Chapters.Rows.Count != 0)
            {
                numOfColumn = chapterFour.Chapters.Rows.Count;
            }

            var table = new Table();
            table.Append(GenerateTableProperties());
            var tableGrid1 = new TableGrid();
            var gridColumn = new GridColumn { Width = "3969" };
            tableGrid1.Append(gridColumn);
            for (var i = 0; i < numOfColumn; i++)
            {
                var gridColumn1 = new GridColumn{ Width = "400" };
                tableGrid1.Append(gridColumn1);
            }
            table.Append(tableGrid1);

            #region Шапка
            #region row
            var tableRow = new TableRow();

            #region cell
            var tableCell = new TableCell();
            TableCellProperties tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new VerticalMerge() { Val = MergedCellValues.Restart });
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });

            tableCell.Append(tableCellProperties1);
            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            var spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            var justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold()
            };
            run.Append(runProp);
            run.Append(new Text("Наименование обеспечиваемых (последующих) дисциплин"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new VerticalMerge() { Val = MergedCellValues.Restart });
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            tableCellProperties1.Append(new GridSpan() { Val = numOfColumn });
            tableCell.Append(tableCellProperties1);
            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
            };
            run.Append(runProp);
            run.Append(new Text("№ разделов данной дисциплины, необходимых для изучения обеспечиваемых (последующих) дисциплин"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            table.Append(tableRow);
            #endregion

            #region row
            tableRow = new TableRow();

            #region cell
            tableCell = new TableCell();
            var tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            for (var i = 0; i < numOfColumn; i++)
            {
                #region cell
                tableCell = new TableCell();
                paragraph = new Paragraph();
                paraProp = GetParagraphProperties("TableStyle");
                spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                justification = new Justification() { Val = JustificationValues.Center };
                paraProp.Append(spacingBetweenLines);
                paraProp.Append(justification);
                run = new Run();
                runProp = new RunProperties
                {
                    Bold = new Bold(),
                };
                run.Append(runProp);
                run.Append(new Text((i + 1).ToString()));
                paragraph.Append(paraProp);
                paragraph.Append(run);
                tableCell.Append(paragraph);
                tableRow.Append(tableCell);
                #endregion
            }

            table.Append(tableRow);
            #endregion
            #endregion

            #region данные
            for (var i = 0; i < 3; i++)
            {
                #region row
                tableRow = new TableRow();

                #region cell
                tableCell = new TableCell();
                tableCellProperties1 = new TableCellProperties();
                tableCellProperties1.Append(new VerticalMerge() { Val = MergedCellValues.Restart });
                tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });

                tableCell.Append(tableCellProperties1);
                paragraph = new Paragraph();
                paraProp = GetParagraphProperties("TableStyle");
                spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                justification = new Justification() { Val = JustificationValues.Center };
                paraProp.Append(spacingBetweenLines);
                paraProp.Append(justification);
                run = new Run();
                run.Append(new Text("Название дисциплины 1"));
                paragraph.Append(paraProp);
                paragraph.Append(run);
                tableCell.Append(paragraph);
                tableRow.Append(tableCell);
                #endregion

                for (var j = 0; j < numOfColumn; j++)
                {
                    var rand = new Random(2);
                    #region cell
                    tableCell = new TableCell();
                    tableCellProperties1 = new TableCellProperties();
                    tableCellProperties1.Append(new VerticalMerge() { Val = MergedCellValues.Restart });
                    tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                    tableCell.Append(tableCellProperties1);
                    paragraph = new Paragraph();
                    paraProp = GetParagraphProperties("TableStyle");
                    spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                    justification = new Justification() { Val = JustificationValues.Center };
                    paraProp.Append(spacingBetweenLines);
                    paraProp.Append(justification);
                    run = new Run();
                    runProp = new RunProperties { Bold = new Bold() };
                    run.Append(runProp);
                    if (rand.Next() == 1)
                    {
                        run.Append(new Text("X"));
                    }
                    paragraph.Append(paraProp);
                    paragraph.Append(run);
                    tableCell.Append(paragraph);
                    tableRow.Append(tableCell);
                    #endregion
                }
                table.Append(tableRow);
                #endregion
            }
            #endregion

            _body.Append(table);
            #endregion

            run = new Run();
            run.Append(new Break { Type = BreakValues.Page });
            GenerateParagraph();
        }

        private void GenerateChapterThree()
        {
            var cts = _sessionObjects.ChapterThree;

            var paragraph = new Paragraph();
            var runProp = new RunProperties();
            var run = new Run();
            var runs = new List<Run>();

            var paraProp = GetParagraphProperties("Header1");
            run.Append(new Text(cts.Header));
            GenerateParagraph(run, paraProp);

            run = new Run();
            run.Append(new Text(cts.Paragraph1));
            GenerateParagraph(run);

            var i = 0;
            foreach (var c in cts.Competence)
            {
                var symbol = ';';
                if(i++ == cts.Competence.Count - 1)
                {
                    symbol = '.';
                }
                paraProp = GetListProperties();
                paraProp.Indentation = new Indentation() { Left = "1084" };
                run = new Run();
                run.Append( new Text( string.Format("{0} ({1}){2}", c.Value, c.Key, symbol) ) );
                GenerateParagraph(run, paraProp);
            }
            GenerateParagraph();

            run = new Run();
            run.Append(new Text(cts.Paragraph2));
            GenerateParagraph(run);

            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            runProp = new RunProperties { Underline = new Underline{ Val = UnderlineValues.Single } };
            run = new Run { RunProperties = runProp };
            run.Append(new Text("знать:"));
            GenerateParagraph(run, paraProp);
            for (i = 0; i < cts.Know.Rows.Count; i++)
            {

                paraProp = GetListProperties();
                paraProp.Indentation = new Indentation() { Left = "1084" };
                run = new Run();
                var row = cts.Know.Rows[i][0];
                run.Append(new Text(Convert.ToString(row) + " ") { Space = SpaceProcessingModeValues.Preserve });
                GenerateParagraph(run, paraProp);
            }

            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            runProp = new RunProperties { Underline = new Underline{ Val = UnderlineValues.Single } };
            run = new Run { RunProperties = runProp };
            run.Append(new Text("уметь:"));
            GenerateParagraph(run, paraProp);
            for (i = 0; i < cts.Reduced.Rows.Count; i++)
            {

                paraProp = GetListProperties();
                paraProp.Indentation = new Indentation() { Left = "1084" };
                run = new Run();
                var row = cts.Reduced.Rows[i][0];
                run.Append(new Text(Convert.ToString(row) + " ") { Space = SpaceProcessingModeValues.Preserve });
                GenerateParagraph(run, paraProp);
            }

            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            runProp = new RunProperties { Underline = new Underline{ Val = UnderlineValues.Single } };
            run = new Run { RunProperties = runProp };
            run.Append(new Text("владеть:"));
            GenerateParagraph(run, paraProp);
            for (i = 0; i < cts.Own.Rows.Count; i++)
            {

                paraProp = GetListProperties();
                paraProp.Indentation = new Indentation() { Left = "1084" };
                run = new Run();
                var row = cts.Own.Rows[i][0];
                run.Append(new Text(Convert.ToString(row) + " ") { Space = SpaceProcessingModeValues.Preserve });
                GenerateParagraph(run, paraProp);
            }
        }

        private void GenerateChapterFour()
        {
            var chapterFour = _sessionObjects.ChapterFour;

            var paraProp = new ParagraphProperties();
            var paragraph = new Paragraph();
            var runProp = new RunProperties();
            var run = new Run();
            var runs = new List<Run>();

            paraProp = GetParagraphProperties("Header1");
            run.Append(new Text(chapterFour.Header));
            GenerateParagraph(run, paraProp);

            run = new Run();
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            run.Append(new Text(chapterFour.Info));
            GenerateParagraph(run, paraProp);

            GenerateChapterFourTable1();

            paragraph = new Paragraph();
            run = new Run();
            run.Append( new Break() { Type = BreakValues.Page } );
            GenerateParagraph(run);

            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            runProp = new RunProperties()
            {
                Bold = new Bold(),
                Italic = new Italic()
            };
            run = new Run();
            run.Append(runProp);
            run.Append(new Text(chapterFour.SubHeader1));
            GenerateParagraph(run, paraProp);

            GenerateChapterFourTable2();

            GenerateChapterFour_PartTwo();
        }

        private void GenerateChapterFourTable1()
        {
            var chapterFour = (ChapterFour)_sessionObjects.ChapterFour;
            var discipline = (Discipline)_additionalObjects.Discipline;

            var paraProp = new ParagraphProperties();
            var paragraph = new Paragraph();
            var runProp = new RunProperties();
            var run = new Run();
            var runs = new List<Run>();

            var table = new Table();
            table.Append(GenerateTableProperties());

            var tableGrid1 = new TableGrid();
            for (var i = 0; i < chapterFour.AuditoriumHours.Columns.Count + 1; i++)
            {
                var gridColumn1 = new GridColumn();
                if (i == 0)
                {
                    gridColumn1.Width = "4536";
                    
                }
                else
                {
                    gridColumn1.Width = "1200";
                }
                tableGrid1.Append(gridColumn1);
            }
            table.Append(tableGrid1);

            #region Шапка
            #region row
            var tableRow = new TableRow();

            #region cell
            var tableCell = new TableCell();
            TableCellProperties tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new VerticalMerge() { Val = MergedCellValues.Restart });
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });

            tableCell.Append(tableCellProperties1);
            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            var spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            var justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
                Italic = new Italic()
            };
            run.Append(runProp);
            run.Append(new Text("Вид учебной работы"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new VerticalMerge() { Val = MergedCellValues.Restart });
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            tableCell.Append(tableCellProperties1);
            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
                Italic = new Italic()
            };
            run.Append(runProp);
            run.Append(new Text("Всего зачетных единиц / часов"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new VerticalMerge() { Val = MergedCellValues.Restart });
            tableCellProperties1.Append(new GridSpan() { Val = 2 });
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            tableCell.Append(tableCellProperties1);
            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
                Italic = new Italic()
            };
            run.Append(runProp);
            run.Append(new Text("Семестр"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            table.Append(tableRow);
            #endregion

            #region row
            tableRow = new TableRow();

            #region cell
            tableCell = new TableCell();
            var tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            for(var i = 0; i < discipline.Semesters.Count; i++)
            {
                #region cell
                tableCell = new TableCell();
                paragraph = new Paragraph();
                paraProp = GetParagraphProperties("TableStyle");
                spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                justification = new Justification() { Val = JustificationValues.Center };
                paraProp.Append(spacingBetweenLines);
                paraProp.Append(justification);
                run = new Run();
                runProp = new RunProperties
                {
                    Bold = new Bold(),
                    Italic = new Italic()
                };
                run.Append(runProp);
                run.Append(new Text(discipline.Semesters[i].Number.ToString()));
                paragraph.Append(paraProp);
                paragraph.Append(run);
                tableCell.Append(paragraph);
                tableRow.Append(tableCell);
                #endregion
            }
          
            table.Append(tableRow);
            #endregion

            #region row
            tableRow = new TableRow();

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            for (var i = 0; i < discipline.Semesters.Count; i++)
            {
                #region cell
                tableCell = new TableCell();
                tableCellProperties1 = new TableCellProperties();
                tableCellProperties1.Append(new VerticalMerge() { Val = MergedCellValues.Restart });
                tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                tableCell.Append(tableCellProperties1);

                paragraph = new Paragraph();
                paraProp = GetParagraphProperties("TableStyle");
                spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                justification = new Justification() { Val = JustificationValues.Center };
                paraProp.Append(spacingBetweenLines);
                paraProp.Append(justification);
                run = new Run();
                runProp = new RunProperties
                {
                    Italic = new Italic()
                };
                run.Append(runProp);
                run.Append(new Text("з.е. / час."));
                paragraph.Append(paraProp);
                paragraph.Append(run);
                tableCell.Append(paragraph);
                tableRow.Append(tableCell);
                #endregion
            }

            table.Append(tableRow);
            #endregion
            #endregion

            #region Аудиторные занятия
            #region row
            tableRow = new TableRow();

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            tableCell.Append(tableCellProperties1);

            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold()
            };
            run.Append(runProp);
            run.Append(new Text("Аудиторные занятия (всего)"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });

            tableCell.Append(tableCellProperties1);
            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold()
            };
            run.Append(runProp);
            var str = GetStringHoursAndCreditUnits(discipline.TotalHours - discipline.IndependentWork);
            run.Append(new Text(str));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            for (var i = 0; i < discipline.Semesters.Count; i++)
            {
                #region cell
                tableCell = new TableCell();
                tableCellProperties1 = new TableCellProperties();
                tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                tableCell.Append(tableCellProperties1);
                paragraph = new Paragraph();
                paraProp = GetParagraphProperties("TableStyle");
                spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                justification = new Justification() { Val = JustificationValues.Center };
                paraProp.Append(spacingBetweenLines);
                paraProp.Append(justification);
                run = new Run();
                runProp = new RunProperties
                {
                    Bold = new Bold()
                };
                run.Append(runProp);
                str = GetStringHoursAndCreditUnits( discipline.Semesters[i].TotalHours - discipline.Semesters[i].Independent );
                run.Append(new Text(str));
                paragraph.Append(paraProp);
                paragraph.Append(run);
                tableCell.Append(paragraph);
                tableRow.Append(tableCell);
                #endregion
            }

            table.Append(tableRow);
            #endregion

            for (var i = 1; i < chapterFour.AuditoriumHours.Rows.Count; i++)
            {
                var dataRow = chapterFour.AuditoriumHours.Rows[i];
                var data = new string[dataRow.ItemArray.Length + 1];

                data[0] = dataRow.ItemArray[0].ToString();
                var summ = 0;
                for (var j = 1; j < dataRow.ItemArray.Length; j++)
                {
                    var integer = Int32.Parse(dataRow.ItemArray[j].ToString());
                    data[j + 1] = GetStringHoursAndCreditUnits(integer);
                    summ += integer;
                }
                data[1] = GetStringHoursAndCreditUnits(summ);

                #region row
                tableRow = new TableRow();

                for (var j = 0; j < data.Length; j++)
                {
                    #region cell
                    tableCell = new TableCell();
                    tableCellProperties1 = new TableCellProperties();
                    tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                    tableCell.Append(tableCellProperties1);

                    paragraph = new Paragraph();
                    paraProp = GetParagraphProperties("TableStyle");
                    spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                    justification = new Justification() { Val = JustificationValues.Center };
                    paraProp.Append(spacingBetweenLines);
                    paraProp.Append(justification);
                    run = new Run();
                    run.Append(new Text(data[j]));
                    paragraph.Append(paraProp);
                    paragraph.Append(run);
                    tableCell.Append(paragraph);
                    tableRow.Append(tableCell);
                    #endregion
                }

                table.Append(tableRow);
                #endregion
            }
            #endregion

            #region Самостоятельная работа
            #region row
            tableRow = new TableRow();

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });

            tableCell.Append(tableCellProperties1);
            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold()
            };
            run.Append(runProp);
            run.Append(new Text("Самостоятельная работа (всего)"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });

            tableCell.Append(tableCellProperties1);
            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold()
            };
            run.Append(runProp);
            str = GetStringHoursAndCreditUnits(discipline.IndependentWork);
            run.Append(new Text(str));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            for (var i = 0; i < discipline.Semesters.Count; i++)
            {
                #region cell
                tableCell = new TableCell();
                tableCellProperties1 = new TableCellProperties();
                tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                tableCell.Append(tableCellProperties1);

                paragraph = new Paragraph();
                paraProp = GetParagraphProperties("TableStyle");
                spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                justification = new Justification() { Val = JustificationValues.Center };
                paraProp.Append(spacingBetweenLines);
                paraProp.Append(justification);
                run = new Run();
                runProp = new RunProperties
                {
                    Bold = new Bold()
                };
                run.Append(runProp);
                str = GetStringHoursAndCreditUnits(discipline.Semesters[i].Independent);
                run.Append(new Text(str));
                paragraph.Append(paraProp);
                paragraph.Append(run);
                tableCell.Append(paragraph);
                tableRow.Append(tableCell);
                #endregion
            }

            table.Append(tableRow);
            #endregion

            for (var i = 1; i < chapterFour.IndependentHours.Rows.Count; i++)
            {
                var dataRow = chapterFour.IndependentHours.Rows[i];
                var data = new string[dataRow.ItemArray.Length + 1];

                data[0] = dataRow.ItemArray[0].ToString();
                var summ = 0;
                for (var j = 1; j < dataRow.ItemArray.Length; j++)
                {
                    var integer = Int32.Parse(dataRow.ItemArray[j].ToString());
                    data[j + 1] = GetStringHoursAndCreditUnits(integer);
                    summ += integer;
                }
                data[1] = GetStringHoursAndCreditUnits(summ);

                #region row
                tableRow = new TableRow();

                for (var j = 0; j < data.Length; j++)
                {
                    #region cell
                    tableCell = new TableCell();
                    tableCellProperties1 = new TableCellProperties();
                    tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                    tableCell.Append(tableCellProperties1);

                    paragraph = new Paragraph();
                    paraProp = GetParagraphProperties("TableStyle");
                    spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                    justification = new Justification() { Val = JustificationValues.Center };
                    paraProp.Append(spacingBetweenLines);
                    paraProp.Append(justification);
                    run = new Run();
                    run.Append(new Text(data[j]));
                    paragraph.Append(paraProp);
                    paragraph.Append(run);
                    tableCell.Append(paragraph);
                    tableRow.Append(tableCell);
                    #endregion
                }

                table.Append(tableRow);
                #endregion
            }
            #endregion

            #region Аттестация
            #region row
            tableRow = new TableRow();

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });

            tableCell.Append(tableCellProperties1);
            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold()
            };
            run.Append(runProp);
            run.Append(new Text("Вид промежуточной аттестации (зачет, экзамен)"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });

            tableCell.Append(tableCellProperties1);
            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            paragraph.Append(paraProp);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            for (var i = 0; i < discipline.Semesters.Count; i++)
            {
                #region cell
                tableCell = new TableCell();
                tableCellProperties1 = new TableCellProperties();
                tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                tableCell.Append(tableCellProperties1);

                paragraph = new Paragraph();
                paraProp = GetParagraphProperties("TableStyle");
                spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                justification = new Justification() { Val = JustificationValues.Center };
                paraProp.Append(spacingBetweenLines);
                paraProp.Append(justification);
                run = new Run();
                runProp = new RunProperties
                {
                    Bold = new Bold()
                };
                run.Append(runProp);
                run.Append(new Text(discipline.Semesters[i].Validation));
                paragraph.Append(paraProp);
                paragraph.Append(run);
                tableCell.Append(paragraph);
                tableRow.Append(tableCell);
                #endregion
            }

            table.Append(tableRow);
            #endregion

            for (var i = 1; i < chapterFour.Validation.Rows.Count; i++)
            {
                var dataRow = chapterFour.Validation.Rows[i];
                var data = new string[dataRow.ItemArray.Length + 1];

                data[0] = dataRow.ItemArray[0].ToString();
                var summ = 0;
                for (var j = 1; j < dataRow.ItemArray.Length; j++)
                {
                    var integer = Helper.ConvertObjectToInt(dataRow.ItemArray[j].ToString());
                    data[j + 1] = GetStringHoursAndCreditUnits(integer);
                    summ += integer;
                }
                data[1] = GetStringHoursAndCreditUnits(summ);

                #region row
                tableRow = new TableRow();

                for (var j = 0; j < data.Length; j++)
                {
                    #region cell
                    tableCell = new TableCell();
                    tableCellProperties1 = new TableCellProperties();
                    tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                    tableCell.Append(tableCellProperties1);

                    paragraph = new Paragraph();
                    paraProp = GetParagraphProperties("TableStyle");
                    spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                    justification = new Justification() { Val = JustificationValues.Center };
                    paraProp.Append(spacingBetweenLines);
                    paraProp.Append(justification);
                    run = new Run();
                    run.Append(new Text(data[j]));
                    paragraph.Append(paraProp);
                    paragraph.Append(run);
                    tableCell.Append(paragraph);
                    tableRow.Append(tableCell);
                    #endregion
                }

                table.Append(tableRow);
                #endregion
            }
            #endregion

            #region общее количество часов

            #region row
            tableRow = new TableRow();

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            Shading shading1 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "D9D9D9" };
            tableCellProperties1.Append(shading1);
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            tableCell.Append(tableCellProperties1);

            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold()
            };
            run.Append(runProp);
            run.Append(new Text("Общая трудоемкость дисциплины"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            shading1 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "D9D9D9" };
            tableCellProperties1.Append(shading1);
            tableCell.Append(tableCellProperties1);

            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold()
            };
            run.Append(runProp);
            str = GetStringHoursAndCreditUnits(discipline.TotalHours);
            run.Append(new Text(str));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            for (var i = 0; i < discipline.Semesters.Count; i++)
            {
                #region cell
                tableCell = new TableCell();
                tableCellProperties1 = new TableCellProperties();
                tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                shading1 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "D9D9D9" };
                tableCellProperties1.Append(shading1);
                tableCell.Append(tableCellProperties1);

                paragraph = new Paragraph();
                paraProp = GetParagraphProperties("TableStyle");
                spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                justification = new Justification() { Val = JustificationValues.Center };
                paraProp.Append(spacingBetweenLines);
                paraProp.Append(justification);
                run = new Run();
                runProp = new RunProperties
                {
                    Bold = new Bold()
                };
                run.Append(runProp);
                str = GetStringHoursAndCreditUnits(discipline.Semesters[i].TotalHours);
                run.Append(new Text(str));
                paragraph.Append(paraProp);
                paragraph.Append(run);
                tableCell.Append(paragraph);
                tableRow.Append(tableCell);
                #endregion
            }

            table.Append(tableRow);
            #endregion

            #endregion

            _body.Append(table); 
        }

        private void GenerateChapterFourTable2()
        {
            var chapterFour = (ChapterFour)_sessionObjects.ChapterFour;
            var discipline = (Discipline)_additionalObjects.Discipline;

            var paraProp = new ParagraphProperties();
            var paragraph = new Paragraph();
            var runProp = new RunProperties();
            var run = new Run();
            var runs = new List<Run>();

            var table = new Table();
            table.Append(GenerateTableProperties());

            var tableGrid1 = new TableGrid();
            tableGrid1.Append(new GridColumn { Width = "450" });
            tableGrid1.Append(new GridColumn { Width = "3100" });
            tableGrid1.Append(new GridColumn { Width = "800" });
            tableGrid1.Append(new GridColumn { Width = "450" });
            tableGrid1.Append(new GridColumn { Width = "600" });
            tableGrid1.Append(new GridColumn { Width = "600" });
            tableGrid1.Append(new GridColumn { Width = "600" });
            tableGrid1.Append(new GridColumn { Width = "600" });
            tableGrid1.Append(new GridColumn { Width = "650" });
            tableGrid1.Append(new GridColumn { Width = "600" });
            tableGrid1.Append(new GridColumn { Width = "600" });
            
            table.Append(tableGrid1);

            #region Шапка

            #region row
            var tableRow = new TableRow();

            #region cell
            var tableCell = new TableCell();
            TableCellProperties tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new VerticalMerge() { Val = MergedCellValues.Restart });
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            tableCellProperties1.Append(new TextDirection() { Val = TextDirectionValues.BottomToTopLeftToRight });
            tableCell.Append(tableCellProperties1);

            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            var spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            var justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
            };
            run.Append(runProp);
            run.Append(new Text("Номер раздела"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new VerticalMerge() { Val = MergedCellValues.Restart });
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            tableCell.Append(tableCellProperties1);

            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
            };
            run.Append(runProp);
            run.Append(new Text("Наименование раздела / темы"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new VerticalMerge() { Val = MergedCellValues.Restart });
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            tableCellProperties1.Append(new TextDirection() { Val = TextDirectionValues.BottomToTopLeftToRight });
            tableCell.Append(tableCellProperties1);

            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
            };
            run.Append(runProp);
            run.Append(new Text("Обрабатываемые"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);

            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
            };
            run.Append(runProp);
            run.Append(new Text("компетенции"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new VerticalMerge() { Val = MergedCellValues.Restart });
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            tableCellProperties1.Append(new TextDirection() { Val = TextDirectionValues.BottomToTopLeftToRight });
            tableCell.Append(tableCellProperties1);

            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
            };
            run.Append(runProp);
            run.Append(new Text("Семестр"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new VerticalMerge() { Val = MergedCellValues.Restart });
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            tableCellProperties1.Append(new TextDirection() { Val = TextDirectionValues.BottomToTopLeftToRight });
            tableCell.Append(tableCellProperties1);

            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
            };
            run.Append(runProp);
            run.Append(new Text("Неделя семестра"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new GridSpan(){ Val = 6 });
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            tableCell.Append(tableCellProperties1);

            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
            };
            run.Append(runProp);
            run.Append(new Text("Часов по учебной (рабочей) программе"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion
            
            table.Append(tableRow);
            #endregion

            #region row
            tableRow = new TableRow();

            #region cell
            tableCell = new TableCell();
            var tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new VerticalMerge() { Val = MergedCellValues.Restart });
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            tableCellProperties1.Append(new TextDirection() { Val = TextDirectionValues.BottomToTopLeftToRight });
            tableCell.Append(tableCellProperties1);

            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
            };
            run.Append(runProp);
            run.Append(new Text("Всего в уч. плане по разделу / теме"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new GridSpan(){ Val = 3 });
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            tableCell.Append(tableCellProperties1);

            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
            };
            run.Append(runProp);
            run.Append(new Text("Аудиторная работа"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new VerticalMerge() { Val = MergedCellValues.Restart });
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            tableCellProperties1.Append(new TextDirection() { Val = TextDirectionValues.BottomToTopLeftToRight });
            tableCell.Append(tableCellProperties1);

            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
            };
            run.Append(runProp);
            run.Append(new Text("Самостоятельная"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);

            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
            };
            run.Append(runProp);
            run.Append(new Text("работа студента"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new VerticalMerge() { Val = MergedCellValues.Restart });
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            tableCellProperties1.Append(new TextDirection() { Val = TextDirectionValues.BottomToTopLeftToRight });
            tableCell.Append(tableCellProperties1);

            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
            };
            run.Append(runProp);
            run.Append(new Text("Экзамен"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            table.Append(tableRow);
            #endregion

            #region row
            tableRow = new TableRow();

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new VerticalMerge() { Val = MergedCellValues.Restart });
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            tableCellProperties1.Append(new TextDirection() { Val = TextDirectionValues.BottomToTopLeftToRight });
            tableCell.Append(tableCellProperties1);

            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
            };
            run.Append(runProp);
            run.Append(new Text("Всего"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new GridSpan(){ Val = 2 });
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            tableCell.Append(tableCellProperties1);

            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
            };
            run.Append(runProp);
            run.Append(new Text("В том числе"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            table.Append(tableRow);
            #endregion

            #region row
            tableRow = new TableRow();
            TableRowProperties tableRowProperties1 = new TableRowProperties();
            tableRowProperties1.Append(new TableRowHeight() { Val = (UInt32Value)1775U });
            tableRow.Append(tableRowProperties1);


            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new VerticalMerge() { Val = MergedCellValues.Restart });
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            tableCellProperties1.Append(new TextDirection() { Val = TextDirectionValues.BottomToTopLeftToRight });
            tableCell.Append(tableCellProperties1);

            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
            };
            run.Append(runProp);
            run.Append(new Text("Лекции"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new VerticalMerge() { Val = MergedCellValues.Restart });
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            tableCellProperties1.Append(new TextDirection() { Val = TextDirectionValues.BottomToTopLeftToRight });
            tableCell.Append(tableCellProperties1);

            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
            };
            run.Append(runProp);
            run.Append(new Text("Практич. занятия"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProp = new TableCellProperties { VerticalMerge = new VerticalMerge() };
            tableCell.Append(tableCellProp);
            paragraph = new Paragraph();
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            table.Append(tableRow);
            #endregion
            #endregion

            #region Данные

            var dstTable = chapterFour.DistributionStudyTime;
            var dstSummTable = chapterFour.DistributionStudyTimeSumm;
            var chSummTable = chapterFour.ChaptersSumm;
            for (var k = 0; k < chSummTable.Rows.Count; k++)
            {
                #region row Раздел
                tableRow = new TableRow();

                #region cell
                tableCell = new TableCell();
                tableCellProperties1 = new TableCellProperties();
                tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                tableCell.Append(tableCellProperties1);

                paragraph = new Paragraph();
                paraProp = GetParagraphProperties("TableStyle");
                spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                justification = new Justification() { Val = JustificationValues.Center };
                paraProp.Append(spacingBetweenLines);
                paraProp.Append(justification);
                run = new Run();
                runProp = new RunProperties { Bold = new Bold() };
                run.Append(runProp);
                run.Append(new Text(chSummTable.Rows[k]["ChapterIndex"].ToString()));
                paragraph.Append(paraProp);
                paragraph.Append(run);
                tableCell.Append(paragraph);
                tableRow.Append(tableCell);
                #endregion

                #region cell
                tableCell = new TableCell();
                tableCellProperties1 = new TableCellProperties();
                tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                tableCell.Append(tableCellProperties1);

                paragraph = new Paragraph();
                paraProp = GetParagraphProperties("TableStyle");
                spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                justification = new Justification() { Val = JustificationValues.Left };
                Indentation indentation = new Indentation() { Left = "87" };
                paraProp.Append(spacingBetweenLines);
                paraProp.Append(justification);
                paraProp.Append(indentation);
                run = new Run();
                runProp = new RunProperties { 
                    Italic = new Italic(),
                    Bold = new Bold() 
                };
                run.Append(runProp);
                run.Append(new Text(chSummTable.Rows[k]["ChapterName"].ToString()));
                paragraph.Append(paraProp);
                paragraph.Append(run);
                tableCell.Append(paragraph);
                tableRow.Append(tableCell);
                #endregion

                #region cell
                tableCell = new TableCell();
                tableCellProperties1 = new TableCellProperties();
                tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                tableCell.Append(tableCellProperties1);

                paragraph = new Paragraph();
                paraProp = GetParagraphProperties("TableStyle");
                spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                justification = new Justification() { Val = JustificationValues.Left };
                paraProp.Append(spacingBetweenLines);
                paraProp.Append(justification);
                run = new Run();
                paragraph.Append(paraProp);
                paragraph.Append(run);
                tableCell.Append(paragraph);
                tableRow.Append(tableCell);
                #endregion

                #region cell
                tableCell = new TableCell();
                tableCellProperties1 = new TableCellProperties();
                tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                tableCell.Append(tableCellProperties1);

                paragraph = new Paragraph();
                paraProp = GetParagraphProperties("TableStyle");
                spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                justification = new Justification() { Val = JustificationValues.Left };
                paraProp.Append(spacingBetweenLines);
                paraProp.Append(justification);
                run = new Run();
                paragraph.Append(paraProp);
                paragraph.Append(run);
                tableCell.Append(paragraph);
                tableRow.Append(tableCell);
                #endregion

                #region cell
                tableCell = new TableCell();
                tableCellProperties1 = new TableCellProperties();
                tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                tableCell.Append(tableCellProperties1);

                paragraph = new Paragraph();
                paraProp = GetParagraphProperties("TableStyle");
                spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                justification = new Justification() { Val = JustificationValues.Left };
                paraProp.Append(spacingBetweenLines);
                paraProp.Append(justification);
                run = new Run();
                paragraph.Append(paraProp);
                paragraph.Append(run);
                tableCell.Append(paragraph);
                tableRow.Append(tableCell);
                #endregion

                for (var i = 2; i < chSummTable.Columns.Count; i++)
                {
                    #region cell
                    tableCell = new TableCell();
                    tableCellProperties1 = new TableCellProperties();
                    tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                    tableCell.Append(tableCellProperties1);

                    paragraph = new Paragraph();
                    paraProp = GetParagraphProperties("TableStyle");
                    spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                    justification = new Justification() { Val = JustificationValues.Center };
                    paraProp.Append(spacingBetweenLines);
                    paraProp.Append(justification);
                    run = new Run();
                    runProp = new RunProperties { Bold = new Bold() };
                    run.Append(runProp);
                    var num = Helper.ConvertObjectToInt(chSummTable.Rows[k][i]);
                    var str = "";
                    if(num != 0)
                    {
                        str = num.ToString();
                    }
                    run.Append(new Text(str));
                    paragraph.Append(paraProp);
                    paragraph.Append(run);
                    tableCell.Append(paragraph);
                    tableRow.Append(tableCell);
                    #endregion
                }

                table.Append(tableRow);
                #endregion

                var indexTheme = 0;
                for (var i = 0; i < dstTable.Rows.Count; i++)
                {
                    if (Helper.ConvertObjectToInt(dstTable.Rows[i]["Номер раздела"]) == Helper.ConvertObjectToInt(chSummTable.Rows[k]["ChapterIndex"]))
                    {
                        indexTheme++;

                        #region row Тема
                        tableRow = new TableRow();

                        #region cell
                        tableCell = new TableCell();
                        tableCellProperties1 = new TableCellProperties();
                        tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                        tableCell.Append(tableCellProperties1);

                        paragraph = new Paragraph();
                        paraProp = GetParagraphProperties("TableStyle");
                        spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                        justification = new Justification() { Val = JustificationValues.Left };
                        paraProp.Append(spacingBetweenLines);
                        paraProp.Append(justification);
                        run = new Run();
                        paragraph.Append(paraProp);
                        paragraph.Append(run);
                        tableCell.Append(paragraph);
                        tableRow.Append(tableCell);
                        #endregion

                        #region cell
                        tableCell = new TableCell();
                        tableCellProperties1 = new TableCellProperties();
                        tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                        tableCell.Append(tableCellProperties1);

                        paragraph = new Paragraph();
                        paraProp = GetParagraphProperties("TableStyle");
                        spacingBetweenLines = new SpacingBetweenLines() { Line = "240", LineRule = LineSpacingRuleValues.Auto };
                        indentation = new Indentation() { Left = "87" };
                        justification = new Justification() { Val = JustificationValues.Left };
                        paraProp.Append(spacingBetweenLines);
                        paraProp.Append(indentation);
                        paraProp.Append(justification);
                        run = new Run();
                        var str = String.Format("Тема {0}.{1}. {2}", 
                            Helper.ConvertObjectToInt(chSummTable.Rows[k]["ChapterIndex"]),
                            indexTheme,
                            dstTable.Rows[i]["Наименование темы"]
                            );
                        run.Append(new Text(str));
                        paragraph.Append(paraProp);
                        paragraph.Append(run);
                        tableCell.Append(paragraph);
                        tableRow.Append(tableCell);
                        #endregion

                        #region cell
                        tableCell = new TableCell();
                        tableCellProperties1 = new TableCellProperties();
                        tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                        tableCell.Append(tableCellProperties1);

                        #region компетенции
                        var competence = dstTable.Rows[i]["Компетенции"].ToString().Replace(" ", "").Split(',');
                        foreach (var c in competence)
                        {
                            paragraph = new Paragraph();
                            paraProp = GetParagraphProperties("TableStyle");
                            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                            justification = new Justification() { Val = JustificationValues.Center };
                            paraProp.Append(spacingBetweenLines);
                            paraProp.Append(justification);
                            run = new Run();
                            run.Append(new Text(c));
                            paragraph.Append(paraProp);
                            paragraph.Append(run);
                            tableCell.Append(paragraph);
                        }
                        if (competence.Length == 0)
                        {
                            paragraph = new Paragraph();
                            paraProp = GetParagraphProperties("TableStyle");
                            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                            justification = new Justification() { Val = JustificationValues.Center };
                            paraProp.Append(spacingBetweenLines);
                            paraProp.Append(justification);
                            run = new Run();
                            run.Append(new Text());
                            paragraph.Append(paraProp);
                            paragraph.Append(run);
                            tableCell.Append(paragraph);
                        }
                        #endregion

                        tableRow.Append(tableCell);
                        #endregion

                        #region cell
                        tableCell = new TableCell();
                        tableCellProperties1 = new TableCellProperties();
                        tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                        tableCell.Append(tableCellProperties1);

                        paragraph = new Paragraph();
                        paraProp = GetParagraphProperties("TableStyle");
                        spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                        justification = new Justification() { Val = JustificationValues.Center };
                        paraProp.Append(spacingBetweenLines);
                        paraProp.Append(justification);
                        run = new Run();
                        run.Append(new Text(dstTable.Rows[i]["Семестр"].ToString()));
                        paragraph.Append(paraProp);
                        paragraph.Append(run);
                        tableCell.Append(paragraph);
                        tableRow.Append(tableCell);
                        #endregion

                        #region cell
                        tableCell = new TableCell();
                        tableCellProperties1 = new TableCellProperties();
                        tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                        tableCell.Append(tableCellProperties1);

                        paragraph = new Paragraph();
                        paraProp = GetParagraphProperties("TableStyle");
                        spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                        justification = new Justification() { Val = JustificationValues.Center };
                        paraProp.Append(spacingBetweenLines);
                        paraProp.Append(justification);
                        run = new Run();
                        run.Append(new Text(dstTable.Rows[i]["Неделя семестра"].ToString()));
                        paragraph.Append(paraProp);
                        paragraph.Append(run);
                        tableCell.Append(paragraph);
                        tableRow.Append(tableCell);
                        #endregion

                        //dstSummTable
                        //обнаружил какой-то столбец ChapterIndex, уменьшил фор на 1
                        //dstSummTable.Columns.Count - 1
                        for (var j = 1; j < dstSummTable.Columns.Count - 1; j++)
                        {
                            #region cell
                            tableCell = new TableCell();
                            tableCellProperties1 = new TableCellProperties();
                            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                            tableCell.Append(tableCellProperties1);

                            paragraph = new Paragraph();
                            paraProp = GetParagraphProperties("TableStyle");
                            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                            justification = new Justification() { Val = JustificationValues.Center };
                            paraProp.Append(spacingBetweenLines);
                            paraProp.Append(justification);
                            run = new Run();
                            run.Append(new Text(dstSummTable.Rows[i][j].ToString()));
                            paragraph.Append(paraProp);
                            paragraph.Append(run);
                            tableCell.Append(paragraph);
                            tableRow.Append(tableCell);
                            #endregion
                        }

                        //dstTable
                        for (var j = 5; j < dstTable.Columns.Count; j++)
                        {
                            #region cell
                            tableCell = new TableCell();
                            tableCellProperties1 = new TableCellProperties();
                            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                            tableCell.Append(tableCellProperties1);

                            paragraph = new Paragraph();
                            paraProp = GetParagraphProperties("TableStyle");
                            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                            justification = new Justification() { Val = JustificationValues.Center };
                            paraProp.Append(spacingBetweenLines);
                            paraProp.Append(justification);
                            run = new Run();
                            run.Append(new Text(dstTable.Rows[i][j].ToString()));
                            paragraph.Append(paraProp);
                            paragraph.Append(run);
                            tableCell.Append(paragraph);
                            tableRow.Append(tableCell);
                            #endregion
                        }

                        //экзамен. пустая ячейка
                        #region cell
                        tableCell = new TableCell();
                        tableCellProperties1 = new TableCellProperties();
                        tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                        tableCell.Append(tableCellProperties1);

                        paragraph = new Paragraph();
                        paraProp = GetParagraphProperties("TableStyle");
                        spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                        justification = new Justification() { Val = JustificationValues.Center };
                        paraProp.Append(spacingBetweenLines);
                        paraProp.Append(justification);
                        run = new Run();
                        paragraph.Append(paraProp);
                        paragraph.Append(run);
                        tableCell.Append(paragraph);
                        tableRow.Append(tableCell);
                        #endregion
                    
                        table.Append(tableRow);
                        #endregion
                    }
                }
            }

            #region Экзамены
            var chapterNum = chapterFour.Chapters.Rows.Count;
            for (var i = 0; i < discipline.Semesters.Count; i++)
            {
                if (discipline.Semesters[i].ValidationHours != 0)
                {
                    tableRow = new TableRow();

                    #region cell
                    tableCell = new TableCell();
                    tableCellProperties1 = new TableCellProperties();
                    tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                    tableCell.Append(tableCellProperties1);

                    paragraph = new Paragraph();
                    paraProp = GetParagraphProperties("TableStyle");
                    spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                    justification = new Justification() { Val = JustificationValues.Left };
                    paraProp.Append(spacingBetweenLines);
                    paraProp.Append(justification);
                    run = new Run(new Text(chapterNum.ToString()));
                    chapterNum++;
                    paragraph.Append(paraProp);
                    paragraph.Append(run);
                    tableCell.Append(paragraph);
                    tableRow.Append(tableCell);
                    #endregion

                    #region cell
                    tableCell = new TableCell();
                    tableCellProperties1 = new TableCellProperties();
                    tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                    tableCell.Append(tableCellProperties1);

                    paragraph = new Paragraph();
                    paraProp = GetParagraphProperties("TableStyle");
                    spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                    justification = new Justification() { Val = JustificationValues.Left };
                    var indentation = new Indentation() { Left = "87" };
                    paraProp.Append(indentation);
                    paraProp.Append(spacingBetweenLines);
                    paraProp.Append(justification);
                    var str = "Подготовка к " + discipline.Semesters[i].Validation + "у";
                    run = new Run(new Text(str));
                    paragraph.Append(paraProp);
                    paragraph.Append(run);
                    tableCell.Append(paragraph);
                    tableRow.Append(tableCell);
                    #endregion

                    #region cell
                    tableCell = new TableCell();
                    tableCellProperties1 = new TableCellProperties();
                    tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                    tableCell.Append(tableCellProperties1);

                    paragraph = new Paragraph();
                    paraProp = GetParagraphProperties("TableStyle");
                    spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                    justification = new Justification() { Val = JustificationValues.Left };
                    paraProp.Append(spacingBetweenLines);
                    paraProp.Append(justification);
                    run = new Run();
                    paragraph.Append(paraProp);
                    paragraph.Append(run);
                    tableCell.Append(paragraph);
                    tableRow.Append(tableCell);
                    #endregion

                    #region cell
                    tableCell = new TableCell();
                    tableCellProperties1 = new TableCellProperties();
                    tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                    tableCell.Append(tableCellProperties1);

                    paragraph = new Paragraph();
                    paraProp = GetParagraphProperties("TableStyle");
                    spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                    justification = new Justification() { Val = JustificationValues.Center };
                    paraProp.Append(spacingBetweenLines);
                    paraProp.Append(justification);
                    run = new Run(new Text(discipline.Semesters[i].Number.ToString()));
                    paragraph.Append(paraProp);
                    paragraph.Append(run);
                    tableCell.Append(paragraph);
                    tableRow.Append(tableCell);
                    #endregion

                    for (var z = 0; z < 6; z++)
                    {
                        #region cell
                        tableCell = new TableCell();
                        tableCellProperties1 = new TableCellProperties();
                        tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                        tableCell.Append(tableCellProperties1);

                        paragraph = new Paragraph();
                        paraProp = GetParagraphProperties("TableStyle");
                        spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                        justification = new Justification() { Val = JustificationValues.Left };
                        paraProp.Append(spacingBetweenLines);
                        paraProp.Append(justification);
                        run = new Run();
                        paragraph.Append(paraProp);
                        paragraph.Append(run);
                        tableCell.Append(paragraph);
                        tableRow.Append(tableCell);
                        #endregion
                    }

                    #region cell
                    tableCell = new TableCell();
                    tableCellProperties1 = new TableCellProperties();
                    tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                    tableCell.Append(tableCellProperties1);

                    paragraph = new Paragraph();
                    paraProp = GetParagraphProperties("TableStyle");
                    spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                    justification = new Justification() { Val = JustificationValues.Center };
                    paraProp.Append(spacingBetweenLines);
                    paraProp.Append(justification);
                    run = new Run(new Text(discipline.Semesters[i].ValidationHours.ToString()));
                    paragraph.Append(paraProp);
                    paragraph.Append(run);
                    tableCell.Append(paragraph);
                    tableRow.Append(tableCell);
                    #endregion

                    table.Append(tableRow);
                }
            }
            #endregion

            var dstAllSummTable = chapterFour.DistributionStudyTimeCheckSumm;
            for (var i = 0; i < dstAllSummTable.Rows.Count; i++)
            {
                #region row общее количество часов
                tableRow = new TableRow();
                
                #region cell
                tableCell = new TableCell();
                tableCellProperties1 = new TableCellProperties();
                tableCellProperties1 = new TableCellProperties();
                Shading shading1 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "D9D9D9" };
                tableCellProperties1.Append(shading1);
                tableCellProperties1.Append(new GridSpan() { Val = 5 });
                tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                tableCell.Append(tableCellProperties1);

                paragraph = new Paragraph();
                paraProp = GetParagraphProperties("TableStyle");
                spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                justification = new Justification() { Val = JustificationValues.Center };
                paraProp.Append(spacingBetweenLines);
                paraProp.Append(justification);
                run = new Run();
                runProp = new RunProperties
                {
                    Bold = new Bold(),
                };
                run.Append(runProp);
                run.Append(new Text(dstAllSummTable.Rows[i][0].ToString()));
                paragraph.Append(paraProp);
                paragraph.Append(run);
                tableCell.Append(paragraph);
                tableRow.Append(tableCell);
                #endregion

                for (var j = 1; j < dstAllSummTable.Columns.Count; j++)
                {
                    #region cell
                    tableCell = new TableCell();
                    tableCellProperties1 = new TableCellProperties();
                    tableCellProperties1 = new TableCellProperties();
                    shading1 = new Shading() { Val = ShadingPatternValues.Clear, Color = "auto", Fill = "D9D9D9" };
                    tableCellProperties1.Append(shading1);
                    tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
                    tableCell.Append(tableCellProperties1);

                    paragraph = new Paragraph();
                    paraProp = GetParagraphProperties("TableStyle");
                    spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                    justification = new Justification() { Val = JustificationValues.Center };
                    paraProp.Append(spacingBetweenLines);
                    paraProp.Append(justification);
                    run = new Run();
                    runProp = new RunProperties
                    {
                        Bold = new Bold(),
                    };
                    run.Append(runProp);
                    var num = Helper.ConvertObjectToInt(dstAllSummTable.Rows[i][j]);
                    var str = "";
                    if (num != 0)
                    {
                        str = num.ToString();
                    }
                    run.Append(new Text(str));
                    paragraph.Append(paraProp);
                    paragraph.Append(run);
                    tableCell.Append(paragraph);
                    tableRow.Append(tableCell);
                    #endregion
                }
                table.Append(tableRow);
                #endregion
            }

            #endregion

            _body.Append(table);

            GenerateParagraph();
        }

        private void GenerateChapterFour_PartTwo()
        {
            var chapterFour = _sessionObjects.ChapterFour;
            var chapterFourPartTwo = chapterFour.PartTwo;

            var paraProp = new ParagraphProperties();
            var paragraph = new Paragraph();
            var runProp = new RunProperties();
            var run = new Run();
            var runs = new List<Run>();

            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            runProp = new RunProperties { Italic = new Italic(), Bold = new Bold() };
            run.Append(runProp);
            run.Append(new Text(chapterFourPartTwo.SubHeader));
            GenerateParagraph(run, paraProp);

            //группировка по номерам разделов
            for (var i = 0; i < chapterFour.Chapters.Rows.Count; i++)
            {
                paraProp = GetParagraphProperties("StyleWithoutIndentation");
                run = new Run();
                runProp = new RunProperties { Bold = new Bold() };
                run.Append(runProp);
                run.Append(new Text(chapterFour.Chapters.Rows[i]["Наименование"].ToString()));
                GenerateParagraph(run, paraProp);

                for (var j = 0; j < chapterFourPartTwo.Themes.Rows.Count; j++)
                {
                    var chapterNumber = Helper.ConvertObjectToInt(chapterFourPartTwo.Themes.Rows[j]["ChapterIndex"]);
                    if (chapterNumber == i + 1)
                    {
                        paraProp = GetParagraphProperties("StyleWithoutIndentation");
                        run = new Run();
                        runProp = new RunProperties { Bold = new Bold() };
                        run.Append(runProp);
                        var str = String.Format("Тема №{0}. {1}. ({2} час.)",
                            j + 1,
                            chapterFourPartTwo.Themes.Rows[j]["Name"],
                            chapterFourPartTwo.Themes.Rows[j]["Hours"]);
                        run.Append(new Text(str));
                        GenerateParagraph(run, paraProp);

                        for (var k = 0; k < chapterFourPartTwo.ListOfLectures[j].Rows.Count; k++)
                        {
                            if (chapterFourPartTwo.ListOfLectures[j].Rows[k]["Hours"].ToString() != String.Empty
                                && chapterFourPartTwo.ListOfLectures[j].Rows[k]["Text"].ToString() != String.Empty)
                            {
                                paragraph = new Paragraph();
                                paraProp = GetParagraphProperties();
                                run = new Run();
                                runProp = new RunProperties { Bold = new Bold() };
                                run.Append(runProp);
                                var str1 = String.Format("Лекция №{0}. ({1} час.).", k + 1, chapterFourPartTwo.ListOfLectures[j].Rows[k]["Hours"]);
                                run.Append(new Text(str1));
                                paragraph.Append(paraProp);
                                paragraph.Append(run);

                                run = new Run();
                                runProp = new RunProperties { Bold = new Bold(), Italic = new Italic() };
                                run.Append(runProp);
                                run.Append(new Text( " " + chapterFourPartTwo.ListOfLectures[j].Rows[k]["Name"].ToString()) { Space = SpaceProcessingModeValues.Preserve });
                                paragraph.Append(run);

                                run = new Run();
                                runProp = new RunProperties();
                                run.Append(runProp);
                                var str3 = String.Format(" {0}.", chapterFourPartTwo.ListOfLectures[j].Rows[k]["Text"]);
                                run.Append(new Text( " " + chapterFourPartTwo.ListOfLectures[j].Rows[k]["Text"].ToString()) { Space = SpaceProcessingModeValues.Preserve });
                                paragraph.Append(run);
                                _body.Append(paragraph);
                            }
                        }
                        for (var k = 0; k < chapterFourPartTwo.ListOfPracticals[j].Rows.Count; k++)
                        {
                            if (chapterFourPartTwo.ListOfPracticals[j].Rows[k]["Hours"].ToString() != String.Empty
                                && chapterFourPartTwo.ListOfPracticals[j].Rows[k]["Text"].ToString() != String.Empty)
                            {
                                paragraph = new Paragraph();
                                paraProp = GetParagraphProperties();
                                run = new Run();
                                runProp = new RunProperties { Bold = new Bold() };
                                run.Append(runProp);
                                var str1 = String.Format("Практическое занятие №{0}. ({1} час.).", k + 1, chapterFourPartTwo.ListOfPracticals[j].Rows[k]["Hours"]);
                                run.Append(new Text(str1));
                                paragraph.Append(paraProp);
                                paragraph.Append(run);
                                run = new Run();
                                runProp = new RunProperties { Bold = new Bold(), Italic = new Italic() };
                                run.Append(runProp);
                                var str2 = String.Format(" {0}", chapterFourPartTwo.ListOfPracticals[j].Rows[k]["Name"]);
                                run.Append(new Text(str2) { Space = SpaceProcessingModeValues.Preserve });
                                paragraph.Append(run);
                                run = new Run();
                                runProp = new RunProperties();
                                run.Append(runProp);
                                var str3 = String.Format(" {0}.", chapterFourPartTwo.ListOfPracticals[j].Rows[k]["Text"]);
                                run.Append(new Text(str3) { Space = SpaceProcessingModeValues.Preserve });
                                paragraph.Append(run);
                                _body.Append(paragraph);
                            }
                        }
                    }
                }
                GenerateParagraph();
            }
        }

        private void GenerateChapterSix()
        {
            GenerateChapterSix1();
            GenerateChapterSix23();
            GenerateChapterSix45();
        }

        private void GenerateChapterSix23()
        {
            var paraProp = new ParagraphProperties();
            var paragraph = new Paragraph();
            var runProp = new RunProperties();
            var run = new Run();

            #region chapterSix23
            var chapterSix23 = _sessionObjects.ChapterSixPartTwoThree;
            runProp = new RunProperties
            {
                Bold = new Bold(),
                Italic = new Italic()
            };
            run.Append(runProp);
            run.Append(new Text(chapterSix23.SubHeader1));
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            GenerateParagraph(run, paraProp);

            #region table
            var table = new Table();
            table.Append(GenerateTableProperties());
            var tableGrid1 = new TableGrid();
            tableGrid1.Append(new GridColumn { Width = "1843" });
            tableGrid1.Append(new GridColumn { Width = "6716" });
            table.Append(tableGrid1);

            #region header
            #region row
            var tableRow = new TableRow();

            #region cell
            var tableCell = new TableCell();
            TableCellProperties tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new VerticalMerge() { Val = MergedCellValues.Restart });
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });

            tableCell.Append(tableCellProperties1);
            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            var spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            var justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
                Italic = new Italic()
            };
            run.Append(runProp);
            run.Append(new Text("№ Занятия"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            #region cell
            tableCell = new TableCell();
            tableCellProperties1 = new TableCellProperties();
            tableCellProperties1.Append(new VerticalMerge() { Val = MergedCellValues.Restart });
            tableCellProperties1.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            tableCell.Append(tableCellProperties1);
            paragraph = new Paragraph();
            paraProp = GetParagraphProperties("TableStyle");
            spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
            justification = new Justification() { Val = JustificationValues.Center };
            paraProp.Append(spacingBetweenLines);
            paraProp.Append(justification);
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
                Italic = new Italic()
            };
            run.Append(runProp);
            run.Append(new Text("Тема смостоятельного занятия"));
            paragraph.Append(paraProp);
            paragraph.Append(run);
            tableCell.Append(paragraph);
            tableRow.Append(tableCell);
            #endregion

            table.Append(tableRow);
            #endregion
            #endregion

            #region data
            for (var i = 0; i < chapterSix23.IndependentWork.Rows.Count; i++)
            {
                #region row
                tableRow = new TableRow();

                #region cell
                tableCell = new TableCell();
                paragraph = new Paragraph();
                paraProp = GetParagraphProperties("TableStyle");
                spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                justification = new Justification() { Val = JustificationValues.Center };
                paraProp.Append(spacingBetweenLines);
                paraProp.Append(justification);
                run = new Run();
                run.Append(new Text((i + 1).ToString()));
                paragraph.Append(paraProp);
                paragraph.Append(run);
                tableCell.Append(paragraph);
                tableRow.Append(tableCell);
                #endregion

                #region cell
                tableCell = new TableCell();
                paragraph = new Paragraph();
                paraProp = GetParagraphProperties("TableStyle");
                spacingBetweenLines = new SpacingBetweenLines() { After = "0", Line = "240", LineRule = LineSpacingRuleValues.Auto };
                justification = new Justification() { Val = JustificationValues.Center };
                paraProp.Append(spacingBetweenLines);
                paraProp.Append(justification);
                run = new Run();
                run.Append(new Text(chapterSix23.IndependentWork.Rows[i].ToString()));
                paragraph.Append(paraProp);
                paragraph.Append(run);
                tableCell.Append(paragraph);
                tableRow.Append(tableCell);
                #endregion

                table.Append(tableRow);
                #endregion
            }
            #endregion
            #endregion

            GenerateParagraph();

            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
                Italic = new Italic()
            };
            run.Append(runProp);
            run.Append(new Text(chapterSix23.SubHeader2));
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            GenerateParagraph(run, paraProp);

            foreach (var home in chapterSix23.HomeWork)
            {
                run = new Run();
                runProp = new RunProperties
                {
                    Bold = new Bold()
                };
                run.Append(runProp);
                run.Append(new Text(home.Rows[0]["Header"].ToString()));
                paraProp = GetParagraphProperties("StyleWithoutIndentation");
                GenerateParagraph(run, paraProp);

                for (var i = 0; i < home.Rows.Count; i++)
                {
                    paraProp = GetParagraphProperties();

                    run = new Run();
                    var str = String.Format("{0}. {1}", i + 1, home.Rows[i]["Text"]);
                    run.Append(new Text(str));

                    paragraph = new Paragraph();
                    paragraph.Append(paraProp);
                    paragraph.Append(run);
                    _body.Append(paragraph);
                }
            }
            #endregion
        }

        private void GenerateChapterSix45()
        {
            var paraProp = new ParagraphProperties();
            var paragraph = new Paragraph();
            var runProp = new RunProperties();
            var run = new Run();

            var chapterSix45 = _sessionObjects.ChapterSixPartFourFive;
            runProp = new RunProperties
            {
                Bold = new Bold(),
                Italic = new Italic()
            };
            run.Append(runProp);
            run.Append(new Text(chapterSix45.SubHeader1));
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            GenerateParagraph(run, paraProp);

            for (var i = 0; i < chapterSix45.TestWork.Rows.Count; i++)
            {
                paraProp = GetParagraphProperties();

                run = new Run();
                var str = String.Format("{0}. {1}", i + 1, chapterSix45.TestWork.Rows[i]["Text"]);
                run.Append(new Text(str));

                paragraph = new Paragraph();
                paragraph.Append(paraProp);
                paragraph.Append(run);
                _body.Append(paragraph);
            }

            GenerateParagraph();

            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
                Italic = new Italic()
            };
            run.Append(runProp);
            run.Append(new Text(chapterSix45.SubHeader2));
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            GenerateParagraph(run, paraProp);

            foreach (var tfe in chapterSix45.TrainingForExam)
            {
                run = new Run();
                runProp = new RunProperties
                {
                    Bold = new Bold()
                };
                run.Append(runProp);
                run.Append(new Text(tfe.Rows[0]["Header"].ToString()));
                paraProp = GetParagraphProperties("StyleWithoutIndentation");
                GenerateParagraph(run, paraProp);

                for (var i = 0; i < tfe.Rows.Count; i++)
                {
                    paraProp = GetParagraphProperties();

                    run = new Run();
                    var str = String.Format("{0}. {1}", i + 1, tfe.Rows[i]["Text"]);
                    run.Append(new Text(str));

                    paragraph = new Paragraph();
                    paragraph.Append(paraProp);
                    paragraph.Append(run);
                    _body.Append(paragraph);
                }
            }
        }

        private void GenerateChapterSeven()
        {
            var paraProp = new ParagraphProperties();
            var paragraph = new Paragraph();
            var runProp = new RunProperties();
            var run = new Run();

            var chapterSeven = _sessionObjects.ChapterSeven;
            run.Append(new Text(chapterSeven.Header));
            paraProp = GetParagraphProperties("Header1");
            GenerateParagraph(run, paraProp);

            #region list1
            run = new Run();
            runProp = new RunProperties
            {
                Italic = new Italic()
            };
            run.Append(runProp);
            run.Append(new Text(chapterSeven.Line1));
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            GenerateParagraph(run, paraProp);
            for (var i = 0; i < chapterSeven.PrimaryLiterature.Rows.Count; i++)
            {
                paraProp = GetParagraphProperties("StyleWithoutIndentation");

                run = new Run();
                var str = String.Format("{0}. {1}", i, chapterSeven.PrimaryLiterature.Rows[i]["Books"].ToString());
                run.Append(new Text(str));
                GenerateParagraph(run, paraProp);
            }
            GenerateParagraph();
            #endregion

            #region list2
            run = new Run();
            runProp = new RunProperties
            {
                Italic = new Italic()
            };
            run.Append(runProp);
            run.Append(new Text(chapterSeven.Line2));
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            GenerateParagraph(run, paraProp);
            for (var i = 0; i < chapterSeven.AdditionalLiterature.Rows.Count; i++)
            {
                paraProp = GetParagraphProperties("StyleWithoutIndentation");
                run = new Run();
                var str = String.Format("{0}. {1}", i, chapterSeven.AdditionalLiterature.Rows[i]["Books"].ToString());
                run.Append(new Text(str));
                GenerateParagraph(run, paraProp);
            }
            GenerateParagraph();
            #endregion

            #region list3
            run = new Run();
            runProp = new RunProperties
            {
                Italic = new Italic()
            };
            run.Append(runProp);
            run.Append(new Text(chapterSeven.Line3));
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            GenerateParagraph(run, paraProp);
            for (var i = 0; i < chapterSeven.Software.Rows.Count; i++)
            {
                paraProp = GetParagraphProperties("StyleWithoutIndentation");
                run = new Run();
                var str = String.Format("{0}. {1}", i, chapterSeven.Software.Rows[i]["Programs"].ToString());
                run.Append(new Text(str));
                GenerateParagraph(run, paraProp);
            }
            GenerateParagraph();
            #endregion
        }

        private void GenerateChapterEight()
        {
            var paraProp = new ParagraphProperties();
            var paragraph = new Paragraph();
            var runProp = new RunProperties();
            var run = new Run();

            var chapterEight = _sessionObjects.ChapterEight;
            run.Append(new Text(chapterEight.Header));
            paraProp = GetParagraphProperties("Header1");
            GenerateParagraph(run, paraProp);

            for (var i = 0; i < chapterEight.Provision.Rows.Count; i++)
            {
                paraProp = GetParagraphProperties("StyleWithoutIndentation");
                run = new Run();
                var str = String.Format("{0}. {1}", i, chapterEight.Provision.Rows[i]["Text"].ToString());
                run.Append(new Text(str));
                GenerateParagraph(run, paraProp);
            }
            GenerateParagraph();
        }

        private void GenerateChapterNine()
        {
            var paraProp = new ParagraphProperties();
            var paragraph = new Paragraph();
            var runProp = new RunProperties();
            var run = new Run();

            var chapterNine = _sessionObjects.ChapterNine;
            run.Append(new Text(chapterNine.Header));
            paraProp = GetParagraphProperties("Header1");
            GenerateParagraph(run, paraProp);

            #region 9.1
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
                Italic = new Italic()
            };
            run.Append(runProp);
            run.Append(new Text(chapterNine.SubHeader1));
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            GenerateParagraph(run, paraProp);

            run = new Run();
            run.Append(new Text(chapterNine.General));
            GenerateParagraph(run);
            GenerateParagraph();
            #endregion

            #region 9.2
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
                Italic = new Italic()
            };
            run.Append(runProp);
            run.Append(new Text(chapterNine.SubHeader2));
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            GenerateParagraph(run, paraProp);

            run = new Run();
            run.Append(new Text(chapterNine.Teacher));
            GenerateParagraph(run);
            GenerateParagraph();
            #endregion

            #region 9.2
            run = new Run();
            runProp = new RunProperties
            {
                Bold = new Bold(),
                Italic = new Italic()
            };
            run.Append(runProp);
            run.Append(new Text(chapterNine.SubHeader3));
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            GenerateParagraph(run, paraProp);

            run = new Run();
            run.Append(new Text(chapterNine.Student));
            GenerateParagraph(run);
            GenerateParagraph();
            #endregion

            run = new Run();
            run.Append(new Break { Type = BreakValues.Page });
            GenerateParagraph(run);
        }
        #endregion

        
    }
}

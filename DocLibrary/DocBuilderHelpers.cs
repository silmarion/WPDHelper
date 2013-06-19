using DataLibrary;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using HelperLibrary;
using System.Collections.Generic;

namespace DocLibrary
{
    public partial class DocBuilder
    {
        private string GetStringHoursAndCreditUnits(int hours)
        {
            var discipline = (Discipline)_additionalObjects.Discipline;
            double creditUnits;
            if (discipline.CreditUnit != 0)
            {
                creditUnits = (double)hours / discipline.CreditUnit;
            }
            else
            {
                creditUnits = hours;
            }
            return string.Format("{0:0.00} / {1}", creditUnits, hours);
        }

        #region GenerateParagraph
        /// <summary>
        /// создание параграфа
        /// </summary>
        /// <param name="text">null = пустая строка</param>
        /// <param name="parProp">null = настройки из стиля</param>
        /// <returns></returns>
        public void GenerateParagraph(Run run = null, ParagraphProperties parProp = null)
        {
            var paragraph = new Paragraph();
            parProp = parProp ?? GetParagraphProperties();
            paragraph.Append(parProp);
            if (run != null)
            {
                paragraph.Append(run);
            }
            _body.Append(paragraph);
        }

        /// <summary>
        /// создание параграфа
        /// </summary>
        /// <param name="text">список ранов</param>
        /// <param name="parProp">null = настройки из стиля</param>
        /// <returns></returns>
        public void GenerateParagraph(List<Run> runs, ParagraphProperties parProp = null)
        {
            var paragraph = new Paragraph();
            parProp = parProp ?? GetParagraphProperties();
            paragraph.Append(parProp);
            foreach (var run in runs)
            {
                if (run != null)
                {
                    paragraph.Append(run);
                }
            }
            _body.Append(paragraph);
        }
        #endregion

        /// <summary>
        /// получить свойства параграфа по умолчанию
        /// </summary>
        /// <returns></returns>
        private ParagraphProperties GetParagraphProperties(string styleName = "DefaultStyleText")
        {
            var paragraphProperties = new ParagraphProperties();
            var paragraphStyleId = new ParagraphStyleId() { Val = styleName };
            paragraphProperties.Append(paragraphStyleId);
            return paragraphProperties;
        }

        /// <summary>
        /// получить свойства списка
        /// </summary>
        /// <returns></returns>
        private ParagraphProperties GetListProperties()
        {
            ParagraphProperties paragraphProperties1 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId1 = new ParagraphStyleId() { Val = "StyleWithoutIndentation" };

            NumberingProperties numberingProperties1 = new NumberingProperties();
            NumberingLevelReference numberingLevelReference1 = new NumberingLevelReference() { Val = 0 };
            NumberingId numberingId1 = new NumberingId() { Val = 1 };

            numberingProperties1.Append(numberingLevelReference1);
            numberingProperties1.Append(numberingId1);

            paragraphProperties1.Append(paragraphStyleId1);
            paragraphProperties1.Append(numberingProperties1);
            return paragraphProperties1;
        }

        private TableProperties GenerateTableProperties()
        {
            TableProperties tableProperties1 = new TableProperties();
            TableWidth tableWidth1 = new TableWidth() { Width = "9639", Type = TableWidthUnitValues.Dxa };

            TableBorders tableBorders1 = new TableBorders();
            TopBorder topBorder1 = new TopBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            LeftBorder leftBorder1 = new LeftBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            BottomBorder bottomBorder1 = new BottomBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            RightBorder rightBorder1 = new RightBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            InsideHorizontalBorder insideHorizontalBorder1 = new InsideHorizontalBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };
            InsideVerticalBorder insideVerticalBorder1 = new InsideVerticalBorder() { Val = BorderValues.Single, Color = "auto", Size = (UInt32Value)4U, Space = (UInt32Value)0U };

            tableBorders1.Append(topBorder1);
            tableBorders1.Append(leftBorder1);
            tableBorders1.Append(bottomBorder1);
            tableBorders1.Append(rightBorder1);
            tableBorders1.Append(insideHorizontalBorder1);
            tableBorders1.Append(insideVerticalBorder1);
            TableLayout tableLayout1 = new TableLayout() { Type = TableLayoutValues.Fixed };
            TableLook tableLook1 = new TableLook() { Val = "04A0" };

            tableProperties1.Append(tableWidth1);
            tableProperties1.Append(tableBorders1);
            tableProperties1.Append(tableLayout1);
            tableProperties1.Append(tableLook1);
            return tableProperties1;
        }
    }
}
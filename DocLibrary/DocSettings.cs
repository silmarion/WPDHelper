using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocLibrary
{
    public class DocSettings
    {
        /// <summary>
        /// набор стилей
        /// </summary>
        public List<Style> Styles { get; set; }

        public DocSettings()
        {
            Styles = new List<Style>();
            GenerateDefaultStyleText();
            
            GenerateStyleHeader1();
            GenerateStyleTextWithoutIndentation();
            GenerateDefaultStyleTextForTable();
        }

        //Создание стандартного стиля для текста
        private void GenerateDefaultStyleText()
        {
            var defaultStyleText = new Style() { Type = StyleValues.Paragraph, StyleId = "DefaultStyleText", CustomStyle = true };
            StyleName styleName1 = new StyleName() { Val = "DefaultStyleText" };
            BasedOn basedOn1 = new BasedOn() { Val = "a" };
            LinkedStyle linkedStyle1 = new LinkedStyle() { Val = "DefaultStyleText0" };
            PrimaryStyle primaryStyle1 = new PrimaryStyle();
            Rsid rsid1 = new Rsid() { Val = "00C5028E" };

            StyleParagraphProperties styleParagraphProperties1 = new StyleParagraphProperties();
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines() { After = "0", Line = "360", LineRule = LineSpacingRuleValues.Auto };
            Justification justification1 = new Justification() { Val = JustificationValues.Both };
            Indentation indentation1 = new Indentation() { FirstLine = "709" };


            styleParagraphProperties1.Append(spacingBetweenLines1);
            styleParagraphProperties1.Append(justification1);
            styleParagraphProperties1.Append(indentation1);

            StyleRunProperties styleRunProperties1 = new StyleRunProperties();
            RunFonts runFonts1 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize1 = new FontSize() { Val = "28" };

            styleRunProperties1.Append(runFonts1);
            styleRunProperties1.Append(fontSize1);

            defaultStyleText.Append(styleName1);
            defaultStyleText.Append(basedOn1);
            defaultStyleText.Append(linkedStyle1);
            defaultStyleText.Append(primaryStyle1);
            defaultStyleText.Append(rsid1);
            defaultStyleText.Append(styleParagraphProperties1);
            defaultStyleText.Append(styleRunProperties1);
            Styles.Add(defaultStyleText);
        }

        //Создание стандартного стиля для текста без отступа
        private void GenerateStyleTextWithoutIndentation()
        {
            var defaultStyleText = new Style() { Type = StyleValues.Paragraph, StyleId = "StyleWithoutIndentation", CustomStyle = true };
            StyleName styleName1 = new StyleName() { Val = "StyleWithoutIndentation" };
            BasedOn basedOn1 = new BasedOn() { Val = "a" };
            LinkedStyle linkedStyle1 = new LinkedStyle() { Val = "StyleWithoutIndentation" };
            PrimaryStyle primaryStyle1 = new PrimaryStyle();
            Rsid rsid1 = new Rsid() { Val = "00C5038E" };

            StyleParagraphProperties styleParagraphProperties1 = new StyleParagraphProperties();
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines() { After = "0", Line = "360", LineRule = LineSpacingRuleValues.Auto };
            Justification justification1 = new Justification() { Val = JustificationValues.Both };

            styleParagraphProperties1.Append(spacingBetweenLines1);
            styleParagraphProperties1.Append(justification1);

            StyleRunProperties styleRunProperties1 = new StyleRunProperties();
            RunFonts runFonts1 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize1 = new FontSize() { Val = "28" };

            styleRunProperties1.Append(runFonts1);
            styleRunProperties1.Append(fontSize1);

            defaultStyleText.Append(styleName1);
            defaultStyleText.Append(basedOn1);
            defaultStyleText.Append(linkedStyle1);
            defaultStyleText.Append(primaryStyle1);
            defaultStyleText.Append(rsid1);
            defaultStyleText.Append(styleParagraphProperties1);
            defaultStyleText.Append(styleRunProperties1);
            Styles.Add(defaultStyleText);
        }

        private void GenerateStyleHeader1()
        {
            //базовый стиль
            GenerateDefaultStyleHeader();

            var styleHeader1 = new Style() { Type = StyleValues.Paragraph, StyleId = "Header1", CustomStyle = true };
            StyleName styleName1 = new StyleName() { Val = "Header1" };
            BasedOn basedOn1 = new BasedOn() { Val = "1" };
            NextParagraphStyle nextParagraphStyle1 = new NextParagraphStyle() { Val = "a" };
            LinkedStyle linkedStyle1 = new LinkedStyle() { Val = "Header10" };
            PrimaryStyle primaryStyle1 = new PrimaryStyle();
            Rsid rsid1 = new Rsid() { Val = "005502FB" };

            StyleParagraphProperties styleParagraphProperties1 = new StyleParagraphProperties();
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines() { Before = "360", After = "120" };

            styleParagraphProperties1.Append(spacingBetweenLines1);

            StyleRunProperties styleRunProperties1 = new StyleRunProperties();
            RunFonts runFonts1 = new RunFonts() { Ascii = "Cambria", HighAnsi = "Cambria" };
            Bold bold1 = new Bold();
            Color color1 = new Color() { Val = "auto" };
            FontSize fontSize1 = new FontSize() { Val = "32" }; 

            styleRunProperties1.Append(runFonts1);
            styleRunProperties1.Append(bold1);
            styleRunProperties1.Append(color1);
            styleRunProperties1.Append(fontSize1);

            styleHeader1.Append(styleName1);
            styleHeader1.Append(basedOn1);
            styleHeader1.Append(nextParagraphStyle1);
            styleHeader1.Append(linkedStyle1);
            styleHeader1.Append(primaryStyle1);
            styleHeader1.Append(rsid1);
            styleHeader1.Append(styleParagraphProperties1);
            styleHeader1.Append(styleRunProperties1);
            Styles.Add(styleHeader1);
        }

        private void GenerateDefaultStyleHeader()
        {
            Style style1 = new Style(){ Type = StyleValues.Paragraph, StyleId = "1" };
            StyleName styleName1 = new StyleName(){ Val = "heading 1" };
            BasedOn basedOn1 = new BasedOn(){ Val = "a" };
            NextParagraphStyle nextParagraphStyle1 = new NextParagraphStyle(){ Val = "a" };
            LinkedStyle linkedStyle1 = new LinkedStyle(){ Val = "10" };
            UIPriority uIPriority1 = new UIPriority(){ Val = 9 };
            PrimaryStyle primaryStyle1 = new PrimaryStyle();
            Rsid rsid1 = new Rsid(){ Val = "004A6073" };

            StyleParagraphProperties styleParagraphProperties1 = new StyleParagraphProperties();
            KeepNext keepNext1 = new KeepNext();
            KeepLines keepLines1 = new KeepLines();
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines(){ Before = "240", After = "0" };
            OutlineLevel outlineLevel1 = new OutlineLevel(){ Val = 0 };

            styleParagraphProperties1.Append(keepNext1);
            styleParagraphProperties1.Append(keepLines1);
            styleParagraphProperties1.Append(spacingBetweenLines1);
            styleParagraphProperties1.Append(outlineLevel1);

            StyleRunProperties styleRunProperties1 = new StyleRunProperties();
            RunFonts runFonts1 = new RunFonts(){ AsciiTheme = ThemeFontValues.MajorHighAnsi, HighAnsiTheme = ThemeFontValues.MajorHighAnsi, EastAsiaTheme = ThemeFontValues.MajorEastAsia, ComplexScriptTheme = ThemeFontValues.MajorBidi };
            Color color1 = new Color(){ Val = "2E74B5", ThemeColor = ThemeColorValues.Accent1, ThemeShade = "BF" };
            FontSize fontSize1 = new FontSize(){ Val = "32" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript(){ Val = "32" };

            styleRunProperties1.Append(runFonts1);
            styleRunProperties1.Append(color1);
            styleRunProperties1.Append(fontSize1);
            styleRunProperties1.Append(fontSizeComplexScript1);

            style1.Append(styleName1);
            style1.Append(basedOn1);
            style1.Append(nextParagraphStyle1);
            style1.Append(linkedStyle1);
            style1.Append(uIPriority1);
            style1.Append(primaryStyle1);
            style1.Append(rsid1);
            style1.Append(styleParagraphProperties1);
            style1.Append(styleRunProperties1);
            Styles.Add(style1);
        }

        /// <summary>
        /// генарция настроек для списков
        /// </summary>
        public void GenerateListNumbering(ref Numbering numbering)
        {
            #region AbstractNum
            AbstractNum abstractNum1 = new AbstractNum() { AbstractNumberId = 0 };
            Nsid nsid1 = new Nsid() { Val = "2EB766E6" };
            MultiLevelType multiLevelType1 = new MultiLevelType() { Val = MultiLevelValues.HybridMultilevel };
            TemplateCode templateCode1 = new TemplateCode() { Val = "C1F20472" };

            Level level1 = new Level() { LevelIndex = 0, TemplateCode = "04190001" };
            StartNumberingValue startNumberingValue1 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat1 = new NumberingFormat() { Val = NumberFormatValues.Bullet };
            LevelText levelText1 = new LevelText() { Val = "·" };
            LevelJustification levelJustification1 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties1 = new PreviousParagraphProperties();
            Indentation indentation1 = new Indentation() { Left = "1429", Hanging = "360" };

            previousParagraphProperties1.Append(indentation1);

            NumberingSymbolRunProperties numberingSymbolRunProperties1 = new NumberingSymbolRunProperties();
            RunFonts runFonts1 = new RunFonts() { Hint = FontTypeHintValues.Default, Ascii = "Symbol", HighAnsi = "Symbol" };

            numberingSymbolRunProperties1.Append(runFonts1);

            level1.Append(startNumberingValue1);
            level1.Append(numberingFormat1);
            level1.Append(levelText1);
            level1.Append(levelJustification1);
            level1.Append(previousParagraphProperties1);
            level1.Append(numberingSymbolRunProperties1);
            abstractNum1.Append(nsid1);
            abstractNum1.Append(multiLevelType1);
            abstractNum1.Append(templateCode1);
            abstractNum1.Append(level1);
            #endregion

            NumberingInstance numberingInstance1 = new NumberingInstance() { NumberID = 1 };
            AbstractNumId abstractNumId1 = new AbstractNumId() { Val = 0 };
            numberingInstance1.Append(abstractNumId1);
            numbering.Append(abstractNum1);
            numbering.Append(numberingInstance1);
        }

        private void GenerateDefaultStyleTextForTable()
        {
            Style style1 = new Style() { Type = StyleValues.Paragraph, StyleId = "TableStyle", CustomStyle = true };
            StyleName styleName1 = new StyleName() { Val = "TableStyle" };
            BasedOn basedOn1 = new BasedOn() { Val = "StyleWithoutIndentation" };
            LinkedStyle linkedStyle1 = new LinkedStyle() { Val = "DefaultStyleTextForTable0" };
            PrimaryStyle primaryStyle1 = new PrimaryStyle();
            Rsid rsid1 = new Rsid() { Val = "00E72C62" };

            StyleRunProperties styleRunProperties1 = new StyleRunProperties();
            FontSize fontSize1 = new FontSize() { Val = "24" };

            styleRunProperties1.Append(fontSize1);

            style1.Append(styleName1);
            style1.Append(basedOn1);
            style1.Append(linkedStyle1);
            style1.Append(primaryStyle1);
            style1.Append(rsid1);
            style1.Append(styleRunProperties1);
            Styles.Add(style1);
        }

        public void GetNumbering(ref Numbering numbering, int abstractNumId, int numberingInstanceId )
        {
            AbstractNum abstractNum1 = new AbstractNum() { AbstractNumberId = abstractNumId };
            Nsid nsid1 = new Nsid() { Val = "3C7E7798" };
            MultiLevelType multiLevelType1 = new MultiLevelType() { Val = MultiLevelValues.HybridMultilevel };
            TemplateCode templateCode1 = new TemplateCode() { Val = "46C6786C" };

            Level level1 = new Level() { LevelIndex = 0, TemplateCode = "38EAF7A0" };
            StartNumberingValue startNumberingValue1 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat1 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText1 = new LevelText() { Val = "%1." };
            LevelJustification levelJustification1 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties1 = new PreviousParagraphProperties();
            Indentation indentation1 = new Indentation() { Left = "786", Hanging = "360" };

            previousParagraphProperties1.Append(indentation1);

            NumberingSymbolRunProperties numberingSymbolRunProperties1 = new NumberingSymbolRunProperties();
            RunFonts runFonts1 = new RunFonts() { Hint = FontTypeHintValues.Default };

            numberingSymbolRunProperties1.Append(runFonts1);

            level1.Append(startNumberingValue1);
            level1.Append(numberingFormat1);
            level1.Append(levelText1);
            level1.Append(levelJustification1);
            level1.Append(previousParagraphProperties1);
            level1.Append(numberingSymbolRunProperties1);

            Level level2 = new Level() { LevelIndex = 1, TemplateCode = "04190019", Tentative = true };
            StartNumberingValue startNumberingValue2 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat2 = new NumberingFormat() { Val = NumberFormatValues.LowerLetter };
            LevelText levelText2 = new LevelText() { Val = "%2." };
            LevelJustification levelJustification2 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties2 = new PreviousParagraphProperties();
            Indentation indentation2 = new Indentation() { Left = "1647", Hanging = "360" };

            previousParagraphProperties2.Append(indentation2);

            level2.Append(startNumberingValue2);
            level2.Append(numberingFormat2);
            level2.Append(levelText2);
            level2.Append(levelJustification2);
            level2.Append(previousParagraphProperties2);

            Level level3 = new Level() { LevelIndex = 2, TemplateCode = "0419001B", Tentative = true };
            StartNumberingValue startNumberingValue3 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat3 = new NumberingFormat() { Val = NumberFormatValues.LowerRoman };
            LevelText levelText3 = new LevelText() { Val = "%3." };
            LevelJustification levelJustification3 = new LevelJustification() { Val = LevelJustificationValues.Right };

            PreviousParagraphProperties previousParagraphProperties3 = new PreviousParagraphProperties();
            Indentation indentation3 = new Indentation() { Left = "2367", Hanging = "180" };

            previousParagraphProperties3.Append(indentation3);

            level3.Append(startNumberingValue3);
            level3.Append(numberingFormat3);
            level3.Append(levelText3);
            level3.Append(levelJustification3);
            level3.Append(previousParagraphProperties3);

            Level level4 = new Level() { LevelIndex = 3, TemplateCode = "0419000F", Tentative = true };
            StartNumberingValue startNumberingValue4 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat4 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText4 = new LevelText() { Val = "%4." };
            LevelJustification levelJustification4 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties4 = new PreviousParagraphProperties();
            Indentation indentation4 = new Indentation() { Left = "3087", Hanging = "360" };

            previousParagraphProperties4.Append(indentation4);

            level4.Append(startNumberingValue4);
            level4.Append(numberingFormat4);
            level4.Append(levelText4);
            level4.Append(levelJustification4);
            level4.Append(previousParagraphProperties4);

            Level level5 = new Level() { LevelIndex = 4, TemplateCode = "04190019", Tentative = true };
            StartNumberingValue startNumberingValue5 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat5 = new NumberingFormat() { Val = NumberFormatValues.LowerLetter };
            LevelText levelText5 = new LevelText() { Val = "%5." };
            LevelJustification levelJustification5 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties5 = new PreviousParagraphProperties();
            Indentation indentation5 = new Indentation() { Left = "3807", Hanging = "360" };

            previousParagraphProperties5.Append(indentation5);

            level5.Append(startNumberingValue5);
            level5.Append(numberingFormat5);
            level5.Append(levelText5);
            level5.Append(levelJustification5);
            level5.Append(previousParagraphProperties5);

            Level level6 = new Level() { LevelIndex = 5, TemplateCode = "0419001B", Tentative = true };
            StartNumberingValue startNumberingValue6 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat6 = new NumberingFormat() { Val = NumberFormatValues.LowerRoman };
            LevelText levelText6 = new LevelText() { Val = "%6." };
            LevelJustification levelJustification6 = new LevelJustification() { Val = LevelJustificationValues.Right };

            PreviousParagraphProperties previousParagraphProperties6 = new PreviousParagraphProperties();
            Indentation indentation6 = new Indentation() { Left = "4527", Hanging = "180" };

            previousParagraphProperties6.Append(indentation6);

            level6.Append(startNumberingValue6);
            level6.Append(numberingFormat6);
            level6.Append(levelText6);
            level6.Append(levelJustification6);
            level6.Append(previousParagraphProperties6);

            Level level7 = new Level() { LevelIndex = 6, TemplateCode = "0419000F", Tentative = true };
            StartNumberingValue startNumberingValue7 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat7 = new NumberingFormat() { Val = NumberFormatValues.Decimal };
            LevelText levelText7 = new LevelText() { Val = "%7." };
            LevelJustification levelJustification7 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties7 = new PreviousParagraphProperties();
            Indentation indentation7 = new Indentation() { Left = "5247", Hanging = "360" };

            previousParagraphProperties7.Append(indentation7);

            level7.Append(startNumberingValue7);
            level7.Append(numberingFormat7);
            level7.Append(levelText7);
            level7.Append(levelJustification7);
            level7.Append(previousParagraphProperties7);

            Level level8 = new Level() { LevelIndex = 7, TemplateCode = "04190019", Tentative = true };
            StartNumberingValue startNumberingValue8 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat8 = new NumberingFormat() { Val = NumberFormatValues.LowerLetter };
            LevelText levelText8 = new LevelText() { Val = "%8." };
            LevelJustification levelJustification8 = new LevelJustification() { Val = LevelJustificationValues.Left };

            PreviousParagraphProperties previousParagraphProperties8 = new PreviousParagraphProperties();
            Indentation indentation8 = new Indentation() { Left = "5967", Hanging = "360" };

            previousParagraphProperties8.Append(indentation8);

            level8.Append(startNumberingValue8);
            level8.Append(numberingFormat8);
            level8.Append(levelText8);
            level8.Append(levelJustification8);
            level8.Append(previousParagraphProperties8);

            Level level9 = new Level() { LevelIndex = 8, TemplateCode = "0419001B", Tentative = true };
            StartNumberingValue startNumberingValue9 = new StartNumberingValue() { Val = 1 };
            NumberingFormat numberingFormat9 = new NumberingFormat() { Val = NumberFormatValues.LowerRoman };
            LevelText levelText9 = new LevelText() { Val = "%9." };
            LevelJustification levelJustification9 = new LevelJustification() { Val = LevelJustificationValues.Right };

            PreviousParagraphProperties previousParagraphProperties9 = new PreviousParagraphProperties();
            Indentation indentation9 = new Indentation() { Left = "6687", Hanging = "180" };

            previousParagraphProperties9.Append(indentation9);

            level9.Append(startNumberingValue9);
            level9.Append(numberingFormat9);
            level9.Append(levelText9);
            level9.Append(levelJustification9);
            level9.Append(previousParagraphProperties9);

            abstractNum1.Append(nsid1);
            abstractNum1.Append(multiLevelType1);
            abstractNum1.Append(templateCode1);
            abstractNum1.Append(level1);
            abstractNum1.Append(level2);
            abstractNum1.Append(level3);
            abstractNum1.Append(level4);
            abstractNum1.Append(level5);
            abstractNum1.Append(level6);
            abstractNum1.Append(level7);
            abstractNum1.Append(level8);
            abstractNum1.Append(level9);

            NumberingInstance numberingInstance1 = new NumberingInstance() { NumberID = numberingInstanceId };
            AbstractNumId abstractNumId1 = new AbstractNumId() { Val = 0 };

            numberingInstance1.Append(abstractNumId1);

            numbering.Append(abstractNum1);
            numbering.Append(numberingInstance1);
        }
    }
}

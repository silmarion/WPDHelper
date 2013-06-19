using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;
using V = DocumentFormat.OpenXml.Vml;
using Ovml = DocumentFormat.OpenXml.Vml.Office;

namespace DocLibrary
{
    public partial class DocBuilder
    {
        private void GenerateChapterFive()
        {
            Paragraph paragraph1 = new Paragraph() { RsidParagraphMarkRevision = "005B1369", RsidParagraphAddition = "005B1369", RsidParagraphProperties = "005B1369", RsidRunAdditionDefault = "005B1369" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties();
            Indentation indentation1 = new Indentation() { FirstLine = "567" };
            Justification justification1 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties1 = new ParagraphMarkRunProperties();
            RunFonts runFonts1 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize1 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript() { Val = "28" };
            Languages languages1 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties1.Append(runFonts1);
            paragraphMarkRunProperties1.Append(fontSize1);
            paragraphMarkRunProperties1.Append(fontSizeComplexScript1);
            paragraphMarkRunProperties1.Append(languages1);

            paragraphProperties1.Append(indentation1);
            paragraphProperties1.Append(justification1);
            paragraphProperties1.Append(paragraphMarkRunProperties1);
            BookmarkStart bookmarkStart1 = new BookmarkStart() { Name = "_GoBack", Id = "0" };
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd() { Id = "0" };

            Run run1 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties1 = new RunProperties();
            RunFonts runFonts2 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize2 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript2 = new FontSizeComplexScript() { Val = "28" };
            Languages languages2 = new Languages() { Val = "ru-RU" };

            runProperties1.Append(runFonts2);
            runProperties1.Append(fontSize2);
            runProperties1.Append(fontSizeComplexScript2);
            runProperties1.Append(languages2);
            Text text1 = new Text();
            text1.Text = "При чтении лекционного материала занятия могут проходить как с использованием:";

            run1.Append(runProperties1);
            run1.Append(text1);

            paragraph1.Append(paragraphProperties1);
            paragraph1.Append(bookmarkStart1);
            paragraph1.Append(bookmarkEnd1);
            paragraph1.Append(run1);

            Paragraph paragraph2 = new Paragraph() { RsidParagraphMarkRevision = "005B1369", RsidParagraphAddition = "005B1369", RsidParagraphProperties = "005B1369", RsidRunAdditionDefault = "005B1369" };

            ParagraphProperties paragraphProperties2 = new ParagraphProperties();

            NumberingProperties numberingProperties1 = new NumberingProperties();
            NumberingLevelReference numberingLevelReference1 = new NumberingLevelReference() { Val = 0 };
            NumberingId numberingId1 = new NumberingId() { Val = 6 };

            numberingProperties1.Append(numberingLevelReference1);
            numberingProperties1.Append(numberingId1);
            Indentation indentation2 = new Indentation() { Left = "641", Hanging = "357" };
            Justification justification2 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties2 = new ParagraphMarkRunProperties();
            RunFonts runFonts3 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize3 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript3 = new FontSizeComplexScript() { Val = "28" };
            Languages languages3 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties2.Append(runFonts3);
            paragraphMarkRunProperties2.Append(fontSize3);
            paragraphMarkRunProperties2.Append(fontSizeComplexScript3);
            paragraphMarkRunProperties2.Append(languages3);

            paragraphProperties2.Append(numberingProperties1);
            paragraphProperties2.Append(indentation2);
            paragraphProperties2.Append(justification2);
            paragraphProperties2.Append(paragraphMarkRunProperties2);
            ProofError proofError1 = new ProofError() { Type = ProofingErrorValues.GrammarStart };

            Run run2 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties2 = new RunProperties();
            RunFonts runFonts4 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold1 = new Bold();
            FontSize fontSize4 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript4 = new FontSizeComplexScript() { Val = "28" };
            Languages languages4 = new Languages() { Val = "ru-RU" };

            runProperties2.Append(runFonts4);
            runProperties2.Append(bold1);
            runProperties2.Append(fontSize4);
            runProperties2.Append(fontSizeComplexScript4);
            runProperties2.Append(languages4);
            Text text2 = new Text();
            text2.Text = "информационно";

            run2.Append(runProperties2);
            run2.Append(text2);
            ProofError proofError2 = new ProofError() { Type = ProofingErrorValues.GrammarEnd };

            Run run3 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties3 = new RunProperties();
            RunFonts runFonts5 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold2 = new Bold();
            FontSize fontSize5 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript5 = new FontSizeComplexScript() { Val = "28" };
            Languages languages5 = new Languages() { Val = "ru-RU" };

            runProperties3.Append(runFonts5);
            runProperties3.Append(bold2);
            runProperties3.Append(fontSize5);
            runProperties3.Append(fontSizeComplexScript5);
            runProperties3.Append(languages5);
            Text text3 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text3.Text = "-коммуникационных образовательных технологий: ";

            run3.Append(runProperties3);
            run3.Append(text3);

            Run run4 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties4 = new RunProperties();
            RunFonts runFonts6 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold3 = new Bold();
            Italic italic1 = new Italic();
            FontSize fontSize6 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript6 = new FontSizeComplexScript() { Val = "28" };
            Languages languages6 = new Languages() { Val = "ru-RU" };

            runProperties4.Append(runFonts6);
            runProperties4.Append(bold3);
            runProperties4.Append(italic1);
            runProperties4.Append(fontSize6);
            runProperties4.Append(fontSizeComplexScript6);
            runProperties4.Append(languages6);
            Text text4 = new Text();
            text4.Text = "лекция-визуализация";

            run4.Append(runProperties4);
            run4.Append(text4);

            Run run5 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties5 = new RunProperties();
            RunFonts runFonts7 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize7 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript7 = new FontSizeComplexScript() { Val = "28" };
            Languages languages7 = new Languages() { Val = "ru-RU" };

            runProperties5.Append(runFonts7);
            runProperties5.Append(fontSize7);
            runProperties5.Append(fontSizeComplexScript7);
            runProperties5.Append(languages7);
            Text text5 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text5.Text = " – изложение содержания каждой темы сопровождается презентацией (демонстрацией учебных материалов, представленных в среде программы ";

            run5.Append(runProperties5);
            run5.Append(text5);

            Run run6 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties6 = new RunProperties();
            RunFonts runFonts8 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize8 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript8 = new FontSizeComplexScript() { Val = "28" };

            runProperties6.Append(runFonts8);
            runProperties6.Append(fontSize8);
            runProperties6.Append(fontSizeComplexScript8);
            Text text6 = new Text();
            text6.Text = "Microsoft";

            run6.Append(runProperties6);
            run6.Append(text6);

            Run run7 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties7 = new RunProperties();
            RunFonts runFonts9 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize9 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript9 = new FontSizeComplexScript() { Val = "28" };
            Languages languages8 = new Languages() { Val = "ru-RU" };

            runProperties7.Append(runFonts9);
            runProperties7.Append(fontSize9);
            runProperties7.Append(fontSizeComplexScript9);
            runProperties7.Append(languages8);
            Text text7 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text7.Text = " ";

            run7.Append(runProperties7);
            run7.Append(text7);
            ProofError proofError3 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run8 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties8 = new RunProperties();
            RunFonts runFonts10 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize10 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript10 = new FontSizeComplexScript() { Val = "28" };

            runProperties8.Append(runFonts10);
            runProperties8.Append(fontSize10);
            runProperties8.Append(fontSizeComplexScript10);
            Text text8 = new Text();
            text8.Text = "Powerpoint";

            run8.Append(runProperties8);
            run8.Append(text8);
            ProofError proofError4 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run9 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties9 = new RunProperties();
            RunFonts runFonts11 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize11 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript11 = new FontSizeComplexScript() { Val = "28" };
            Languages languages9 = new Languages() { Val = "ru-RU" };

            runProperties9.Append(runFonts11);
            runProperties9.Append(fontSize11);
            runProperties9.Append(fontSizeComplexScript11);
            runProperties9.Append(languages9);
            Text text9 = new Text();
            text9.Text = ")";

            run9.Append(runProperties9);
            run9.Append(text9);

            paragraph2.Append(paragraphProperties2);
            paragraph2.Append(proofError1);
            paragraph2.Append(run2);
            paragraph2.Append(proofError2);
            paragraph2.Append(run3);
            paragraph2.Append(run4);
            paragraph2.Append(run5);
            paragraph2.Append(run6);
            paragraph2.Append(run7);
            paragraph2.Append(proofError3);
            paragraph2.Append(run8);
            paragraph2.Append(proofError4);
            paragraph2.Append(run9);

            Paragraph paragraph3 = new Paragraph() { RsidParagraphMarkRevision = "005B1369", RsidParagraphAddition = "005B1369", RsidParagraphProperties = "005B1369", RsidRunAdditionDefault = "005B1369" };

            ParagraphProperties paragraphProperties3 = new ParagraphProperties();

            NumberingProperties numberingProperties2 = new NumberingProperties();
            NumberingLevelReference numberingLevelReference2 = new NumberingLevelReference() { Val = 0 };
            NumberingId numberingId2 = new NumberingId() { Val = 6 };

            numberingProperties2.Append(numberingLevelReference2);
            numberingProperties2.Append(numberingId2);
            Indentation indentation3 = new Indentation() { Left = "641", Hanging = "357" };
            Justification justification3 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties3 = new ParagraphMarkRunProperties();
            RunFonts runFonts12 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize12 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript12 = new FontSizeComplexScript() { Val = "28" };
            Languages languages10 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties3.Append(runFonts12);
            paragraphMarkRunProperties3.Append(fontSize12);
            paragraphMarkRunProperties3.Append(fontSizeComplexScript12);
            paragraphMarkRunProperties3.Append(languages10);

            paragraphProperties3.Append(numberingProperties2);
            paragraphProperties3.Append(indentation3);
            paragraphProperties3.Append(justification3);
            paragraphProperties3.Append(paragraphMarkRunProperties3);
            ProofError proofError5 = new ProofError() { Type = ProofingErrorValues.GrammarStart };

            Run run10 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties10 = new RunProperties();
            RunFonts runFonts13 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize13 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript13 = new FontSizeComplexScript() { Val = "28" };
            Languages languages11 = new Languages() { Val = "ru-RU" };

            runProperties10.Append(runFonts13);
            runProperties10.Append(fontSize13);
            runProperties10.Append(fontSizeComplexScript13);
            runProperties10.Append(languages11);
            Text text10 = new Text();
            text10.Text = "так";

            run10.Append(runProperties10);
            run10.Append(text10);
            ProofError proofError6 = new ProofError() { Type = ProofingErrorValues.GrammarEnd };

            Run run11 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties11 = new RunProperties();
            RunFonts runFonts14 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize14 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript14 = new FontSizeComplexScript() { Val = "28" };
            Languages languages12 = new Languages() { Val = "ru-RU" };

            runProperties11.Append(runFonts14);
            runProperties11.Append(fontSize14);
            runProperties11.Append(fontSizeComplexScript14);
            runProperties11.Append(languages12);
            Text text11 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text11.Text = " и с помощью специализированных ";

            run11.Append(runProperties11);
            run11.Append(text11);

            Run run12 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties12 = new RunProperties();
            RunFonts runFonts15 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold4 = new Bold();
            FontSize fontSize15 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript15 = new FontSizeComplexScript() { Val = "28" };
            Languages languages13 = new Languages() { Val = "ru-RU" };

            runProperties12.Append(runFonts15);
            runProperties12.Append(bold4);
            runProperties12.Append(fontSize15);
            runProperties12.Append(fontSizeComplexScript15);
            runProperties12.Append(languages13);
            Text text12 = new Text();
            text12.Text = "интерактивных технологий";

            run12.Append(runProperties12);
            run12.Append(text12);

            Run run13 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties13 = new RunProperties();
            RunFonts runFonts16 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize16 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript16 = new FontSizeComplexScript() { Val = "28" };
            Languages languages14 = new Languages() { Val = "ru-RU" };

            runProperties13.Append(runFonts16);
            runProperties13.Append(fontSize16);
            runProperties13.Append(fontSizeComplexScript16);
            runProperties13.Append(languages14);
            Text text13 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text13.Text = " (";

            run13.Append(runProperties13);
            run13.Append(text13);

            Run run14 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties14 = new RunProperties();
            RunFonts runFonts17 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold5 = new Bold();
            Italic italic2 = new Italic();
            FontSize fontSize17 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript17 = new FontSizeComplexScript() { Val = "28" };
            Languages languages15 = new Languages() { Val = "ru-RU" };

            runProperties14.Append(runFonts17);
            runProperties14.Append(bold5);
            runProperties14.Append(italic2);
            runProperties14.Append(fontSize17);
            runProperties14.Append(fontSizeComplexScript17);
            runProperties14.Append(languages15);
            Text text14 = new Text();
            text14.Text = "лекция «обратной связи»";

            run14.Append(runProperties14);
            run14.Append(text14);

            Run run15 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties15 = new RunProperties();
            RunFonts runFonts18 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize18 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript18 = new FontSizeComplexScript() { Val = "28" };
            Languages languages16 = new Languages() { Val = "ru-RU" };

            runProperties15.Append(runFonts18);
            runProperties15.Append(fontSize18);
            runProperties15.Append(fontSizeComplexScript18);
            runProperties15.Append(languages16);
            Text text15 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text15.Text = " – лекция–провокация, в которой часть материала приводится с заранее запланированными ошибками, после чего завязывается лекция-беседа, лекция-дискуссия).";

            run15.Append(runProperties15);
            run15.Append(text15);

            paragraph3.Append(paragraphProperties3);
            paragraph3.Append(proofError5);
            paragraph3.Append(run10);
            paragraph3.Append(proofError6);
            paragraph3.Append(run11);
            paragraph3.Append(run12);
            paragraph3.Append(run13);
            paragraph3.Append(run14);
            paragraph3.Append(run15);

            Paragraph paragraph4 = new Paragraph() { RsidParagraphMarkRevision = "005B1369", RsidParagraphAddition = "005B1369", RsidParagraphProperties = "005B1369", RsidRunAdditionDefault = "005B1369" };

            ParagraphProperties paragraphProperties4 = new ParagraphProperties();
            Indentation indentation4 = new Indentation() { FirstLine = "567" };
            Justification justification4 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties4 = new ParagraphMarkRunProperties();
            RunFonts runFonts19 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize19 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript19 = new FontSizeComplexScript() { Val = "28" };
            Languages languages17 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties4.Append(runFonts19);
            paragraphMarkRunProperties4.Append(fontSize19);
            paragraphMarkRunProperties4.Append(fontSizeComplexScript19);
            paragraphMarkRunProperties4.Append(languages17);

            paragraphProperties4.Append(indentation4);
            paragraphProperties4.Append(justification4);
            paragraphProperties4.Append(paragraphMarkRunProperties4);

            Run run16 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties16 = new RunProperties();
            RunFonts runFonts20 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize20 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript20 = new FontSizeComplexScript() { Val = "28" };
            Languages languages18 = new Languages() { Val = "ru-RU" };

            runProperties16.Append(runFonts20);
            runProperties16.Append(fontSize20);
            runProperties16.Append(fontSizeComplexScript20);
            runProperties16.Append(languages18);
            Text text16 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text16.Text = "На всех практических занятиях студенты выполняют задания на рабочем месте за персональным компьютером, пользуясь консультацией преподавателя на индивидуальном уровне. ";

            run16.Append(runProperties16);
            run16.Append(text16);

            paragraph4.Append(paragraphProperties4);
            paragraph4.Append(run16);

            Paragraph paragraph5 = new Paragraph() { RsidParagraphMarkRevision = "005B1369", RsidParagraphAddition = "005B1369", RsidParagraphProperties = "005B1369", RsidRunAdditionDefault = "005B1369" };

            ParagraphProperties paragraphProperties5 = new ParagraphProperties();
            Indentation indentation5 = new Indentation() { FirstLine = "567" };
            Justification justification5 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties5 = new ParagraphMarkRunProperties();
            RunFonts runFonts21 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize21 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript21 = new FontSizeComplexScript() { Val = "28" };
            Languages languages19 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties5.Append(runFonts21);
            paragraphMarkRunProperties5.Append(fontSize21);
            paragraphMarkRunProperties5.Append(fontSizeComplexScript21);
            paragraphMarkRunProperties5.Append(languages19);

            paragraphProperties5.Append(indentation5);
            paragraphProperties5.Append(justification5);
            paragraphProperties5.Append(paragraphMarkRunProperties5);

            Run run17 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties17 = new RunProperties();
            RunFonts runFonts22 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize22 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript22 = new FontSizeComplexScript() { Val = "28" };
            Languages languages20 = new Languages() { Val = "ru-RU" };

            runProperties17.Append(runFonts22);
            runProperties17.Append(fontSize22);
            runProperties17.Append(fontSizeComplexScript22);
            runProperties17.Append(languages20);
            Text text17 = new Text();
            text17.Text = "В качестве домашних заданий студенты заканчивают работу, выданную на практических занятиях, а также выполняют индивидуальные задания, выдаваемые преподавателем, с проверкой и обсуждением результата выполнения на следующем занятии.";

            run17.Append(runProperties17);
            run17.Append(text17);

            paragraph5.Append(paragraphProperties5);
            paragraph5.Append(run17);

            Paragraph paragraph6 = new Paragraph() { RsidParagraphMarkRevision = "005B1369", RsidParagraphAddition = "005B1369", RsidParagraphProperties = "005B1369", RsidRunAdditionDefault = "005B1369" };

            ParagraphProperties paragraphProperties6 = new ParagraphProperties();
            Indentation indentation6 = new Indentation() { FirstLine = "567" };
            Justification justification6 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties6 = new ParagraphMarkRunProperties();
            RunFonts runFonts23 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize23 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript23 = new FontSizeComplexScript() { Val = "28" };
            Languages languages21 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties6.Append(runFonts23);
            paragraphMarkRunProperties6.Append(fontSize23);
            paragraphMarkRunProperties6.Append(fontSizeComplexScript23);
            paragraphMarkRunProperties6.Append(languages21);

            paragraphProperties6.Append(indentation6);
            paragraphProperties6.Append(justification6);
            paragraphProperties6.Append(paragraphMarkRunProperties6);

            Run run18 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties18 = new RunProperties();
            RunFonts runFonts24 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize24 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript24 = new FontSizeComplexScript() { Val = "28" };
            Languages languages22 = new Languages() { Val = "ru-RU" };

            runProperties18.Append(runFonts24);
            runProperties18.Append(fontSize24);
            runProperties18.Append(fontSizeComplexScript24);
            runProperties18.Append(languages22);
            Text text18 = new Text();
            text18.Text = "С целью повышения эффективности учебного процесса, в ходе практических занятий используются:";

            run18.Append(runProperties18);
            run18.Append(text18);

            paragraph6.Append(paragraphProperties6);
            paragraph6.Append(run18);

            Paragraph paragraph7 = new Paragraph() { RsidParagraphMarkRevision = "005B1369", RsidParagraphAddition = "005B1369", RsidParagraphProperties = "005B1369", RsidRunAdditionDefault = "005B1369" };

            ParagraphProperties paragraphProperties7 = new ParagraphProperties();
            WidowControl widowControl1 = new WidowControl() { Val = false };

            NumberingProperties numberingProperties3 = new NumberingProperties();
            NumberingLevelReference numberingLevelReference3 = new NumberingLevelReference() { Val = 0 };
            NumberingId numberingId3 = new NumberingId() { Val = 5 };

            numberingProperties3.Append(numberingLevelReference3);
            numberingProperties3.Append(numberingId3);
            Indentation indentation7 = new Indentation() { Left = "641", Hanging = "357" };
            Justification justification7 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties7 = new ParagraphMarkRunProperties();
            RunFonts runFonts25 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize25 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript25 = new FontSizeComplexScript() { Val = "28" };
            Languages languages23 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties7.Append(runFonts25);
            paragraphMarkRunProperties7.Append(fontSize25);
            paragraphMarkRunProperties7.Append(fontSizeComplexScript25);
            paragraphMarkRunProperties7.Append(languages23);

            paragraphProperties7.Append(widowControl1);
            paragraphProperties7.Append(numberingProperties3);
            paragraphProperties7.Append(indentation7);
            paragraphProperties7.Append(justification7);
            paragraphProperties7.Append(paragraphMarkRunProperties7);

            Run run19 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties19 = new RunProperties();
            RunFonts runFonts26 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold6 = new Bold();
            FontSize fontSize26 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript26 = new FontSizeComplexScript() { Val = "28" };
            Languages languages24 = new Languages() { Val = "ru-RU" };

            runProperties19.Append(runFonts26);
            runProperties19.Append(bold6);
            runProperties19.Append(fontSize26);
            runProperties19.Append(fontSizeComplexScript26);
            runProperties19.Append(languages24);
            Text text19 = new Text();
            text19.Text = "Интерактивные технологии";

            run19.Append(runProperties19);
            run19.Append(text19);

            Run run20 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties20 = new RunProperties();
            RunFonts runFonts27 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize27 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript27 = new FontSizeComplexScript() { Val = "28" };
            Languages languages25 = new Languages() { Val = "ru-RU" };

            runProperties20.Append(runFonts27);
            runProperties20.Append(fontSize27);
            runProperties20.Append(fontSizeComplexScript27);
            runProperties20.Append(languages25);
            Text text20 = new Text();
            text20.Text = ", например, семинар-дискуссия – коллективное обсуждение какого-либо спорного вопроса, проблемы, выявление мнений в группе.";

            run20.Append(runProperties20);
            run20.Append(text20);

            paragraph7.Append(paragraphProperties7);
            paragraph7.Append(run19);
            paragraph7.Append(run20);

            Paragraph paragraph8 = new Paragraph() { RsidParagraphMarkRevision = "005B1369", RsidParagraphAddition = "005B1369", RsidParagraphProperties = "005B1369", RsidRunAdditionDefault = "005B1369" };

            ParagraphProperties paragraphProperties8 = new ParagraphProperties();
            WidowControl widowControl2 = new WidowControl() { Val = false };

            NumberingProperties numberingProperties4 = new NumberingProperties();
            NumberingLevelReference numberingLevelReference4 = new NumberingLevelReference() { Val = 0 };
            NumberingId numberingId4 = new NumberingId() { Val = 5 };

            numberingProperties4.Append(numberingLevelReference4);
            numberingProperties4.Append(numberingId4);
            Indentation indentation8 = new Indentation() { Left = "641", Hanging = "357" };
            Justification justification8 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties8 = new ParagraphMarkRunProperties();
            RunFonts runFonts28 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize28 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript28 = new FontSizeComplexScript() { Val = "28" };
            Languages languages26 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties8.Append(runFonts28);
            paragraphMarkRunProperties8.Append(fontSize28);
            paragraphMarkRunProperties8.Append(fontSizeComplexScript28);
            paragraphMarkRunProperties8.Append(languages26);

            paragraphProperties8.Append(widowControl2);
            paragraphProperties8.Append(numberingProperties4);
            paragraphProperties8.Append(indentation8);
            paragraphProperties8.Append(justification8);
            paragraphProperties8.Append(paragraphMarkRunProperties8);

            Run run21 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties21 = new RunProperties();
            RunFonts runFonts29 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold7 = new Bold();
            FontSize fontSize29 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript29 = new FontSizeComplexScript() { Val = "28" };
            Languages languages27 = new Languages() { Val = "ru-RU" };

            runProperties21.Append(runFonts29);
            runProperties21.Append(bold7);
            runProperties21.Append(fontSize29);
            runProperties21.Append(fontSizeComplexScript29);
            runProperties21.Append(languages27);
            Text text21 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text21.Text = "Информационно-коммуникационные образовательные технологии: ";

            run21.Append(runProperties21);
            run21.Append(text21);

            Run run22 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties22 = new RunProperties();
            RunFonts runFonts30 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize30 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript30 = new FontSizeComplexScript() { Val = "28" };
            Languages languages28 = new Languages() { Val = "ru-RU" };

            runProperties22.Append(runFonts30);
            runProperties22.Append(fontSize30);
            runProperties22.Append(fontSizeComplexScript30);
            runProperties22.Append(languages28);
            Text text22 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text22.Text = "практическое занятие в форме презентации (представление результатов исследовательской деятельности с использованием специализированных программных сред). ";

            run22.Append(runProperties22);
            run22.Append(text22);

            paragraph8.Append(paragraphProperties8);
            paragraph8.Append(run21);
            paragraph8.Append(run22);

            Paragraph paragraph9 = new Paragraph() { RsidParagraphMarkRevision = "005B1369", RsidParagraphAddition = "005B1369", RsidParagraphProperties = "005B1369", RsidRunAdditionDefault = "005B1369" };

            ParagraphProperties paragraphProperties9 = new ParagraphProperties();
            WidowControl widowControl3 = new WidowControl() { Val = false };

            NumberingProperties numberingProperties5 = new NumberingProperties();
            NumberingLevelReference numberingLevelReference5 = new NumberingLevelReference() { Val = 0 };
            NumberingId numberingId5 = new NumberingId() { Val = 5 };

            numberingProperties5.Append(numberingLevelReference5);
            numberingProperties5.Append(numberingId5);
            Indentation indentation9 = new Indentation() { Left = "641", Hanging = "357" };
            Justification justification9 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties9 = new ParagraphMarkRunProperties();
            RunFonts runFonts31 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize31 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript31 = new FontSizeComplexScript() { Val = "28" };
            Languages languages29 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties9.Append(runFonts31);
            paragraphMarkRunProperties9.Append(fontSize31);
            paragraphMarkRunProperties9.Append(fontSizeComplexScript31);
            paragraphMarkRunProperties9.Append(languages29);

            paragraphProperties9.Append(widowControl3);
            paragraphProperties9.Append(numberingProperties5);
            paragraphProperties9.Append(indentation9);
            paragraphProperties9.Append(justification9);
            paragraphProperties9.Append(paragraphMarkRunProperties9);

            Run run23 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties23 = new RunProperties();
            RunFonts runFonts32 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold8 = new Bold();
            FontSize fontSize32 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript32 = new FontSizeComplexScript() { Val = "28" };
            Languages languages30 = new Languages() { Val = "ru-RU" };

            runProperties23.Append(runFonts32);
            runProperties23.Append(bold8);
            runProperties23.Append(fontSize32);
            runProperties23.Append(fontSizeComplexScript32);
            runProperties23.Append(languages30);
            Text text23 = new Text();
            text23.Text = "Инновационные методы";

            run23.Append(runProperties23);
            run23.Append(text23);

            Run run24 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties24 = new RunProperties();
            RunFonts runFonts33 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize33 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript33 = new FontSizeComplexScript() { Val = "28" };
            Languages languages31 = new Languages() { Val = "ru-RU" };

            runProperties24.Append(runFonts33);
            runProperties24.Append(fontSize33);
            runProperties24.Append(fontSizeComplexScript33);
            runProperties24.Append(languages31);
            Text text24 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text24.Text = ": использование мультимедийных учебников, электронных версий эксклюзивных курсов в преподавании дисциплины; использование ";

            run24.Append(runProperties24);
            run24.Append(text24);
            ProofError proofError7 = new ProofError() { Type = ProofingErrorValues.SpellStart };

            Run run25 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties25 = new RunProperties();
            RunFonts runFonts34 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize34 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript34 = new FontSizeComplexScript() { Val = "28" };
            Languages languages32 = new Languages() { Val = "ru-RU" };

            runProperties25.Append(runFonts34);
            runProperties25.Append(fontSize34);
            runProperties25.Append(fontSizeComplexScript34);
            runProperties25.Append(languages32);
            Text text25 = new Text();
            text25.Text = "медиаресурсов";

            run25.Append(runProperties25);
            run25.Append(text25);
            ProofError proofError8 = new ProofError() { Type = ProofingErrorValues.SpellEnd };

            Run run26 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties26 = new RunProperties();
            RunFonts runFonts35 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize35 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript35 = new FontSizeComplexScript() { Val = "28" };
            Languages languages33 = new Languages() { Val = "ru-RU" };

            runProperties26.Append(runFonts35);
            runProperties26.Append(fontSize35);
            runProperties26.Append(fontSizeComplexScript35);
            runProperties26.Append(languages33);
            Text text26 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text26.Text = ", энциклопедий, электронных библиотек ";

            run26.Append(runProperties26);
            run26.Append(text26);
            ProofError proofError9 = new ProofError() { Type = ProofingErrorValues.GrammarStart };

            Run run27 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties27 = new RunProperties();
            RunFonts runFonts36 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize36 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript36 = new FontSizeComplexScript() { Val = "28" };
            Languages languages34 = new Languages() { Val = "ru-RU" };

            runProperties27.Append(runFonts36);
            runProperties27.Append(fontSize36);
            runProperties27.Append(fontSizeComplexScript36);
            runProperties27.Append(languages34);
            Text text27 = new Text();
            text27.Text = "и  Интернет";

            run27.Append(runProperties27);
            run27.Append(text27);
            ProofError proofError10 = new ProofError() { Type = ProofingErrorValues.GrammarEnd };

            Run run28 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties28 = new RunProperties();
            RunFonts runFonts37 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize37 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript37 = new FontSizeComplexScript() { Val = "28" };
            Languages languages35 = new Languages() { Val = "ru-RU" };

            runProperties28.Append(runFonts37);
            runProperties28.Append(fontSize37);
            runProperties28.Append(fontSizeComplexScript37);
            runProperties28.Append(languages35);
            Text text28 = new Text();
            text28.Text = "; использование программно-педагогических тестовых заданий для проверки знаний студентов и т.д.";

            run28.Append(runProperties28);
            run28.Append(text28);

            paragraph9.Append(paragraphProperties9);
            paragraph9.Append(run23);
            paragraph9.Append(run24);
            paragraph9.Append(proofError7);
            paragraph9.Append(run25);
            paragraph9.Append(proofError8);
            paragraph9.Append(run26);
            paragraph9.Append(proofError9);
            paragraph9.Append(run27);
            paragraph9.Append(proofError10);
            paragraph9.Append(run28);

            Paragraph paragraph10 = new Paragraph() { RsidParagraphMarkRevision = "005B1369", RsidParagraphAddition = "005B1369", RsidParagraphProperties = "005B1369", RsidRunAdditionDefault = "005B1369" };

            ParagraphProperties paragraphProperties10 = new ParagraphProperties();
            WidowControl widowControl4 = new WidowControl() { Val = false };

            Tabs tabs1 = new Tabs();
            TabStop tabStop1 = new TabStop() { Val = TabStopValues.Left, Position = 1080 };

            tabs1.Append(tabStop1);
            Indentation indentation10 = new Indentation() { Left = "851", FirstLine = "567" };
            Justification justification10 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties10 = new ParagraphMarkRunProperties();
            RunFonts runFonts38 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize38 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript38 = new FontSizeComplexScript() { Val = "28" };
            Languages languages36 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties10.Append(runFonts38);
            paragraphMarkRunProperties10.Append(fontSize38);
            paragraphMarkRunProperties10.Append(fontSizeComplexScript38);
            paragraphMarkRunProperties10.Append(languages36);

            paragraphProperties10.Append(widowControl4);
            paragraphProperties10.Append(tabs1);
            paragraphProperties10.Append(indentation10);
            paragraphProperties10.Append(justification10);
            paragraphProperties10.Append(paragraphMarkRunProperties10);

            Run run29 = new Run() { RsidRunProperties = "005B1369" };

            RunProperties runProperties29 = new RunProperties();
            RunFonts runFonts39 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize39 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript39 = new FontSizeComplexScript() { Val = "28" };
            Languages languages37 = new Languages() { Val = "ru-RU" };

            runProperties29.Append(runFonts39);
            runProperties29.Append(fontSize39);
            runProperties29.Append(fontSizeComplexScript39);
            runProperties29.Append(languages37);
            Text text29 = new Text();
            text29.Text = "Кроме того, инновационные методы также предполагают и применение методов активного обучения: интерактивные методы обучения: («метод кейсов», метод проектов), модульно-рейтинговые технологии организации учебного процесса и др.";

            run29.Append(runProperties29);
            run29.Append(text29);

            paragraph10.Append(paragraphProperties10);
            paragraph10.Append(run29);

            Paragraph paragraph11 = new Paragraph() { RsidParagraphMarkRevision = "005B1369", RsidParagraphAddition = "005E7445", RsidParagraphProperties = "005B1369", RsidRunAdditionDefault = "005E7445" };

            ParagraphProperties paragraphProperties11 = new ParagraphProperties();

            ParagraphMarkRunProperties paragraphMarkRunProperties11 = new ParagraphMarkRunProperties();
            Languages languages38 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties11.Append(languages38);

            paragraphProperties11.Append(paragraphMarkRunProperties11);

            paragraph11.Append(paragraphProperties11);

            SectionProperties sectionProperties1 = new SectionProperties() { RsidRPr = "005B1369", RsidR = "005E7445" };
            PageSize pageSize1 = new PageSize() { Width = (UInt32Value)11906U, Height = (UInt32Value)16838U };
            PageMargin pageMargin1 = new PageMargin() { Top = 1134, Right = (UInt32Value)850U, Bottom = 1134, Left = (UInt32Value)1701U, Header = (UInt32Value)708U, Footer = (UInt32Value)708U, Gutter = (UInt32Value)0U };
            Columns columns1 = new Columns() { Space = "708" };
            DocGrid docGrid1 = new DocGrid() { LinePitch = 360 };

            sectionProperties1.Append(pageSize1);
            sectionProperties1.Append(pageMargin1);
            sectionProperties1.Append(columns1);
            sectionProperties1.Append(docGrid1);


            var paraProp = new ParagraphProperties();
            var paragraph0 = new Paragraph();
            var runProp = new RunProperties();
            var run = new Run();

            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            var paragraphStyleId = new ParagraphStyleId() { Val = "Header1" };
            paraProp.Append(paragraphStyleId);
            run.Append(new Text("5.	Образовательные технологии"));
            paragraph0.Append(paraProp);
            paragraph0.Append(run);

            var paragraph00 = new Paragraph();
            paraProp = GetParagraphProperties("StyleWithoutIndentation");
            run = new Run();
            runProp = new RunProperties { Color = new Color { Val = "FF0000" } };
            run.Append(runProp);
            run.Append(new Text("Данный раздел генерируется в стандартной форме. Возможно его требуется изменить."));
            paragraph00.Append(paraProp);
            paragraph00.Append(run);

            _body.Append(paragraph0);
            _body.Append(paragraph00);
            _body.Append(paragraph1);
            _body.Append(paragraph2);
            _body.Append(paragraph3);
            _body.Append(paragraph4);
            _body.Append(paragraph5);
            _body.Append(paragraph6);
            _body.Append(paragraph7);
            _body.Append(paragraph8);
            _body.Append(paragraph9);
            _body.Append(paragraph10);
            _body.Append(paragraph11);
            _body.Append(sectionProperties1);
        }

        private void GenerateChapterSix1()
        {
            Paragraph paragraph1 = new Paragraph() { RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties1 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId1 = new ParagraphStyleId() { Val = "Header1" };

            paragraphProperties1.Append(paragraphStyleId1);

            Run run1 = new Run();
            Text text1 = new Text();
            text1.Text = "6";

            run1.Append(text1);

            Run run2 = new Run() { RsidRunProperties = "006354D8" };
            Text text2 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text2.Text = ". ";

            run2.Append(text2);

            Run run3 = new Run();
            Text text3 = new Text();
            text3.Text = "Оценочные средства дисциплины";

            run3.Append(text3);

            paragraph1.Append(paragraphProperties1);
            paragraph1.Append(run1);
            paragraph1.Append(run2);
            paragraph1.Append(run3);

            Paragraph paragraph2 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties2 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId2 = new ParagraphStyleId() { Val = "2" };
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines() { Before = "120", After = "120" };
            Justification justification1 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties1 = new ParagraphMarkRunProperties();
            RunFonts runFonts1 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages1 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties1.Append(runFonts1);
            paragraphMarkRunProperties1.Append(languages1);

            paragraphProperties2.Append(paragraphStyleId2);
            paragraphProperties2.Append(spacingBetweenLines1);
            paragraphProperties2.Append(justification1);
            paragraphProperties2.Append(paragraphMarkRunProperties1);
            BookmarkStart bookmarkStart1 = new BookmarkStart() { Name = "_Toc293679414", Id = "0" };

            Run run4 = new Run() { RsidRunProperties = "000F6A5D" };

            RunProperties runProperties1 = new RunProperties();
            RunFonts runFonts2 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages2 = new Languages() { Val = "ru-RU" };

            runProperties1.Append(runFonts2);
            runProperties1.Append(languages2);
            Text text4 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text4.Text = "6.1 ";

            run4.Append(runProperties1);
            run4.Append(text4);

            Run run5 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties2 = new RunProperties();
            RunFonts runFonts3 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Languages languages3 = new Languages() { Val = "ru-RU" };

            runProperties2.Append(runFonts3);
            runProperties2.Append(languages3);
            Text text5 = new Text();
            text5.Text = "Контрольно-измерительные материалы к промежуточному и итоговому контролю";

            run5.Append(runProperties2);
            run5.Append(text5);
            BookmarkEnd bookmarkEnd1 = new BookmarkEnd() { Id = "0" };

            paragraph2.Append(paragraphProperties2);
            paragraph2.Append(bookmarkStart1);
            paragraph2.Append(run4);
            paragraph2.Append(run5);
            paragraph2.Append(bookmarkEnd1);

            Paragraph paragraph3 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties3 = new ParagraphProperties();
            Indentation indentation1 = new Indentation() { FirstLine = "720" };
            Justification justification2 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties2 = new ParagraphMarkRunProperties();
            RunFonts runFonts4 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize1 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties2.Append(runFonts4);
            paragraphMarkRunProperties2.Append(fontSize1);
            paragraphMarkRunProperties2.Append(fontSizeComplexScript1);

            paragraphProperties3.Append(indentation1);
            paragraphProperties3.Append(justification2);
            paragraphProperties3.Append(paragraphMarkRunProperties2);

            Run run6 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties3 = new RunProperties();
            RunFonts runFonts5 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize2 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript2 = new FontSizeComplexScript() { Val = "28" };

            runProperties3.Append(runFonts5);
            runProperties3.Append(fontSize2);
            runProperties3.Append(fontSizeComplexScript2);
            Text text6 = new Text();
            text6.Text = "В процессе изучения дисциплины осуществляются следующие виды контроля:";

            run6.Append(runProperties3);
            run6.Append(text6);

            paragraph3.Append(paragraphProperties3);
            paragraph3.Append(run6);

            Paragraph paragraph4 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties4 = new ParagraphProperties();
            Indentation indentation2 = new Indentation() { FirstLine = "720" };
            Justification justification3 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties3 = new ParagraphMarkRunProperties();
            RunFonts runFonts6 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize3 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript3 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties3.Append(runFonts6);
            paragraphMarkRunProperties3.Append(fontSize3);
            paragraphMarkRunProperties3.Append(fontSizeComplexScript3);

            paragraphProperties4.Append(indentation2);
            paragraphProperties4.Append(justification3);
            paragraphProperties4.Append(paragraphMarkRunProperties3);

            Run run7 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties4 = new RunProperties();
            RunFonts runFonts7 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold1 = new Bold();
            BoldComplexScript boldComplexScript1 = new BoldComplexScript();
            FontSize fontSize4 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript4 = new FontSizeComplexScript() { Val = "28" };

            runProperties4.Append(runFonts7);
            runProperties4.Append(bold1);
            runProperties4.Append(boldComplexScript1);
            runProperties4.Append(fontSize4);
            runProperties4.Append(fontSizeComplexScript4);
            Text text7 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text7.Text = "входной контроль ";

            run7.Append(runProperties4);
            run7.Append(text7);

            Run run8 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties5 = new RunProperties();
            RunFonts runFonts8 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize5 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript5 = new FontSizeComplexScript() { Val = "28" };

            runProperties5.Append(runFonts8);
            runProperties5.Append(fontSize5);
            runProperties5.Append(fontSizeComplexScript5);
            Text text8 = new Text();
            text8.Text = "заключается в изучении первоначальных знаний по смежным предшествующим дисциплинам, проведении входного тестирования о наличии представлений, знаний, умений и навыков по данной дисциплине;";

            run8.Append(runProperties5);
            run8.Append(text8);

            paragraph4.Append(paragraphProperties4);
            paragraph4.Append(run7);
            paragraph4.Append(run8);

            Paragraph paragraph5 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties5 = new ParagraphProperties();
            Indentation indentation3 = new Indentation() { FirstLine = "720" };
            Justification justification4 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties4 = new ParagraphMarkRunProperties();
            RunFonts runFonts9 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize6 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript6 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties4.Append(runFonts9);
            paragraphMarkRunProperties4.Append(fontSize6);
            paragraphMarkRunProperties4.Append(fontSizeComplexScript6);

            paragraphProperties5.Append(indentation3);
            paragraphProperties5.Append(justification4);
            paragraphProperties5.Append(paragraphMarkRunProperties4);

            Run run9 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties6 = new RunProperties();
            RunFonts runFonts10 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold2 = new Bold();
            BoldComplexScript boldComplexScript2 = new BoldComplexScript();
            FontSize fontSize7 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript7 = new FontSizeComplexScript() { Val = "28" };

            runProperties6.Append(runFonts10);
            runProperties6.Append(bold2);
            runProperties6.Append(boldComplexScript2);
            runProperties6.Append(fontSize7);
            runProperties6.Append(fontSizeComplexScript7);
            Text text9 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text9.Text = "текущий контроль качества ";

            run9.Append(runProperties6);
            run9.Append(text9);

            Run run10 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties7 = new RunProperties();
            RunFonts runFonts11 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize8 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript8 = new FontSizeComplexScript() { Val = "28" };

            runProperties7.Append(runFonts11);
            runProperties7.Append(fontSize8);
            runProperties7.Append(fontSizeComplexScript8);
            Text text10 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text10.Text = "усвоения знаний состоит в проведении тестов в конце разделов курса, а так же в отработке практических навыков, активность на лабораторных занятиях. ";

            run10.Append(runProperties7);
            run10.Append(text10);

            paragraph5.Append(paragraphProperties5);
            paragraph5.Append(run9);
            paragraph5.Append(run10);

            Paragraph paragraph6 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties6 = new ParagraphProperties();
            Indentation indentation4 = new Indentation() { FirstLine = "720" };
            Justification justification5 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties5 = new ParagraphMarkRunProperties();
            RunFonts runFonts12 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize9 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript9 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties5.Append(runFonts12);
            paragraphMarkRunProperties5.Append(fontSize9);
            paragraphMarkRunProperties5.Append(fontSizeComplexScript9);

            paragraphProperties6.Append(indentation4);
            paragraphProperties6.Append(justification5);
            paragraphProperties6.Append(paragraphMarkRunProperties5);

            Run run11 = new Run();

            RunProperties runProperties8 = new RunProperties();
            RunFonts runFonts13 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold3 = new Bold();
            BoldComplexScript boldComplexScript3 = new BoldComplexScript();
            FontSize fontSize10 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript10 = new FontSizeComplexScript() { Val = "28" };

            runProperties8.Append(runFonts13);
            runProperties8.Append(bold3);
            runProperties8.Append(boldComplexScript3);
            runProperties8.Append(fontSize10);
            runProperties8.Append(fontSizeComplexScript10);
            Text text11 = new Text();
            text11.Text = "рубежный";

            run11.Append(runProperties8);
            run11.Append(text11);

            Run run12 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties9 = new RunProperties();
            RunFonts runFonts14 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold4 = new Bold();
            BoldComplexScript boldComplexScript4 = new BoldComplexScript();
            FontSize fontSize11 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript11 = new FontSizeComplexScript() { Val = "28" };

            runProperties9.Append(runFonts14);
            runProperties9.Append(bold4);
            runProperties9.Append(boldComplexScript4);
            runProperties9.Append(fontSize11);
            runProperties9.Append(fontSizeComplexScript11);
            Text text12 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text12.Text = " контроль ";

            run12.Append(runProperties9);
            run12.Append(text12);
            ProofError proofError1 = new ProofError() { Type = ProofingErrorValues.GrammarStart };

            Run run13 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties10 = new RunProperties();
            RunFonts runFonts15 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold5 = new Bold();
            BoldComplexScript boldComplexScript5 = new BoldComplexScript();
            FontSize fontSize12 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript12 = new FontSizeComplexScript() { Val = "28" };

            runProperties10.Append(runFonts15);
            runProperties10.Append(bold5);
            runProperties10.Append(boldComplexScript5);
            runProperties10.Append(fontSize12);
            runProperties10.Append(fontSizeComplexScript12);
            Text text13 = new Text();
            text13.Text = "–";

            run13.Append(runProperties10);
            run13.Append(text13);

            Run run14 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties11 = new RunProperties();
            RunFonts runFonts16 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            BoldComplexScript boldComplexScript6 = new BoldComplexScript();
            FontSize fontSize13 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript13 = new FontSizeComplexScript() { Val = "28" };

            runProperties11.Append(runFonts16);
            runProperties11.Append(boldComplexScript6);
            runProperties11.Append(fontSize13);
            runProperties11.Append(fontSizeComplexScript13);
            Text text14 = new Text();
            text14.Text = "з";

            run14.Append(runProperties11);
            run14.Append(text14);
            ProofError proofError2 = new ProofError() { Type = ProofingErrorValues.GrammarEnd };

            Run run15 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties12 = new RunProperties();
            RunFonts runFonts17 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            BoldComplexScript boldComplexScript7 = new BoldComplexScript();
            FontSize fontSize14 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript14 = new FontSizeComplexScript() { Val = "28" };

            runProperties12.Append(runFonts17);
            runProperties12.Append(boldComplexScript7);
            runProperties12.Append(fontSize14);
            runProperties12.Append(fontSizeComplexScript14);
            Text text15 = new Text();
            text15.Text = "ачет (третий семестр) и экзамен (четвертый семестр)";

            run15.Append(runProperties12);
            run15.Append(text15);

            Run run16 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties13 = new RunProperties();
            RunFonts runFonts18 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize15 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript15 = new FontSizeComplexScript() { Val = "28" };

            runProperties13.Append(runFonts18);
            runProperties13.Append(fontSize15);
            runProperties13.Append(fontSizeComplexScript15);
            Text text16 = new Text();
            text16.Text = ".";

            run16.Append(runProperties13);
            run16.Append(text16);

            paragraph6.Append(paragraphProperties6);
            paragraph6.Append(run11);
            paragraph6.Append(run12);
            paragraph6.Append(proofError1);
            paragraph6.Append(run13);
            paragraph6.Append(run14);
            paragraph6.Append(proofError2);
            paragraph6.Append(run15);
            paragraph6.Append(run16);

            Paragraph paragraph7 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties7 = new ParagraphProperties();
            Indentation indentation5 = new Indentation() { FirstLine = "720" };
            Justification justification6 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties6 = new ParagraphMarkRunProperties();
            RunFonts runFonts19 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize16 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript16 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties6.Append(runFonts19);
            paragraphMarkRunProperties6.Append(fontSize16);
            paragraphMarkRunProperties6.Append(fontSizeComplexScript16);

            paragraphProperties7.Append(indentation5);
            paragraphProperties7.Append(justification6);
            paragraphProperties7.Append(paragraphMarkRunProperties6);

            Run run17 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties14 = new RunProperties();
            RunFonts runFonts20 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize17 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript17 = new FontSizeComplexScript() { Val = "28" };

            runProperties14.Append(runFonts20);
            runProperties14.Append(fontSize17);
            runProperties14.Append(fontSizeComplexScript17);
            Text text17 = new Text();
            text17.Text = "Рейтинговая оценка по данной дисциплине в каждом семестре осуществляется по 100-балльной шкале и складывается из текущих оценок посещаемости занятий, защиты результатов работ, выполняемых на практических занятиях, знаний на промежуточном контроле (тестирование по темам) и итоговой оценки на зачете или экзамене. Формой итогового контроля в 3-м семестре является зачет, в 4-м семестре — экзамен.";

            run17.Append(runProperties14);
            run17.Append(text17);

            paragraph7.Append(paragraphProperties7);
            paragraph7.Append(run17);

            Paragraph paragraph8 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties8 = new ParagraphProperties();
            Indentation indentation6 = new Indentation() { FirstLine = "720" };
            Justification justification7 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties7 = new ParagraphMarkRunProperties();
            RunFonts runFonts21 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize18 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript18 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties7.Append(runFonts21);
            paragraphMarkRunProperties7.Append(fontSize18);
            paragraphMarkRunProperties7.Append(fontSizeComplexScript18);

            paragraphProperties8.Append(indentation6);
            paragraphProperties8.Append(justification7);
            paragraphProperties8.Append(paragraphMarkRunProperties7);

            Run run18 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties15 = new RunProperties();
            RunFonts runFonts22 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize19 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript19 = new FontSizeComplexScript() { Val = "28" };

            runProperties15.Append(runFonts22);
            runProperties15.Append(fontSize19);
            runProperties15.Append(fontSizeComplexScript19);
            Text text18 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text18.Text = "В 3-м семестре, заканчивающимся зачетом, текущий контроль оценивается интервалом 40–80 баллов, а итоговый — 0–20 баллов. Сумма баллов текущего и итогового контроля в интервале 60–100 баллов соответствует положительной оценке знаний студента и позволяет преподавателю поставить оценку «Зачет» за семестр. ";

            run18.Append(runProperties15);
            run18.Append(text18);

            paragraph8.Append(paragraphProperties8);
            paragraph8.Append(run18);

            Paragraph paragraph9 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties9 = new ParagraphProperties();
            Indentation indentation7 = new Indentation() { FirstLine = "720" };
            Justification justification8 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties8 = new ParagraphMarkRunProperties();
            RunFonts runFonts23 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize20 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript20 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties8.Append(runFonts23);
            paragraphMarkRunProperties8.Append(fontSize20);
            paragraphMarkRunProperties8.Append(fontSizeComplexScript20);

            paragraphProperties9.Append(indentation7);
            paragraphProperties9.Append(justification8);
            paragraphProperties9.Append(paragraphMarkRunProperties8);

            Run run19 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties16 = new RunProperties();
            RunFonts runFonts24 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize21 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript21 = new FontSizeComplexScript() { Val = "28" };

            runProperties16.Append(runFonts24);
            runProperties16.Append(fontSize21);
            runProperties16.Append(fontSizeComplexScript21);
            Text text19 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text19.Text = "В случае пропуска занятий студент ликвидирует образовавшуюся задолженность в сроки, устанавливаемые по договоренности с преподавателем. В случае пропуска занятий по уважительной причине, что подтверждается соответствующей справкой из деканата, защита результатов его работы оценивается по обычной шкале баллов, установленной для каждой темы; при этом ему компенсируется оценка посещаемости пропущенных занятий. В случае пропуска занятий по неуважительной причине защита результатов работы оценивается по 50%-ной шкале баллов ";

            run19.Append(runProperties16);
            run19.Append(text19);

            Run run20 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties17 = new RunProperties();
            RunFonts runFonts25 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize22 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript22 = new FontSizeComplexScript() { Val = "28" };

            runProperties17.Append(runFonts25);
            runProperties17.Append(fontSize22);
            runProperties17.Append(fontSizeComplexScript22);
            LastRenderedPageBreak lastRenderedPageBreak1 = new LastRenderedPageBreak();
            Text text20 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text20.Text = "по каждой теме без компенсации оценки посещаемости пропущенных занятий. ";

            run20.Append(runProperties17);
            run20.Append(lastRenderedPageBreak1);
            run20.Append(text20);

            paragraph9.Append(paragraphProperties9);
            paragraph9.Append(run19);
            paragraph9.Append(run20);

            Paragraph paragraph10 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties10 = new ParagraphProperties();
            Indentation indentation8 = new Indentation() { FirstLine = "720" };
            Justification justification9 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties9 = new ParagraphMarkRunProperties();
            RunFonts runFonts26 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize23 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript23 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties9.Append(runFonts26);
            paragraphMarkRunProperties9.Append(fontSize23);
            paragraphMarkRunProperties9.Append(fontSizeComplexScript23);

            paragraphProperties10.Append(indentation8);
            paragraphProperties10.Append(justification9);
            paragraphProperties10.Append(paragraphMarkRunProperties9);

            Run run21 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties18 = new RunProperties();
            RunFonts runFonts27 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize24 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript24 = new FontSizeComplexScript() { Val = "28" };

            runProperties18.Append(runFonts27);
            runProperties18.Append(fontSize24);
            runProperties18.Append(fontSizeComplexScript24);
            Text text21 = new Text();
            text21.Text = "Студенты, не сумевшие ликвидировать задолженности в установленные сроки в течение семестра, получают на зачете дополнительные вопросы (задачи для решения) по соответствующим темам.";

            run21.Append(runProperties18);
            run21.Append(text21);

            paragraph10.Append(paragraphProperties10);
            paragraph10.Append(run21);

            Paragraph paragraph11 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties11 = new ParagraphProperties();
            Indentation indentation9 = new Indentation() { FirstLine = "720" };
            Justification justification10 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties10 = new ParagraphMarkRunProperties();
            RunFonts runFonts28 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize25 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript25 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties10.Append(runFonts28);
            paragraphMarkRunProperties10.Append(fontSize25);
            paragraphMarkRunProperties10.Append(fontSizeComplexScript25);

            paragraphProperties11.Append(indentation9);
            paragraphProperties11.Append(justification10);
            paragraphProperties11.Append(paragraphMarkRunProperties10);

            Run run22 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties19 = new RunProperties();
            RunFonts runFonts29 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize26 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript26 = new FontSizeComplexScript() { Val = "28" };

            runProperties19.Append(runFonts29);
            runProperties19.Append(fontSize26);
            runProperties19.Append(fontSizeComplexScript26);
            Text text22 = new Text();
            text22.Text = "Если студенту разрешено деканатом заниматься по индивидуальному учебному плану, то в начале семестра совместно с преподавателем устанавливается график защиты результатов его работы по темам в соответствии с учебным планом изучения дисциплины. В случае соблюдения графика его работа оценивается по обычной шкале баллов с компенсацией оценки посещаемости пропущенных занятий, отведенных рабочим учебным планом на изучение соответствующих тем. В случае нарушения установленных сроков он получает на зачете дополнительные вопросы (задачи для решения) по соответствующим темам.";

            run22.Append(runProperties19);
            run22.Append(text22);

            paragraph11.Append(paragraphProperties11);
            paragraph11.Append(run22);

            Paragraph paragraph12 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties12 = new ParagraphProperties();
            Indentation indentation10 = new Indentation() { FirstLine = "720" };
            Justification justification11 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties11 = new ParagraphMarkRunProperties();
            RunFonts runFonts30 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize27 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript27 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties11.Append(runFonts30);
            paragraphMarkRunProperties11.Append(fontSize27);
            paragraphMarkRunProperties11.Append(fontSizeComplexScript27);

            paragraphProperties12.Append(indentation10);
            paragraphProperties12.Append(justification11);
            paragraphProperties12.Append(paragraphMarkRunProperties11);

            Run run23 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties20 = new RunProperties();
            RunFonts runFonts31 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize28 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript28 = new FontSizeComplexScript() { Val = "28" };

            runProperties20.Append(runFonts31);
            runProperties20.Append(fontSize28);
            runProperties20.Append(fontSizeComplexScript28);
            Text text23 = new Text();
            text23.Text = "При защите результатов работы по темам дисциплины студент получает положительную оценку только в том случае, если он демонстрирует умение работать с материалами, предъявленными к защите в электронном виде.";

            run23.Append(runProperties20);
            run23.Append(text23);

            paragraph12.Append(paragraphProperties12);
            paragraph12.Append(run23);

            Paragraph paragraph13 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties13 = new ParagraphProperties();
            Indentation indentation11 = new Indentation() { FirstLine = "720" };
            Justification justification12 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties12 = new ParagraphMarkRunProperties();
            RunFonts runFonts32 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize29 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript29 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties12.Append(runFonts32);
            paragraphMarkRunProperties12.Append(fontSize29);
            paragraphMarkRunProperties12.Append(fontSizeComplexScript29);

            paragraphProperties13.Append(indentation11);
            paragraphProperties13.Append(justification12);
            paragraphProperties13.Append(paragraphMarkRunProperties12);

            Run run24 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties21 = new RunProperties();
            RunFonts runFonts33 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize30 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript30 = new FontSizeComplexScript() { Val = "28" };

            runProperties21.Append(runFonts33);
            runProperties21.Append(fontSize30);
            runProperties21.Append(fontSizeComplexScript30);
            Text text24 = new Text();
            text24.Text = "Оценки, полученные при тестировании по темам дисциплины (от 0 до 100), пересчитываются в шкалу баллов, предусмотренную для соответствующих тем.";

            run24.Append(runProperties21);
            run24.Append(text24);

            paragraph13.Append(paragraphProperties13);
            paragraph13.Append(run24);

            Paragraph paragraph14 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties14 = new ParagraphProperties();
            Indentation indentation12 = new Indentation() { FirstLine = "720" };
            Justification justification13 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties13 = new ParagraphMarkRunProperties();
            RunFonts runFonts34 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize31 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript31 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties13.Append(runFonts34);
            paragraphMarkRunProperties13.Append(fontSize31);
            paragraphMarkRunProperties13.Append(fontSizeComplexScript31);

            paragraphProperties14.Append(indentation12);
            paragraphProperties14.Append(justification13);
            paragraphProperties14.Append(paragraphMarkRunProperties13);

            Run run25 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties22 = new RunProperties();
            RunFonts runFonts35 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize32 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript32 = new FontSizeComplexScript() { Val = "28" };

            runProperties22.Append(runFonts35);
            runProperties22.Append(fontSize32);
            runProperties22.Append(fontSizeComplexScript32);
            Text text25 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text25.Text = "В 4-м семестре, заканчивающимся экзаменом, текущий контроль оценивается интервалом 20–60 баллов, а итоговый — 0–40 баллов. Студенты, не сумевшие ликвидировать задолженности в установленные сроки в течение семестра, получают на экзамене дополнительные вопросы (задачи для решения) по соответствующим темам. ";

            run25.Append(runProperties22);
            run25.Append(text25);

            paragraph14.Append(paragraphProperties14);
            paragraph14.Append(run25);

            Paragraph paragraph15 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties15 = new ParagraphProperties();
            Indentation indentation13 = new Indentation() { FirstLine = "720" };
            Justification justification14 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties14 = new ParagraphMarkRunProperties();
            RunFonts runFonts36 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize33 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript33 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties14.Append(runFonts36);
            paragraphMarkRunProperties14.Append(fontSize33);
            paragraphMarkRunProperties14.Append(fontSizeComplexScript33);

            paragraphProperties15.Append(indentation13);
            paragraphProperties15.Append(justification14);
            paragraphProperties15.Append(paragraphMarkRunProperties14);

            Run run26 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties23 = new RunProperties();
            RunFonts runFonts37 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize34 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript34 = new FontSizeComplexScript() { Val = "28" };

            runProperties23.Append(runFonts37);
            runProperties23.Append(fontSize34);
            runProperties23.Append(fontSizeComplexScript34);
            Text text26 = new Text();
            text26.Text = "Экзамен состоит из теоретического вопроса и нескольких практических заданий, выполняемых студентом непосредственно на компьютере.";

            run26.Append(runProperties23);
            run26.Append(text26);

            paragraph15.Append(paragraphProperties15);
            paragraph15.Append(run26);

            Paragraph paragraph16 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties16 = new ParagraphProperties();
            Indentation indentation14 = new Indentation() { FirstLine = "720" };
            Justification justification15 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties15 = new ParagraphMarkRunProperties();
            RunFonts runFonts38 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize35 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript35 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties15.Append(runFonts38);
            paragraphMarkRunProperties15.Append(fontSize35);
            paragraphMarkRunProperties15.Append(fontSizeComplexScript35);

            paragraphProperties16.Append(indentation14);
            paragraphProperties16.Append(justification15);
            paragraphProperties16.Append(paragraphMarkRunProperties15);

            paragraph16.Append(paragraphProperties16);

            Paragraph paragraph17 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties17 = new ParagraphProperties();
            Indentation indentation15 = new Indentation() { FirstLine = "720" };
            Justification justification16 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties16 = new ParagraphMarkRunProperties();
            RunFonts runFonts39 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize36 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript36 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties16.Append(runFonts39);
            paragraphMarkRunProperties16.Append(fontSize36);
            paragraphMarkRunProperties16.Append(fontSizeComplexScript36);

            paragraphProperties17.Append(indentation15);
            paragraphProperties17.Append(justification16);
            paragraphProperties17.Append(paragraphMarkRunProperties16);

            Run run27 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties24 = new RunProperties();
            RunFonts runFonts40 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize37 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript37 = new FontSizeComplexScript() { Val = "28" };

            runProperties24.Append(runFonts40);
            runProperties24.Append(fontSize37);
            runProperties24.Append(fontSizeComplexScript37);
            Text text27 = new Text();
            text27.Text = "Итоговая сумма баллов на экзамене учитывает результат, накопленный студентом за оба семестра, и вычисляется по формуле:";

            run27.Append(runProperties24);
            run27.Append(text27);

            paragraph17.Append(paragraphProperties17);
            paragraph17.Append(run27);

            Paragraph paragraph18 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties18 = new ParagraphProperties();
            Indentation indentation16 = new Indentation() { FirstLine = "720" };
            Justification justification17 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties17 = new ParagraphMarkRunProperties();
            RunFonts runFonts41 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize38 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript38 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties17.Append(runFonts41);
            paragraphMarkRunProperties17.Append(fontSize38);
            paragraphMarkRunProperties17.Append(fontSizeComplexScript38);

            paragraphProperties18.Append(indentation16);
            paragraphProperties18.Append(justification17);
            paragraphProperties18.Append(paragraphMarkRunProperties17);

            //Run run28 = new Run() { RsidRunProperties = "00881E7E" };

            //RunProperties runProperties25 = new RunProperties();
            //RunFonts runFonts42 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            //Position position1 = new Position() { Val = "-28" };
            //FontSize fontSize39 = new FontSize() { Val = "28" };
            //FontSizeComplexScript fontSizeComplexScript39 = new FontSizeComplexScript() { Val = "28" };

            //runProperties25.Append(runFonts42);
            //runProperties25.Append(position1);
            //runProperties25.Append(fontSize39);
            //runProperties25.Append(fontSizeComplexScript39);

            //EmbeddedObject embeddedObject1 = new EmbeddedObject() { DxaOriginal = "2520", DyaOriginal = "680" };

            //V.Shapetype shapetype1 = new V.Shapetype() { Id = "_x0000_t75", CoordinateSize = "21600,21600", Filled = false, Stroked = false, OptionalNumber = 75, PreferRelative = true, EdgePath = "m@4@5l@4@11@9@11@9@5xe" };
            //V.Stroke stroke1 = new V.Stroke() { JoinStyle = V.StrokeJoinStyleValues.Miter };

            //V.Formulas formulas1 = new V.Formulas();
            //V.Formula formula1 = new V.Formula() { Equation = "if lineDrawn pixelLineWidth 0" };
            //V.Formula formula2 = new V.Formula() { Equation = "sum @0 1 0" };
            //V.Formula formula3 = new V.Formula() { Equation = "sum 0 0 @1" };
            //V.Formula formula4 = new V.Formula() { Equation = "prod @2 1 2" };
            //V.Formula formula5 = new V.Formula() { Equation = "prod @3 21600 pixelWidth" };
            //V.Formula formula6 = new V.Formula() { Equation = "prod @3 21600 pixelHeight" };
            //V.Formula formula7 = new V.Formula() { Equation = "sum @0 0 1" };
            //V.Formula formula8 = new V.Formula() { Equation = "prod @6 1 2" };
            //V.Formula formula9 = new V.Formula() { Equation = "prod @7 21600 pixelWidth" };
            //V.Formula formula10 = new V.Formula() { Equation = "sum @8 21600 0" };
            //V.Formula formula11 = new V.Formula() { Equation = "prod @7 21600 pixelHeight" };
            //V.Formula formula12 = new V.Formula() { Equation = "sum @10 21600 0" };

            //formulas1.Append(formula1);
            //formulas1.Append(formula2);
            //formulas1.Append(formula3);
            //formulas1.Append(formula4);
            //formulas1.Append(formula5);
            //formulas1.Append(formula6);
            //formulas1.Append(formula7);
            //formulas1.Append(formula8);
            //formulas1.Append(formula9);
            //formulas1.Append(formula10);
            //formulas1.Append(formula11);
            //formulas1.Append(formula12);
            //V.Path path1 = new V.Path() { AllowGradientShape = true, ConnectionPointType = Ovml.ConnectValues.Rectangle, AllowExtrusion = false };
            //Ovml.Lock lock1 = new Ovml.Lock() { Extension = V.ExtensionHandlingBehaviorValues.Edit, AspectRatio = true };

            //shapetype1.Append(stroke1);
            //shapetype1.Append(formulas1);
            //shapetype1.Append(path1);
            //shapetype1.Append(lock1);

            //V.Shape shape1 = new V.Shape() { Id = "_x0000_i1025", Style = "width:171.05pt;height:45.5pt", Ole = false, Type = "#_x0000_t75" };
            //V.ImageData imageData1 = new V.ImageData() { Title = "", RelationshipId = "rId5" };

            //shape1.Append(imageData1);
            //Ovml.OleObject oleObject1 = new Ovml.OleObject() { Type = Ovml.OleValues.Embed, ProgId = "Equation.3", ShapeId = "_x0000_i1025", DrawAspect = Ovml.OleDrawAspectValues.Content, ObjectId = "_1432036585", Id = "rId6" };

            //embeddedObject1.Append(shapetype1);
            //embeddedObject1.Append(shape1);
            //embeddedObject1.Append(oleObject1);

            //run28.Append(runProperties25);
            //run28.Append(embeddedObject1);

            //paragraph18.Append(paragraphProperties18);
            //paragraph18.Append(run28);

            Paragraph paragraph19 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties19 = new ParagraphProperties();
            Justification justification18 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties18 = new ParagraphMarkRunProperties();
            RunFonts runFonts43 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize40 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript40 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties18.Append(runFonts43);
            paragraphMarkRunProperties18.Append(fontSize40);
            paragraphMarkRunProperties18.Append(fontSizeComplexScript40);

            paragraphProperties19.Append(justification18);
            paragraphProperties19.Append(paragraphMarkRunProperties18);

            Run run29 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties26 = new RunProperties();
            RunFonts runFonts44 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize41 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript41 = new FontSizeComplexScript() { Val = "28" };

            runProperties26.Append(runFonts44);
            runProperties26.Append(fontSize41);
            runProperties26.Append(fontSizeComplexScript41);
            LastRenderedPageBreak lastRenderedPageBreak2 = new LastRenderedPageBreak();
            Text text28 = new Text();
            text28.Text = "где:";

            run29.Append(runProperties26);
            run29.Append(lastRenderedPageBreak2);
            run29.Append(text28);

            paragraph19.Append(paragraphProperties19);
            paragraph19.Append(run29);

            Paragraph paragraph20 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties20 = new ParagraphProperties();
            Indentation indentation17 = new Indentation() { FirstLine = "720" };
            Justification justification19 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties19 = new ParagraphMarkRunProperties();
            RunFonts runFonts45 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize42 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript42 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties19.Append(runFonts45);
            paragraphMarkRunProperties19.Append(fontSize42);
            paragraphMarkRunProperties19.Append(fontSizeComplexScript42);

            paragraphProperties20.Append(indentation17);
            paragraphProperties20.Append(justification19);
            paragraphProperties20.Append(paragraphMarkRunProperties19);

            Run run30 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties27 = new RunProperties();
            RunFonts runFonts46 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Italic italic1 = new Italic();
            FontSize fontSize43 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript43 = new FontSizeComplexScript() { Val = "28" };

            runProperties27.Append(runFonts46);
            runProperties27.Append(italic1);
            runProperties27.Append(fontSize43);
            runProperties27.Append(fontSizeComplexScript43);
            Text text29 = new Text();
            text29.Text = "R";

            run30.Append(runProperties27);
            run30.Append(text29);

            Run run31 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties28 = new RunProperties();
            RunFonts runFonts47 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize44 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript44 = new FontSizeComplexScript() { Val = "28" };
            VerticalTextAlignment verticalTextAlignment1 = new VerticalTextAlignment() { Val = VerticalPositionValues.Subscript };

            runProperties28.Append(runFonts47);
            runProperties28.Append(fontSize44);
            runProperties28.Append(fontSizeComplexScript44);
            runProperties28.Append(verticalTextAlignment1);
            Text text30 = new Text();
            text30.Text = "3";

            run31.Append(runProperties28);
            run31.Append(text30);

            Run run32 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties29 = new RunProperties();
            RunFonts runFonts48 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize45 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript45 = new FontSizeComplexScript() { Val = "28" };

            runProperties29.Append(runFonts48);
            runProperties29.Append(fontSize45);
            runProperties29.Append(fontSizeComplexScript45);
            Text text31 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text31.Text = " — рейтинг за 3-й семестр, закончившийся зачетом (от 60 до 100);";

            run32.Append(runProperties29);
            run32.Append(text31);

            paragraph20.Append(paragraphProperties20);
            paragraph20.Append(run30);
            paragraph20.Append(run31);
            paragraph20.Append(run32);

            Paragraph paragraph21 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties21 = new ParagraphProperties();
            Indentation indentation18 = new Indentation() { FirstLine = "720" };
            Justification justification20 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties20 = new ParagraphMarkRunProperties();
            RunFonts runFonts49 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize46 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript46 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties20.Append(runFonts49);
            paragraphMarkRunProperties20.Append(fontSize46);
            paragraphMarkRunProperties20.Append(fontSizeComplexScript46);

            paragraphProperties21.Append(indentation18);
            paragraphProperties21.Append(justification20);
            paragraphProperties21.Append(paragraphMarkRunProperties20);
            ProofError proofError3 = new ProofError() { Type = ProofingErrorValues.GrammarStart };

            Run run33 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties30 = new RunProperties();
            RunFonts runFonts50 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Italic italic2 = new Italic();
            FontSize fontSize47 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript47 = new FontSizeComplexScript() { Val = "28" };

            runProperties30.Append(runFonts50);
            runProperties30.Append(italic2);
            runProperties30.Append(fontSize47);
            runProperties30.Append(fontSizeComplexScript47);
            Text text32 = new Text();
            text32.Text = "S";

            run33.Append(runProperties30);
            run33.Append(text32);
            ProofError proofError4 = new ProofError() { Type = ProofingErrorValues.GrammarEnd };

            Run run34 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties31 = new RunProperties();
            RunFonts runFonts51 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize48 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript48 = new FontSizeComplexScript() { Val = "28" };
            VerticalTextAlignment verticalTextAlignment2 = new VerticalTextAlignment() { Val = VerticalPositionValues.Subscript };

            runProperties31.Append(runFonts51);
            runProperties31.Append(fontSize48);
            runProperties31.Append(fontSizeComplexScript48);
            runProperties31.Append(verticalTextAlignment2);
            Text text33 = new Text();
            text33.Text = "Т";

            run34.Append(runProperties31);
            run34.Append(text33);

            Run run35 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties32 = new RunProperties();
            RunFonts runFonts52 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize49 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript49 = new FontSizeComplexScript() { Val = "28" };

            runProperties32.Append(runFonts52);
            runProperties32.Append(fontSize49);
            runProperties32.Append(fontSizeComplexScript49);
            Text text34 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text34.Text = " — сумма баллов текущей успеваемости в четвертом семестре (от 0 до 60);";

            run35.Append(runProperties32);
            run35.Append(text34);

            paragraph21.Append(paragraphProperties21);
            paragraph21.Append(proofError3);
            paragraph21.Append(run33);
            paragraph21.Append(proofError4);
            paragraph21.Append(run34);
            paragraph21.Append(run35);

            Paragraph paragraph22 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties22 = new ParagraphProperties();
            Indentation indentation19 = new Indentation() { FirstLine = "720" };
            Justification justification21 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties21 = new ParagraphMarkRunProperties();
            RunFonts runFonts53 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize50 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript50 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties21.Append(runFonts53);
            paragraphMarkRunProperties21.Append(fontSize50);
            paragraphMarkRunProperties21.Append(fontSizeComplexScript50);

            paragraphProperties22.Append(indentation19);
            paragraphProperties22.Append(justification21);
            paragraphProperties22.Append(paragraphMarkRunProperties21);
            ProofError proofError5 = new ProofError() { Type = ProofingErrorValues.GrammarStart };

            Run run36 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties33 = new RunProperties();
            RunFonts runFonts54 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Italic italic3 = new Italic();
            FontSize fontSize51 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript51 = new FontSizeComplexScript() { Val = "28" };

            runProperties33.Append(runFonts54);
            runProperties33.Append(italic3);
            runProperties33.Append(fontSize51);
            runProperties33.Append(fontSizeComplexScript51);
            Text text35 = new Text();
            text35.Text = "S";

            run36.Append(runProperties33);
            run36.Append(text35);
            ProofError proofError6 = new ProofError() { Type = ProofingErrorValues.GrammarEnd };

            Run run37 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties34 = new RunProperties();
            RunFonts runFonts55 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize52 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript52 = new FontSizeComplexScript() { Val = "28" };
            VerticalTextAlignment verticalTextAlignment3 = new VerticalTextAlignment() { Val = VerticalPositionValues.Subscript };

            runProperties34.Append(runFonts55);
            runProperties34.Append(fontSize52);
            runProperties34.Append(fontSizeComplexScript52);
            runProperties34.Append(verticalTextAlignment3);
            Text text36 = new Text();
            text36.Text = "Э";

            run37.Append(runProperties34);
            run37.Append(text36);

            Run run38 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties35 = new RunProperties();
            RunFonts runFonts56 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize53 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript53 = new FontSizeComplexScript() { Val = "28" };

            runProperties35.Append(runFonts56);
            runProperties35.Append(fontSize53);
            runProperties35.Append(fontSizeComplexScript53);
            Text text37 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text37.Text = " — балл, полученный на экзамене (от 0 до 40).";

            run38.Append(runProperties35);
            run38.Append(text37);

            paragraph22.Append(paragraphProperties22);
            paragraph22.Append(proofError5);
            paragraph22.Append(run36);
            paragraph22.Append(proofError6);
            paragraph22.Append(run37);
            paragraph22.Append(run38);

            Paragraph paragraph23 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties23 = new ParagraphProperties();
            Indentation indentation20 = new Indentation() { FirstLine = "720" };
            Justification justification22 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties22 = new ParagraphMarkRunProperties();
            RunFonts runFonts57 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize54 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript54 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties22.Append(runFonts57);
            paragraphMarkRunProperties22.Append(fontSize54);
            paragraphMarkRunProperties22.Append(fontSizeComplexScript54);

            paragraphProperties23.Append(indentation20);
            paragraphProperties23.Append(justification22);
            paragraphProperties23.Append(paragraphMarkRunProperties22);

            Run run39 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties36 = new RunProperties();
            RunFonts runFonts58 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize55 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript55 = new FontSizeComplexScript() { Val = "28" };

            runProperties36.Append(runFonts58);
            runProperties36.Append(fontSize55);
            runProperties36.Append(fontSizeComplexScript55);
            Text text38 = new Text();
            text38.Text = "Полученный таким образом рейтинг пересчитывается в традиционную шкалу оценок, выставляемых в ведомость и зачетную книжку, следующим образом:";

            run39.Append(runProperties36);
            run39.Append(text38);

            paragraph23.Append(paragraphProperties23);
            paragraph23.Append(run39);

            Paragraph paragraph24 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties24 = new ParagraphProperties();
            Indentation indentation21 = new Indentation() { FirstLine = "720" };
            Justification justification23 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties23 = new ParagraphMarkRunProperties();
            RunFonts runFonts59 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize56 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript56 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties23.Append(runFonts59);
            paragraphMarkRunProperties23.Append(fontSize56);
            paragraphMarkRunProperties23.Append(fontSizeComplexScript56);

            paragraphProperties24.Append(indentation21);
            paragraphProperties24.Append(justification23);
            paragraphProperties24.Append(paragraphMarkRunProperties23);

            Run run40 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties37 = new RunProperties();
            RunFonts runFonts60 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize57 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript57 = new FontSizeComplexScript() { Val = "28" };

            runProperties37.Append(runFonts60);
            runProperties37.Append(fontSize57);
            runProperties37.Append(fontSizeComplexScript57);
            Text text39 = new Text();
            text39.Text = "неудовлетворительно";

            run40.Append(runProperties37);
            run40.Append(text39);

            Run run41 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties38 = new RunProperties();
            RunFonts runFonts61 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize58 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript58 = new FontSizeComplexScript() { Val = "28" };

            runProperties38.Append(runFonts61);
            runProperties38.Append(fontSize58);
            runProperties38.Append(fontSizeComplexScript58);
            TabChar tabChar1 = new TabChar();
            Text text40 = new Text();
            text40.Text = "—";

            run41.Append(runProperties38);
            run41.Append(tabChar1);
            run41.Append(text40);

            Run run42 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties39 = new RunProperties();
            RunFonts runFonts62 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize59 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript59 = new FontSizeComplexScript() { Val = "28" };

            runProperties39.Append(runFonts62);
            runProperties39.Append(fontSize59);
            runProperties39.Append(fontSizeComplexScript59);
            TabChar tabChar2 = new TabChar();
            Text text41 = new Text();
            text41.Text = "менее 55 баллов;";

            run42.Append(runProperties39);
            run42.Append(tabChar2);
            run42.Append(text41);

            paragraph24.Append(paragraphProperties24);
            paragraph24.Append(run40);
            paragraph24.Append(run41);
            paragraph24.Append(run42);

            Paragraph paragraph25 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties25 = new ParagraphProperties();
            Indentation indentation22 = new Indentation() { FirstLine = "720" };
            Justification justification24 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties24 = new ParagraphMarkRunProperties();
            RunFonts runFonts63 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize60 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript60 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties24.Append(runFonts63);
            paragraphMarkRunProperties24.Append(fontSize60);
            paragraphMarkRunProperties24.Append(fontSizeComplexScript60);

            paragraphProperties25.Append(indentation22);
            paragraphProperties25.Append(justification24);
            paragraphProperties25.Append(paragraphMarkRunProperties24);

            Run run43 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties40 = new RunProperties();
            RunFonts runFonts64 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize61 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript61 = new FontSizeComplexScript() { Val = "28" };

            runProperties40.Append(runFonts64);
            runProperties40.Append(fontSize61);
            runProperties40.Append(fontSizeComplexScript61);
            Text text42 = new Text();
            text42.Text = "удовлетворительно";

            run43.Append(runProperties40);
            run43.Append(text42);

            Run run44 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties41 = new RunProperties();
            RunFonts runFonts65 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize62 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript62 = new FontSizeComplexScript() { Val = "28" };

            runProperties41.Append(runFonts65);
            runProperties41.Append(fontSize62);
            runProperties41.Append(fontSizeComplexScript62);
            TabChar tabChar3 = new TabChar();
            Text text43 = new Text();
            text43.Text = "—";

            run44.Append(runProperties41);
            run44.Append(tabChar3);
            run44.Append(text43);

            Run run45 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties42 = new RunProperties();
            RunFonts runFonts66 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize63 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript63 = new FontSizeComplexScript() { Val = "28" };

            runProperties42.Append(runFonts66);
            runProperties42.Append(fontSize63);
            runProperties42.Append(fontSizeComplexScript63);
            TabChar tabChar4 = new TabChar();
            Text text44 = new Text();
            text44.Text = "55 – 69 баллов;";

            run45.Append(runProperties42);
            run45.Append(tabChar4);
            run45.Append(text44);

            paragraph25.Append(paragraphProperties25);
            paragraph25.Append(run43);
            paragraph25.Append(run44);
            paragraph25.Append(run45);

            Paragraph paragraph26 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties26 = new ParagraphProperties();
            Indentation indentation23 = new Indentation() { FirstLine = "720" };
            Justification justification25 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties25 = new ParagraphMarkRunProperties();
            RunFonts runFonts67 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize64 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript64 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties25.Append(runFonts67);
            paragraphMarkRunProperties25.Append(fontSize64);
            paragraphMarkRunProperties25.Append(fontSizeComplexScript64);

            paragraphProperties26.Append(indentation23);
            paragraphProperties26.Append(justification25);
            paragraphProperties26.Append(paragraphMarkRunProperties25);

            Run run46 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties43 = new RunProperties();
            RunFonts runFonts68 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize65 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript65 = new FontSizeComplexScript() { Val = "28" };

            runProperties43.Append(runFonts68);
            runProperties43.Append(fontSize65);
            runProperties43.Append(fontSizeComplexScript65);
            Text text45 = new Text();
            text45.Text = "хорошо";

            run46.Append(runProperties43);
            run46.Append(text45);

            Run run47 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties44 = new RunProperties();
            RunFonts runFonts69 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize66 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript66 = new FontSizeComplexScript() { Val = "28" };

            runProperties44.Append(runFonts69);
            runProperties44.Append(fontSize66);
            runProperties44.Append(fontSizeComplexScript66);
            TabChar tabChar5 = new TabChar();
            Text text46 = new Text();
            text46.Text = "—";

            run47.Append(runProperties44);
            run47.Append(tabChar5);
            run47.Append(text46);

            Run run48 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties45 = new RunProperties();
            RunFonts runFonts70 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize67 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript67 = new FontSizeComplexScript() { Val = "28" };

            runProperties45.Append(runFonts70);
            runProperties45.Append(fontSize67);
            runProperties45.Append(fontSizeComplexScript67);
            TabChar tabChar6 = new TabChar();
            Text text47 = new Text();
            text47.Text = "70 – 84 баллов;";

            run48.Append(runProperties45);
            run48.Append(tabChar6);
            run48.Append(text47);

            paragraph26.Append(paragraphProperties26);
            paragraph26.Append(run46);
            paragraph26.Append(run47);
            paragraph26.Append(run48);

            Paragraph paragraph27 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties27 = new ParagraphProperties();
            Indentation indentation24 = new Indentation() { FirstLine = "720" };
            Justification justification26 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties26 = new ParagraphMarkRunProperties();
            RunFonts runFonts71 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize68 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript68 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties26.Append(runFonts71);
            paragraphMarkRunProperties26.Append(fontSize68);
            paragraphMarkRunProperties26.Append(fontSizeComplexScript68);

            paragraphProperties27.Append(indentation24);
            paragraphProperties27.Append(justification26);
            paragraphProperties27.Append(paragraphMarkRunProperties26);

            Run run49 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties46 = new RunProperties();
            RunFonts runFonts72 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize69 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript69 = new FontSizeComplexScript() { Val = "28" };

            runProperties46.Append(runFonts72);
            runProperties46.Append(fontSize69);
            runProperties46.Append(fontSizeComplexScript69);
            Text text48 = new Text();
            text48.Text = "отлично";

            run49.Append(runProperties46);
            run49.Append(text48);

            Run run50 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties47 = new RunProperties();
            RunFonts runFonts73 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize70 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript70 = new FontSizeComplexScript() { Val = "28" };

            runProperties47.Append(runFonts73);
            runProperties47.Append(fontSize70);
            runProperties47.Append(fontSizeComplexScript70);
            TabChar tabChar7 = new TabChar();
            Text text49 = new Text();
            text49.Text = "—";

            run50.Append(runProperties47);
            run50.Append(tabChar7);
            run50.Append(text49);

            Run run51 = new Run() { RsidRunProperties = "00881E7E" };

            RunProperties runProperties48 = new RunProperties();
            RunFonts runFonts74 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize71 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript71 = new FontSizeComplexScript() { Val = "28" };

            runProperties48.Append(runFonts74);
            runProperties48.Append(fontSize71);
            runProperties48.Append(fontSizeComplexScript71);
            TabChar tabChar8 = new TabChar();
            Text text50 = new Text();
            text50.Text = "85 – 100 баллов.";

            run51.Append(runProperties48);
            run51.Append(tabChar8);
            run51.Append(text50);

            paragraph27.Append(paragraphProperties27);
            paragraph27.Append(run49);
            paragraph27.Append(run50);
            paragraph27.Append(run51);

            Paragraph paragraph28 = new Paragraph() { RsidParagraphMarkRevision = "00881E7E", RsidParagraphAddition = "000F6A5D", RsidParagraphProperties = "000F6A5D", RsidRunAdditionDefault = "000F6A5D" };

            ParagraphProperties paragraphProperties28 = new ParagraphProperties();
            Indentation indentation25 = new Indentation() { FirstLine = "709" };
            Justification justification27 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties27 = new ParagraphMarkRunProperties();
            RunFonts runFonts75 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize72 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript72 = new FontSizeComplexScript() { Val = "28" };

            paragraphMarkRunProperties27.Append(runFonts75);
            paragraphMarkRunProperties27.Append(fontSize72);
            paragraphMarkRunProperties27.Append(fontSizeComplexScript72);

            paragraphProperties28.Append(indentation25);
            paragraphProperties28.Append(justification27);
            paragraphProperties28.Append(paragraphMarkRunProperties27);

            paragraph28.Append(paragraphProperties28);

            Paragraph paragraph29 = new Paragraph() { RsidParagraphAddition = "00E03058", RsidRunAdditionDefault = "00E03058" };

            ParagraphProperties paragraphProperties29 = new ParagraphProperties();
            ParagraphStyleId paragraphStyleId3 = new ParagraphStyleId() { Val = "StyleWithoutIndentation" };

            paragraphProperties29.Append(paragraphStyleId3);

            paragraph29.Append(paragraphProperties29);

            SectionProperties sectionProperties1 = new SectionProperties() { RsidR = "00E03058" };
            PageSize pageSize1 = new PageSize() { Width = (UInt32Value)11906U, Height = (UInt32Value)16838U };
            PageMargin pageMargin1 = new PageMargin() { Top = 1134, Right = (UInt32Value)850U, Bottom = 1134, Left = (UInt32Value)1701U, Header = (UInt32Value)708U, Footer = (UInt32Value)708U, Gutter = (UInt32Value)0U };
            Columns columns1 = new Columns() { Space = "708" };
            DocGrid docGrid1 = new DocGrid() { LinePitch = 360 };

            sectionProperties1.Append(pageSize1);
            sectionProperties1.Append(pageMargin1);
            sectionProperties1.Append(columns1);
            sectionProperties1.Append(docGrid1);

            _body.Append(paragraph1);
            _body.Append(paragraph2);
            _body.Append(paragraph3);
            _body.Append(paragraph4);
            _body.Append(paragraph5);
            _body.Append(paragraph6);
            _body.Append(paragraph7);
            _body.Append(paragraph8);
            _body.Append(paragraph9);
            _body.Append(paragraph10);
            _body.Append(paragraph11);
            _body.Append(paragraph12);
            _body.Append(paragraph13);
            _body.Append(paragraph14);
            _body.Append(paragraph15);
            _body.Append(paragraph16);
            _body.Append(paragraph17);
            _body.Append(paragraph18);
            _body.Append(paragraph19);
            _body.Append(paragraph20);
            _body.Append(paragraph21);
            _body.Append(paragraph22);
            _body.Append(paragraph23);
            _body.Append(paragraph24);
            _body.Append(paragraph25);
            _body.Append(paragraph26);
            _body.Append(paragraph27);
            _body.Append(paragraph28);
            _body.Append(paragraph29);
            _body.Append(sectionProperties1);
        }

        private void GenerateChapterTen()
        {
            var paragraph1 = new Paragraph();
            var paraProp = GetParagraphProperties("Header1");
            var run = new Run();
            run.Append(new Text("10. Лист регистрации изменений, вносимых в РПД дисциплины"));

            paragraph1.Append(paraProp);
            paragraph1.Append(run);

            Paragraph paragraph2 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00E24EED", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties2 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines1 = new SpacingBetweenLines() { Line = "360", LineRule = LineSpacingRuleValues.Auto };
            Indentation indentation1 = new Indentation() { Left = "360" };
            Justification justification1 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties2 = new ParagraphMarkRunProperties();
            RunFonts runFonts7 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize1 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript1 = new FontSizeComplexScript() { Val = "28" };
            Languages languages7 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties2.Append(runFonts7);
            paragraphMarkRunProperties2.Append(fontSize1);
            paragraphMarkRunProperties2.Append(fontSizeComplexScript1);
            paragraphMarkRunProperties2.Append(languages7);

            paragraphProperties2.Append(spacingBetweenLines1);
            paragraphProperties2.Append(indentation1);
            paragraphProperties2.Append(justification1);
            paragraphProperties2.Append(paragraphMarkRunProperties2);

            paragraph2.Append(paragraphProperties2);

            Table table1 = new Table();

            TableProperties tableProperties1 = new TableProperties();
            TableWidth tableWidth1 = new TableWidth() { Width = "9807", Type = TableWidthUnitValues.Dxa };

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
            TableLook tableLook1 = new TableLook() { Val = "01E0", FirstRow = true, LastRow = true, FirstColumn = true, LastColumn = true, NoHorizontalBand = false, NoVerticalBand = false };

            tableProperties1.Append(tableWidth1);
            tableProperties1.Append(tableBorders1);
            tableProperties1.Append(tableLook1);

            TableGrid tableGrid1 = new TableGrid();
            GridColumn gridColumn1 = new GridColumn() { Width = "1565" };
            GridColumn gridColumn2 = new GridColumn() { Width = "1066" };
            GridColumn gridColumn3 = new GridColumn() { Width = "1917" };
            GridColumn gridColumn4 = new GridColumn() { Width = "5259" };

            tableGrid1.Append(gridColumn1);
            tableGrid1.Append(gridColumn2);
            tableGrid1.Append(gridColumn3);
            tableGrid1.Append(gridColumn4);

            TableRow tableRow1 = new TableRow() { RsidTableRowMarkRevision = "00107D47", RsidTableRowAddition = "00E24EED", RsidTableRowProperties = "00BF6E08" };

            TableCell tableCell1 = new TableCell();

            TableCellProperties tableCellProperties1 = new TableCellProperties();
            TableCellWidth tableCellWidth1 = new TableCellWidth() { Width = "1565", Type = TableWidthUnitValues.Dxa };

            tableCellProperties1.Append(tableCellWidth1);

            Paragraph paragraph3 = new Paragraph() { RsidParagraphMarkRevision = "00512F8B", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties3 = new ParagraphProperties();
            Justification justification2 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties3 = new ParagraphMarkRunProperties();
            RunFonts runFonts8 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold1 = new Bold();
            FontSize fontSize2 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript2 = new FontSizeComplexScript() { Val = "28" };
            Languages languages8 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties3.Append(runFonts8);
            paragraphMarkRunProperties3.Append(bold1);
            paragraphMarkRunProperties3.Append(fontSize2);
            paragraphMarkRunProperties3.Append(fontSizeComplexScript2);
            paragraphMarkRunProperties3.Append(languages8);

            paragraphProperties3.Append(justification2);
            paragraphProperties3.Append(paragraphMarkRunProperties3);

            Run run6 = new Run() { RsidRunProperties = "00512F8B" };

            RunProperties runProperties6 = new RunProperties();
            RunFonts runFonts9 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold2 = new Bold();
            FontSize fontSize3 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript3 = new FontSizeComplexScript() { Val = "28" };
            Languages languages9 = new Languages() { Val = "ru-RU" };

            runProperties6.Append(runFonts9);
            runProperties6.Append(bold2);
            runProperties6.Append(fontSize3);
            runProperties6.Append(fontSizeComplexScript3);
            runProperties6.Append(languages9);
            Text text5 = new Text();
            text5.Text = "№ изменения";

            run6.Append(runProperties6);
            run6.Append(text5);

            paragraph3.Append(paragraphProperties3);
            paragraph3.Append(run6);

            tableCell1.Append(tableCellProperties1);
            tableCell1.Append(paragraph3);

            TableCell tableCell2 = new TableCell();

            TableCellProperties tableCellProperties2 = new TableCellProperties();
            TableCellWidth tableCellWidth2 = new TableCellWidth() { Width = "1066", Type = TableWidthUnitValues.Dxa };

            tableCellProperties2.Append(tableCellWidth2);

            Paragraph paragraph4 = new Paragraph() { RsidParagraphMarkRevision = "00512F8B", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties4 = new ParagraphProperties();
            Justification justification3 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties4 = new ParagraphMarkRunProperties();
            RunFonts runFonts10 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold3 = new Bold();
            FontSize fontSize4 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript4 = new FontSizeComplexScript() { Val = "28" };
            Languages languages10 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties4.Append(runFonts10);
            paragraphMarkRunProperties4.Append(bold3);
            paragraphMarkRunProperties4.Append(fontSize4);
            paragraphMarkRunProperties4.Append(fontSizeComplexScript4);
            paragraphMarkRunProperties4.Append(languages10);

            paragraphProperties4.Append(justification3);
            paragraphProperties4.Append(paragraphMarkRunProperties4);

            Run run7 = new Run() { RsidRunProperties = "00512F8B" };

            RunProperties runProperties7 = new RunProperties();
            RunFonts runFonts11 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold4 = new Bold();
            FontSize fontSize5 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript5 = new FontSizeComplexScript() { Val = "28" };
            Languages languages11 = new Languages() { Val = "ru-RU" };

            runProperties7.Append(runFonts11);
            runProperties7.Append(bold4);
            runProperties7.Append(fontSize5);
            runProperties7.Append(fontSizeComplexScript5);
            runProperties7.Append(languages11);
            Text text6 = new Text();
            text6.Text = "дата";

            run7.Append(runProperties7);
            run7.Append(text6);

            paragraph4.Append(paragraphProperties4);
            paragraph4.Append(run7);

            tableCell2.Append(tableCellProperties2);
            tableCell2.Append(paragraph4);

            TableCell tableCell3 = new TableCell();

            TableCellProperties tableCellProperties3 = new TableCellProperties();
            TableCellWidth tableCellWidth3 = new TableCellWidth() { Width = "1917", Type = TableWidthUnitValues.Dxa };

            tableCellProperties3.Append(tableCellWidth3);

            Paragraph paragraph5 = new Paragraph() { RsidParagraphMarkRevision = "00512F8B", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties5 = new ParagraphProperties();
            Justification justification4 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties5 = new ParagraphMarkRunProperties();
            RunFonts runFonts12 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold5 = new Bold();
            FontSize fontSize6 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript6 = new FontSizeComplexScript() { Val = "28" };
            Languages languages12 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties5.Append(runFonts12);
            paragraphMarkRunProperties5.Append(bold5);
            paragraphMarkRunProperties5.Append(fontSize6);
            paragraphMarkRunProperties5.Append(fontSizeComplexScript6);
            paragraphMarkRunProperties5.Append(languages12);

            paragraphProperties5.Append(justification4);
            paragraphProperties5.Append(paragraphMarkRunProperties5);

            Run run8 = new Run() { RsidRunProperties = "00512F8B" };

            RunProperties runProperties8 = new RunProperties();
            RunFonts runFonts13 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold6 = new Bold();
            FontSize fontSize7 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript7 = new FontSizeComplexScript() { Val = "28" };
            Languages languages13 = new Languages() { Val = "ru-RU" };

            runProperties8.Append(runFonts13);
            runProperties8.Append(bold6);
            runProperties8.Append(fontSize7);
            runProperties8.Append(fontSizeComplexScript7);
            runProperties8.Append(languages13);
            Text text7 = new Text();
            text7.Text = "Страницы с изменениями";

            run8.Append(runProperties8);
            run8.Append(text7);

            paragraph5.Append(paragraphProperties5);
            paragraph5.Append(run8);

            tableCell3.Append(tableCellProperties3);
            tableCell3.Append(paragraph5);

            TableCell tableCell4 = new TableCell();

            TableCellProperties tableCellProperties4 = new TableCellProperties();
            TableCellWidth tableCellWidth4 = new TableCellWidth() { Width = "5259", Type = TableWidthUnitValues.Dxa };

            tableCellProperties4.Append(tableCellWidth4);

            Paragraph paragraph6 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties6 = new ParagraphProperties();
            Justification justification5 = new Justification() { Val = JustificationValues.Center };

            ParagraphMarkRunProperties paragraphMarkRunProperties6 = new ParagraphMarkRunProperties();
            RunFonts runFonts14 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold7 = new Bold();
            FontSize fontSize8 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript8 = new FontSizeComplexScript() { Val = "28" };
            Languages languages14 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties6.Append(runFonts14);
            paragraphMarkRunProperties6.Append(bold7);
            paragraphMarkRunProperties6.Append(fontSize8);
            paragraphMarkRunProperties6.Append(fontSizeComplexScript8);
            paragraphMarkRunProperties6.Append(languages14);

            paragraphProperties6.Append(justification5);
            paragraphProperties6.Append(paragraphMarkRunProperties6);

            Run run9 = new Run() { RsidRunProperties = "00B65E2F" };

            RunProperties runProperties9 = new RunProperties();
            RunFonts runFonts15 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold8 = new Bold();
            FontSize fontSize9 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript9 = new FontSizeComplexScript() { Val = "28" };
            Languages languages15 = new Languages() { Val = "ru-RU" };

            runProperties9.Append(runFonts15);
            runProperties9.Append(bold8);
            runProperties9.Append(fontSize9);
            runProperties9.Append(fontSizeComplexScript9);
            runProperties9.Append(languages15);
            Text text8 = new Text() { Space = SpaceProcessingModeValues.Preserve };
            text8.Text = "Перечень и содержание откорректированных разделов ";

            run9.Append(runProperties9);
            run9.Append(text8);

            Run run10 = new Run();

            RunProperties runProperties10 = new RunProperties();
            RunFonts runFonts16 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            Bold bold9 = new Bold();
            FontSize fontSize10 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript10 = new FontSizeComplexScript() { Val = "28" };
            Languages languages16 = new Languages() { Val = "ru-RU" };

            runProperties10.Append(runFonts16);
            runProperties10.Append(bold9);
            runProperties10.Append(fontSize10);
            runProperties10.Append(fontSizeComplexScript10);
            runProperties10.Append(languages16);
            Text text9 = new Text();
            text9.Text = "РПД";

            run10.Append(runProperties10);
            run10.Append(text9);

            paragraph6.Append(paragraphProperties6);
            paragraph6.Append(run9);
            paragraph6.Append(run10);

            tableCell4.Append(tableCellProperties4);
            tableCell4.Append(paragraph6);

            tableRow1.Append(tableCell1);
            tableRow1.Append(tableCell2);
            tableRow1.Append(tableCell3);
            tableRow1.Append(tableCell4);

            TableRow tableRow2 = new TableRow() { RsidTableRowMarkRevision = "00107D47", RsidTableRowAddition = "00E24EED", RsidTableRowProperties = "00BF6E08" };

            TableCell tableCell5 = new TableCell();

            TableCellProperties tableCellProperties5 = new TableCellProperties();
            TableCellWidth tableCellWidth5 = new TableCellWidth() { Width = "1565", Type = TableWidthUnitValues.Dxa };

            tableCellProperties5.Append(tableCellWidth5);

            Paragraph paragraph7 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties7 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines2 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification6 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties7 = new ParagraphMarkRunProperties();
            RunFonts runFonts17 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize11 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript11 = new FontSizeComplexScript() { Val = "28" };
            Languages languages17 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties7.Append(runFonts17);
            paragraphMarkRunProperties7.Append(fontSize11);
            paragraphMarkRunProperties7.Append(fontSizeComplexScript11);
            paragraphMarkRunProperties7.Append(languages17);

            paragraphProperties7.Append(spacingBetweenLines2);
            paragraphProperties7.Append(justification6);
            paragraphProperties7.Append(paragraphMarkRunProperties7);

            paragraph7.Append(paragraphProperties7);

            tableCell5.Append(tableCellProperties5);
            tableCell5.Append(paragraph7);

            TableCell tableCell6 = new TableCell();

            TableCellProperties tableCellProperties6 = new TableCellProperties();
            TableCellWidth tableCellWidth6 = new TableCellWidth() { Width = "1066", Type = TableWidthUnitValues.Dxa };

            tableCellProperties6.Append(tableCellWidth6);

            Paragraph paragraph8 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties8 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines3 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification7 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties8 = new ParagraphMarkRunProperties();
            RunFonts runFonts18 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize12 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript12 = new FontSizeComplexScript() { Val = "28" };
            Languages languages18 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties8.Append(runFonts18);
            paragraphMarkRunProperties8.Append(fontSize12);
            paragraphMarkRunProperties8.Append(fontSizeComplexScript12);
            paragraphMarkRunProperties8.Append(languages18);

            paragraphProperties8.Append(spacingBetweenLines3);
            paragraphProperties8.Append(justification7);
            paragraphProperties8.Append(paragraphMarkRunProperties8);

            paragraph8.Append(paragraphProperties8);

            tableCell6.Append(tableCellProperties6);
            tableCell6.Append(paragraph8);

            TableCell tableCell7 = new TableCell();

            TableCellProperties tableCellProperties7 = new TableCellProperties();
            TableCellWidth tableCellWidth7 = new TableCellWidth() { Width = "1917", Type = TableWidthUnitValues.Dxa };

            tableCellProperties7.Append(tableCellWidth7);

            Paragraph paragraph9 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties9 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines4 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification8 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties9 = new ParagraphMarkRunProperties();
            RunFonts runFonts19 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize13 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript13 = new FontSizeComplexScript() { Val = "28" };
            Languages languages19 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties9.Append(runFonts19);
            paragraphMarkRunProperties9.Append(fontSize13);
            paragraphMarkRunProperties9.Append(fontSizeComplexScript13);
            paragraphMarkRunProperties9.Append(languages19);

            paragraphProperties9.Append(spacingBetweenLines4);
            paragraphProperties9.Append(justification8);
            paragraphProperties9.Append(paragraphMarkRunProperties9);

            paragraph9.Append(paragraphProperties9);

            tableCell7.Append(tableCellProperties7);
            tableCell7.Append(paragraph9);

            TableCell tableCell8 = new TableCell();

            TableCellProperties tableCellProperties8 = new TableCellProperties();
            TableCellWidth tableCellWidth8 = new TableCellWidth() { Width = "5259", Type = TableWidthUnitValues.Dxa };

            tableCellProperties8.Append(tableCellWidth8);

            Paragraph paragraph10 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties10 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines5 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification9 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties10 = new ParagraphMarkRunProperties();
            RunFonts runFonts20 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize14 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript14 = new FontSizeComplexScript() { Val = "28" };
            Languages languages20 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties10.Append(runFonts20);
            paragraphMarkRunProperties10.Append(fontSize14);
            paragraphMarkRunProperties10.Append(fontSizeComplexScript14);
            paragraphMarkRunProperties10.Append(languages20);

            paragraphProperties10.Append(spacingBetweenLines5);
            paragraphProperties10.Append(justification9);
            paragraphProperties10.Append(paragraphMarkRunProperties10);

            paragraph10.Append(paragraphProperties10);

            tableCell8.Append(tableCellProperties8);
            tableCell8.Append(paragraph10);

            tableRow2.Append(tableCell5);
            tableRow2.Append(tableCell6);
            tableRow2.Append(tableCell7);
            tableRow2.Append(tableCell8);

            TableRow tableRow3 = new TableRow() { RsidTableRowMarkRevision = "00107D47", RsidTableRowAddition = "00E24EED", RsidTableRowProperties = "00BF6E08" };

            TableCell tableCell9 = new TableCell();

            TableCellProperties tableCellProperties9 = new TableCellProperties();
            TableCellWidth tableCellWidth9 = new TableCellWidth() { Width = "1565", Type = TableWidthUnitValues.Dxa };

            tableCellProperties9.Append(tableCellWidth9);

            Paragraph paragraph11 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties11 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines6 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification10 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties11 = new ParagraphMarkRunProperties();
            RunFonts runFonts21 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize15 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript15 = new FontSizeComplexScript() { Val = "28" };
            Languages languages21 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties11.Append(runFonts21);
            paragraphMarkRunProperties11.Append(fontSize15);
            paragraphMarkRunProperties11.Append(fontSizeComplexScript15);
            paragraphMarkRunProperties11.Append(languages21);

            paragraphProperties11.Append(spacingBetweenLines6);
            paragraphProperties11.Append(justification10);
            paragraphProperties11.Append(paragraphMarkRunProperties11);

            paragraph11.Append(paragraphProperties11);

            tableCell9.Append(tableCellProperties9);
            tableCell9.Append(paragraph11);

            TableCell tableCell10 = new TableCell();

            TableCellProperties tableCellProperties10 = new TableCellProperties();
            TableCellWidth tableCellWidth10 = new TableCellWidth() { Width = "1066", Type = TableWidthUnitValues.Dxa };

            tableCellProperties10.Append(tableCellWidth10);

            Paragraph paragraph12 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties12 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines7 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification11 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties12 = new ParagraphMarkRunProperties();
            RunFonts runFonts22 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize16 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript16 = new FontSizeComplexScript() { Val = "28" };
            Languages languages22 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties12.Append(runFonts22);
            paragraphMarkRunProperties12.Append(fontSize16);
            paragraphMarkRunProperties12.Append(fontSizeComplexScript16);
            paragraphMarkRunProperties12.Append(languages22);

            paragraphProperties12.Append(spacingBetweenLines7);
            paragraphProperties12.Append(justification11);
            paragraphProperties12.Append(paragraphMarkRunProperties12);

            paragraph12.Append(paragraphProperties12);

            tableCell10.Append(tableCellProperties10);
            tableCell10.Append(paragraph12);

            TableCell tableCell11 = new TableCell();

            TableCellProperties tableCellProperties11 = new TableCellProperties();
            TableCellWidth tableCellWidth11 = new TableCellWidth() { Width = "1917", Type = TableWidthUnitValues.Dxa };

            tableCellProperties11.Append(tableCellWidth11);

            Paragraph paragraph13 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties13 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines8 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification12 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties13 = new ParagraphMarkRunProperties();
            RunFonts runFonts23 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize17 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript17 = new FontSizeComplexScript() { Val = "28" };
            Languages languages23 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties13.Append(runFonts23);
            paragraphMarkRunProperties13.Append(fontSize17);
            paragraphMarkRunProperties13.Append(fontSizeComplexScript17);
            paragraphMarkRunProperties13.Append(languages23);

            paragraphProperties13.Append(spacingBetweenLines8);
            paragraphProperties13.Append(justification12);
            paragraphProperties13.Append(paragraphMarkRunProperties13);

            paragraph13.Append(paragraphProperties13);

            tableCell11.Append(tableCellProperties11);
            tableCell11.Append(paragraph13);

            TableCell tableCell12 = new TableCell();

            TableCellProperties tableCellProperties12 = new TableCellProperties();
            TableCellWidth tableCellWidth12 = new TableCellWidth() { Width = "5259", Type = TableWidthUnitValues.Dxa };

            tableCellProperties12.Append(tableCellWidth12);

            Paragraph paragraph14 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties14 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines9 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification13 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties14 = new ParagraphMarkRunProperties();
            RunFonts runFonts24 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize18 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript18 = new FontSizeComplexScript() { Val = "28" };
            Languages languages24 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties14.Append(runFonts24);
            paragraphMarkRunProperties14.Append(fontSize18);
            paragraphMarkRunProperties14.Append(fontSizeComplexScript18);
            paragraphMarkRunProperties14.Append(languages24);

            paragraphProperties14.Append(spacingBetweenLines9);
            paragraphProperties14.Append(justification13);
            paragraphProperties14.Append(paragraphMarkRunProperties14);

            paragraph14.Append(paragraphProperties14);

            tableCell12.Append(tableCellProperties12);
            tableCell12.Append(paragraph14);

            tableRow3.Append(tableCell9);
            tableRow3.Append(tableCell10);
            tableRow3.Append(tableCell11);
            tableRow3.Append(tableCell12);

            TableRow tableRow4 = new TableRow() { RsidTableRowMarkRevision = "00107D47", RsidTableRowAddition = "00E24EED", RsidTableRowProperties = "00BF6E08" };

            TableCell tableCell13 = new TableCell();

            TableCellProperties tableCellProperties13 = new TableCellProperties();
            TableCellWidth tableCellWidth13 = new TableCellWidth() { Width = "1565", Type = TableWidthUnitValues.Dxa };

            tableCellProperties13.Append(tableCellWidth13);

            Paragraph paragraph15 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties15 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines10 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification14 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties15 = new ParagraphMarkRunProperties();
            RunFonts runFonts25 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize19 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript19 = new FontSizeComplexScript() { Val = "28" };
            Languages languages25 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties15.Append(runFonts25);
            paragraphMarkRunProperties15.Append(fontSize19);
            paragraphMarkRunProperties15.Append(fontSizeComplexScript19);
            paragraphMarkRunProperties15.Append(languages25);

            paragraphProperties15.Append(spacingBetweenLines10);
            paragraphProperties15.Append(justification14);
            paragraphProperties15.Append(paragraphMarkRunProperties15);

            paragraph15.Append(paragraphProperties15);

            tableCell13.Append(tableCellProperties13);
            tableCell13.Append(paragraph15);

            TableCell tableCell14 = new TableCell();

            TableCellProperties tableCellProperties14 = new TableCellProperties();
            TableCellWidth tableCellWidth14 = new TableCellWidth() { Width = "1066", Type = TableWidthUnitValues.Dxa };

            tableCellProperties14.Append(tableCellWidth14);

            Paragraph paragraph16 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties16 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines11 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification15 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties16 = new ParagraphMarkRunProperties();
            RunFonts runFonts26 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize20 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript20 = new FontSizeComplexScript() { Val = "28" };
            Languages languages26 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties16.Append(runFonts26);
            paragraphMarkRunProperties16.Append(fontSize20);
            paragraphMarkRunProperties16.Append(fontSizeComplexScript20);
            paragraphMarkRunProperties16.Append(languages26);

            paragraphProperties16.Append(spacingBetweenLines11);
            paragraphProperties16.Append(justification15);
            paragraphProperties16.Append(paragraphMarkRunProperties16);

            paragraph16.Append(paragraphProperties16);

            tableCell14.Append(tableCellProperties14);
            tableCell14.Append(paragraph16);

            TableCell tableCell15 = new TableCell();

            TableCellProperties tableCellProperties15 = new TableCellProperties();
            TableCellWidth tableCellWidth15 = new TableCellWidth() { Width = "1917", Type = TableWidthUnitValues.Dxa };

            tableCellProperties15.Append(tableCellWidth15);

            Paragraph paragraph17 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties17 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines12 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification16 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties17 = new ParagraphMarkRunProperties();
            RunFonts runFonts27 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize21 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript21 = new FontSizeComplexScript() { Val = "28" };
            Languages languages27 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties17.Append(runFonts27);
            paragraphMarkRunProperties17.Append(fontSize21);
            paragraphMarkRunProperties17.Append(fontSizeComplexScript21);
            paragraphMarkRunProperties17.Append(languages27);

            paragraphProperties17.Append(spacingBetweenLines12);
            paragraphProperties17.Append(justification16);
            paragraphProperties17.Append(paragraphMarkRunProperties17);

            paragraph17.Append(paragraphProperties17);

            tableCell15.Append(tableCellProperties15);
            tableCell15.Append(paragraph17);

            TableCell tableCell16 = new TableCell();

            TableCellProperties tableCellProperties16 = new TableCellProperties();
            TableCellWidth tableCellWidth16 = new TableCellWidth() { Width = "5259", Type = TableWidthUnitValues.Dxa };

            tableCellProperties16.Append(tableCellWidth16);

            Paragraph paragraph18 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties18 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines13 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification17 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties18 = new ParagraphMarkRunProperties();
            RunFonts runFonts28 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize22 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript22 = new FontSizeComplexScript() { Val = "28" };
            Languages languages28 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties18.Append(runFonts28);
            paragraphMarkRunProperties18.Append(fontSize22);
            paragraphMarkRunProperties18.Append(fontSizeComplexScript22);
            paragraphMarkRunProperties18.Append(languages28);

            paragraphProperties18.Append(spacingBetweenLines13);
            paragraphProperties18.Append(justification17);
            paragraphProperties18.Append(paragraphMarkRunProperties18);

            paragraph18.Append(paragraphProperties18);

            tableCell16.Append(tableCellProperties16);
            tableCell16.Append(paragraph18);

            tableRow4.Append(tableCell13);
            tableRow4.Append(tableCell14);
            tableRow4.Append(tableCell15);
            tableRow4.Append(tableCell16);

            TableRow tableRow5 = new TableRow() { RsidTableRowMarkRevision = "00107D47", RsidTableRowAddition = "00E24EED", RsidTableRowProperties = "00BF6E08" };

            TableCell tableCell17 = new TableCell();

            TableCellProperties tableCellProperties17 = new TableCellProperties();
            TableCellWidth tableCellWidth17 = new TableCellWidth() { Width = "1565", Type = TableWidthUnitValues.Dxa };

            tableCellProperties17.Append(tableCellWidth17);

            Paragraph paragraph19 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties19 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines14 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification18 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties19 = new ParagraphMarkRunProperties();
            RunFonts runFonts29 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize23 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript23 = new FontSizeComplexScript() { Val = "28" };
            Languages languages29 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties19.Append(runFonts29);
            paragraphMarkRunProperties19.Append(fontSize23);
            paragraphMarkRunProperties19.Append(fontSizeComplexScript23);
            paragraphMarkRunProperties19.Append(languages29);

            paragraphProperties19.Append(spacingBetweenLines14);
            paragraphProperties19.Append(justification18);
            paragraphProperties19.Append(paragraphMarkRunProperties19);

            paragraph19.Append(paragraphProperties19);

            tableCell17.Append(tableCellProperties17);
            tableCell17.Append(paragraph19);

            TableCell tableCell18 = new TableCell();

            TableCellProperties tableCellProperties18 = new TableCellProperties();
            TableCellWidth tableCellWidth18 = new TableCellWidth() { Width = "1066", Type = TableWidthUnitValues.Dxa };

            tableCellProperties18.Append(tableCellWidth18);

            Paragraph paragraph20 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties20 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines15 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification19 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties20 = new ParagraphMarkRunProperties();
            RunFonts runFonts30 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize24 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript24 = new FontSizeComplexScript() { Val = "28" };
            Languages languages30 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties20.Append(runFonts30);
            paragraphMarkRunProperties20.Append(fontSize24);
            paragraphMarkRunProperties20.Append(fontSizeComplexScript24);
            paragraphMarkRunProperties20.Append(languages30);

            paragraphProperties20.Append(spacingBetweenLines15);
            paragraphProperties20.Append(justification19);
            paragraphProperties20.Append(paragraphMarkRunProperties20);

            paragraph20.Append(paragraphProperties20);

            tableCell18.Append(tableCellProperties18);
            tableCell18.Append(paragraph20);

            TableCell tableCell19 = new TableCell();

            TableCellProperties tableCellProperties19 = new TableCellProperties();
            TableCellWidth tableCellWidth19 = new TableCellWidth() { Width = "1917", Type = TableWidthUnitValues.Dxa };

            tableCellProperties19.Append(tableCellWidth19);

            Paragraph paragraph21 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties21 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines16 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification20 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties21 = new ParagraphMarkRunProperties();
            RunFonts runFonts31 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize25 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript25 = new FontSizeComplexScript() { Val = "28" };
            Languages languages31 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties21.Append(runFonts31);
            paragraphMarkRunProperties21.Append(fontSize25);
            paragraphMarkRunProperties21.Append(fontSizeComplexScript25);
            paragraphMarkRunProperties21.Append(languages31);

            paragraphProperties21.Append(spacingBetweenLines16);
            paragraphProperties21.Append(justification20);
            paragraphProperties21.Append(paragraphMarkRunProperties21);

            paragraph21.Append(paragraphProperties21);

            tableCell19.Append(tableCellProperties19);
            tableCell19.Append(paragraph21);

            TableCell tableCell20 = new TableCell();

            TableCellProperties tableCellProperties20 = new TableCellProperties();
            TableCellWidth tableCellWidth20 = new TableCellWidth() { Width = "5259", Type = TableWidthUnitValues.Dxa };

            tableCellProperties20.Append(tableCellWidth20);

            Paragraph paragraph22 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties22 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines17 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification21 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties22 = new ParagraphMarkRunProperties();
            RunFonts runFonts32 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize26 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript26 = new FontSizeComplexScript() { Val = "28" };
            Languages languages32 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties22.Append(runFonts32);
            paragraphMarkRunProperties22.Append(fontSize26);
            paragraphMarkRunProperties22.Append(fontSizeComplexScript26);
            paragraphMarkRunProperties22.Append(languages32);

            paragraphProperties22.Append(spacingBetweenLines17);
            paragraphProperties22.Append(justification21);
            paragraphProperties22.Append(paragraphMarkRunProperties22);

            paragraph22.Append(paragraphProperties22);

            tableCell20.Append(tableCellProperties20);
            tableCell20.Append(paragraph22);

            tableRow5.Append(tableCell17);
            tableRow5.Append(tableCell18);
            tableRow5.Append(tableCell19);
            tableRow5.Append(tableCell20);

            TableRow tableRow6 = new TableRow() { RsidTableRowMarkRevision = "00107D47", RsidTableRowAddition = "00E24EED", RsidTableRowProperties = "00BF6E08" };

            TableCell tableCell21 = new TableCell();

            TableCellProperties tableCellProperties21 = new TableCellProperties();
            TableCellWidth tableCellWidth21 = new TableCellWidth() { Width = "1565", Type = TableWidthUnitValues.Dxa };

            tableCellProperties21.Append(tableCellWidth21);

            Paragraph paragraph23 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties23 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines18 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification22 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties23 = new ParagraphMarkRunProperties();
            RunFonts runFonts33 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize27 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript27 = new FontSizeComplexScript() { Val = "28" };
            Languages languages33 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties23.Append(runFonts33);
            paragraphMarkRunProperties23.Append(fontSize27);
            paragraphMarkRunProperties23.Append(fontSizeComplexScript27);
            paragraphMarkRunProperties23.Append(languages33);

            paragraphProperties23.Append(spacingBetweenLines18);
            paragraphProperties23.Append(justification22);
            paragraphProperties23.Append(paragraphMarkRunProperties23);

            paragraph23.Append(paragraphProperties23);

            tableCell21.Append(tableCellProperties21);
            tableCell21.Append(paragraph23);

            TableCell tableCell22 = new TableCell();

            TableCellProperties tableCellProperties22 = new TableCellProperties();
            TableCellWidth tableCellWidth22 = new TableCellWidth() { Width = "1066", Type = TableWidthUnitValues.Dxa };

            tableCellProperties22.Append(tableCellWidth22);

            Paragraph paragraph24 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties24 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines19 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification23 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties24 = new ParagraphMarkRunProperties();
            RunFonts runFonts34 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize28 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript28 = new FontSizeComplexScript() { Val = "28" };
            Languages languages34 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties24.Append(runFonts34);
            paragraphMarkRunProperties24.Append(fontSize28);
            paragraphMarkRunProperties24.Append(fontSizeComplexScript28);
            paragraphMarkRunProperties24.Append(languages34);

            paragraphProperties24.Append(spacingBetweenLines19);
            paragraphProperties24.Append(justification23);
            paragraphProperties24.Append(paragraphMarkRunProperties24);

            paragraph24.Append(paragraphProperties24);

            tableCell22.Append(tableCellProperties22);
            tableCell22.Append(paragraph24);

            TableCell tableCell23 = new TableCell();

            TableCellProperties tableCellProperties23 = new TableCellProperties();
            TableCellWidth tableCellWidth23 = new TableCellWidth() { Width = "1917", Type = TableWidthUnitValues.Dxa };

            tableCellProperties23.Append(tableCellWidth23);

            Paragraph paragraph25 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties25 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines20 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification24 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties25 = new ParagraphMarkRunProperties();
            RunFonts runFonts35 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize29 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript29 = new FontSizeComplexScript() { Val = "28" };
            Languages languages35 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties25.Append(runFonts35);
            paragraphMarkRunProperties25.Append(fontSize29);
            paragraphMarkRunProperties25.Append(fontSizeComplexScript29);
            paragraphMarkRunProperties25.Append(languages35);

            paragraphProperties25.Append(spacingBetweenLines20);
            paragraphProperties25.Append(justification24);
            paragraphProperties25.Append(paragraphMarkRunProperties25);

            paragraph25.Append(paragraphProperties25);

            tableCell23.Append(tableCellProperties23);
            tableCell23.Append(paragraph25);

            TableCell tableCell24 = new TableCell();

            TableCellProperties tableCellProperties24 = new TableCellProperties();
            TableCellWidth tableCellWidth24 = new TableCellWidth() { Width = "5259", Type = TableWidthUnitValues.Dxa };

            tableCellProperties24.Append(tableCellWidth24);

            Paragraph paragraph26 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties26 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines21 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification25 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties26 = new ParagraphMarkRunProperties();
            RunFonts runFonts36 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize30 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript30 = new FontSizeComplexScript() { Val = "28" };
            Languages languages36 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties26.Append(runFonts36);
            paragraphMarkRunProperties26.Append(fontSize30);
            paragraphMarkRunProperties26.Append(fontSizeComplexScript30);
            paragraphMarkRunProperties26.Append(languages36);

            paragraphProperties26.Append(spacingBetweenLines21);
            paragraphProperties26.Append(justification25);
            paragraphProperties26.Append(paragraphMarkRunProperties26);

            paragraph26.Append(paragraphProperties26);

            tableCell24.Append(tableCellProperties24);
            tableCell24.Append(paragraph26);

            tableRow6.Append(tableCell21);
            tableRow6.Append(tableCell22);
            tableRow6.Append(tableCell23);
            tableRow6.Append(tableCell24);

            TableRow tableRow7 = new TableRow() { RsidTableRowMarkRevision = "00107D47", RsidTableRowAddition = "00E24EED", RsidTableRowProperties = "00BF6E08" };

            TableCell tableCell25 = new TableCell();

            TableCellProperties tableCellProperties25 = new TableCellProperties();
            TableCellWidth tableCellWidth25 = new TableCellWidth() { Width = "1565", Type = TableWidthUnitValues.Dxa };

            tableCellProperties25.Append(tableCellWidth25);

            Paragraph paragraph27 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties27 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines22 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification26 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties27 = new ParagraphMarkRunProperties();
            RunFonts runFonts37 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize31 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript31 = new FontSizeComplexScript() { Val = "28" };
            Languages languages37 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties27.Append(runFonts37);
            paragraphMarkRunProperties27.Append(fontSize31);
            paragraphMarkRunProperties27.Append(fontSizeComplexScript31);
            paragraphMarkRunProperties27.Append(languages37);

            paragraphProperties27.Append(spacingBetweenLines22);
            paragraphProperties27.Append(justification26);
            paragraphProperties27.Append(paragraphMarkRunProperties27);

            paragraph27.Append(paragraphProperties27);

            tableCell25.Append(tableCellProperties25);
            tableCell25.Append(paragraph27);

            TableCell tableCell26 = new TableCell();

            TableCellProperties tableCellProperties26 = new TableCellProperties();
            TableCellWidth tableCellWidth26 = new TableCellWidth() { Width = "1066", Type = TableWidthUnitValues.Dxa };

            tableCellProperties26.Append(tableCellWidth26);

            Paragraph paragraph28 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties28 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines23 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification27 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties28 = new ParagraphMarkRunProperties();
            RunFonts runFonts38 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize32 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript32 = new FontSizeComplexScript() { Val = "28" };
            Languages languages38 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties28.Append(runFonts38);
            paragraphMarkRunProperties28.Append(fontSize32);
            paragraphMarkRunProperties28.Append(fontSizeComplexScript32);
            paragraphMarkRunProperties28.Append(languages38);

            paragraphProperties28.Append(spacingBetweenLines23);
            paragraphProperties28.Append(justification27);
            paragraphProperties28.Append(paragraphMarkRunProperties28);

            paragraph28.Append(paragraphProperties28);

            tableCell26.Append(tableCellProperties26);
            tableCell26.Append(paragraph28);

            TableCell tableCell27 = new TableCell();

            TableCellProperties tableCellProperties27 = new TableCellProperties();
            TableCellWidth tableCellWidth27 = new TableCellWidth() { Width = "1917", Type = TableWidthUnitValues.Dxa };

            tableCellProperties27.Append(tableCellWidth27);

            Paragraph paragraph29 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties29 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines24 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification28 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties29 = new ParagraphMarkRunProperties();
            RunFonts runFonts39 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize33 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript33 = new FontSizeComplexScript() { Val = "28" };
            Languages languages39 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties29.Append(runFonts39);
            paragraphMarkRunProperties29.Append(fontSize33);
            paragraphMarkRunProperties29.Append(fontSizeComplexScript33);
            paragraphMarkRunProperties29.Append(languages39);

            paragraphProperties29.Append(spacingBetweenLines24);
            paragraphProperties29.Append(justification28);
            paragraphProperties29.Append(paragraphMarkRunProperties29);

            paragraph29.Append(paragraphProperties29);

            tableCell27.Append(tableCellProperties27);
            tableCell27.Append(paragraph29);

            TableCell tableCell28 = new TableCell();

            TableCellProperties tableCellProperties28 = new TableCellProperties();
            TableCellWidth tableCellWidth28 = new TableCellWidth() { Width = "5259", Type = TableWidthUnitValues.Dxa };

            tableCellProperties28.Append(tableCellWidth28);

            Paragraph paragraph30 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties30 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines25 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification29 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties30 = new ParagraphMarkRunProperties();
            RunFonts runFonts40 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize34 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript34 = new FontSizeComplexScript() { Val = "28" };
            Languages languages40 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties30.Append(runFonts40);
            paragraphMarkRunProperties30.Append(fontSize34);
            paragraphMarkRunProperties30.Append(fontSizeComplexScript34);
            paragraphMarkRunProperties30.Append(languages40);

            paragraphProperties30.Append(spacingBetweenLines25);
            paragraphProperties30.Append(justification29);
            paragraphProperties30.Append(paragraphMarkRunProperties30);

            paragraph30.Append(paragraphProperties30);

            tableCell28.Append(tableCellProperties28);
            tableCell28.Append(paragraph30);

            tableRow7.Append(tableCell25);
            tableRow7.Append(tableCell26);
            tableRow7.Append(tableCell27);
            tableRow7.Append(tableCell28);

            TableRow tableRow8 = new TableRow() { RsidTableRowMarkRevision = "00107D47", RsidTableRowAddition = "00E24EED", RsidTableRowProperties = "00BF6E08" };

            TableCell tableCell29 = new TableCell();

            TableCellProperties tableCellProperties29 = new TableCellProperties();
            TableCellWidth tableCellWidth29 = new TableCellWidth() { Width = "1565", Type = TableWidthUnitValues.Dxa };

            tableCellProperties29.Append(tableCellWidth29);

            Paragraph paragraph31 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties31 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines26 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification30 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties31 = new ParagraphMarkRunProperties();
            RunFonts runFonts41 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize35 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript35 = new FontSizeComplexScript() { Val = "28" };
            Languages languages41 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties31.Append(runFonts41);
            paragraphMarkRunProperties31.Append(fontSize35);
            paragraphMarkRunProperties31.Append(fontSizeComplexScript35);
            paragraphMarkRunProperties31.Append(languages41);

            paragraphProperties31.Append(spacingBetweenLines26);
            paragraphProperties31.Append(justification30);
            paragraphProperties31.Append(paragraphMarkRunProperties31);

            paragraph31.Append(paragraphProperties31);

            tableCell29.Append(tableCellProperties29);
            tableCell29.Append(paragraph31);

            TableCell tableCell30 = new TableCell();

            TableCellProperties tableCellProperties30 = new TableCellProperties();
            TableCellWidth tableCellWidth30 = new TableCellWidth() { Width = "1066", Type = TableWidthUnitValues.Dxa };

            tableCellProperties30.Append(tableCellWidth30);

            Paragraph paragraph32 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties32 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines27 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification31 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties32 = new ParagraphMarkRunProperties();
            RunFonts runFonts42 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize36 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript36 = new FontSizeComplexScript() { Val = "28" };
            Languages languages42 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties32.Append(runFonts42);
            paragraphMarkRunProperties32.Append(fontSize36);
            paragraphMarkRunProperties32.Append(fontSizeComplexScript36);
            paragraphMarkRunProperties32.Append(languages42);

            paragraphProperties32.Append(spacingBetweenLines27);
            paragraphProperties32.Append(justification31);
            paragraphProperties32.Append(paragraphMarkRunProperties32);

            paragraph32.Append(paragraphProperties32);

            tableCell30.Append(tableCellProperties30);
            tableCell30.Append(paragraph32);

            TableCell tableCell31 = new TableCell();

            TableCellProperties tableCellProperties31 = new TableCellProperties();
            TableCellWidth tableCellWidth31 = new TableCellWidth() { Width = "1917", Type = TableWidthUnitValues.Dxa };

            tableCellProperties31.Append(tableCellWidth31);

            Paragraph paragraph33 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties33 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines28 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification32 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties33 = new ParagraphMarkRunProperties();
            RunFonts runFonts43 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize37 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript37 = new FontSizeComplexScript() { Val = "28" };
            Languages languages43 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties33.Append(runFonts43);
            paragraphMarkRunProperties33.Append(fontSize37);
            paragraphMarkRunProperties33.Append(fontSizeComplexScript37);
            paragraphMarkRunProperties33.Append(languages43);

            paragraphProperties33.Append(spacingBetweenLines28);
            paragraphProperties33.Append(justification32);
            paragraphProperties33.Append(paragraphMarkRunProperties33);

            paragraph33.Append(paragraphProperties33);

            tableCell31.Append(tableCellProperties31);
            tableCell31.Append(paragraph33);

            TableCell tableCell32 = new TableCell();

            TableCellProperties tableCellProperties32 = new TableCellProperties();
            TableCellWidth tableCellWidth32 = new TableCellWidth() { Width = "5259", Type = TableWidthUnitValues.Dxa };

            tableCellProperties32.Append(tableCellWidth32);

            Paragraph paragraph34 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties34 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines29 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification33 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties34 = new ParagraphMarkRunProperties();
            RunFonts runFonts44 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize38 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript38 = new FontSizeComplexScript() { Val = "28" };
            Languages languages44 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties34.Append(runFonts44);
            paragraphMarkRunProperties34.Append(fontSize38);
            paragraphMarkRunProperties34.Append(fontSizeComplexScript38);
            paragraphMarkRunProperties34.Append(languages44);

            paragraphProperties34.Append(spacingBetweenLines29);
            paragraphProperties34.Append(justification33);
            paragraphProperties34.Append(paragraphMarkRunProperties34);

            paragraph34.Append(paragraphProperties34);

            tableCell32.Append(tableCellProperties32);
            tableCell32.Append(paragraph34);

            tableRow8.Append(tableCell29);
            tableRow8.Append(tableCell30);
            tableRow8.Append(tableCell31);
            tableRow8.Append(tableCell32);

            TableRow tableRow9 = new TableRow() { RsidTableRowMarkRevision = "00107D47", RsidTableRowAddition = "00E24EED", RsidTableRowProperties = "00BF6E08" };

            TableCell tableCell33 = new TableCell();

            TableCellProperties tableCellProperties33 = new TableCellProperties();
            TableCellWidth tableCellWidth33 = new TableCellWidth() { Width = "1565", Type = TableWidthUnitValues.Dxa };

            tableCellProperties33.Append(tableCellWidth33);

            Paragraph paragraph35 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties35 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines30 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification34 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties35 = new ParagraphMarkRunProperties();
            RunFonts runFonts45 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize39 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript39 = new FontSizeComplexScript() { Val = "28" };
            Languages languages45 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties35.Append(runFonts45);
            paragraphMarkRunProperties35.Append(fontSize39);
            paragraphMarkRunProperties35.Append(fontSizeComplexScript39);
            paragraphMarkRunProperties35.Append(languages45);

            paragraphProperties35.Append(spacingBetweenLines30);
            paragraphProperties35.Append(justification34);
            paragraphProperties35.Append(paragraphMarkRunProperties35);

            paragraph35.Append(paragraphProperties35);

            tableCell33.Append(tableCellProperties33);
            tableCell33.Append(paragraph35);

            TableCell tableCell34 = new TableCell();

            TableCellProperties tableCellProperties34 = new TableCellProperties();
            TableCellWidth tableCellWidth34 = new TableCellWidth() { Width = "1066", Type = TableWidthUnitValues.Dxa };

            tableCellProperties34.Append(tableCellWidth34);

            Paragraph paragraph36 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties36 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines31 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification35 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties36 = new ParagraphMarkRunProperties();
            RunFonts runFonts46 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize40 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript40 = new FontSizeComplexScript() { Val = "28" };
            Languages languages46 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties36.Append(runFonts46);
            paragraphMarkRunProperties36.Append(fontSize40);
            paragraphMarkRunProperties36.Append(fontSizeComplexScript40);
            paragraphMarkRunProperties36.Append(languages46);

            paragraphProperties36.Append(spacingBetweenLines31);
            paragraphProperties36.Append(justification35);
            paragraphProperties36.Append(paragraphMarkRunProperties36);

            paragraph36.Append(paragraphProperties36);

            tableCell34.Append(tableCellProperties34);
            tableCell34.Append(paragraph36);

            TableCell tableCell35 = new TableCell();

            TableCellProperties tableCellProperties35 = new TableCellProperties();
            TableCellWidth tableCellWidth35 = new TableCellWidth() { Width = "1917", Type = TableWidthUnitValues.Dxa };

            tableCellProperties35.Append(tableCellWidth35);

            Paragraph paragraph37 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties37 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines32 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification36 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties37 = new ParagraphMarkRunProperties();
            RunFonts runFonts47 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize41 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript41 = new FontSizeComplexScript() { Val = "28" };
            Languages languages47 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties37.Append(runFonts47);
            paragraphMarkRunProperties37.Append(fontSize41);
            paragraphMarkRunProperties37.Append(fontSizeComplexScript41);
            paragraphMarkRunProperties37.Append(languages47);

            paragraphProperties37.Append(spacingBetweenLines32);
            paragraphProperties37.Append(justification36);
            paragraphProperties37.Append(paragraphMarkRunProperties37);

            paragraph37.Append(paragraphProperties37);

            tableCell35.Append(tableCellProperties35);
            tableCell35.Append(paragraph37);

            TableCell tableCell36 = new TableCell();

            TableCellProperties tableCellProperties36 = new TableCellProperties();
            TableCellWidth tableCellWidth36 = new TableCellWidth() { Width = "5259", Type = TableWidthUnitValues.Dxa };

            tableCellProperties36.Append(tableCellWidth36);

            Paragraph paragraph38 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties38 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines33 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification37 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties38 = new ParagraphMarkRunProperties();
            RunFonts runFonts48 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize42 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript42 = new FontSizeComplexScript() { Val = "28" };
            Languages languages48 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties38.Append(runFonts48);
            paragraphMarkRunProperties38.Append(fontSize42);
            paragraphMarkRunProperties38.Append(fontSizeComplexScript42);
            paragraphMarkRunProperties38.Append(languages48);

            paragraphProperties38.Append(spacingBetweenLines33);
            paragraphProperties38.Append(justification37);
            paragraphProperties38.Append(paragraphMarkRunProperties38);

            paragraph38.Append(paragraphProperties38);

            tableCell36.Append(tableCellProperties36);
            tableCell36.Append(paragraph38);

            tableRow9.Append(tableCell33);
            tableRow9.Append(tableCell34);
            tableRow9.Append(tableCell35);
            tableRow9.Append(tableCell36);

            TableRow tableRow10 = new TableRow() { RsidTableRowMarkRevision = "00107D47", RsidTableRowAddition = "00E24EED", RsidTableRowProperties = "00BF6E08" };

            TableCell tableCell37 = new TableCell();

            TableCellProperties tableCellProperties37 = new TableCellProperties();
            TableCellWidth tableCellWidth37 = new TableCellWidth() { Width = "1565", Type = TableWidthUnitValues.Dxa };

            tableCellProperties37.Append(tableCellWidth37);

            Paragraph paragraph39 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties39 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines34 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification38 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties39 = new ParagraphMarkRunProperties();
            RunFonts runFonts49 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize43 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript43 = new FontSizeComplexScript() { Val = "28" };
            Languages languages49 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties39.Append(runFonts49);
            paragraphMarkRunProperties39.Append(fontSize43);
            paragraphMarkRunProperties39.Append(fontSizeComplexScript43);
            paragraphMarkRunProperties39.Append(languages49);

            paragraphProperties39.Append(spacingBetweenLines34);
            paragraphProperties39.Append(justification38);
            paragraphProperties39.Append(paragraphMarkRunProperties39);

            paragraph39.Append(paragraphProperties39);

            tableCell37.Append(tableCellProperties37);
            tableCell37.Append(paragraph39);

            TableCell tableCell38 = new TableCell();

            TableCellProperties tableCellProperties38 = new TableCellProperties();
            TableCellWidth tableCellWidth38 = new TableCellWidth() { Width = "1066", Type = TableWidthUnitValues.Dxa };

            tableCellProperties38.Append(tableCellWidth38);

            Paragraph paragraph40 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties40 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines35 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification39 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties40 = new ParagraphMarkRunProperties();
            RunFonts runFonts50 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize44 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript44 = new FontSizeComplexScript() { Val = "28" };
            Languages languages50 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties40.Append(runFonts50);
            paragraphMarkRunProperties40.Append(fontSize44);
            paragraphMarkRunProperties40.Append(fontSizeComplexScript44);
            paragraphMarkRunProperties40.Append(languages50);

            paragraphProperties40.Append(spacingBetweenLines35);
            paragraphProperties40.Append(justification39);
            paragraphProperties40.Append(paragraphMarkRunProperties40);

            paragraph40.Append(paragraphProperties40);

            tableCell38.Append(tableCellProperties38);
            tableCell38.Append(paragraph40);

            TableCell tableCell39 = new TableCell();

            TableCellProperties tableCellProperties39 = new TableCellProperties();
            TableCellWidth tableCellWidth39 = new TableCellWidth() { Width = "1917", Type = TableWidthUnitValues.Dxa };

            tableCellProperties39.Append(tableCellWidth39);

            Paragraph paragraph41 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties41 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines36 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification40 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties41 = new ParagraphMarkRunProperties();
            RunFonts runFonts51 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize45 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript45 = new FontSizeComplexScript() { Val = "28" };
            Languages languages51 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties41.Append(runFonts51);
            paragraphMarkRunProperties41.Append(fontSize45);
            paragraphMarkRunProperties41.Append(fontSizeComplexScript45);
            paragraphMarkRunProperties41.Append(languages51);

            paragraphProperties41.Append(spacingBetweenLines36);
            paragraphProperties41.Append(justification40);
            paragraphProperties41.Append(paragraphMarkRunProperties41);

            paragraph41.Append(paragraphProperties41);

            tableCell39.Append(tableCellProperties39);
            tableCell39.Append(paragraph41);

            TableCell tableCell40 = new TableCell();

            TableCellProperties tableCellProperties40 = new TableCellProperties();
            TableCellWidth tableCellWidth40 = new TableCellWidth() { Width = "5259", Type = TableWidthUnitValues.Dxa };

            tableCellProperties40.Append(tableCellWidth40);

            Paragraph paragraph42 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties42 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines37 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification41 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties42 = new ParagraphMarkRunProperties();
            RunFonts runFonts52 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize46 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript46 = new FontSizeComplexScript() { Val = "28" };
            Languages languages52 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties42.Append(runFonts52);
            paragraphMarkRunProperties42.Append(fontSize46);
            paragraphMarkRunProperties42.Append(fontSizeComplexScript46);
            paragraphMarkRunProperties42.Append(languages52);

            paragraphProperties42.Append(spacingBetweenLines37);
            paragraphProperties42.Append(justification41);
            paragraphProperties42.Append(paragraphMarkRunProperties42);

            paragraph42.Append(paragraphProperties42);

            tableCell40.Append(tableCellProperties40);
            tableCell40.Append(paragraph42);

            tableRow10.Append(tableCell37);
            tableRow10.Append(tableCell38);
            tableRow10.Append(tableCell39);
            tableRow10.Append(tableCell40);

            TableRow tableRow11 = new TableRow() { RsidTableRowMarkRevision = "00107D47", RsidTableRowAddition = "00E24EED", RsidTableRowProperties = "00BF6E08" };

            TableCell tableCell41 = new TableCell();

            TableCellProperties tableCellProperties41 = new TableCellProperties();
            TableCellWidth tableCellWidth41 = new TableCellWidth() { Width = "1565", Type = TableWidthUnitValues.Dxa };

            tableCellProperties41.Append(tableCellWidth41);

            Paragraph paragraph43 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties43 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines38 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification42 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties43 = new ParagraphMarkRunProperties();
            RunFonts runFonts53 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize47 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript47 = new FontSizeComplexScript() { Val = "28" };
            Languages languages53 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties43.Append(runFonts53);
            paragraphMarkRunProperties43.Append(fontSize47);
            paragraphMarkRunProperties43.Append(fontSizeComplexScript47);
            paragraphMarkRunProperties43.Append(languages53);

            paragraphProperties43.Append(spacingBetweenLines38);
            paragraphProperties43.Append(justification42);
            paragraphProperties43.Append(paragraphMarkRunProperties43);

            paragraph43.Append(paragraphProperties43);

            tableCell41.Append(tableCellProperties41);
            tableCell41.Append(paragraph43);

            TableCell tableCell42 = new TableCell();

            TableCellProperties tableCellProperties42 = new TableCellProperties();
            TableCellWidth tableCellWidth42 = new TableCellWidth() { Width = "1066", Type = TableWidthUnitValues.Dxa };

            tableCellProperties42.Append(tableCellWidth42);

            Paragraph paragraph44 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties44 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines39 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification43 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties44 = new ParagraphMarkRunProperties();
            RunFonts runFonts54 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize48 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript48 = new FontSizeComplexScript() { Val = "28" };
            Languages languages54 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties44.Append(runFonts54);
            paragraphMarkRunProperties44.Append(fontSize48);
            paragraphMarkRunProperties44.Append(fontSizeComplexScript48);
            paragraphMarkRunProperties44.Append(languages54);

            paragraphProperties44.Append(spacingBetweenLines39);
            paragraphProperties44.Append(justification43);
            paragraphProperties44.Append(paragraphMarkRunProperties44);

            paragraph44.Append(paragraphProperties44);

            tableCell42.Append(tableCellProperties42);
            tableCell42.Append(paragraph44);

            TableCell tableCell43 = new TableCell();

            TableCellProperties tableCellProperties43 = new TableCellProperties();
            TableCellWidth tableCellWidth43 = new TableCellWidth() { Width = "1917", Type = TableWidthUnitValues.Dxa };

            tableCellProperties43.Append(tableCellWidth43);

            Paragraph paragraph45 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties45 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines40 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification44 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties45 = new ParagraphMarkRunProperties();
            RunFonts runFonts55 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize49 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript49 = new FontSizeComplexScript() { Val = "28" };
            Languages languages55 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties45.Append(runFonts55);
            paragraphMarkRunProperties45.Append(fontSize49);
            paragraphMarkRunProperties45.Append(fontSizeComplexScript49);
            paragraphMarkRunProperties45.Append(languages55);

            paragraphProperties45.Append(spacingBetweenLines40);
            paragraphProperties45.Append(justification44);
            paragraphProperties45.Append(paragraphMarkRunProperties45);

            paragraph45.Append(paragraphProperties45);

            tableCell43.Append(tableCellProperties43);
            tableCell43.Append(paragraph45);

            TableCell tableCell44 = new TableCell();

            TableCellProperties tableCellProperties44 = new TableCellProperties();
            TableCellWidth tableCellWidth44 = new TableCellWidth() { Width = "5259", Type = TableWidthUnitValues.Dxa };

            tableCellProperties44.Append(tableCellWidth44);

            Paragraph paragraph46 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties46 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines41 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification45 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties46 = new ParagraphMarkRunProperties();
            RunFonts runFonts56 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize50 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript50 = new FontSizeComplexScript() { Val = "28" };
            Languages languages56 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties46.Append(runFonts56);
            paragraphMarkRunProperties46.Append(fontSize50);
            paragraphMarkRunProperties46.Append(fontSizeComplexScript50);
            paragraphMarkRunProperties46.Append(languages56);

            paragraphProperties46.Append(spacingBetweenLines41);
            paragraphProperties46.Append(justification45);
            paragraphProperties46.Append(paragraphMarkRunProperties46);

            paragraph46.Append(paragraphProperties46);

            tableCell44.Append(tableCellProperties44);
            tableCell44.Append(paragraph46);

            tableRow11.Append(tableCell41);
            tableRow11.Append(tableCell42);
            tableRow11.Append(tableCell43);
            tableRow11.Append(tableCell44);

            TableRow tableRow12 = new TableRow() { RsidTableRowMarkRevision = "00107D47", RsidTableRowAddition = "00E24EED", RsidTableRowProperties = "00BF6E08" };

            TableCell tableCell45 = new TableCell();

            TableCellProperties tableCellProperties45 = new TableCellProperties();
            TableCellWidth tableCellWidth45 = new TableCellWidth() { Width = "1565", Type = TableWidthUnitValues.Dxa };

            tableCellProperties45.Append(tableCellWidth45);

            Paragraph paragraph47 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties47 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines42 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification46 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties47 = new ParagraphMarkRunProperties();
            RunFonts runFonts57 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize51 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript51 = new FontSizeComplexScript() { Val = "28" };
            Languages languages57 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties47.Append(runFonts57);
            paragraphMarkRunProperties47.Append(fontSize51);
            paragraphMarkRunProperties47.Append(fontSizeComplexScript51);
            paragraphMarkRunProperties47.Append(languages57);

            paragraphProperties47.Append(spacingBetweenLines42);
            paragraphProperties47.Append(justification46);
            paragraphProperties47.Append(paragraphMarkRunProperties47);

            paragraph47.Append(paragraphProperties47);

            tableCell45.Append(tableCellProperties45);
            tableCell45.Append(paragraph47);

            TableCell tableCell46 = new TableCell();

            TableCellProperties tableCellProperties46 = new TableCellProperties();
            TableCellWidth tableCellWidth46 = new TableCellWidth() { Width = "1066", Type = TableWidthUnitValues.Dxa };

            tableCellProperties46.Append(tableCellWidth46);

            Paragraph paragraph48 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties48 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines43 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification47 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties48 = new ParagraphMarkRunProperties();
            RunFonts runFonts58 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize52 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript52 = new FontSizeComplexScript() { Val = "28" };
            Languages languages58 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties48.Append(runFonts58);
            paragraphMarkRunProperties48.Append(fontSize52);
            paragraphMarkRunProperties48.Append(fontSizeComplexScript52);
            paragraphMarkRunProperties48.Append(languages58);

            paragraphProperties48.Append(spacingBetweenLines43);
            paragraphProperties48.Append(justification47);
            paragraphProperties48.Append(paragraphMarkRunProperties48);

            paragraph48.Append(paragraphProperties48);

            tableCell46.Append(tableCellProperties46);
            tableCell46.Append(paragraph48);

            TableCell tableCell47 = new TableCell();

            TableCellProperties tableCellProperties47 = new TableCellProperties();
            TableCellWidth tableCellWidth47 = new TableCellWidth() { Width = "1917", Type = TableWidthUnitValues.Dxa };

            tableCellProperties47.Append(tableCellWidth47);

            Paragraph paragraph49 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties49 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines44 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification48 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties49 = new ParagraphMarkRunProperties();
            RunFonts runFonts59 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize53 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript53 = new FontSizeComplexScript() { Val = "28" };
            Languages languages59 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties49.Append(runFonts59);
            paragraphMarkRunProperties49.Append(fontSize53);
            paragraphMarkRunProperties49.Append(fontSizeComplexScript53);
            paragraphMarkRunProperties49.Append(languages59);

            paragraphProperties49.Append(spacingBetweenLines44);
            paragraphProperties49.Append(justification48);
            paragraphProperties49.Append(paragraphMarkRunProperties49);

            paragraph49.Append(paragraphProperties49);

            tableCell47.Append(tableCellProperties47);
            tableCell47.Append(paragraph49);

            TableCell tableCell48 = new TableCell();

            TableCellProperties tableCellProperties48 = new TableCellProperties();
            TableCellWidth tableCellWidth48 = new TableCellWidth() { Width = "5259", Type = TableWidthUnitValues.Dxa };

            tableCellProperties48.Append(tableCellWidth48);

            Paragraph paragraph50 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties50 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines45 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification49 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties50 = new ParagraphMarkRunProperties();
            RunFonts runFonts60 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize54 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript54 = new FontSizeComplexScript() { Val = "28" };
            Languages languages60 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties50.Append(runFonts60);
            paragraphMarkRunProperties50.Append(fontSize54);
            paragraphMarkRunProperties50.Append(fontSizeComplexScript54);
            paragraphMarkRunProperties50.Append(languages60);

            paragraphProperties50.Append(spacingBetweenLines45);
            paragraphProperties50.Append(justification49);
            paragraphProperties50.Append(paragraphMarkRunProperties50);

            paragraph50.Append(paragraphProperties50);

            tableCell48.Append(tableCellProperties48);
            tableCell48.Append(paragraph50);

            tableRow12.Append(tableCell45);
            tableRow12.Append(tableCell46);
            tableRow12.Append(tableCell47);
            tableRow12.Append(tableCell48);

            TableRow tableRow13 = new TableRow() { RsidTableRowMarkRevision = "00107D47", RsidTableRowAddition = "00E24EED", RsidTableRowProperties = "00BF6E08" };

            TableCell tableCell49 = new TableCell();

            TableCellProperties tableCellProperties49 = new TableCellProperties();
            TableCellWidth tableCellWidth49 = new TableCellWidth() { Width = "1565", Type = TableWidthUnitValues.Dxa };

            tableCellProperties49.Append(tableCellWidth49);

            Paragraph paragraph51 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties51 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines46 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification50 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties51 = new ParagraphMarkRunProperties();
            RunFonts runFonts61 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize55 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript55 = new FontSizeComplexScript() { Val = "28" };
            Languages languages61 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties51.Append(runFonts61);
            paragraphMarkRunProperties51.Append(fontSize55);
            paragraphMarkRunProperties51.Append(fontSizeComplexScript55);
            paragraphMarkRunProperties51.Append(languages61);

            paragraphProperties51.Append(spacingBetweenLines46);
            paragraphProperties51.Append(justification50);
            paragraphProperties51.Append(paragraphMarkRunProperties51);

            paragraph51.Append(paragraphProperties51);

            tableCell49.Append(tableCellProperties49);
            tableCell49.Append(paragraph51);

            TableCell tableCell50 = new TableCell();

            TableCellProperties tableCellProperties50 = new TableCellProperties();
            TableCellWidth tableCellWidth50 = new TableCellWidth() { Width = "1066", Type = TableWidthUnitValues.Dxa };

            tableCellProperties50.Append(tableCellWidth50);

            Paragraph paragraph52 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties52 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines47 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification51 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties52 = new ParagraphMarkRunProperties();
            RunFonts runFonts62 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize56 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript56 = new FontSizeComplexScript() { Val = "28" };
            Languages languages62 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties52.Append(runFonts62);
            paragraphMarkRunProperties52.Append(fontSize56);
            paragraphMarkRunProperties52.Append(fontSizeComplexScript56);
            paragraphMarkRunProperties52.Append(languages62);

            paragraphProperties52.Append(spacingBetweenLines47);
            paragraphProperties52.Append(justification51);
            paragraphProperties52.Append(paragraphMarkRunProperties52);

            paragraph52.Append(paragraphProperties52);

            tableCell50.Append(tableCellProperties50);
            tableCell50.Append(paragraph52);

            TableCell tableCell51 = new TableCell();

            TableCellProperties tableCellProperties51 = new TableCellProperties();
            TableCellWidth tableCellWidth51 = new TableCellWidth() { Width = "1917", Type = TableWidthUnitValues.Dxa };

            tableCellProperties51.Append(tableCellWidth51);

            Paragraph paragraph53 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties53 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines48 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification52 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties53 = new ParagraphMarkRunProperties();
            RunFonts runFonts63 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize57 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript57 = new FontSizeComplexScript() { Val = "28" };
            Languages languages63 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties53.Append(runFonts63);
            paragraphMarkRunProperties53.Append(fontSize57);
            paragraphMarkRunProperties53.Append(fontSizeComplexScript57);
            paragraphMarkRunProperties53.Append(languages63);

            paragraphProperties53.Append(spacingBetweenLines48);
            paragraphProperties53.Append(justification52);
            paragraphProperties53.Append(paragraphMarkRunProperties53);

            paragraph53.Append(paragraphProperties53);

            tableCell51.Append(tableCellProperties51);
            tableCell51.Append(paragraph53);

            TableCell tableCell52 = new TableCell();

            TableCellProperties tableCellProperties52 = new TableCellProperties();
            TableCellWidth tableCellWidth52 = new TableCellWidth() { Width = "5259", Type = TableWidthUnitValues.Dxa };

            tableCellProperties52.Append(tableCellWidth52);

            Paragraph paragraph54 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties54 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines49 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification53 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties54 = new ParagraphMarkRunProperties();
            RunFonts runFonts64 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize58 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript58 = new FontSizeComplexScript() { Val = "28" };
            Languages languages64 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties54.Append(runFonts64);
            paragraphMarkRunProperties54.Append(fontSize58);
            paragraphMarkRunProperties54.Append(fontSizeComplexScript58);
            paragraphMarkRunProperties54.Append(languages64);

            paragraphProperties54.Append(spacingBetweenLines49);
            paragraphProperties54.Append(justification53);
            paragraphProperties54.Append(paragraphMarkRunProperties54);

            paragraph54.Append(paragraphProperties54);

            tableCell52.Append(tableCellProperties52);
            tableCell52.Append(paragraph54);

            tableRow13.Append(tableCell49);
            tableRow13.Append(tableCell50);
            tableRow13.Append(tableCell51);
            tableRow13.Append(tableCell52);

            TableRow tableRow14 = new TableRow() { RsidTableRowMarkRevision = "00107D47", RsidTableRowAddition = "00E24EED", RsidTableRowProperties = "00BF6E08" };

            TableCell tableCell53 = new TableCell();

            TableCellProperties tableCellProperties53 = new TableCellProperties();
            TableCellWidth tableCellWidth53 = new TableCellWidth() { Width = "1565", Type = TableWidthUnitValues.Dxa };

            tableCellProperties53.Append(tableCellWidth53);

            Paragraph paragraph55 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties55 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines50 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification54 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties55 = new ParagraphMarkRunProperties();
            RunFonts runFonts65 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize59 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript59 = new FontSizeComplexScript() { Val = "28" };
            Languages languages65 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties55.Append(runFonts65);
            paragraphMarkRunProperties55.Append(fontSize59);
            paragraphMarkRunProperties55.Append(fontSizeComplexScript59);
            paragraphMarkRunProperties55.Append(languages65);

            paragraphProperties55.Append(spacingBetweenLines50);
            paragraphProperties55.Append(justification54);
            paragraphProperties55.Append(paragraphMarkRunProperties55);

            paragraph55.Append(paragraphProperties55);

            tableCell53.Append(tableCellProperties53);
            tableCell53.Append(paragraph55);

            TableCell tableCell54 = new TableCell();

            TableCellProperties tableCellProperties54 = new TableCellProperties();
            TableCellWidth tableCellWidth54 = new TableCellWidth() { Width = "1066", Type = TableWidthUnitValues.Dxa };

            tableCellProperties54.Append(tableCellWidth54);

            Paragraph paragraph56 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties56 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines51 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification55 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties56 = new ParagraphMarkRunProperties();
            RunFonts runFonts66 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize60 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript60 = new FontSizeComplexScript() { Val = "28" };
            Languages languages66 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties56.Append(runFonts66);
            paragraphMarkRunProperties56.Append(fontSize60);
            paragraphMarkRunProperties56.Append(fontSizeComplexScript60);
            paragraphMarkRunProperties56.Append(languages66);

            paragraphProperties56.Append(spacingBetweenLines51);
            paragraphProperties56.Append(justification55);
            paragraphProperties56.Append(paragraphMarkRunProperties56);

            paragraph56.Append(paragraphProperties56);

            tableCell54.Append(tableCellProperties54);
            tableCell54.Append(paragraph56);

            TableCell tableCell55 = new TableCell();

            TableCellProperties tableCellProperties55 = new TableCellProperties();
            TableCellWidth tableCellWidth55 = new TableCellWidth() { Width = "1917", Type = TableWidthUnitValues.Dxa };

            tableCellProperties55.Append(tableCellWidth55);

            Paragraph paragraph57 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties57 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines52 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification56 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties57 = new ParagraphMarkRunProperties();
            RunFonts runFonts67 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize61 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript61 = new FontSizeComplexScript() { Val = "28" };
            Languages languages67 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties57.Append(runFonts67);
            paragraphMarkRunProperties57.Append(fontSize61);
            paragraphMarkRunProperties57.Append(fontSizeComplexScript61);
            paragraphMarkRunProperties57.Append(languages67);

            paragraphProperties57.Append(spacingBetweenLines52);
            paragraphProperties57.Append(justification56);
            paragraphProperties57.Append(paragraphMarkRunProperties57);

            paragraph57.Append(paragraphProperties57);

            tableCell55.Append(tableCellProperties55);
            tableCell55.Append(paragraph57);

            TableCell tableCell56 = new TableCell();

            TableCellProperties tableCellProperties56 = new TableCellProperties();
            TableCellWidth tableCellWidth56 = new TableCellWidth() { Width = "5259", Type = TableWidthUnitValues.Dxa };

            tableCellProperties56.Append(tableCellWidth56);

            Paragraph paragraph58 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties58 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines53 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification57 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties58 = new ParagraphMarkRunProperties();
            RunFonts runFonts68 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize62 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript62 = new FontSizeComplexScript() { Val = "28" };
            Languages languages68 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties58.Append(runFonts68);
            paragraphMarkRunProperties58.Append(fontSize62);
            paragraphMarkRunProperties58.Append(fontSizeComplexScript62);
            paragraphMarkRunProperties58.Append(languages68);

            paragraphProperties58.Append(spacingBetweenLines53);
            paragraphProperties58.Append(justification57);
            paragraphProperties58.Append(paragraphMarkRunProperties58);

            paragraph58.Append(paragraphProperties58);

            tableCell56.Append(tableCellProperties56);
            tableCell56.Append(paragraph58);

            tableRow14.Append(tableCell53);
            tableRow14.Append(tableCell54);
            tableRow14.Append(tableCell55);
            tableRow14.Append(tableCell56);

            TableRow tableRow15 = new TableRow() { RsidTableRowMarkRevision = "00107D47", RsidTableRowAddition = "00E24EED", RsidTableRowProperties = "00BF6E08" };

            TableCell tableCell57 = new TableCell();

            TableCellProperties tableCellProperties57 = new TableCellProperties();
            TableCellWidth tableCellWidth57 = new TableCellWidth() { Width = "1565", Type = TableWidthUnitValues.Dxa };

            tableCellProperties57.Append(tableCellWidth57);

            Paragraph paragraph59 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties59 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines54 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification58 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties59 = new ParagraphMarkRunProperties();
            RunFonts runFonts69 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize63 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript63 = new FontSizeComplexScript() { Val = "28" };
            Languages languages69 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties59.Append(runFonts69);
            paragraphMarkRunProperties59.Append(fontSize63);
            paragraphMarkRunProperties59.Append(fontSizeComplexScript63);
            paragraphMarkRunProperties59.Append(languages69);

            paragraphProperties59.Append(spacingBetweenLines54);
            paragraphProperties59.Append(justification58);
            paragraphProperties59.Append(paragraphMarkRunProperties59);

            paragraph59.Append(paragraphProperties59);

            tableCell57.Append(tableCellProperties57);
            tableCell57.Append(paragraph59);

            TableCell tableCell58 = new TableCell();

            TableCellProperties tableCellProperties58 = new TableCellProperties();
            TableCellWidth tableCellWidth58 = new TableCellWidth() { Width = "1066", Type = TableWidthUnitValues.Dxa };

            tableCellProperties58.Append(tableCellWidth58);

            Paragraph paragraph60 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties60 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines55 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification59 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties60 = new ParagraphMarkRunProperties();
            RunFonts runFonts70 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize64 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript64 = new FontSizeComplexScript() { Val = "28" };
            Languages languages70 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties60.Append(runFonts70);
            paragraphMarkRunProperties60.Append(fontSize64);
            paragraphMarkRunProperties60.Append(fontSizeComplexScript64);
            paragraphMarkRunProperties60.Append(languages70);

            paragraphProperties60.Append(spacingBetweenLines55);
            paragraphProperties60.Append(justification59);
            paragraphProperties60.Append(paragraphMarkRunProperties60);

            paragraph60.Append(paragraphProperties60);

            tableCell58.Append(tableCellProperties58);
            tableCell58.Append(paragraph60);

            TableCell tableCell59 = new TableCell();

            TableCellProperties tableCellProperties59 = new TableCellProperties();
            TableCellWidth tableCellWidth59 = new TableCellWidth() { Width = "1917", Type = TableWidthUnitValues.Dxa };

            tableCellProperties59.Append(tableCellWidth59);

            Paragraph paragraph61 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties61 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines56 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification60 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties61 = new ParagraphMarkRunProperties();
            RunFonts runFonts71 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize65 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript65 = new FontSizeComplexScript() { Val = "28" };
            Languages languages71 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties61.Append(runFonts71);
            paragraphMarkRunProperties61.Append(fontSize65);
            paragraphMarkRunProperties61.Append(fontSizeComplexScript65);
            paragraphMarkRunProperties61.Append(languages71);

            paragraphProperties61.Append(spacingBetweenLines56);
            paragraphProperties61.Append(justification60);
            paragraphProperties61.Append(paragraphMarkRunProperties61);

            paragraph61.Append(paragraphProperties61);

            tableCell59.Append(tableCellProperties59);
            tableCell59.Append(paragraph61);

            TableCell tableCell60 = new TableCell();

            TableCellProperties tableCellProperties60 = new TableCellProperties();
            TableCellWidth tableCellWidth60 = new TableCellWidth() { Width = "5259", Type = TableWidthUnitValues.Dxa };

            tableCellProperties60.Append(tableCellWidth60);

            Paragraph paragraph62 = new Paragraph() { RsidParagraphMarkRevision = "00B65E2F", RsidParagraphAddition = "00E24EED", RsidParagraphProperties = "00BF6E08", RsidRunAdditionDefault = "00E24EED" };

            ParagraphProperties paragraphProperties62 = new ParagraphProperties();
            SpacingBetweenLines spacingBetweenLines57 = new SpacingBetweenLines() { Line = "480", LineRule = LineSpacingRuleValues.Auto };
            Justification justification61 = new Justification() { Val = JustificationValues.Both };

            ParagraphMarkRunProperties paragraphMarkRunProperties62 = new ParagraphMarkRunProperties();
            RunFonts runFonts72 = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
            FontSize fontSize66 = new FontSize() { Val = "28" };
            FontSizeComplexScript fontSizeComplexScript66 = new FontSizeComplexScript() { Val = "28" };
            Languages languages72 = new Languages() { Val = "ru-RU" };

            paragraphMarkRunProperties62.Append(runFonts72);
            paragraphMarkRunProperties62.Append(fontSize66);
            paragraphMarkRunProperties62.Append(fontSizeComplexScript66);
            paragraphMarkRunProperties62.Append(languages72);

            paragraphProperties62.Append(spacingBetweenLines57);
            paragraphProperties62.Append(justification61);
            paragraphProperties62.Append(paragraphMarkRunProperties62);

            paragraph62.Append(paragraphProperties62);

            tableCell60.Append(tableCellProperties60);
            tableCell60.Append(paragraph62);

            tableRow15.Append(tableCell57);
            tableRow15.Append(tableCell58);
            tableRow15.Append(tableCell59);
            tableRow15.Append(tableCell60);

            table1.Append(tableProperties1);
            table1.Append(tableGrid1);
            table1.Append(tableRow1);
            table1.Append(tableRow2);
            table1.Append(tableRow3);
            table1.Append(tableRow4);
            table1.Append(tableRow5);
            table1.Append(tableRow6);
            table1.Append(tableRow7);
            table1.Append(tableRow8);
            table1.Append(tableRow9);
            table1.Append(tableRow10);
            table1.Append(tableRow11);
            table1.Append(tableRow12);
            table1.Append(tableRow13);
            table1.Append(tableRow14);
            table1.Append(tableRow15);

            //SectionProperties sectionProperties1 = new SectionProperties() { RsidRPr = "00E24EED", RsidR = "00E43BFF", RsidSect = "00FF205A" };
            //PageSize pageSize1 = new PageSize() { Width = (UInt32Value)11906U, Height = (UInt32Value)16838U };
            //PageMargin pageMargin1 = new PageMargin() { Top = 1440, Right = (UInt32Value)992U, Bottom = 1440, Left = (UInt32Value)1701U, Header = (UInt32Value)720U, Footer = (UInt32Value)720U, Gutter = (UInt32Value)0U };
            //PageNumberType pageNumberType1 = new PageNumberType() { Start = 1 };
            //Columns columns1 = new Columns() { Space = "720" };
            //TitlePage titlePage1 = new TitlePage();
            //DocGrid docGrid1 = new DocGrid() { LinePitch = 326 };

            //sectionProperties1.Append(pageSize1);
            //sectionProperties1.Append(pageMargin1);
            //sectionProperties1.Append(pageNumberType1);
            //sectionProperties1.Append(columns1);
            //sectionProperties1.Append(titlePage1);
            //sectionProperties1.Append(docGrid1);

            _body.Append(paragraph1);
            _body.Append(paragraph2);
            _body.Append(table1);
            //_body.Append(sectionProperties1);
        }
    }
}
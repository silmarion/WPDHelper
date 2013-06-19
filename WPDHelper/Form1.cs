using DataLibrary;
using HelperLibrary;
using SessionLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WPDHelper
{
    public partial class Form1 : Form
    {
        //Много костылей
        public Manager SM {get; set;}
        private bool _changedSearchText;

        //TODO: подставить во 2 раздел "Математический и естественнонаучный цикл" из .плм
        public Form1()
        {
            InitializeComponent();
            SM = new Manager();
            _changedSearchText = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Tabs.Controls)
            {
                if (control.GetType().Name == "TabPage")
                {
                    control.BackColor = SystemColors.InactiveCaption;
                }
            }
        }

        public void Initilize()
        {
            InitilizeTab_TitlePage();
            BindingComponents();
            ConfiguringComponents();
            this.timer.Start();
        }

        private void InitilizeTab_TitlePage()
        {
            comboBox_TitlePage_CreatorPost.Items.Clear();
            comboBox_TitlePage_CreatorName.Items.Clear();
            var creators = SM.FormDataInitilizer.GetCreators();
            foreach (var cr in creators)
            {
                comboBox_TitlePage_CreatorPost.Items.Add(cr.Key);
                comboBox_TitlePage_CreatorPost.SelectedIndex = 0;
                comboBox_TitlePage_CreatorName.Items.Add(cr.Value);
                comboBox_TitlePage_CreatorName.SelectedIndex = 0;
            }
            SetComboBoxItems(comboBox_TitlePage_Discipline, SM.FormDataInitilizer.GetDisciplineName());
            SetComboBoxItems(comboBox_TitlePage_TrainingDirection, SM.FormDataInitilizer.GetTrainingDirection());
            textBox_TitlePage_Year.Text = DateTime.Now.Year.ToString();
            if (!SM.NewSession)
            {
                var titlePage = SM.SessionObjects.TitlePage;
                comboBox_TitlePage_CreatorPost.Text = titlePage.CreatorPost;
                comboBox_TitlePage_CreatorName.Text = titlePage.CreatorName;
                for (var i = 0; i < comboBox_TitlePage_Discipline.Items.Count; i++)
                {
                    if (comboBox_TitlePage_Discipline.Items[i].ToString() == titlePage.Discipline)
                    {
                        comboBox_TitlePage_Discipline.SelectedIndex = i;
                    }
                }
                comboBox_TitlePage_TrainingDirection.Text = titlePage.TrainingDirection;
            }
        }

        #region Bindings
        private void InitilizeBinding(Control.ControlCollection cc)
        {
            foreach (var c in cc)
            {
                Control t;
                if (c is Control)
                {
                    t = (Control)c;
                    t.DataBindings.Clear();
                    t.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
                    InitilizeBinding(t.Controls);
                }
            }
        }

        // Связывание компонентов формы с объектами SessionManager.SessionObjects
        private void BindingComponents()
        {
            InitilizeBinding(this.Controls);
            
            //Tab_TitlePage
            var source1 = new BindingSource();
            source1.DataSource = SM.SessionObjects.TitlePage; //TODO: проверку на null во всех сурсах
            textBox_TitlePage_NameUniversity.DataBindings.Add("Text", source1, "University");
            comboBox_TitlePage_CreatorPost.DataBindings.Add("Text", source1, "CreatorPost");
            comboBox_TitlePage_CreatorName.DataBindings.Add("Text", source1, "CreatorName");
            textBox_TitlePage_DisciplineCode.DataBindings.Add("Text", source1, "DisciplineCode");
            comboBox_TitlePage_TrainingDirection.DataBindings.Add("Text", source1, "TrainingDirection");
            textBox_TitlePage_ProfileTraining.DataBindings.Add("Text", source1, "ProfileTraining");
            textBox_TitlePage_Qualification.DataBindings.Add("Text", source1, "Qualification");
            textBox_TitlePage_FormOfTraining.DataBindings.Add("Text", source1, "FormOfTraining");
            textBox_TitlePage_Сathedra.DataBindings.Add("Text", source1, "Сathedra");
            textBox_TitlePage_City.DataBindings.Add("Text", source1, "City");
            textBox_TitlePage_Year.DataBindings.Add("Text", source1, "Year");

            //Tab_ChapterOne
            var source2 = new BindingSource();
            source2.DataSource = SM.SessionObjects.ChapterOne;
            textBox1_DisciplineMission.DataBindings.Add("Text", source2, "DisciplineMission");
            dataGridView1_ProfessionalActivity.DataSource = SM.SessionObjects.ChapterOne.ProfessionalActivity;
            dataGridView1_TechnologicalActivity.DataSource = SM.SessionObjects.ChapterOne.TechnologicalActivity;
            dataGridView1_AdministrativeActivity.DataSource = SM.SessionObjects.ChapterOne.AdministrativeActivity;
            dataGridView1_AnalyticalActivity.DataSource = SM.SessionObjects.ChapterOne.AnalyticalActivity;
            dataGridView1_ResearchActivity.DataSource = SM.SessionObjects.ChapterOne.ResearchActivity;
            dataGridView1_GiveTheBasics.DataSource = SM.SessionObjects.ChapterOne.GiveTheBasics;

            //Tab_ChapterThree
            dataGridView3_Know.DataSource = SM.SessionObjects.ChapterThree.Know;
            dataGridView3_Reduced.DataSource = SM.SessionObjects.ChapterThree.Reduced;
            dataGridView3_Own.DataSource = SM.SessionObjects.ChapterThree.Own;

            //Tab_ChapterFour
            dataGridView4_Auditorium.DataSource = SM.SessionObjects.ChapterFour.AuditoriumHours;
            dataGridView4_Independent.DataSource = SM.SessionObjects.ChapterFour.IndependentHours;
            dataGridView4_Validation.DataSource = SM.SessionObjects.ChapterFour.Validation;
            dataGridView4_Chapters.DataSource = SM.SessionObjects.ChapterFour.Chapters;
            dataGridView4_DistributionStudyTime.DataSource = SM.SessionObjects.ChapterFour.DistributionStudyTime;

            //Tab_ChaperSeven1
            dataGridView7_1_PrimatyLiterature.DataSource = SM.SessionObjects.ChapterSeven.PrimaryLiterature;

            //Tab_ChaperSeven2
            dataGridView7_2_AdditionalLiterature.DataSource = SM.SessionObjects.ChapterSeven.AdditionalLiterature;
            dataGridView7_2_Software.DataSource = SM.SessionObjects.ChapterSeven.Software;

            //Tab_ChaperEight
            dataGridView8_Provision.DataSource = SM.SessionObjects.ChapterEight.Provision;

            //Tab_ChapterNine
            textBox9_General.DataBindings.Add("Text", SM.SessionObjects.ChapterNine, "General");
            textBox9_Teacher.DataBindings.Add("Text", SM.SessionObjects.ChapterNine, "Teacher");
            textBox9_Student.DataBindings.Add("Text", SM.SessionObjects.ChapterNine, "Student");
            
        }
        #endregion

        //настройки отображения комонентов
        private void ConfiguringComponents()
        {
            //Tab_ChapterFour
            dataGridView4_Chapters.RowHeadersWidth = 70;

            dataGridView4_DistributionStudyTime.Columns[0].Width = 290;
            dataGridView4_DistributionStudyTime.Columns[1].Width = 70;
            dataGridView4_DistributionStudyTime.Columns[2].Width = 100;
            dataGridView4_DistributionStudyTime.Columns[3].Width = 70;
            dataGridView4_DistributionStudyTime.Columns[4].Width = 80;
            dataGridView4_DistributionStudyTime.Columns[5].Width = 65;
            dataGridView4_DistributionStudyTime.Columns[6].Width = 110;
            dataGridView4_DistributionStudyTime.Columns[7].Width = 130;
        }

        // Заполняет комбо боксы
        private void SetComboBoxItems(ComboBox comboBox, List<string> data)
        {
            comboBox.Items.Clear();
            if (data.Count == 0)
            {
                comboBox.Items.Add("Не найдено");
            }
            else
            {
                foreach (var item in data)
                {
                    comboBox.Items.Add(item);
                }
            }
        }
    
        #region DEBUG
        private void button5_Click(object sender, EventArgs e)
        {
            var chapterFour = SM.SessionObjects.ChapterFour;
            chapterFour.PartTwo.Validate(chapterFour.DistributionStudyTime, chapterFour.DistributionStudyTimeSumm);
        }
        #endregion


    #region Events

        #region Other -------------------------------------------------------------------
        private void button7_Click(object sender, EventArgs e)
        {
            SM.SessionObjects.ChapterSixPartTwoThree.Validate();
        }
        
        ////////////
        private void button2_Click_1(object sender, EventArgs e)
        {
            SM.LoadSession(@"C:\Users\arado_000\Documents\Visual Studio 2012\Projects\XmlWorker\WPDHelper\bin\Debug\Sessions\Start\14.04.2013\S23");

            BindingComponents();
        }
        ////////////
        private void button1_Click_1(object sender, EventArgs e)
        {
            SM.SaveSession();
        }


        private void Timer_SaveSession(object sender, EventArgs e)
        {
            SM.SaveSession();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SM.Validate();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            SM.SaveSession();
        }
        #endregion

        #region Menu
        private void CreateSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            SM.CloseSession();
            openFileDialog_CreateSession.ShowDialog(this);
        }

        private void openFileDialog_CreateSession_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                var plan = openFileDialog_CreateSession.FileNames.FirstOrDefault(
                    s => s.Substring(s.Length - 7) == "plm.xml" || s.Substring(s.Length - 7) == "pli.xml");
                if (plan != null)
                {
                    this.SM.CreateSession(plan);
                    foreach (var f in openFileDialog_CreateSession.FileNames)
                    {
                        if (f != plan)
                        {
                            System.IO.File.Copy(f, SM.SessionPath + f.Substring(f.LastIndexOf('\\') + 1), true);
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критическая ошибка. " + ex.Message);
            }
            Initilize();
        }

        private void loadSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            SM.CloseSession();

            var form = new FormLoadSession();
            form.ShowDialog(this);
        }

        private void button_GenerateDocument_Click_1(object sender, EventArgs e)
        {
            try
            {
                SM.GenerateDocument();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сгенерировать документ. " + ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        private void CloseSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            SM.CloseSession();

            comboBox_TitlePage_CreatorPost.Items.Clear();
            comboBox_TitlePage_CreatorName.Items.Clear();
            comboBox_TitlePage_Discipline.Items.Clear();
            comboBox_TitlePage_TrainingDirection.Items.Clear();
            BindingComponents();
        }

        private void ToolStripMenuItem_OpenSessionFolder_Click(object sender, EventArgs e)
        {
            SM.OpenSessionFolder();
        }

        private void ManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var path = Directory.GetCurrentDirectory() + @"\Resources\UserManual.docx";
            if (System.IO.File.Exists(path))
            {
                Process.Start(path);
            }
            else
            {
                MessageBox.Show("Не удается найти файл справки. =(");
            }
        }

        private void CreateSessionOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            SM.CloseSession();
            Tabs.SelectTab("Tab_TitlePage");
            var form = new FormCreateSessionOn();
            form.ShowDialog(this);
        }

        private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SM.ReadyToWork)
            {
                Process.Start(SM.SessionPath);
            }
        }

        private void showDemoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var path = Directory.GetCurrentDirectory() + @"\Resources\Demo";
            if(Directory.Exists(path))
            {
                if (SM.ReadyToWork)
                {
                    SM.CloseSession();
                }
                try
                {
                    SM.LoadSession(path);
                    this.Initilize();
                }
                catch
                {
                }
            }
            else
            {
                MessageBox.Show("Невозможно загрузить демонстрационный пример.");
            }
        }
        #endregion

        #region Tab_TitlePage -------------------------------------------------------------------
        private void comboBox_Discipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ttt = sender.GetType();
            var ggg = e.GetType();
            textBox_TitlePage_DisciplineCode.Text = SM.FormDataInitilizer.GetDisciplineCode(comboBox_TitlePage_Discipline.Text);
            var titlePage = SM.SessionObjects.TitlePage;
            titlePage.Discipline = comboBox_TitlePage_Discipline.Text;
            SM.UpdateObjects();
            dataGridView4_Independent.Update();

        }
        #endregion

        #region Tab_ChapterOne -------------------------------------------------------------------
        //подтановка названия предмета в groupBox_DisciplineDevelopment
        private void Tab_ChapterOne_Enter(object sender, EventArgs e)
        {
            groupBox_DisciplineDevelopment.Text = "Целями освоения дисциплины ";
            groupBox_DisciplineDevelopment.Text += "\"" + comboBox_TitlePage_Discipline.Text + "\" является ...";
            dataGridView1_ProfessionalActivity.Focus();
        }
        #endregion

        #region Tab_ChapterTwo
        #endregion

        #region Tab_ChapterThree -------------------------------------------------------------------
        private void Tab_ChapterThree_Enter(object sender, EventArgs e)
        {
            textBox3_Info.Text = "Выпускник по направлению подготовки " + comboBox_TitlePage_TrainingDirection.Text +
                " c квалификацией (степенью) «" + textBox_TitlePage_Qualification.Text + "» должен обладать следующими компетенциями:";
            SM.UpdateObjects();
            var competence = SM.SessionObjects.ChapterThree;
            foreach (var c in competence.Competence)
            {
                textBox3_Info.Text += Environment.NewLine + string.Format("     - ({0}) {1}", c.Key, c.Value);
            }

            var titlePage = SM.SessionObjects.TitlePage;
            label3_Info.Text = string.Format("В частности, в результате изучения дисциплины  «{0}» студенты должны", titlePage.Discipline);
        }
        #endregion

        #region Tab_ChapterFour -------------------------------------------------------------------
        private void Tab_ChapterFour_Enter(object sender, EventArgs e)
        {
            if (dataGridView4_Auditorium.Columns.Count > 1)
            {
                //хз почему не срабатывает и вылетает с nullReference
                //Оооо, исцеляющий слип, да прибудет с тобой сила
                Thread.Sleep(100);
                try
                {
                    dataGridView4_Auditorium.Columns[0].Width = 320;
                    dataGridView4_Auditorium.ClearSelection();

                    dataGridView4_Independent.Columns[0].Width = 320;
                    dataGridView4_Independent.ClearSelection();
                    dataGridView4_Independent.Rows[1].Cells[0].Selected = true;

                    dataGridView4_Validation.Columns[0].Width = 320;
                    dataGridView4_Validation.ClearSelection();
                }
                catch
                {
                }
            }

            label4_Info.Text = SM.SessionObjects.ChapterFour.Info;
            for (var i = 0; i < dataGridView4_Chapters.Rows.Count; i++)
            {
                dataGridView4_Chapters.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }

        private void dataGridView4_DistributionStudyTime_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                var formChoiceOfCompetence = new FormChoiceOfCompetence(e.RowIndex);
                formChoiceOfCompetence.Top = 1;
                formChoiceOfCompetence.ShowDialog(this);
                e.Cancel = true;
            }
        }

        private void dataGridView4_Chapters_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView4_Chapters.Rows[e.RowIndex].HeaderCell.Value = (e.RowIndex + 1).ToString();
        }
        #endregion

        #region Tab_ChapterFour2 -------------------------------------------------------------------
        private void Tab_ChapterFour2_Enter(object sender, EventArgs e)
        {
            var chapterFour = SM.SessionObjects.ChapterFour;
            var discipline = SM.AdditionalObjects.Discipline;
            try
            {
                chapterFour.Validate(discipline);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            //апдейт второй части специально вынесен из раздела 4
            chapterFour.PartTwo.Update(chapterFour.DistributionStudyTime, chapterFour.DistributionStudyTimeSumm);

            var bsTheme = new BindingSource { DataSource = chapterFour.PartTwo.Themes };
            bsTheme.PositionChanged += new System.EventHandler(this.bindingNavigator4_Themes_BindingSource_PositionChanged);
            bindingNavigator4_Themes.BindingSource = bsTheme;

            label4_ThemeName.DataBindings.Clear();
            label4_ThemeName.DataBindings.Add("Text", bsTheme, "Name");

            var label1 = (BindableToolStripLabel)bindingNavigator4_Themes.Items["toolStripLabel4_ThemeHours"];
            label1.DataBindings.Clear();
            label1.DataBindings.Add("Text", bsTheme, "Hours");

            bindingNavigator4_Themes_BindingSource_PositionChanged(bindingNavigator4_Themes.BindingSource, null);
        }

        private void bindingNavigator4_Themes_BindingSource_PositionChanged(object sender, EventArgs e)
        {
            var chapterFour = SM.SessionObjects.ChapterFour;
            if (chapterFour.PartTwo.ListOfLectures.Count != 0 && bindingNavigator4_Themes.BindingSource != null)
            {
                var bsNavigator = (BindingSource)sender;
                if (bsNavigator.Position == -1)
                {
                    return;
                }

                //лекции
                var lHours = Helper.ConvertObjectToInt(chapterFour.DistributionStudyTime.Rows[bsNavigator.Position]["Лекции (час.)"]);
                toolStripLabel4_SummHoursOfLectures.Text = String.Format("Всего по теме {0} час.", lHours);

                var bsLectures = new BindingSource { DataSource = chapterFour.PartTwo.ListOfLectures[bsNavigator.Position] };
                bindingNavigator4_Lectures.BindingSource = bsLectures;

                textBox4_LectureName.DataBindings.Clear();
                textBox4_LectureText.DataBindings.Clear();
                textBox4_LectureName.DataBindings.Add("Text", bsLectures, "Name");
                textBox4_LectureText.DataBindings.Add("Text", bsLectures, "Text");

                bindableToolStripTextBox_LecturesHours.DataBindings.Clear();
                bindableToolStripTextBox_LecturesHours.DataBindings.Add("Text", bsLectures, "Hours");

                var summ = chapterFour.PartTwo.GetLecturesSummHours(
                       bindingNavigator4_Themes.BindingSource.Position,
                       bindingNavigator4_Lectures.BindingSource.Position,
                       bindableToolStripTextBox_LecturesHours.Text);
                toolStripLabel4_HoursOfLectures.Text = String.Format("Всего {0} час.", summ);
                //практические
                var pHours = Helper.ConvertObjectToInt(chapterFour.DistributionStudyTime.Rows[bsNavigator.Position]["Практические занятия (час.)"]);
                toolStripLabel4_SummHoursOfPracticals.Text = String.Format("Всего по теме {0} час.", pHours);

                var bsPracticals = new BindingSource { DataSource = chapterFour.PartTwo.ListOfPracticals[bsNavigator.Position] };
                bindingNavigator4_Practical.BindingSource = bsPracticals;

                textBox4_PracticalName.DataBindings.Clear();
                textBox4_PracticalText.DataBindings.Clear();
                textBox4_PracticalName.DataBindings.Add("Text", bsPracticals, "Name");
                textBox4_PracticalText.DataBindings.Add("Text", bsPracticals, "Text");

                bindableToolStripTextBox4_PracticalHours.DataBindings.Clear();
                bindableToolStripTextBox4_PracticalHours.DataBindings.Add("Text", bsPracticals, "Hours");

                summ = chapterFour.PartTwo.GetPracticalSummHours(
                        bindingNavigator4_Themes.BindingSource.Position,
                        bindingNavigator4_Practical.BindingSource.Position,
                        bindableToolStripTextBox4_PracticalHours.Text);
                toolStripLabel4_HoursOfPracticals.Text = String.Format("Всего {0} час.", summ);
            }
        }

        private void bindableToolStripTextBox_LecturesHours_Leave(object sender, EventArgs e)
        {
            var chapterFour = SM.SessionObjects.ChapterFour;
            if (bindableToolStripTextBox_LecturesHours.Text != ""
                && chapterFour.PartTwo.ListOfLectures.Count != 0
                && bindingNavigator4_Lectures.BindingSource.Position != -1)
            {
                try
                {
                    toolStripLabel4_HoursOfLectures.Text = Helper.ConvertObjectToDouble(bindableToolStripTextBox_LecturesHours.Text, false).ToString();
                    var summ = chapterFour.PartTwo.GetLecturesSummHours(
                        bindingNavigator4_Themes.BindingSource.Position,
                        bindingNavigator4_Lectures.BindingSource.Position,
                        bindableToolStripTextBox_LecturesHours.Text);
                    toolStripLabel4_HoursOfLectures.Text = String.Format("Всего {0} час.", summ);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + Environment.NewLine + "Возможно в вашей системе используется другой десятичный разделитель.");
                }
            }
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            var chapterFour = SM.SessionObjects.ChapterFour;
            chapterFour.PartTwo.ClearLectures();
            Tab_ChapterFour2_Enter(null, null);
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            var chapterFour = SM.SessionObjects.ChapterFour;
            chapterFour.PartTwo.ClearPracticals();
            Tab_ChapterFour2_Enter(null, null);
        }

        private void bindableToolStripTextBox4_PracticalHours_Leave(object sender, EventArgs e)
        {
            var chapterFour = SM.SessionObjects.ChapterFour;
            if (bindableToolStripTextBox4_PracticalHours.Text != ""
                && chapterFour.PartTwo.ListOfPracticals.Count != 0
                && bindingNavigator4_Practical.BindingSource.Position != -1)
            {
                try
                {
                    toolStripLabel4_HoursOfPracticals.Text = Helper.ConvertObjectToDouble(bindableToolStripTextBox4_PracticalHours.Text, false).ToString();
                    var summ = chapterFour.PartTwo.GetPracticalSummHours(
                        bindingNavigator4_Themes.BindingSource.Position,
                        bindingNavigator4_Practical.BindingSource.Position,
                        bindableToolStripTextBox4_PracticalHours.Text);
                    toolStripLabel4_HoursOfPracticals.Text = String.Format("Всего {0} час.", summ);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + Environment.NewLine + "Возможно в вашей системе используется другой десятичный разделитель.");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var chapterFour = SM.SessionObjects.ChapterFour;
            chapterFour.PartTwo.Clear();
            Tab_ChapterFour2_Enter(null, null);
        }
        #endregion

        #region Tab_ChapterSix23 -------------------------------------------------------------------
        private void Tab_ChapterSix2_Enter(object sender, EventArgs e)
        {
            var chapterSix23 = SM.SessionObjects.ChapterSixPartTwoThree;
            chapterSix23.Initialize();
            dataGridView6_2_IndependantWork.DataSource = chapterSix23.IndependentWork;

            var bsHomeWork = new BindingSource { DataSource = chapterSix23.HomeWork };
            bsHomeWork.PositionChanged += new System.EventHandler(this.bindingNavigator6_2_HomeWork_BindingSource_PositionChanged);
            bindingNavigator6_2_HomeWork.BindingSource = bsHomeWork;

            bindingNavigator6_2_HomeWork_BindingSource_PositionChanged(bindingNavigator6_2_HomeWork.BindingSource, null);
        }

        private void bindingNavigator6_2_HomeWork_BindingSource_PositionChanged(object sender, EventArgs e)
        {
            var chapterSix23 = SM.SessionObjects.ChapterSixPartTwoThree;
            if (chapterSix23.HomeWork.Count != 0)
            {
                var bsNavigator = (BindingSource)sender;
                if (bsNavigator.Position == -1)
                {
                    return;
                }
                chapterSix23.InitializeNewHomeWorkTable(bsNavigator.Position);

                bindableToolStripTextBox6_2_HomeWorkHeader.DataBindings.Clear();
                bindableToolStripTextBox6_2_HomeWorkHeader.DataBindings.Add("Text", bsNavigator[bsNavigator.Position], "Header");
                dataGridView6_2_HomeWork.DataSource = chapterSix23.HomeWork[bsNavigator.Position];
                dataGridView6_2_HomeWork.Columns["Header"].Visible = false;
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            bindingNavigator6_2_HomeWork_BindingSource_PositionChanged(bindingNavigator6_2_HomeWork.BindingSource, null);
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            SM.SessionObjects.ChapterSixPartTwoThree.ClearHomeWork();
            bindingNavigator6_2_HomeWork.BindingSource.Position = 0;
            bindingNavigator6_2_HomeWork_BindingSource_PositionChanged(bindingNavigator6_5_TrainingForExam.BindingSource, null);
        }
        #endregion

        #region Tab_ChapterSix45
        private void Tab_ChapterSix_3_Enter(object sender, EventArgs e)
        {
            var chapterSix45 = SM.SessionObjects.ChapterSixPartFourFive;
            chapterSix45.Initialize();
            dataGridView6_4_TestWork.DataSource = chapterSix45.TestWork;

            var bsTraining = new BindingSource { DataSource = chapterSix45.TrainingForExam };
            bsTraining.PositionChanged += new System.EventHandler(this.bindingNavigator6_5_TrainingForExam_BindingSource_PositionChanged);
            bindingNavigator6_5_TrainingForExam.BindingSource = bsTraining;
            
            bindingNavigator6_5_TrainingForExam_BindingSource_PositionChanged(bindingNavigator6_5_TrainingForExam.BindingSource, null);
        }

        private void bindingNavigator6_5_TrainingForExam_BindingSource_PositionChanged(object sender, EventArgs e)
        {
            var chapterSix45 = SM.SessionObjects.ChapterSixPartFourFive;
            if (chapterSix45.TrainingForExam.Count != 0)
            {
                var bsNavigator = (BindingSource)sender;
                if (bsNavigator.Position == -1)
                {
                    return;
                }
                chapterSix45.InitializeNewHomeWorkTable(bsNavigator.Position);
                
                bindableToolStripTextBox6_5_TrainingForExamHeader.DataBindings.Clear();
                bindableToolStripTextBox6_5_TrainingForExamHeader.DataBindings.Add("Text", bsNavigator[bsNavigator.Position], "Header");
                dataGridView6_5_TrainingForExam.DataSource = bsNavigator[bsNavigator.Position];
                dataGridView6_5_TrainingForExam.Columns["Header"].Visible = false;
            }
        }

        private void toolStripButton6_5_ClearHomeWork_Click(object sender, EventArgs e)
        {
            SM.SessionObjects.ChapterSixPartFourFive.ClearTrainingForExam();
            bindingNavigator6_5_TrainingForExam.BindingSource.Position = 0;
            bindingNavigator6_5_TrainingForExam_BindingSource_PositionChanged(bindingNavigator6_5_TrainingForExam.BindingSource, null);
        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            bindingNavigator6_5_TrainingForExam_BindingSource_PositionChanged(bindingNavigator6_5_TrainingForExam.BindingSource, e);
        }
        #endregion

        #region Tab_ChapterSeven1
        private void toolStripButton7_1_UpdateLibrary_Click(object sender, EventArgs e)
        {
            if (SM.ReadyToWork)
            {
                openFileDialog_UpdateLibrary.ShowDialog(this);
            }
        }

        private void openFileDialog_UpdateLibrary_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                SM.UpdateLibrary(openFileDialog_UpdateLibrary.FileName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            checkedListBox7_1_Search.Items.Clear();
        }

        private void toolStripButton7_1_Search_Click(object sender, EventArgs e)
        {
            dataGridView7_1_PrimatyLiterature.Visible = false;
            checkedListBox7_1_Search.Visible = true;
            //if (!_changedSearchText)
            //{
            //    return;
            //}
            if (SM.ReadyToWork)
            {
                if (!SM.SearchEngine.Loaded)
                {
                    MessageBox.Show("Обновите список литературы.");
                    return;
                }
                var list = new List<string>();
                if (checkBox7_1_Accurate.Checked)
                {
                    list = SM.SearchEngine.Search(toolStripTextBox7_1_TextSearch.Text);
                }
                else
                {
                    list = SM.SearchEngine.SuperSearch(toolStripTextBox7_1_TextSearch.Text);
                }
                checkedListBox7_1_Search.Items.Clear();
                foreach (var book in list)
                {
                    checkedListBox7_1_Search.Items.Add(book);
                }
                label7_1_Finded.Text = "Найдено: " + list.Count;
                _changedSearchText = false;
            }
            else
            {
                label7_1_Finded.Text = "";
            }
        }

        private void toolStripButton7_1_Show_Click(object sender, EventArgs e)
        {
            checkedListBox7_1_Search.Visible = false;
            dataGridView7_1_PrimatyLiterature.Visible = true;
        }

        private void toolStripButton7_1_Add_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox7_1_Search.CheckedItems)
            {
                //checkedListBox7_1_List.Items.Add(checkedListBox7_1_Search.Items[item]);
                SM.SessionObjects.ChapterSeven.PrimaryLiterature.Rows.Add(item);
            }
            checkedListBox7_1_Search.ClearSelected();
        }

        private void toolStripTextBox7_1_TextSearch_TextChanged(object sender, EventArgs e)
        {
            _changedSearchText = true;
        }

        private void toolStripTextBox7_1_TextSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                toolStripButton7_1_Search_Click(null, null);
            }
        }
        #endregion



    #endregion
    }
}

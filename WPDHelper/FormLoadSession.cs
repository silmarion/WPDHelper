using HelperLibrary;
using SessionLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WPDHelper
{
    public partial class FormLoadSession : Form
    {
        private List<SessionDirInfo> _sdi;

        public FormLoadSession()
        {
            InitializeComponent();
        }

        private void FormSession_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            var owner = this.Owner as Form1;
            _sdi = owner.SM.GetDisciplinesFromSessions(SessionType.Start);
            AddInList();
        }

        private void AddInList()
        {
            checkedListBox1.Items.Clear();
            foreach (var info in _sdi)
            {
                var str = String.Format("{0}. {1} {2}. Дата создания: {3}",
                    info.DisciplineName, info.DisciplineCode, info.FormOftraining, info.CreationDate);
                checkedListBox1.Items.Add(str);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var typeSession = SessionType.Start;
            switch (comboBox1.SelectedIndex)
            {
                case 0: typeSession = SessionType.Start; break;
                case 1: typeSession = SessionType.Complete; break;
            }
            var owner = this.Owner as Form1;
            _sdi = owner.SM.GetDisciplinesFromSessions(typeSession);
            AddInList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_DeleteSession_Click(object sender, EventArgs e)
        {
            var owner = this.Owner as Form1;
            foreach(int ch in checkedListBox1.CheckedIndices)
            {
                try
                {
                    owner.SM.DeleteSession(_sdi[ch].Path);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            comboBox1_SelectedIndexChanged(null, null);
        }

        private void button_UpdatePlan_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedIndices.Count == 0)
            {
                MessageBox.Show("Невозможно обновление данных. Необходимо выбрать сеансы для обновления.");
                return;
            }
            openFileDialog_UpdatePlan.ShowDialog();
        }

        private void openFileDialog_UpdatePlan_FileOk(object sender, CancelEventArgs e)
        {
            var owner = this.Owner as Form1;
            try
            {
                foreach (int ch in checkedListBox1.CheckedIndices)
                {
                    foreach (var f in openFileDialog_UpdatePlan.FileNames)
                    {
                        var extension = f.Substring(f.Length - 7);
                        if (extension == "plm.xml" || extension == "pli.xml")
                        {
                            owner.SM.UpdatePlan(_sdi[ch].Path, f);
                        }
                        else
                        {
                            File.Copy(f, _sdi[ch].Path + f.Substring(f.LastIndexOf('\\')), true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            comboBox1_SelectedIndexChanged(null, null);
        }

        private void button_LoadSession_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите сеанс для загрузки.");
                return;
            }
            var owner = this.Owner as Form1;
            try
            {
                owner.SM.LoadSession(_sdi[checkedListBox1.SelectedIndex].Path);
                owner.Initilize();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Критическая ошибка.");
            }
        }
    }
}

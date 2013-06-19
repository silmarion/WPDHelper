using HelperLibrary;
using SessionLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WPDHelper
{
    public partial class FormCreateSessionOn : Form
    {
        private List<SessionDirInfo> _sdi;

        public FormCreateSessionOn()
        {
            InitializeComponent();
        }

        private void FormCreateSessionOn_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            var owner = this.Owner as Form1;
            _sdi = owner.SM.GetDisciplinesFromSessions(SessionType.Start);
            AddInList();
        }

        private void AddInList()
        {
            listBox1.Items.Clear();
            foreach (var info in _sdi)
            {
                var str = String.Format("{0}. {1} {2}. Дата создания: {3}",
                    info.DisciplineName, info.DisciplineCode, info.FormOftraining, info.CreationDate);
                listBox1.Items.Add(str);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран сеанс.");
                return;
            }
            var owner = this.Owner as Form1;
            try
            {
                owner.SM.CreateSessionOn(_sdi[listBox1.SelectedIndex].Path);
                owner.Initilize();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критическая ошибка.\n" + ex ); 
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

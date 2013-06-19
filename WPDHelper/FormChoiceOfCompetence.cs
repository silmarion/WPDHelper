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
    public partial class FormChoiceOfCompetence : Form
    {
        private int _rowIndex;

        public FormChoiceOfCompetence()
        {
            InitializeComponent();
        }

        public FormChoiceOfCompetence(int rowIndex)
        {
            InitializeComponent();
            _rowIndex = rowIndex;
        }

        private void FormChoiceOfCompetence_Load(object sender, EventArgs e)
        {
            var parent = (Form1)this.Owner;
            var competence = parent.SM.SessionObjects.ChapterThree.Competence;
            for(var i = 0; i < competence.Count; i++)
            {
                var str = String.Format("{0} - {1}", competence.ElementAt(i).Key, competence.ElementAt(i).Value);
                checkedListBox1.Items.Add(str);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var parent = (Form1)this.Owner;
            var competence = parent.SM.SessionObjects.ChapterThree.Competence;
            var list = competence.Keys.ToList();
            var checkedItems = checkedListBox1.CheckedIndices;

            parent.dataGridView4_DistributionStudyTime.Rows[_rowIndex].Cells[2].Value = "";
            for (var i = 0; i < checkedItems.Count; i++)
            {
                if (i != checkedItems.Count - 1)
                {
                    parent.dataGridView4_DistributionStudyTime.Rows[_rowIndex].Cells[2].Value += list[checkedItems[i]] + ", ";
                }
                else
                {
                    parent.dataGridView4_DistributionStudyTime.Rows[_rowIndex].Cells[2].Value += list[checkedItems[i]];
                }
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

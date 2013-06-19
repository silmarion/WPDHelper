namespace WPDHelper
{
    partial class FormLoadSession
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button_LoadSession = new System.Windows.Forms.Button();
            this.button_UpdatePlan = new System.Windows.Forms.Button();
            this.button_DeleteSession = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.openFileDialog_UpdatePlan = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 442);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkedListBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 366);
            this.panel3.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(576, 366);
            this.checkedListBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button_LoadSession);
            this.panel1.Controls.Add(this.button_UpdatePlan);
            this.panel1.Controls.Add(this.button_DeleteSession);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 76);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выделите необходимый сеанс и нажмите кнопку \"Открыть\".";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(280, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Отменить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_LoadSession
            // 
            this.button_LoadSession.Location = new System.Drawing.Point(185, 10);
            this.button_LoadSession.Name = "button_LoadSession";
            this.button_LoadSession.Size = new System.Drawing.Size(75, 23);
            this.button_LoadSession.TabIndex = 3;
            this.button_LoadSession.Text = "Открыть";
            this.button_LoadSession.UseVisualStyleBackColor = true;
            this.button_LoadSession.Click += new System.EventHandler(this.button_LoadSession_Click);
            // 
            // button_UpdatePlan
            // 
            this.button_UpdatePlan.Location = new System.Drawing.Point(458, 39);
            this.button_UpdatePlan.Name = "button_UpdatePlan";
            this.button_UpdatePlan.Size = new System.Drawing.Size(106, 23);
            this.button_UpdatePlan.TabIndex = 2;
            this.button_UpdatePlan.Text = "Обновить данные";
            this.button_UpdatePlan.UseVisualStyleBackColor = true;
            this.button_UpdatePlan.Click += new System.EventHandler(this.button_UpdatePlan_Click);
            // 
            // button_DeleteSession
            // 
            this.button_DeleteSession.Location = new System.Drawing.Point(458, 10);
            this.button_DeleteSession.Name = "button_DeleteSession";
            this.button_DeleteSession.Size = new System.Drawing.Size(106, 23);
            this.button_DeleteSession.TabIndex = 1;
            this.button_DeleteSession.Text = "Удалить сеансы";
            this.button_DeleteSession.UseVisualStyleBackColor = true;
            this.button_DeleteSession.Click += new System.EventHandler(this.button_DeleteSession_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "открытые сеансы",
            "завершенные сеансы"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // openFileDialog_UpdatePlan
            // 
            this.openFileDialog_UpdatePlan.FileName = "openFileDialog1";
            this.openFileDialog_UpdatePlan.Multiselect = true;
            this.openFileDialog_UpdatePlan.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_UpdatePlan_FileOk);
            // 
            // FormLoadSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 442);
            this.Controls.Add(this.panel2);
            this.Name = "FormLoadSession";
            this.Text = "Открыть сеанс";
            this.Load += new System.EventHandler(this.FormSession_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_DeleteSession;
        private System.Windows.Forms.Button button_UpdatePlan;
        private System.Windows.Forms.OpenFileDialog openFileDialog_UpdatePlan;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_LoadSession;
        private System.Windows.Forms.Label label1;


    }
}
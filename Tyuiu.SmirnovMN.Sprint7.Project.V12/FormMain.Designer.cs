namespace Tyuiu.SmirnovMN.Sprint7.Project.V12
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFind_SMN = new System.Windows.Forms.TextBox();
            this.buttonSortAlp_SMN = new System.Windows.Forms.Button();
            this.buttonSortData_SMN = new System.Windows.Forms.Button();
            this.buttonFirma_SMN = new System.Windows.Forms.Button();
            this.buttonStat_SMN = new System.Windows.Forms.Button();
            this.dataGridViewIn_SMN = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonInfo_SMN = new System.Windows.Forms.Button();
            this.buttonOpen_SMN = new System.Windows.Forms.Button();
            this.buttonSave_SMN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_SMN)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.textBoxFind_SMN);
            this.groupBox1.Location = new System.Drawing.Point(185, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(303, 109);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Найти по названию";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxFind_SMN
            // 
            this.textBoxFind_SMN.Location = new System.Drawing.Point(18, 41);
            this.textBoxFind_SMN.Name = "textBoxFind_SMN";
            this.textBoxFind_SMN.Size = new System.Drawing.Size(262, 31);
            this.textBoxFind_SMN.TabIndex = 23;
            this.textBoxFind_SMN.TextChanged += new System.EventHandler(this.textBoxFind_SMN_TextChanged);
            // 
            // buttonSortAlp_SMN
            // 
            this.buttonSortAlp_SMN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSortAlp_SMN.Location = new System.Drawing.Point(71, 758);
            this.buttonSortAlp_SMN.Name = "buttonSortAlp_SMN";
            this.buttonSortAlp_SMN.Size = new System.Drawing.Size(213, 65);
            this.buttonSortAlp_SMN.TabIndex = 16;
            this.buttonSortAlp_SMN.Text = "Сортировать по алфавиту";
            this.buttonSortAlp_SMN.UseVisualStyleBackColor = false;
            this.buttonSortAlp_SMN.Click += new System.EventHandler(this.buttonSortAlp_SMN_Click);
            // 
            // buttonSortData_SMN
            // 
            this.buttonSortData_SMN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSortData_SMN.Location = new System.Drawing.Point(325, 758);
            this.buttonSortData_SMN.Name = "buttonSortData_SMN";
            this.buttonSortData_SMN.Size = new System.Drawing.Size(208, 65);
            this.buttonSortData_SMN.TabIndex = 17;
            this.buttonSortData_SMN.Text = "Сортировать по дате";
            this.buttonSortData_SMN.UseVisualStyleBackColor = false;
            this.buttonSortData_SMN.Click += new System.EventHandler(this.buttonSortData_SMN_Click);
            // 
            // buttonFirma_SMN
            // 
            this.buttonFirma_SMN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFirma_SMN.Location = new System.Drawing.Point(804, 740);
            this.buttonFirma_SMN.Name = "buttonFirma_SMN";
            this.buttonFirma_SMN.Size = new System.Drawing.Size(214, 83);
            this.buttonFirma_SMN.TabIndex = 18;
            this.buttonFirma_SMN.Text = "Список производителей";
            this.buttonFirma_SMN.UseVisualStyleBackColor = false;
            this.buttonFirma_SMN.Click += new System.EventHandler(this.buttonFirma_SMN_Click);
            // 
            // buttonStat_SMN
            // 
            this.buttonStat_SMN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStat_SMN.Location = new System.Drawing.Point(571, 758);
            this.buttonStat_SMN.Name = "buttonStat_SMN";
            this.buttonStat_SMN.Size = new System.Drawing.Size(198, 65);
            this.buttonStat_SMN.TabIndex = 19;
            this.buttonStat_SMN.Text = "Расчетные данные";
            this.buttonStat_SMN.UseVisualStyleBackColor = false;
            this.buttonStat_SMN.Click += new System.EventHandler(this.buttonStat_SMN_Click);
            // 
            // dataGridViewIn_SMN
            // 
            this.dataGridViewIn_SMN.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewIn_SMN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_SMN.Location = new System.Drawing.Point(31, 51);
            this.dataGridViewIn_SMN.Name = "dataGridViewIn_SMN";
            this.dataGridViewIn_SMN.RowHeadersWidth = 82;
            this.dataGridViewIn_SMN.RowTemplate.Height = 33;
            this.dataGridViewIn_SMN.Size = new System.Drawing.Size(797, 479);
            this.dataGridViewIn_SMN.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox2.Controls.Add(this.dataGridViewIn_SMN);
            this.groupBox2.Location = new System.Drawing.Point(38, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(980, 563);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список ЭВМ";
            // 
            // buttonInfo_SMN
            // 
            this.buttonInfo_SMN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonInfo_SMN.Image = global::Tyuiu.SmirnovMN.Sprint7.Project.V12.Properties.Resources.information;
            this.buttonInfo_SMN.Location = new System.Drawing.Point(662, 25);
            this.buttonInfo_SMN.Name = "buttonInfo_SMN";
            this.buttonInfo_SMN.Size = new System.Drawing.Size(129, 120);
            this.buttonInfo_SMN.TabIndex = 15;
            this.buttonInfo_SMN.Text = "\r\n\r\n\r\nInform\r\n";
            this.buttonInfo_SMN.UseVisualStyleBackColor = false;
            this.buttonInfo_SMN.Click += new System.EventHandler(this.buttonInfo_SMN_Click);
            // 
            // buttonOpen_SMN
            // 
            this.buttonOpen_SMN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOpen_SMN.Image = global::Tyuiu.SmirnovMN.Sprint7.Project.V12.Properties.Resources.email_open;
            this.buttonOpen_SMN.Location = new System.Drawing.Point(38, 19);
            this.buttonOpen_SMN.Name = "buttonOpen_SMN";
            this.buttonOpen_SMN.Size = new System.Drawing.Size(129, 130);
            this.buttonOpen_SMN.TabIndex = 21;
            this.buttonOpen_SMN.Text = "\r\n\r\n \r\nOpen file\r\n";
            this.buttonOpen_SMN.UseVisualStyleBackColor = false;
            this.buttonOpen_SMN.Click += new System.EventHandler(this.buttonOpen_SMN_Click);
            // 
            // buttonSave_SMN
            // 
            this.buttonSave_SMN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSave_SMN.Image = global::Tyuiu.SmirnovMN.Sprint7.Project.V12.Properties.Resources.page_save;
            this.buttonSave_SMN.Location = new System.Drawing.Point(820, 25);
            this.buttonSave_SMN.Name = "buttonSave_SMN";
            this.buttonSave_SMN.Size = new System.Drawing.Size(198, 119);
            this.buttonSave_SMN.TabIndex = 14;
            this.buttonSave_SMN.Text = "\r\n\r\n\r\nSave";
            this.buttonSave_SMN.UseVisualStyleBackColor = false;
            this.buttonSave_SMN.Click += new System.EventHandler(this.buttonSave_SMN_Click);
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1077, 888);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonInfo_SMN);
            this.Controls.Add(this.buttonOpen_SMN);
            this.Controls.Add(this.buttonStat_SMN);
            this.Controls.Add(this.buttonFirma_SMN);
            this.Controls.Add(this.buttonSortData_SMN);
            this.Controls.Add(this.buttonSortAlp_SMN);
            this.Controls.Add(this.buttonSave_SMN);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Спринт 7 | Проект | Вариант 12 | Смирнов М.Н.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_SMN)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSave_SMN;
        private System.Windows.Forms.Button buttonInfo_SMN;
        private System.Windows.Forms.Button buttonSortAlp_SMN;
        private System.Windows.Forms.Button buttonSortData_SMN;
        private System.Windows.Forms.Button buttonFirma_SMN;
        private System.Windows.Forms.Button buttonStat_SMN;
        private System.Windows.Forms.DataGridView dataGridViewIn_SMN;
        private System.Windows.Forms.Button buttonOpen_SMN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxFind_SMN;
    }
}
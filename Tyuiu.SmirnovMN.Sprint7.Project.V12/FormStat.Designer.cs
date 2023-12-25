namespace Tyuiu.SmirnovMN.Sprint7.Project.V12
{
    partial class FormStat
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMaxOZU_SMN = new System.Windows.Forms.Button();
            this.textBoxMaxOZU_SMN = new System.Windows.Forms.TextBox();
            this.chartDiag_SMN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewInStat_SMN = new System.Windows.Forms.DataGridView();
            this.buttonBigYadra_SMN = new System.Windows.Forms.Button();
            this.buttonDiag_SMN = new System.Windows.Forms.Button();
            this.textBoxYadra_SMN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SMN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInStat_SMN)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(696, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ядер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(696, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Гб";
            // 
            // buttonMaxOZU_SMN
            // 
            this.buttonMaxOZU_SMN.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonMaxOZU_SMN.Location = new System.Drawing.Point(131, 47);
            this.buttonMaxOZU_SMN.Name = "buttonMaxOZU_SMN";
            this.buttonMaxOZU_SMN.Size = new System.Drawing.Size(380, 105);
            this.buttonMaxOZU_SMN.TabIndex = 21;
            this.buttonMaxOZU_SMN.Text = "Максимальное количество оперативной памяти";
            this.buttonMaxOZU_SMN.UseVisualStyleBackColor = false;
            this.buttonMaxOZU_SMN.Click += new System.EventHandler(this.buttonMaxOZU_SMN_Click);
            // 
            // textBoxMaxOZU_SMN
            // 
            this.textBoxMaxOZU_SMN.BackColor = System.Drawing.Color.White;
            this.textBoxMaxOZU_SMN.Location = new System.Drawing.Point(570, 121);
            this.textBoxMaxOZU_SMN.Name = "textBoxMaxOZU_SMN";
            this.textBoxMaxOZU_SMN.Size = new System.Drawing.Size(119, 31);
            this.textBoxMaxOZU_SMN.TabIndex = 20;
            // 
            // chartDiag_SMN
            // 
            this.chartDiag_SMN.BackColor = System.Drawing.Color.AntiqueWhite;
            this.chartDiag_SMN.BorderlineColor = System.Drawing.Color.AntiqueWhite;
            chartArea2.Name = "ChartArea1";
            this.chartDiag_SMN.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDiag_SMN.Legends.Add(legend2);
            this.chartDiag_SMN.Location = new System.Drawing.Point(59, 341);
            this.chartDiag_SMN.Name = "chartDiag_SMN";
            this.chartDiag_SMN.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "inches";
            this.chartDiag_SMN.Series.Add(series2);
            this.chartDiag_SMN.Size = new System.Drawing.Size(1036, 527);
            this.chartDiag_SMN.TabIndex = 19;
            this.chartDiag_SMN.Text = "chart1";
            // 
            // dataGridViewInStat_SMN
            // 
            this.dataGridViewInStat_SMN.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewInStat_SMN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInStat_SMN.GridColor = System.Drawing.Color.White;
            this.dataGridViewInStat_SMN.Location = new System.Drawing.Point(1010, 73);
            this.dataGridViewInStat_SMN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewInStat_SMN.Name = "dataGridViewInStat_SMN";
            this.dataGridViewInStat_SMN.RowHeadersWidth = 51;
            this.dataGridViewInStat_SMN.RowTemplate.Height = 24;
            this.dataGridViewInStat_SMN.Size = new System.Drawing.Size(67, 61);
            this.dataGridViewInStat_SMN.TabIndex = 17;
            this.dataGridViewInStat_SMN.Visible = false;
            // 
            // buttonBigYadra_SMN
            // 
            this.buttonBigYadra_SMN.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonBigYadra_SMN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBigYadra_SMN.Location = new System.Drawing.Point(131, 187);
            this.buttonBigYadra_SMN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBigYadra_SMN.Name = "buttonBigYadra_SMN";
            this.buttonBigYadra_SMN.Size = new System.Drawing.Size(380, 99);
            this.buttonBigYadra_SMN.TabIndex = 16;
            this.buttonBigYadra_SMN.Text = "Самое большое количество ядер";
            this.buttonBigYadra_SMN.UseVisualStyleBackColor = false;
            this.buttonBigYadra_SMN.Click += new System.EventHandler(this.buttonBigYadra_SMN_Click);
            // 
            // buttonDiag_SMN
            // 
            this.buttonDiag_SMN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDiag_SMN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDiag_SMN.Location = new System.Drawing.Point(910, 191);
            this.buttonDiag_SMN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDiag_SMN.Name = "buttonDiag_SMN";
            this.buttonDiag_SMN.Size = new System.Drawing.Size(185, 109);
            this.buttonDiag_SMN.TabIndex = 15;
            this.buttonDiag_SMN.Text = " Показать диагонали ЭВМ";
            this.buttonDiag_SMN.UseVisualStyleBackColor = false;
            this.buttonDiag_SMN.Click += new System.EventHandler(this.buttonDiag_SMN_Click);
            // 
            // textBoxYadra_SMN
            // 
            this.textBoxYadra_SMN.Location = new System.Drawing.Point(570, 241);
            this.textBoxYadra_SMN.Name = "textBoxYadra_SMN";
            this.textBoxYadra_SMN.Size = new System.Drawing.Size(119, 31);
            this.textBoxYadra_SMN.TabIndex = 24;
            this.textBoxYadra_SMN.TextChanged += new System.EventHandler(this.textBoxYadra_SMN_TextChanged);
            // 
            // FormStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1155, 925);
            this.Controls.Add(this.textBoxYadra_SMN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMaxOZU_SMN);
            this.Controls.Add(this.textBoxMaxOZU_SMN);
            this.Controls.Add(this.chartDiag_SMN);
            this.Controls.Add(this.dataGridViewInStat_SMN);
            this.Controls.Add(this.buttonBigYadra_SMN);
            this.Controls.Add(this.buttonDiag_SMN);
            this.Name = "FormStat";
            this.Text = "FormStat";
            this.Load += new System.EventHandler(this.FormStat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SMN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInStat_SMN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMaxOZU_SMN;
        private System.Windows.Forms.TextBox textBoxMaxOZU_SMN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_SMN;
        private System.Windows.Forms.DataGridView dataGridViewInStat_SMN;
        private System.Windows.Forms.Button buttonBigYadra_SMN;
        private System.Windows.Forms.Button buttonDiag_SMN;
        private System.Windows.Forms.TextBox textBoxYadra_SMN;
    }
}
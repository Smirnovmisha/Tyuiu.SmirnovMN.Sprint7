namespace Tyuiu.SmirnovMN.Sprint7.Project.V12
{
    partial class FormFirma
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
            this.buttonBrowser_GVE = new System.Windows.Forms.Button();
            this.dataGridViewInFirma_GVE = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewInFirma_SMN = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInFirma_GVE)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInFirma_SMN)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBrowser_GVE
            // 
            this.buttonBrowser_GVE.Location = new System.Drawing.Point(52, 572);
            this.buttonBrowser_GVE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBrowser_GVE.Name = "buttonBrowser_GVE";
            this.buttonBrowser_GVE.Size = new System.Drawing.Size(242, 70);
            this.buttonBrowser_GVE.TabIndex = 4;
            this.buttonBrowser_GVE.Text = "Открыть браузер";
            this.buttonBrowser_GVE.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInFirma_GVE
            // 
            this.dataGridViewInFirma_GVE.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewInFirma_GVE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInFirma_GVE.Location = new System.Drawing.Point(50, 33);
            this.dataGridViewInFirma_GVE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewInFirma_GVE.Name = "dataGridViewInFirma_GVE";
            this.dataGridViewInFirma_GVE.RowHeadersWidth = 51;
            this.dataGridViewInFirma_GVE.RowTemplate.Height = 24;
            this.dataGridViewInFirma_GVE.Size = new System.Drawing.Size(960, 528);
            this.dataGridViewInFirma_GVE.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.dataGridViewInFirma_SMN);
            this.groupBox1.Location = new System.Drawing.Point(53, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 614);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о производителях";
            // 
            // dataGridViewInFirma_SMN
            // 
            this.dataGridViewInFirma_SMN.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewInFirma_SMN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInFirma_SMN.Location = new System.Drawing.Point(6, 52);
            this.dataGridViewInFirma_SMN.Name = "dataGridViewInFirma_SMN";
            this.dataGridViewInFirma_SMN.RowHeadersWidth = 82;
            this.dataGridViewInFirma_SMN.RowTemplate.Height = 33;
            this.dataGridViewInFirma_SMN.Size = new System.Drawing.Size(992, 539);
            this.dataGridViewInFirma_SMN.TabIndex = 4;
            this.dataGridViewInFirma_SMN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInFirma_SMN_CellContentClick);
            // 
            // FormFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1126, 683);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonBrowser_GVE);
            this.Controls.Add(this.dataGridViewInFirma_GVE);
            this.Name = "FormFirma";
            this.Text = "FormFirma";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInFirma_GVE)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInFirma_SMN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowser_GVE;
        private System.Windows.Forms.DataGridView dataGridViewInFirma_GVE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewInFirma_SMN;
    }
}
namespace Tyuiu.SmirnovMN.Sprint7.Project.V12
{
    partial class FormAbout
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
            this.buttonClose_SMN = new System.Windows.Forms.Button();
            this.label_SMN = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose_SMN
            // 
            this.buttonClose_SMN.BackColor = System.Drawing.Color.White;
            this.buttonClose_SMN.Location = new System.Drawing.Point(417, 265);
            this.buttonClose_SMN.Name = "buttonClose_SMN";
            this.buttonClose_SMN.Size = new System.Drawing.Size(198, 76);
            this.buttonClose_SMN.TabIndex = 12;
            this.buttonClose_SMN.Text = "OK";
            this.buttonClose_SMN.UseVisualStyleBackColor = false;
            this.buttonClose_SMN.Click += new System.EventHandler(this.buttonClose_SMN_Click);
            // 
            // label_SMN
            // 
            this.label_SMN.AutoSize = true;
            this.label_SMN.Location = new System.Drawing.Point(257, 56);
            this.label_SMN.Name = "label_SMN";
            this.label_SMN.Size = new System.Drawing.Size(553, 225);
            this.label_SMN.TabIndex = 11;
            this.label_SMN.Text = "Разработчик: Смирнов М.Н.\r\nгруппа ИИПб-23-2\r\n\r\nПрограмма разработана в рамках изу" +
    "чения языка C#\r\n\r\nТюменский индустриальный университет (с) 2023\r\nВысшая школа ци" +
    "фровых технологий (с) 2023\r\n\r\n\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Tyuiu.SmirnovMN.Sprint7.Project.V12.Properties.Resources.photo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 56);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 285);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(822, 397);
            this.Controls.Add(this.buttonClose_SMN);
            this.Controls.Add(this.label_SMN);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAbout";
            this.Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose_SMN;
        private System.Windows.Forms.Label label_SMN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
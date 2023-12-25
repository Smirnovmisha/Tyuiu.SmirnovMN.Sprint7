using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.SmirnovMN.Sprint7.Project.V12.Lib;

namespace Tyuiu.SmirnovMN.Sprint7.Project.V12
{
    public partial class FormStat : Form
    {
        private DataTable ReadCSVFile(string pathToCsvFile)
        {
            //создаём таблицу 
            DataTable dt = new DataTable();
            //создаём колонки
            DataColumn colIVM;
            colIVM = new DataColumn("ЭВМ", typeof(String));
            DataColumn colName;
            colName = new DataColumn("Фирма", typeof(String));
            DataColumn colProc;
            colProc = new DataColumn("Процессор", typeof(String));
            DataColumn colYAD;
            colYAD = new DataColumn("Количество ядер", typeof(Int32));
            DataColumn colOZ;
            colOZ = new DataColumn("Объем ОЗУ (ГБ)", typeof(Int32));
            DataColumn colDIAG;
            colDIAG = new DataColumn("Диагональ", typeof(Double));
            DataColumn colYear;
            colYear = new DataColumn("Дата выпуска", typeof(Int32));
            //добавляем колонки в таблицу
            dt.Columns.AddRange(new DataColumn[] { colIVM, colName, colProc, colYAD, colOZ, colDIAG, colYear });
            try
            {
                DataRow dr = null;
                string[] ivmValues = null;
                string[] ivm = File.ReadAllLines(pathToCsvFile);
                for (int i = 0; i < ivm.Length; i++)
                {
                    if (!String.IsNullOrEmpty(ivm[i]))
                    {
                        ivmValues = ivm[i].Split(';');
                        //создаём новую строку
                        dr = dt.NewRow();
                        dr["ЭВМ"] = ivmValues[0];
                        dr["Фирма"] = ivmValues[1];
                        dr["Процессор"] = ivmValues[2];
                        dr["Количество ядер"] = int.Parse(ivmValues[3]);
                        dr["Объем ОЗУ (ГБ)"] = int.Parse(ivmValues[4]);
                        dr["Диагональ"] = Double.Parse(ivmValues[5]);
                        dr["Дата выпуска"] = int.Parse(ivmValues[6]);
                        //добавляем строку в таблицу
                        dt.Rows.Add(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public FormStat()
        {
            InitializeComponent();
            dataGridViewInStat_SMN.DataSource = ReadCSVFile(@"C:\Users\mishasmirnov\source\repos\Tyuiu.SmirnovMN.Sprint7\Tyuiu.SmirnovMN.Sprint7.Project.V12\bin\Debug\InPutEC_Sprint7.csv");
        }

        DataService ds = new DataService();

        private void FormStat_Load(object sender, EventArgs e)
        {

        }

        private void buttonMaxOZU_SMN_Click(object sender, EventArgs e)
        {
            double maxOZU = double.MinValue; // Инициализация с самым маленьким возможным значением

            foreach (DataGridViewRow row in dataGridViewInStat_SMN.Rows)
            {
                if (row.Cells["Объем ОЗУ (ГБ)"].Value != null)
                {
                    double currentOZU;
                    if (double.TryParse(row.Cells["Объем ОЗУ (ГБ)"].Value.ToString(), out currentOZU))
                    {
                        if (currentOZU > maxOZU)
                        {
                            maxOZU = currentOZU;
                        }
                    }
                }
            }

            if (maxOZU != double.MinValue)
            {
                textBoxMaxOZU_SMN.Text = Convert.ToString(maxOZU);
            }
            else
            {
                textBoxMaxOZU_SMN.Text = "Нет данных";
            }
        }

        private void buttonBigYadra_SMN_Click(object sender, EventArgs e)
        {
            int maxNumber = int.MinValue;
            foreach (DataGridViewRow row in dataGridViewInStat_SMN.Rows)
            {
                if (row.Cells["Количество ядер"].Value != null)
                {
                    int currentValue;
                    if (int.TryParse(row.Cells["Количество ядер"].Value.ToString(), out currentValue))
                    {
                        if (currentValue > maxNumber)
                        {
                            maxNumber = currentValue;
                        }
                    }
                }
            }
            textBoxYadra_SMN.Text = Convert.ToString(maxNumber);
        }

        private void textBoxYadra_SMN_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDiag_SMN_Click(object sender, EventArgs e)
        {
            chartDiag_SMN.Series[0].Points.Clear();

            foreach (DataGridViewRow row in dataGridViewInStat_SMN.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null) // проверяем что ячейки не пустые
                {
                    string xValue = row.Cells[0].Value.ToString(); // название эвм
                    double yValue = Convert.ToDouble(row.Cells[5].Value); // его диагональ

                    chartDiag_SMN.Series["inches"].Points.AddXY(xValue, yValue); // добавляем 
                }
            }
        }
    }
}

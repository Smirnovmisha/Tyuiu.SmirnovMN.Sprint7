using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Tyuiu.SmirnovMN.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        private SaveFileDialog saveFileDialog_SMN;
        public FormMain()
        {
            InitializeComponent();

            saveFileDialog_SMN = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "Save CSV File"
            };

        }

        //метод чтения данных из файла
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        

        private void buttonSave_SMN_Click(object sender, EventArgs e)
        {
            try
            {
                // Открываем диалог сохранения файла
                saveFileDialog_SMN.FileName = "OutPutIVM.csv";
                saveFileDialog_SMN.InitialDirectory = Directory.GetCurrentDirectory();
                DialogResult result = saveFileDialog_SMN.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string path = saveFileDialog_SMN.FileName;

                    // Проверяем существование файла
                    FileInfo fileInfo = new FileInfo(path);
                    bool fileExists = fileInfo.Exists;
                    if (fileExists)
                    {
                        File.Delete(path);
                    }

                    // Получаем количество строк и столбцов в DataGridView
                    int rows = dataGridViewIn_SMN.RowCount;
                    int columns = dataGridViewIn_SMN.ColumnCount;

                    // Строка для записи в файл
                    string str = "";

                    // Проходим по всем строкам и столбцам DataGridView
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            // Формируем строку в формате CSV
                            if (j != columns - 1)
                            {
                                str = str + dataGridViewIn_SMN.Rows[i].Cells[j].Value + ";";
                            }
                            else
                            {
                                str = str + dataGridViewIn_SMN.Rows[i].Cells[j].Value;
                            }
                        }
                        // Добавляем строку в файл
                        File.AppendAllText(path, str + Environment.NewLine);
                        str = "";
                    }

                    // Предложение открыть файл в блокноте после сохранения
                    DialogResult dialogres = MessageBox.Show("Файл " + path + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogres == DialogResult.Yes)
                    {
                        System.Diagnostics.Process txt = new System.Diagnostics.Process();
                        txt.StartInfo.FileName = "notepad.exe";
                        txt.StartInfo.Arguments = path;
                        txt.Start();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void buttonInfo_SMN_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }

        private void buttonSortAlp_SMN_Click(object sender, EventArgs e)
        {
            this.dataGridViewIn_SMN.Sort(this.dataGridViewIn_SMN.Columns["ЭВМ"], ListSortDirection.Ascending);
        }

        private void buttonSortData_SMN_Click(object sender, EventArgs e)
        {
            this.dataGridViewIn_SMN.Sort(this.dataGridViewIn_SMN.Columns["Дата выпуска"], ListSortDirection.Ascending);
        }

        private void buttonFirma_SMN_Click(object sender, EventArgs e)
        {
            FormFirma formfirma = new FormFirma();
            formfirma.ShowDialog();
        }

        private void buttonStat_SMN_Click(object sender, EventArgs e)
        {
            FormStat formstat = new FormStat();
            formstat.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpen_SMN_Click(object sender, EventArgs e)
        {
            dataGridViewIn_SMN.DataSource = ReadCSVFile(@"C:\Users\mishasmirnov\source\repos\Tyuiu.SmirnovMN.Sprint7\Tyuiu.SmirnovMN.Sprint7.Project.V12\bin\Debug\InPutEC_Sprint7.csv");
        }

        private void textBoxFind_SMN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (dataGridViewIn_SMN.DataSource as DataTable).DefaultView.RowFilter = $"ЭВМ LIKE '%{textBoxFind_SMN.Text}%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tyuiu.SmirnovMN.Sprint7.Project.V12
{
    public partial class FormFirma : Form
    {
        private DataTable ReadCSVFile(string pathToCsvFile)
        {
            //создаём таблицу
            DataTable dt = new DataTable();
            //создаём колонки
            DataColumn colIVM;
            colIVM = new DataColumn("Фирма", typeof(String));
            DataColumn colName;
            colName = new DataColumn("Месторасположение", typeof(String));
            DataColumn colProc;
            colProc = new DataColumn("Год основания", typeof(Int32));
            DataColumn colYAD;
            colYAD = new DataColumn("Основатель", typeof(String));

            //добавляем колонки в таблицу
            dt.Columns.AddRange(new DataColumn[] { colIVM, colName, colProc, colYAD });
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
                        dr["Фирма"] = ivmValues[0];
                        dr["Месторасположение"] = ivmValues[1];
                        dr["Год основания"] = int.Parse(ivmValues[2]);
                        dr["Основатель"] = ivmValues[3];
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

        public FormFirma()
        {
            InitializeComponent();
            dataGridViewInFirma_SMN.DataSource = ReadCSVFile(@"C:\Users\mishasmirnov\source\repos\Tyuiu.SmirnovMN.Sprint7\Tyuiu.SmirnovMN.Sprint7.Project.V12\bin\Debug\InPutFirma_Sprint7.csv");

        }

        private void dataGridViewInFirma_SMN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

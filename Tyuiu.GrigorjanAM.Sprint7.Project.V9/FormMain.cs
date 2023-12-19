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
using Tyuiu.GrigorjanAM.Sprint7.Project.V9.Lib;

namespace Tyuiu.GrigorjanAM.Sprint7.Project.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\djura\Desktop\DataSet.csv";
        static string openFile;
        static int rows;
        static int columns;
        static string[,] matrix;
        private void buttonLoad_GAM_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogMain_GAM.ShowDialog();
                openFile = openFileDialogMain_GAM.FileName;

                matrix = ds.LoadDataSet(openFile);
                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);
                dataGridViewBase_GAM.RowCount = rows;
                dataGridViewBase_GAM.ColumnCount = columns;

                
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewBase_GAM.Rows[i].Cells[j].Value = matrix[i, j];
                        dataGridViewBase_GAM.Rows[i].Cells[j].Selected = false;
                    }
                }
                dataGridViewBase_GAM.Columns[0].Width = 100;
                dataGridViewBase_GAM.Columns[1].Width = 150;
                dataGridViewBase_GAM.Columns[3].Width = 150;

            }
            catch
            {
                MessageBox.Show("Возникла проблема с открытием файла", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_GAM_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogMain_GAM.FileName = "OutPutFileTask7.csv";
                saveFileDialogMain_GAM.InitialDirectory = Directory.GetCurrentDirectory();

                if (saveFileDialogMain_GAM.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialogMain_GAM.FileName;

                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }

                    int rows = dataGridViewBase_GAM.RowCount;
                    int columns = dataGridViewBase_GAM.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridViewBase_GAM.Rows[i].Cells[j].Value);

                            if (j != columns - 1)
                            {
                                strBuilder.Append(";");
                            }
                        }

                        strBuilder.AppendLine();
                    }

                    File.WriteAllText(path, strBuilder.ToString(), Encoding.UTF8);

                    MessageBox.Show("Файл успешно сохранен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось сохранить файл. Ошибка: {ex.Message}", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonAbout_GAM_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonSearch_GAM_Click(object sender, EventArgs e)
        {

        }



        private void сортировкаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string[,] mx = ds.LoadDataSet(path);
            string[,] mxsort = ds.SortVozr(mx, 2);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewBase_GAM.Rows[i].Cells[j].Value = mxsort[i, j];
                }
            }
        }

        private void столбецВесToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[,] mx = ds.LoadDataSet(path);
            string[,] mxsort = ds.SortVozr(mx, 5);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewBase_GAM.Rows[i].Cells[j].Value = mxsort[i, j];
                }
            }
        }


        private void столбецIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[,] mx = ds.LoadDataSet(path);
            string[,] mxsort = ds.SortVozr(mx, 0);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewBase_GAM.Rows[i].Cells[j].Value = mxsort[i, j];
                }
            }
        }

        
        private void buttonReset_GAM_Click(object sender, EventArgs e)
        {
            matrix = ds.LoadDataSet(path);
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
            dataGridViewBase_GAM.RowCount = rows;
            dataGridViewBase_GAM.ColumnCount = columns;


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewBase_GAM.Rows[i].Cells[j].Value = matrix[i, j];
                    dataGridViewBase_GAM.Rows[i].Cells[j].Selected = false;
                }
            }
            dataGridViewBase_GAM.Columns[0].Width = 100;
            dataGridViewBase_GAM.Columns[1].Width = 150;
            dataGridViewBase_GAM.Columns[3].Width = 150;
        }

        private void столбецДлительностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[,] mx = ds.LoadDataSet(path);
            string[,] mxsort = ds.SortMax(mx, 2);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewBase_GAM.Rows[i].Cells[j].Value = mxsort[i, j];
                }
            }
        }

        private void столбецВесToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string[,] mx = ds.LoadDataSet(path);
            string[,] mxsort = ds.SortMax(mx, 5);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewBase_GAM.Rows[i].Cells[j].Value = mxsort[i, j];
                }
            }
        }

        private void столбецДатаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string[,] mx = ds.LoadDataSet(path);
            string[,] mxsort = ds.SortMax(mx, 0);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewBase_GAM.Rows[i].Cells[j].Value = mxsort[i, j];
                }
            }
        }

      

        private void buttonRight_GAM_Click(object sender, EventArgs e)
        {
            dataGridViewBase_GAM.HorizontalScrollingOffset = dataGridViewBase_GAM.HorizontalScrollingOffset + 10;
        }

        private void buttonLeft_GAM_Click(object sender, EventArgs e)
        {
            if (dataGridViewBase_GAM.HorizontalScrollingOffset >= 10)
            {
                dataGridViewBase_GAM.HorizontalScrollingOffset = dataGridViewBase_GAM.HorizontalScrollingOffset - 10;
            }
            else
            {
                dataGridViewBase_GAM.HorizontalScrollingOffset = 0;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GrigorjanAM.Sprint7.Project.V9.Lib;


namespace Tyuiu.GrigorjanAM.Sprint7.Project.V9
{
    public partial class FormSort : Form
    {
        public FormSort()
        {
            InitializeComponent();
            try
            {
                openFileDialogSort_GAM.ShowDialog();
                openFile = openFileDialogSort_GAM.FileName;

                matrix = ds.LoadDataSet(openFile);
                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);
                dataGridViewBaseSort_GAM.RowCount = rows;
                dataGridViewBaseSort_GAM.ColumnCount = columns;


                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewBaseSort_GAM.Rows[i].Cells[j].Value = matrix[i, j];
                        dataGridViewBaseSort_GAM.Rows[i].Cells[j].Selected = false;
                    }
                }
                dataGridViewBaseSort_GAM.Columns[0].Width = 100;
                dataGridViewBaseSort_GAM.Columns[1].Width = 150;
                dataGridViewBaseSort_GAM.Columns[3].Width = 150;

            }
            catch
            {
                MessageBox.Show("Возникла проблема с открытием файла", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        DataService ds = new DataService();
        string path = @"C:\Users\djura\Desktop\DataSet.csv";
        private void buttonBackSort_GAM_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        static string openFile;
        static int rows;
        static int columns;
        static string[,] matrix;
        private void сортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string[,] mx = ds.LoadDataSet(path);
            string[,] mxsort = ds.SortMin(mx, 2);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewBaseSort_GAM.Rows[i].Cells[j].Value = mxsort[i, j];
                }
            }
            
        }


    }
}

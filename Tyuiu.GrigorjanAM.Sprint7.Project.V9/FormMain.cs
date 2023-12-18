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
                dataGridViewBase_GAM.RowCount = 250;
                dataGridViewBase_GAM.ColumnCount = 50;

                for (int i = 0; i < rows; i++)
                {
                    dataGridViewBase_GAM.Columns[i].Width = 135;
                }
                for (int i = 1; i < rows; i++)
                {
                    for (int j = 1; j < columns; j++)
                    {
                        dataGridViewBase_GAM.Rows[i-1].Cells[j-1].Value = matrix[i, j];
                        dataGridViewBase_GAM.Rows[i-1].Cells[j-1].Selected = false;
                    }
                }
                for (int i = 0; i < rows-1; i++)
                {
                    for (int j = 0; j < columns-1; j++)
                    {
                        dataGridViewBase_GAM.Rows[i].HeaderCell.Value = matrix[i+1, 0];
                        dataGridViewBase_GAM.Columns[j].HeaderCell.Value = matrix[0, j+1];
                    }

                }
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

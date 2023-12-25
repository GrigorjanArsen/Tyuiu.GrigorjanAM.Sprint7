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
            FormMenu formmenu = new FormMenu();
            formmenu.TopMost = true;
            formmenu.Show();


        }
        
        DataService ds = new DataService();
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DataSet.csv");
        //string path = @"C:\Users\djura\Desktop\DataSet.csv";
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
                dataGridViewBase_GAM.RowCount = rows + 1;
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
                dataGridViewBase_GAM.Columns[6].Width = 900;
                buttonReset_GAM.Enabled = true;

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
            dataGridViewBase_GAM.ClearSelection();
            if (textBoxSearch_GAM.Text == "")
            {
                MessageBox.Show("Введите критерий для поиска", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (matrix[i, j].ToLower().Contains(textBoxSearch_GAM.Text.ToLower()))
                        {
                            dataGridViewBase_GAM.Rows[i].Selected = true;
                        }
                    }
                }
            }
            

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
            for (int v = 0; v < rows; v++)
            {
                dataGridViewBase_GAM.Rows[v].Visible = true;
            }

            dataGridViewBase_GAM.Rows.Clear();
            matrix = ds.LoadDataSet(path);
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
            dataGridViewBase_GAM.RowCount = rows + 1;
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
            string[,] mxsort = ds.SortUbyv(mx, 2);
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
            string[,] mxsort = ds.SortUbyv(mx, 5);
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
            string[,] mxsort = ds.SortUbyv(mx, 0);
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

        private void buttonFilter_GAM_Click(object sender, EventArgs e)
        {
            if (textBoxFilter_GAM.Text == "")
            {
                MessageBox.Show("Введите критерий для фильтрации", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string filterValue = textBoxFilter_GAM.Text.ToLower();
                for (int i = 1; i < dataGridViewBase_GAM.Rows.Count; i++)
                {
                    if (!dataGridViewBase_GAM.Rows[i].IsNewRow)
                    {
                        bool rowShouldBeVisible = false;

                        for (int j = 0; j < dataGridViewBase_GAM.Columns.Count; j++)
                        {
                            var cellValue = dataGridViewBase_GAM.Rows[i].Cells[j].Value?.ToString()?.ToLower();

                            if (cellValue != null && cellValue.IndexOf(filterValue, StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                rowShouldBeVisible = true;
                                break;
                            }
                        }
                        for (int q = 0; q < columns; q++)
                        {
                            dataGridViewBase_GAM.Rows[matrix.GetLength(0) - 1].Cells[q].Value = "";

                        }

                        dataGridViewBase_GAM.Rows[i].Visible = rowShouldBeVisible;

                    }
                }
            }
            //string filtervalue = textBoxFilter_GAM.Text.ToLower();
            //for (int i = 1; i < rows; i++)
            //{
            //    if (!(matrix[i, 1].ToLower().Contains(filtervalue)))
            //    {
            //        dataGridViewBase_GAM.Rows[i].Visible = false;
            //    }

            //}


        }

        private void buttonManagement_GAM_Click(object sender, EventArgs e)
        {
            FormManual formmanual = new FormManual();
            formmanual.ShowDialog();
        }

        private void buttonLoad_GAM_MouseEnter(object sender, EventArgs e)
        {
            buttonLoad_GAM.BackColor = Color.DarkTurquoise;
            buttonLoad_GAM.ForeColor = Color.Black;
        }
            
      

        private void buttonSave_GAM_MouseEnter(object sender, EventArgs e)
        {
            buttonSave_GAM.BackColor = Color.DarkTurquoise;
            buttonSave_GAM.ForeColor = Color.Black;
        }

        private void buttonSave_GAM_MouseLeave(object sender, EventArgs e)
        {
            buttonSave_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonSave_GAM.ForeColor = Color.WhiteSmoke;
        }

        private void buttonLoad_GAM_MouseLeave(object sender, EventArgs e)
        {
            buttonLoad_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonLoad_GAM.ForeColor = Color.WhiteSmoke;
        }

        private void buttonManagement_GAM_MouseEnter(object sender, EventArgs e)
        {
            buttonManagement_GAM.BackColor = Color.DarkTurquoise;
            buttonManagement_GAM.ForeColor = Color.Black;
        }

        private void buttonManagement_GAM_MouseLeave(object sender, EventArgs e)
        {
            buttonManagement_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonManagement_GAM.ForeColor = Color.WhiteSmoke;
        }

        private void buttonAbout_GAM_MouseEnter(object sender, EventArgs e)
        {
            buttonAbout_GAM.BackColor = Color.DarkTurquoise;
            buttonAbout_GAM.ForeColor = Color.Black;
        }

        private void buttonAbout_GAM_MouseLeave(object sender, EventArgs e)
        {
            buttonAbout_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonAbout_GAM.ForeColor = Color.WhiteSmoke;
        }

        private void buttonSearch_GAM_MouseEnter(object sender, EventArgs e)
        {
            buttonSearch_GAM.BackColor = Color.DarkTurquoise;
            buttonSearch_GAM.ForeColor = Color.Black;
        }

        private void buttonSearch_GAM_MouseLeave(object sender, EventArgs e)
        {
            buttonSearch_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonSearch_GAM.ForeColor = Color.WhiteSmoke;
        }

        private void buttonReset_GAM_MouseEnter(object sender, EventArgs e)
        {
            buttonReset_GAM.BackColor = Color.DarkTurquoise;

        }

        private void buttonReset_GAM_MouseLeave(object sender, EventArgs e)
        {
            buttonReset_GAM.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void buttonLeft_GAM_MouseEnter(object sender, EventArgs e)
        {
            buttonLeft_GAM.BackColor = Color.LightGray;
        }

        private void buttonLeft_GAM_MouseLeave(object sender, EventArgs e)
        {
            buttonLeft_GAM.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void buttonRight_GAM_MouseEnter(object sender, EventArgs e)
        {
            buttonRight_GAM.BackColor = Color.LightGray;
        }

        private void buttonRight_GAM_MouseLeave(object sender, EventArgs e)
        {
            buttonRight_GAM.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void buttonGraph_GAM_Click(object sender, EventArgs e)
        {
            FormGraph fg = new FormGraph();

            fg.Show();
           
            
        }

        private void названиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string filtervalue = textBoxFilter_GAM.Text.ToLower();
                for (int i = 1; i < rows; i++)
                {
                    if (!(matrix[i, 1].ToLower().Contains(filtervalue)))
                    {
                        dataGridViewBase_GAM.Rows[i].Visible = false;
                        //dataGridViewBase_GAM.Rows.RemoveAt(i);
                        
                    }


                }
                //dataGridViewBase_GAM.Rows.RemoveAt(rows);
                dataGridViewBase_GAM.Rows[rows].Visible = false;
                
            }
            catch
            {
                
            }
        }

        private void весToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string filtervalue = textBoxFilter_GAM.Text.ToLower();
                for (int i = 1; i < rows; i++)
                {
                    if (!(matrix[i, 5].ToLower().Contains(filtervalue)))
                    {
                        dataGridViewBase_GAM.Rows[i].Visible = false;
                    }

                }
                dataGridViewBase_GAM.Rows[rows].Visible = false;
            }
            catch
            {
                
            }
        }

        private void длительностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string filtervalue = textBoxFilter_GAM.Text.ToLower();
                for (int i = 1; i < rows; i++)
                {
                    if (!(matrix[i, 2].ToLower().Contains(filtervalue)))
                    {
                        dataGridViewBase_GAM.Rows[i].Visible = false;
                    }

                }
                dataGridViewBase_GAM.Rows[rows].Visible = false;
            }
            catch
            {
                
            }
        }

        private void форматToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string filtervalue = textBoxFilter_GAM.Text.ToLower();
                for (int i = 1; i < rows; i++)
                {
                    if (!(matrix[i, 3].ToLower().Contains(filtervalue)))
                    {
                        dataGridViewBase_GAM.Rows[i].Visible = false;
                    }

                }
                dataGridViewBase_GAM.Rows[rows].Visible = false;
            }
            catch
            {
                
            }
        }

        private void категорияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string filtervalue = textBoxFilter_GAM.Text.ToLower();
                for (int i = 1; i < rows; i++)
                {
                    if (!(matrix[i, 6].ToLower().Contains(filtervalue)))
                    {
                        dataGridViewBase_GAM.Rows[i].Visible = false;
                    }

                }
                dataGridViewBase_GAM.Rows[rows].Visible = false;
            }
            catch
            {
               
            }
        }

        private void iDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string filtervalue = textBoxFilter_GAM.Text.ToLower();
                for (int i = 1; i < rows; i++)
                {
                    if (!(matrix[i, 0].ToLower().Contains(filtervalue)))
                    {
                        dataGridViewBase_GAM.Rows[i].Visible = false;
                    }

                }
                dataGridViewBase_GAM.Rows[rows].Visible = false;
                
        }
            catch
            {
                
            }
}

        private void buttonGraph_GAM_MouseEnter(object sender, EventArgs e)
        {
            buttonGraph_GAM.BackColor = Color.DarkTurquoise;
            buttonGraph_GAM.ForeColor = Color.Black;
        }

        private void buttonGraph_GAM_MouseLeave(object sender, EventArgs e)
        {
            buttonGraph_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonGraph_GAM.ForeColor = Color.WhiteSmoke;
        }

        private void buttonMenu_GAM_Click(object sender, EventArgs e)
        {
            FormMenu fmen = new FormMenu();
            
            fmen.TopMost = true;
            fmen.ShowDialog();
        }

        private void buttonMenu_GAM_MouseEnter(object sender, EventArgs e)
        {
            buttonMenu_GAM.BackColor = Color.DarkTurquoise;
            buttonMenu_GAM.ForeColor = Color.Black;
        }

        private void buttonMenu_GAM_MouseLeave(object sender, EventArgs e)
        {
            buttonMenu_GAM.BackColor = Color.FromArgb(40, 40, 40);
            buttonMenu_GAM.ForeColor = Color.WhiteSmoke;
        }
    }
    }
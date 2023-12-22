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
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.GrigorjanAM.Sprint7.Project.V9
{
    public partial class FormGraph : Form
    {
        public FormGraph()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\djura\Desktop\DataSet.csv";
        static string openFile;
        static int rows;
        static int columns;
        static string[,] matrix;
        
        private void buttonManagement_GAM_Click(object sender, EventArgs e)
        {
            FormManual formmanual = new FormManual();
            formmanual.ShowDialog();
        }

        private void buttonAbout_GAM_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void форматВидеоклипаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartGraph_GAM.Titles.Clear();
            chartGraph_GAM.Series.Clear();
            matrix = ds.LoadDataSet(path);
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
            List<string> category = new List<string>();
            for (int i = 1; i < rows; i++)
            {
                category.Add(matrix[i, 3]);
            }
            Dictionary<string, int> countByElement = new Dictionary<string, int>();

            foreach (var element in category)
            {
                if (countByElement.ContainsKey(element))
                {
                    countByElement[element]++;
                }
                else
                {
                    countByElement[element] = 1;
                }
            }

            Chart grafik = chartGraph_GAM;
            Series series = new Series();
            foreach (var kvp in countByElement)
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }
            grafik.Series.Add(series);
            grafik.Invalidate();
            grafik.Legends.Clear();
            series.Color = Color.DarkCyan;
            series.BackGradientStyle = GradientStyle.DiagonalLeft;
            string title = "Формат";
            grafik.Titles.Add(title);
            this.chartGraph_GAM.ChartAreas[0].AxisX.Title = "Значение";
            this.chartGraph_GAM.ChartAreas[0].AxisY.Title = "Количество";
        }

        private void категорияВидеоклипаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartGraph_GAM.Titles.Clear();
            chartGraph_GAM.Series.Clear();
            matrix = ds.LoadDataSet(path);
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
            List<string> category = new List<string>();
            for (int i = 1; i < rows; i++)
            {
                category.Add(matrix[i, 6]);
            }
            Dictionary<string, int> countByElement = new Dictionary<string, int>();

            foreach (var element in category)
            {
                if (countByElement.ContainsKey(element))
                {
                    countByElement[element]++;
                }
                else
                {
                    countByElement[element] = 1;
                }
            }

            Chart grafik = chartGraph_GAM;
            Series series = new Series();
            foreach (var kvp in countByElement)
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }
            grafik.Series.Add(series);
            grafik.Invalidate();
            grafik.Legends.Clear();
            series.Color = Color.Indigo;
            series.BackGradientStyle = GradientStyle.DiagonalLeft;
            string title = "Категория";
            grafik.Titles.Add(title);
            this.chartGraph_GAM.ChartAreas[0].AxisX.Title = "Значение";
            this.chartGraph_GAM.ChartAreas[0].AxisY.Title = "Количество";
        }

        private void весВидеоклипаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chartGraph_GAM.Titles.Clear();
            chartGraph_GAM.Series.Clear();
            matrix = ds.LoadDataSet(path);
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
            List<string> category = new List<string>();
            for (int i = 1; i < rows; i++)
            {
                category.Add(matrix[i, 5]);
            }
            Dictionary<string, int> countByElement = new Dictionary<string, int>();

            foreach (var element in category)
            {
                if (countByElement.ContainsKey(element))
                {
                    countByElement[element]++;
                }
                else
                {
                    countByElement[element] = 1;
                }
            }

            Chart grafik = chartGraph_GAM;
            Series series = new Series();
            foreach (var kvp in countByElement)
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }
            grafik.Series.Add(series);
            grafik.Invalidate();
            grafik.Legends.Clear();
            series.Color = Color.RoyalBlue;
            series.BackGradientStyle = GradientStyle.DiagonalLeft;
            string title = "Вес";
            grafik.Titles.Add(title);
            this.chartGraph_GAM.ChartAreas[0].AxisX.Title = "Значение";
            this.chartGraph_GAM.ChartAreas[0].AxisY.Title = "Количество";
        }
        private void длительностьВидеоклипаToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            chartGraph_GAM.Titles.Clear();
            chartGraph_GAM.Series.Clear();
            matrix = ds.LoadDataSet(path);
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
            List<string> category = new List<string>();
            for (int i = 1; i < rows; i++)
            {
                category.Add(matrix[i, 2]);
            }
            Dictionary<string, int> countByElement = new Dictionary<string, int>();

            foreach (var element in category)
            {
                if (countByElement.ContainsKey(element))
                {
                    countByElement[element]++;
                }
                else
                {
                    countByElement[element] = 1;
                }
            }

            Chart grafik = chartGraph_GAM;
            Series series = new Series();
            foreach (var kvp in countByElement)
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }
            grafik.Series.Add(series);
            grafik.Invalidate();
            grafik.Legends.Clear();
            series.Color = Color.DarkSlateGray;
            series.BackGradientStyle = GradientStyle.DiagonalLeft;
            string title = "Длительность";
            grafik.Titles.Add(title);
            this.chartGraph_GAM.ChartAreas[0].AxisX.Title = "Значение";
            this.chartGraph_GAM.ChartAreas[0].AxisY.Title = "Количество";

        }

        private void buttonBack_GAM_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void весВидеоклипаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            matrix = ds.LoadDataSet(path);
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
            List<string> ves = new List<string>();
            for (int i = 1; i < rows; i++)
            {
                ves.Add(matrix[i, 5]);
            }
            double[] doubleVes = new double[ves.Count];
            for (int v = 0; v < ves.Count; v++)
            {
                if (double.TryParse(ves[v], out double parsedValue))
                {
                    doubleVes[v] = parsedValue;
                }
                else
                {
                    MessageBox.Show("Произошло непредвиденное исключение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            textBoxOutPutMinMax_GAM.Text = Convert.ToString(doubleVes.Min());

        }

        private void длительностьВидеоклипаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matrix = ds.LoadDataSet(path);
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
            List<string> dlit = new List<string>();
            for (int i = 1; i < rows; i++)
            {
                dlit.Add(matrix[i, 2]);
            }
            double[] doubleDlit = new double[dlit.Count];
            for (int v = 0; v < dlit.Count; v++)
            {
                if (double.TryParse(dlit[v], out double parsedValue))
                {
                    doubleDlit[v] = parsedValue;
                }
                else
                {
                    MessageBox.Show("Произошло непредвиденное исключение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            textBoxOutPutMinMax_GAM.Text = Convert.ToString(doubleDlit.Min());
        }

        private void весВидеоклипаToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            matrix = ds.LoadDataSet(path);
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
            List<string> ves = new List<string>();
            for (int i = 1; i < rows; i++)
            {
                ves.Add(matrix[i, 5]);
            }
            double[] doubleVes = new double[ves.Count];
            for (int v = 0; v < ves.Count; v++)
            {
                if (double.TryParse(ves[v], out double parsedValue))
                {
                    doubleVes[v] = parsedValue;
                }
                else
                {
                    MessageBox.Show("Произошло непредвиденное исключение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            textBoxOutPutMinMax_GAM.Text = Convert.ToString(doubleVes.Max());
        }

        private void длительностьВидеоклипаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            matrix = ds.LoadDataSet(path);
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
            List<string> dlit = new List<string>();
            for (int i = 1; i < rows; i++)
            {
                dlit.Add(matrix[i, 2]);
            }
            double[] doubleDlit = new double[dlit.Count];
            for (int v = 0; v < dlit.Count; v++)
            {
                if (double.TryParse(dlit[v], out double parsedValue))
                {
                    doubleDlit[v] = parsedValue;
                }
                else
                {
                    MessageBox.Show("Произошло непредвиденное исключение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            textBoxOutPutMinMax_GAM.Text = Convert.ToString(doubleDlit.Max());
        }

        private void весВидеоклипаToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            matrix = ds.LoadDataSet(path);
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
            List<string> ves = new List<string>();
            for (int i = 1; i < rows; i++)
            {
                ves.Add(matrix[i, 5]);
            }
            double[] doubleVes = new double[ves.Count];
            for (int v = 0; v < ves.Count; v++)
            {
                if (double.TryParse(ves[v], out double parsedValue))
                {
                    doubleVes[v] = parsedValue;
                }
                else
                {
                    MessageBox.Show("Произошло непредвиденное исключение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            double sred = Math.Round(doubleVes.Sum() / doubleVes.Length, 3);
            textBoxOutPutMinMax_GAM.Text = Convert.ToString(sred);
        }

        private void длительностьВидеоклипаToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            matrix = ds.LoadDataSet(path);
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
            List<string> dlit = new List<string>();
            for (int i = 1; i < rows; i++)
            {
                dlit.Add(matrix[i, 2]);
            }
            double[] doubleDlit = new double[dlit.Count];
            for (int v = 0; v < dlit.Count; v++)
            {
                if (double.TryParse(dlit[v], out double parsedValue))
                {
                    doubleDlit[v] = parsedValue;
                }
                else
                {
                    MessageBox.Show("Произошло непредвиденное исключение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            double sred = Math.Round(doubleDlit.Sum() / doubleDlit.Length,3);
            textBoxOutPutMinMax_GAM.Text = Convert.ToString(sred);
        }
    }
    }


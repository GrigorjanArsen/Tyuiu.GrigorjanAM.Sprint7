
namespace Tyuiu.GrigorjanAM.Sprint7.Project.V9
{
    partial class FormGraph
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGraph));
            this.panelMiddleGraph_GAM = new System.Windows.Forms.Panel();
            this.groupBoxBaseGraph_GAM = new System.Windows.Forms.GroupBox();
            this.chartGraph_GAM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTipButtonsGraph_GAM = new System.Windows.Forms.ToolTip(this.components);
            this.buttonBack_GAM = new System.Windows.Forms.Button();
            this.buttonAbout_GAM = new System.Windows.Forms.Button();
            this.buttonManagement_GAM = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.графикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматВидеоклипаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.весВидеоклипаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорияВидеоклипаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.длительностьВидеоклипаToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.минимальноеЗначениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.весВидеоклипаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.длительностьВидеоклипаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.максимальноеЗначениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.весВидеоклипаToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.длительностьВидеоклипаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.среднееЗначениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.весВидеоклипаToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.длительностьВидеоклипаToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogGraph_GAM = new System.Windows.Forms.SaveFileDialog();
            this.panelUpperGraph_GAM = new System.Windows.Forms.Panel();
            this.labelOPMM_GAM = new System.Windows.Forms.Label();
            this.textBoxOutPutMinMax_GAM = new System.Windows.Forms.TextBox();
            this.pictureBoxAbout_GAM = new System.Windows.Forms.PictureBox();
            this.pictureBoxManagement_GAM = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack_GAM = new System.Windows.Forms.PictureBox();
            this.openFileDialogGraph_GAM = new System.Windows.Forms.OpenFileDialog();
            this.panelMiddleGraph_GAM.SuspendLayout();
            this.groupBoxBaseGraph_GAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph_GAM)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelUpperGraph_GAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout_GAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManagement_GAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack_GAM)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMiddleGraph_GAM
            // 
            this.panelMiddleGraph_GAM.BackColor = System.Drawing.Color.DarkGray;
            this.panelMiddleGraph_GAM.Controls.Add(this.groupBoxBaseGraph_GAM);
            this.panelMiddleGraph_GAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddleGraph_GAM.Location = new System.Drawing.Point(0, 84);
            this.panelMiddleGraph_GAM.Name = "panelMiddleGraph_GAM";
            this.panelMiddleGraph_GAM.Size = new System.Drawing.Size(800, 366);
            this.panelMiddleGraph_GAM.TabIndex = 5;
            // 
            // groupBoxBaseGraph_GAM
            // 
            this.groupBoxBaseGraph_GAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBoxBaseGraph_GAM.Controls.Add(this.chartGraph_GAM);
            this.groupBoxBaseGraph_GAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBaseGraph_GAM.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBoxBaseGraph_GAM.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBaseGraph_GAM.Name = "groupBoxBaseGraph_GAM";
            this.groupBoxBaseGraph_GAM.Size = new System.Drawing.Size(800, 366);
            this.groupBoxBaseGraph_GAM.TabIndex = 0;
            this.groupBoxBaseGraph_GAM.TabStop = false;
            this.groupBoxBaseGraph_GAM.Text = "Данные";
            // 
            // chartGraph_GAM
            // 
            this.chartGraph_GAM.BackColor = System.Drawing.Color.DarkGray;
            chartArea1.Name = "ChartArea1";
            this.chartGraph_GAM.ChartAreas.Add(chartArea1);
            this.chartGraph_GAM.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartGraph_GAM.Legends.Add(legend1);
            this.chartGraph_GAM.Location = new System.Drawing.Point(3, 16);
            this.chartGraph_GAM.Name = "chartGraph_GAM";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Indigo;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGraph_GAM.Series.Add(series1);
            this.chartGraph_GAM.Size = new System.Drawing.Size(794, 347);
            this.chartGraph_GAM.TabIndex = 0;
            // 
            // toolTipButtonsGraph_GAM
            // 
            this.toolTipButtonsGraph_GAM.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButtonsGraph_GAM.ToolTipTitle = "Подсказка";
            // 
            // buttonBack_GAM
            // 
            this.buttonBack_GAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonBack_GAM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack_GAM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBack_GAM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBack_GAM.Location = new System.Drawing.Point(43, 6);
            this.buttonBack_GAM.Name = "buttonBack_GAM";
            this.buttonBack_GAM.Size = new System.Drawing.Size(75, 34);
            this.buttonBack_GAM.TabIndex = 6;
            this.buttonBack_GAM.Text = "Назад";
            this.toolTipButtonsGraph_GAM.SetToolTip(this.buttonBack_GAM, "Вернуться на главный экран");
            this.buttonBack_GAM.UseVisualStyleBackColor = false;
            this.buttonBack_GAM.Click += new System.EventHandler(this.buttonBack_GAM_Click);
            this.buttonBack_GAM.MouseEnter += new System.EventHandler(this.buttonBack_GAM_MouseEnter);
            this.buttonBack_GAM.MouseLeave += new System.EventHandler(this.buttonBack_GAM_MouseLeave);
            // 
            // buttonAbout_GAM
            // 
            this.buttonAbout_GAM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAbout_GAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonAbout_GAM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAbout_GAM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAbout_GAM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAbout_GAM.Location = new System.Drawing.Point(694, 6);
            this.buttonAbout_GAM.Name = "buttonAbout_GAM";
            this.buttonAbout_GAM.Size = new System.Drawing.Size(94, 34);
            this.buttonAbout_GAM.TabIndex = 7;
            this.buttonAbout_GAM.Text = "О программе";
            this.toolTipButtonsGraph_GAM.SetToolTip(this.buttonAbout_GAM, "Информация о разработчике");
            this.buttonAbout_GAM.UseVisualStyleBackColor = false;
            this.buttonAbout_GAM.Click += new System.EventHandler(this.buttonAbout_GAM_Click);
            this.buttonAbout_GAM.MouseEnter += new System.EventHandler(this.buttonAbout_GAM_MouseEnter);
            this.buttonAbout_GAM.MouseLeave += new System.EventHandler(this.buttonAbout_GAM_MouseLeave);
            // 
            // buttonManagement_GAM
            // 
            this.buttonManagement_GAM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonManagement_GAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonManagement_GAM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonManagement_GAM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonManagement_GAM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonManagement_GAM.Location = new System.Drawing.Point(562, 6);
            this.buttonManagement_GAM.Name = "buttonManagement_GAM";
            this.buttonManagement_GAM.Size = new System.Drawing.Size(86, 34);
            this.buttonManagement_GAM.TabIndex = 8;
            this.buttonManagement_GAM.Text = "Руководство";
            this.toolTipButtonsGraph_GAM.SetToolTip(this.buttonManagement_GAM, "Открыть краткое руководство по программе");
            this.buttonManagement_GAM.UseVisualStyleBackColor = false;
            this.buttonManagement_GAM.Click += new System.EventHandler(this.buttonManagement_GAM_Click);
            this.buttonManagement_GAM.MouseEnter += new System.EventHandler(this.buttonManagement_GAM_MouseEnter);
            this.buttonManagement_GAM.MouseLeave += new System.EventHandler(this.buttonManagement_GAM_MouseLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графикToolStripMenuItem,
            this.минимальноеЗначениеToolStripMenuItem,
            this.максимальноеЗначениеToolStripMenuItem,
            this.среднееЗначениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 57);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 24);
            this.menuStrip1.TabIndex = 11;
            this.toolTipButtonsGraph_GAM.SetToolTip(this.menuStrip1, "Выберите нужный для вас график");
            // 
            // графикToolStripMenuItem
            // 
            this.графикToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.форматВидеоклипаToolStripMenuItem,
            this.весВидеоклипаToolStripMenuItem,
            this.категорияВидеоклипаToolStripMenuItem,
            this.длительностьВидеоклипаToolStripMenuItem2});
            this.графикToolStripMenuItem.Name = "графикToolStripMenuItem";
            this.графикToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.графикToolStripMenuItem.Text = "Выбор графика";
            this.графикToolStripMenuItem.ToolTipText = "Выберите нужный для вас график";
            // 
            // форматВидеоклипаToolStripMenuItem
            // 
            this.форматВидеоклипаToolStripMenuItem.Name = "форматВидеоклипаToolStripMenuItem";
            this.форматВидеоклипаToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.форматВидеоклипаToolStripMenuItem.Text = "Формат видеоклипа";
            this.форматВидеоклипаToolStripMenuItem.Click += new System.EventHandler(this.форматВидеоклипаToolStripMenuItem_Click);
            // 
            // весВидеоклипаToolStripMenuItem
            // 
            this.весВидеоклипаToolStripMenuItem.Name = "весВидеоклипаToolStripMenuItem";
            this.весВидеоклипаToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.весВидеоклипаToolStripMenuItem.Text = "Вес видеоклипа";
            this.весВидеоклипаToolStripMenuItem.Click += new System.EventHandler(this.весВидеоклипаToolStripMenuItem_Click);
            // 
            // категорияВидеоклипаToolStripMenuItem
            // 
            this.категорияВидеоклипаToolStripMenuItem.Name = "категорияВидеоклипаToolStripMenuItem";
            this.категорияВидеоклипаToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.категорияВидеоклипаToolStripMenuItem.Text = "Категория видеоклипа";
            this.категорияВидеоклипаToolStripMenuItem.Click += new System.EventHandler(this.категорияВидеоклипаToolStripMenuItem_Click);
            // 
            // длительностьВидеоклипаToolStripMenuItem2
            // 
            this.длительностьВидеоклипаToolStripMenuItem2.Name = "длительностьВидеоклипаToolStripMenuItem2";
            this.длительностьВидеоклипаToolStripMenuItem2.Size = new System.Drawing.Size(219, 22);
            this.длительностьВидеоклипаToolStripMenuItem2.Text = "Длительность видеоклипа";
            this.длительностьВидеоклипаToolStripMenuItem2.Click += new System.EventHandler(this.длительностьВидеоклипаToolStripMenuItem2_Click);
            // 
            // минимальноеЗначениеToolStripMenuItem
            // 
            this.минимальноеЗначениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.весВидеоклипаToolStripMenuItem1,
            this.длительностьВидеоклипаToolStripMenuItem});
            this.минимальноеЗначениеToolStripMenuItem.Name = "минимальноеЗначениеToolStripMenuItem";
            this.минимальноеЗначениеToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.минимальноеЗначениеToolStripMenuItem.Text = "Минимальное значение";
            this.минимальноеЗначениеToolStripMenuItem.ToolTipText = "Выберите интересующее вас минимальное значение";
            // 
            // весВидеоклипаToolStripMenuItem1
            // 
            this.весВидеоклипаToolStripMenuItem1.Name = "весВидеоклипаToolStripMenuItem1";
            this.весВидеоклипаToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.весВидеоклипаToolStripMenuItem1.Text = "Вес видеоклипа";
            this.весВидеоклипаToolStripMenuItem1.Click += new System.EventHandler(this.весВидеоклипаToolStripMenuItem1_Click);
            // 
            // длительностьВидеоклипаToolStripMenuItem
            // 
            this.длительностьВидеоклипаToolStripMenuItem.Name = "длительностьВидеоклипаToolStripMenuItem";
            this.длительностьВидеоклипаToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.длительностьВидеоклипаToolStripMenuItem.Text = "Длительность видеоклипа";
            this.длительностьВидеоклипаToolStripMenuItem.Click += new System.EventHandler(this.длительностьВидеоклипаToolStripMenuItem_Click);
            // 
            // максимальноеЗначениеToolStripMenuItem
            // 
            this.максимальноеЗначениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.весВидеоклипаToolStripMenuItem2,
            this.длительностьВидеоклипаToolStripMenuItem1});
            this.максимальноеЗначениеToolStripMenuItem.Name = "максимальноеЗначениеToolStripMenuItem";
            this.максимальноеЗначениеToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.максимальноеЗначениеToolStripMenuItem.Text = "Максимальное значение";
            this.максимальноеЗначениеToolStripMenuItem.ToolTipText = "Выберите интересующее вас максимальное значение";
            // 
            // весВидеоклипаToolStripMenuItem2
            // 
            this.весВидеоклипаToolStripMenuItem2.Name = "весВидеоклипаToolStripMenuItem2";
            this.весВидеоклипаToolStripMenuItem2.Size = new System.Drawing.Size(219, 22);
            this.весВидеоклипаToolStripMenuItem2.Text = "Вес видеоклипа";
            this.весВидеоклипаToolStripMenuItem2.Click += new System.EventHandler(this.весВидеоклипаToolStripMenuItem2_Click);
            // 
            // длительностьВидеоклипаToolStripMenuItem1
            // 
            this.длительностьВидеоклипаToolStripMenuItem1.Name = "длительностьВидеоклипаToolStripMenuItem1";
            this.длительностьВидеоклипаToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.длительностьВидеоклипаToolStripMenuItem1.Text = "Длительность видеоклипа";
            this.длительностьВидеоклипаToolStripMenuItem1.Click += new System.EventHandler(this.длительностьВидеоклипаToolStripMenuItem1_Click);
            // 
            // среднееЗначениеToolStripMenuItem
            // 
            this.среднееЗначениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.весВидеоклипаToolStripMenuItem3,
            this.длительностьВидеоклипаToolStripMenuItem3});
            this.среднееЗначениеToolStripMenuItem.Name = "среднееЗначениеToolStripMenuItem";
            this.среднееЗначениеToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.среднееЗначениеToolStripMenuItem.Text = "Среднее значение";
            // 
            // весВидеоклипаToolStripMenuItem3
            // 
            this.весВидеоклипаToolStripMenuItem3.Name = "весВидеоклипаToolStripMenuItem3";
            this.весВидеоклипаToolStripMenuItem3.Size = new System.Drawing.Size(219, 22);
            this.весВидеоклипаToolStripMenuItem3.Text = "Вес видеоклипа";
            this.весВидеоклипаToolStripMenuItem3.Click += new System.EventHandler(this.весВидеоклипаToolStripMenuItem3_Click);
            // 
            // длительностьВидеоклипаToolStripMenuItem3
            // 
            this.длительностьВидеоклипаToolStripMenuItem3.Name = "длительностьВидеоклипаToolStripMenuItem3";
            this.длительностьВидеоклипаToolStripMenuItem3.Size = new System.Drawing.Size(219, 22);
            this.длительностьВидеоклипаToolStripMenuItem3.Text = "Длительность видеоклипа";
            this.длительностьВидеоклипаToolStripMenuItem3.Click += new System.EventHandler(this.длительностьВидеоклипаToolStripMenuItem3_Click);
            // 
            // panelUpperGraph_GAM
            // 
            this.panelUpperGraph_GAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelUpperGraph_GAM.Controls.Add(this.labelOPMM_GAM);
            this.panelUpperGraph_GAM.Controls.Add(this.textBoxOutPutMinMax_GAM);
            this.panelUpperGraph_GAM.Controls.Add(this.pictureBoxAbout_GAM);
            this.panelUpperGraph_GAM.Controls.Add(this.pictureBoxManagement_GAM);
            this.panelUpperGraph_GAM.Controls.Add(this.buttonAbout_GAM);
            this.panelUpperGraph_GAM.Controls.Add(this.buttonManagement_GAM);
            this.panelUpperGraph_GAM.Controls.Add(this.buttonBack_GAM);
            this.panelUpperGraph_GAM.Controls.Add(this.pictureBoxBack_GAM);
            this.panelUpperGraph_GAM.Controls.Add(this.menuStrip1);
            this.panelUpperGraph_GAM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpperGraph_GAM.Location = new System.Drawing.Point(0, 0);
            this.panelUpperGraph_GAM.Name = "panelUpperGraph_GAM";
            this.panelUpperGraph_GAM.Size = new System.Drawing.Size(800, 84);
            this.panelUpperGraph_GAM.TabIndex = 3;
            // 
            // labelOPMM_GAM
            // 
            this.labelOPMM_GAM.AutoSize = true;
            this.labelOPMM_GAM.ForeColor = System.Drawing.SystemColors.Info;
            this.labelOPMM_GAM.Location = new System.Drawing.Point(548, 41);
            this.labelOPMM_GAM.Name = "labelOPMM_GAM";
            this.labelOPMM_GAM.Size = new System.Drawing.Size(62, 13);
            this.labelOPMM_GAM.TabIndex = 13;
            this.labelOPMM_GAM.Text = "Результат:";
            // 
            // textBoxOutPutMinMax_GAM
            // 
            this.textBoxOutPutMinMax_GAM.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxOutPutMinMax_GAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOutPutMinMax_GAM.Location = new System.Drawing.Point(548, 57);
            this.textBoxOutPutMinMax_GAM.Multiline = true;
            this.textBoxOutPutMinMax_GAM.Name = "textBoxOutPutMinMax_GAM";
            this.textBoxOutPutMinMax_GAM.ReadOnly = true;
            this.textBoxOutPutMinMax_GAM.Size = new System.Drawing.Size(100, 24);
            this.textBoxOutPutMinMax_GAM.TabIndex = 12;
            // 
            // pictureBoxAbout_GAM
            // 
            this.pictureBoxAbout_GAM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxAbout_GAM.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAbout_GAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAbout_GAM.ErrorImage = null;
            this.pictureBoxAbout_GAM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAbout_GAM.Image")));
            this.pictureBoxAbout_GAM.InitialImage = null;
            this.pictureBoxAbout_GAM.Location = new System.Drawing.Point(654, 6);
            this.pictureBoxAbout_GAM.Name = "pictureBoxAbout_GAM";
            this.pictureBoxAbout_GAM.Size = new System.Drawing.Size(34, 34);
            this.pictureBoxAbout_GAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAbout_GAM.TabIndex = 9;
            this.pictureBoxAbout_GAM.TabStop = false;
            // 
            // pictureBoxManagement_GAM
            // 
            this.pictureBoxManagement_GAM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxManagement_GAM.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxManagement_GAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxManagement_GAM.ErrorImage = null;
            this.pictureBoxManagement_GAM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxManagement_GAM.Image")));
            this.pictureBoxManagement_GAM.InitialImage = null;
            this.pictureBoxManagement_GAM.Location = new System.Drawing.Point(522, 6);
            this.pictureBoxManagement_GAM.Name = "pictureBoxManagement_GAM";
            this.pictureBoxManagement_GAM.Size = new System.Drawing.Size(34, 34);
            this.pictureBoxManagement_GAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxManagement_GAM.TabIndex = 10;
            this.pictureBoxManagement_GAM.TabStop = false;
            // 
            // pictureBoxBack_GAM
            // 
            this.pictureBoxBack_GAM.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBack_GAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBack_GAM.ErrorImage = null;
            this.pictureBoxBack_GAM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBack_GAM.Image")));
            this.pictureBoxBack_GAM.InitialImage = null;
            this.pictureBoxBack_GAM.Location = new System.Drawing.Point(3, 6);
            this.pictureBoxBack_GAM.Name = "pictureBoxBack_GAM";
            this.pictureBoxBack_GAM.Size = new System.Drawing.Size(34, 34);
            this.pictureBoxBack_GAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBack_GAM.TabIndex = 5;
            this.pictureBoxBack_GAM.TabStop = false;
            // 
            // openFileDialogGraph_GAM
            // 
            this.openFileDialogGraph_GAM.FileName = "openFileDialog1";
            // 
            // FormGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMiddleGraph_GAM);
            this.Controls.Add(this.panelUpperGraph_GAM);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGraph";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графики";
            this.panelMiddleGraph_GAM.ResumeLayout(false);
            this.groupBoxBaseGraph_GAM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph_GAM)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelUpperGraph_GAM.ResumeLayout(false);
            this.panelUpperGraph_GAM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout_GAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxManagement_GAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack_GAM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTipButtonsGraph_GAM;
        private System.Windows.Forms.Panel panelMiddleGraph_GAM;
        private System.Windows.Forms.GroupBox groupBoxBaseGraph_GAM;
        private System.Windows.Forms.SaveFileDialog saveFileDialogGraph_GAM;
        private System.Windows.Forms.Panel panelUpperGraph_GAM;
        private System.Windows.Forms.OpenFileDialog openFileDialogGraph_GAM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph_GAM;
        private System.Windows.Forms.PictureBox pictureBoxBack_GAM;
        private System.Windows.Forms.Button buttonBack_GAM;
        private System.Windows.Forms.PictureBox pictureBoxAbout_GAM;
        private System.Windows.Forms.PictureBox pictureBoxManagement_GAM;
        private System.Windows.Forms.Button buttonAbout_GAM;
        private System.Windows.Forms.Button buttonManagement_GAM;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem графикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматВидеоклипаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem весВидеоклипаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорияВидеоклипаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem минимальноеЗначениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem весВидеоклипаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem длительностьВидеоклипаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem максимальноеЗначениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem весВидеоклипаToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem длительностьВидеоклипаToolStripMenuItem1;
        private System.Windows.Forms.Label labelOPMM_GAM;
        private System.Windows.Forms.TextBox textBoxOutPutMinMax_GAM;
        private System.Windows.Forms.ToolStripMenuItem длительностьВидеоклипаToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem среднееЗначениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem весВидеоклипаToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem длительностьВидеоклипаToolStripMenuItem3;
    }
}
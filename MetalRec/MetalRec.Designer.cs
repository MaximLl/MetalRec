namespace MetalRec
{
    partial class MetalRec
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Ishod_Dan = new System.Windows.Forms.TabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.Rezult_raschet = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Raschet_dan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Znach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiz_Ponyatue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ed_Izmeren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Graf = new System.Windows.Forms.TabPage();
            this.lbKol_tepla = new System.Windows.Forms.Label();
            this.lb_Rashod_prod = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnOptionsReport = new System.Windows.Forms.Button();
            this.btnO_programme = new System.Windows.Forms.Button();
            this.btnOtchet = new System.Windows.Forms.Button();
            this.btnRaschet = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPostr_Graf = new System.Windows.Forms.Button();
            this.btnDelete_Graf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Ishod_Dan.SuspendLayout();
            this.Rezult_raschet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Graf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnOptionsReport);
            this.splitContainer1.Panel2.Controls.Add(this.btnO_programme);
            this.splitContainer1.Panel2.Controls.Add(this.btnOtchet);
            this.splitContainer1.Panel2.Controls.Add(this.btnRaschet);
            this.splitContainer1.Panel2.Controls.Add(this.btnExit);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(939, 596);
            this.splitContainer1.SplitterDistance = 393;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Ishod_Dan);
            this.tabControl1.Controls.Add(this.Rezult_raschet);
            this.tabControl1.Controls.Add(this.Graf);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(939, 393);
            this.tabControl1.TabIndex = 0;
            // 
            // Ishod_Dan
            // 
            this.Ishod_Dan.Controls.Add(this.propertyGrid1);
            this.Ishod_Dan.Location = new System.Drawing.Point(4, 22);
            this.Ishod_Dan.Name = "Ishod_Dan";
            this.Ishod_Dan.Padding = new System.Windows.Forms.Padding(3);
            this.Ishod_Dan.Size = new System.Drawing.Size(931, 367);
            this.Ishod_Dan.TabIndex = 0;
            this.Ishod_Dan.Text = "Исходные данные";
            this.Ishod_Dan.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(925, 361);
            this.propertyGrid1.TabIndex = 0;
            // 
            // Rezult_raschet
            // 
            this.Rezult_raschet.Controls.Add(this.dataGridView1);
            this.Rezult_raschet.Location = new System.Drawing.Point(4, 22);
            this.Rezult_raschet.Name = "Rezult_raschet";
            this.Rezult_raschet.Padding = new System.Windows.Forms.Padding(3);
            this.Rezult_raschet.Size = new System.Drawing.Size(931, 367);
            this.Rezult_raschet.TabIndex = 1;
            this.Rezult_raschet.Text = "Результаты расчета";
            this.Rezult_raschet.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Raschet_dan,
            this.Znach,
            this.Fiz_Ponyatue,
            this.Ed_Izmeren});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(925, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Raschet_dan
            // 
            this.Raschet_dan.HeaderText = "Расчетные данные";
            this.Raschet_dan.Name = "Raschet_dan";
            this.Raschet_dan.ReadOnly = true;
            this.Raschet_dan.Width = 150;
            // 
            // Znach
            // 
            this.Znach.HeaderText = "Значение";
            this.Znach.Name = "Znach";
            this.Znach.ReadOnly = true;
            this.Znach.Width = 150;
            // 
            // Fiz_Ponyatue
            // 
            this.Fiz_Ponyatue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fiz_Ponyatue.HeaderText = "Физическое пояснение";
            this.Fiz_Ponyatue.Name = "Fiz_Ponyatue";
            this.Fiz_Ponyatue.ReadOnly = true;
            // 
            // Ed_Izmeren
            // 
            this.Ed_Izmeren.HeaderText = "Единицы измерения";
            this.Ed_Izmeren.Name = "Ed_Izmeren";
            this.Ed_Izmeren.ReadOnly = true;
            // 
            // Graf
            // 
            this.Graf.Controls.Add(this.btnDelete_Graf);
            this.Graf.Controls.Add(this.btnPostr_Graf);
            this.Graf.Controls.Add(this.lbKol_tepla);
            this.Graf.Controls.Add(this.lb_Rashod_prod);
            this.Graf.Controls.Add(this.chart1);
            this.Graf.Location = new System.Drawing.Point(4, 22);
            this.Graf.Name = "Graf";
            this.Graf.Size = new System.Drawing.Size(931, 367);
            this.Graf.TabIndex = 2;
            this.Graf.Text = "Графическое отображение результата";
            this.Graf.UseVisualStyleBackColor = true;
            // 
            // lbKol_tepla
            // 
            this.lbKol_tepla.AutoSize = true;
            this.lbKol_tepla.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbKol_tepla.Location = new System.Drawing.Point(3, 103);
            this.lbKol_tepla.Name = "lbKol_tepla";
            this.lbKol_tepla.Size = new System.Drawing.Size(165, 45);
            this.lbKol_tepla.TabIndex = 2;
            this.lbKol_tepla.Text = "Количество тепла,вносимое \r\nв теплообменный аппарат \r\nпродуктами сгорания, Квт";
            // 
            // lb_Rashod_prod
            // 
            this.lb_Rashod_prod.AutoSize = true;
            this.lb_Rashod_prod.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Rashod_prod.Location = new System.Drawing.Point(280, 289);
            this.lb_Rashod_prod.Name = "lb_Rashod_prod";
            this.lb_Rashod_prod.Size = new System.Drawing.Size(190, 15);
            this.lb_Rashod_prod.TabIndex = 1;
            this.lb_Rashod_prod.Text = "Расход продуктов сгорания, м3/с";
            this.lb_Rashod_prod.Click += new System.EventHandler(this.lb_Rashod_prod_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(132, 27);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Количество тепла,вносимое в теплообменный аппарат продуктами сгорания ";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(712, 259);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "Title_Kol_tepla";
            title1.Text = "График параметра \"Количество тепла,вносимое в теплообменный аппарат продуктами сг" +
    "орания\" ";
            this.chart1.Titles.Add(title1);
            // 
            // btnOptionsReport
            // 
            this.btnOptionsReport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOptionsReport.Location = new System.Drawing.Point(188, 133);
            this.btnOptionsReport.Name = "btnOptionsReport";
            this.btnOptionsReport.Size = new System.Drawing.Size(123, 35);
            this.btnOptionsReport.TabIndex = 3;
            this.btnOptionsReport.Text = "Настройка отчета...";
            this.btnOptionsReport.UseVisualStyleBackColor = true;
            this.btnOptionsReport.Click += new System.EventHandler(this.btnOptionsReport_Click);
            // 
            // btnO_programme
            // 
            this.btnO_programme.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnO_programme.Location = new System.Drawing.Point(622, 132);
            this.btnO_programme.Name = "btnO_programme";
            this.btnO_programme.Size = new System.Drawing.Size(106, 35);
            this.btnO_programme.TabIndex = 3;
            this.btnO_programme.Text = "О программе";
            this.btnO_programme.UseVisualStyleBackColor = true;
            this.btnO_programme.Click += new System.EventHandler(this.btnO_programme_Click);
            // 
            // btnOtchet
            // 
            this.btnOtchet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOtchet.Location = new System.Drawing.Point(327, 133);
            this.btnOtchet.Name = "btnOtchet";
            this.btnOtchet.Size = new System.Drawing.Size(109, 35);
            this.btnOtchet.TabIndex = 2;
            this.btnOtchet.Text = "Отчет";
            this.btnOtchet.UseVisualStyleBackColor = true;
            this.btnOtchet.Click += new System.EventHandler(this.btnOtchet_Click);
            // 
            // btnRaschet
            // 
            this.btnRaschet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRaschet.Location = new System.Drawing.Point(13, 133);
            this.btnRaschet.Name = "btnRaschet";
            this.btnRaschet.Size = new System.Drawing.Size(112, 35);
            this.btnRaschet.TabIndex = 1;
            this.btnRaschet.Text = "Расчет";
            this.btnRaschet.UseVisualStyleBackColor = true;
            this.btnRaschet.Click += new System.EventHandler(this.btnRaschet_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExit.Location = new System.Drawing.Point(820, 133);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 35);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPostr_Graf
            // 
            this.btnPostr_Graf.Location = new System.Drawing.Point(618, 238);
            this.btnPostr_Graf.Name = "btnPostr_Graf";
            this.btnPostr_Graf.Size = new System.Drawing.Size(124, 35);
            this.btnPostr_Graf.TabIndex = 3;
            this.btnPostr_Graf.Text = "Построить график";
            this.btnPostr_Graf.UseVisualStyleBackColor = true;
            this.btnPostr_Graf.Click += new System.EventHandler(this.btnPostr_Graf_Click);
            // 
            // btnDelete_Graf
            // 
            this.btnDelete_Graf.Location = new System.Drawing.Point(618, 170);
            this.btnDelete_Graf.Name = "btnDelete_Graf";
            this.btnDelete_Graf.Size = new System.Drawing.Size(124, 38);
            this.btnDelete_Graf.TabIndex = 4;
            this.btnDelete_Graf.Text = "Удалить график";
            this.btnDelete_Graf.UseVisualStyleBackColor = true;
            this.btnDelete_Graf.Click += new System.EventHandler(this.btnDelete_Graf_Click);
            // 
            // MetalRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 596);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MetalRec";
            this.Text = "Расчет металлического петлевого рекуператора";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Ishod_Dan.ResumeLayout(false);
            this.Rezult_raschet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Graf.ResumeLayout(false);
            this.Graf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Ishod_Dan;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TabPage Rezult_raschet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage Graf;
        private System.Windows.Forms.Button btnO_programme;
        private System.Windows.Forms.Button btnOtchet;
        private System.Windows.Forms.Button btnRaschet;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raschet_dan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Znach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiz_Ponyatue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ed_Izmeren;
        private System.Windows.Forms.Button btnOptionsReport;
        private System.Windows.Forms.Label lbKol_tepla;
        private System.Windows.Forms.Label lb_Rashod_prod;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnDelete_Graf;
        private System.Windows.Forms.Button btnPostr_Graf;
    }
}


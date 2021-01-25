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
            this.btnO_programme = new System.Windows.Forms.Button();
            this.btnOtchet = new System.Windows.Forms.Button();
            this.btnRaschet = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Ishod_Dan.SuspendLayout();
            this.Rezult_raschet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.Location = new System.Drawing.Point(6, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(919, 355);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Raschet_dan,
            this.Znach,
            this.Fiz_Ponyatue,
            this.Ed_Izmeren});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(925, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Raschet_dan
            // 
            this.Raschet_dan.HeaderText = "Расчетные данные";
            this.Raschet_dan.Name = "Raschet_dan";
            this.Raschet_dan.Width = 150;
            // 
            // Znach
            // 
            this.Znach.HeaderText = "Значение";
            this.Znach.Name = "Znach";
            this.Znach.Width = 150;
            // 
            // Fiz_Ponyatue
            // 
            this.Fiz_Ponyatue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fiz_Ponyatue.HeaderText = "Физическое пояснение";
            this.Fiz_Ponyatue.Name = "Fiz_Ponyatue";
            // 
            // Ed_Izmeren
            // 
            this.Ed_Izmeren.HeaderText = "Единицы измерения";
            this.Ed_Izmeren.Name = "Ed_Izmeren";
            // 
            // Graf
            // 
            this.Graf.Location = new System.Drawing.Point(4, 22);
            this.Graf.Name = "Graf";
            this.Graf.Size = new System.Drawing.Size(931, 367);
            this.Graf.TabIndex = 2;
            this.Graf.Text = "Графическое отображение результата";
            this.Graf.UseVisualStyleBackColor = true;
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
            // 
            // btnOtchet
            // 
            this.btnOtchet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOtchet.Location = new System.Drawing.Point(198, 132);
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
    }
}


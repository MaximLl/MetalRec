﻿namespace MetalRec
{
    partial class myReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cReportInputBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cReportOutputBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.cReportInputBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cReportOutputBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cReportInputBindingSource
            // 
            this.cReportInputBindingSource.DataMember = "cReportInput";
            // 
            // cReportOutputBindingSource
            // 
            this.cReportOutputBindingSource.DataMember = "cReportOutput";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsReportInput";
            reportDataSource1.Value = this.cReportInputBindingSource;
            reportDataSource2.Name = "dsReportOutput";
            reportDataSource2.Value = this.cReportOutputBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MetalRec.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(606, 476);
            this.reportViewer1.TabIndex = 0;
            // 
            // myReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 476);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "myReport";
            this.Text = "Расчет керамического петлевого рекуператора";
            this.Load += new System.EventHandler(this.myReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cReportInputBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cReportOutputBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.BindingSource cReportInputBindingSource;
        public System.Windows.Forms.BindingSource cReportOutputBindingSource;
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MetalRec
{
    public partial class frmReportOptions : Form
    {
        private List<Param> _pInput = new List<Param>();
        private List<Param> _pOutput = new List<Param>();  

        public frmReportOptions() {  }

        public frmReportOptions(List<Param> pInput, List<Param> pOutput)
        {
            _pInput = pInput;
            _pOutput = pOutput;
            InitializeComponent();
            CenterToScreen();
            dgvToReportInput.DataSource = _pInput;
            dgvToReportOutput.DataSource = _pOutput;
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Обработка события: Выделить все исходные данные в отчет
        /// </summary>
        private void btnToReportInputAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvToReportInput.Rows.Count; i++)
            {
                dgvToReportInput.Rows[i].Cells[3].Value = true;
            }
        }
        /// <summary>
        /// Обработка события: Снять выделение все исходные данные в отчет
        /// </summary>
        private void btnToReportInputClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvToReportInput.Rows.Count; i++)
            {
                dgvToReportInput.Rows[i].Cells[3].Value = false;
            }
        }
        /// <summary>
        /// Обработка события: Выделить все исходные данные в отчет
        /// </summary>
        private void btnToReportOutputAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvToReportOutput.Rows.Count; i++)
            {
                dgvToReportOutput.Rows[i].Cells[3].Value = true;
            }
        }
        /// <summary>
        /// Обработка события: Снять выделение все исходные данные в отчет
        /// </summary>
        private void btnToReportOutputClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvToReportOutput.Rows.Count; i++)
            {
                dgvToReportOutput.Rows[i].Cells[3].Value = false;
            }
        }

     
      
    }
}

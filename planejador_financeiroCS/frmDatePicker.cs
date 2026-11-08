using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace planejador_financeiroCS
{
    public partial class frmDatePicker : Form
    {
        public frmDatePicker()
        {
            InitializeComponent();
        }

        public void DatePicker()
        {
            int mes = comboBoxMes.SelectedIndex + 1;
            int ano = (int)numericUpDownAno.Value;
            ((frmMenuPrincipal)Owner).ShowDays(mes, ano);
        }

        private void btnDatePicker_Click(object sender, EventArgs e)
        {
            DatePicker();
        }

        private void frmDatePicker_Load(object sender, EventArgs e)
        {
            numericUpDownAno.Value = DateTime.Now.Year;
        }
    }
}

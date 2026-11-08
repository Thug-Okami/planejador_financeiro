using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using planejador_financeiroCS.Services;

namespace planejador_financeiroCS
{

    public partial class ucDia : UserControl
    {
        // null = célula vazia (preenchimento antes do dia 1)
        private readonly DateTime? _date;



        private void panel1_Click(object sender, EventArgs e)
        {
            if (_date == null) return;
            using (var eventform = new EventoForm(_date.Value))
            {
                eventform.ShowDialog(this);
            }
            DisplayEvents();
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            if (_date == null) return;
            using (var eventform = new EventoForm(_date.Value))
            {
                eventform.ShowDialog(this);
            }
            DisplayEvents();
        }

        public ucDia(DateTime? date)
        {
            InitializeComponent();
            _date = date;
        }

        //Modifica as cores dos domingos
        private void Sundays()
        {
            if (_date == null) return;
            if (_date.Value.DayOfWeek == DayOfWeek.Sunday)
                lblDia.ForeColor = Color.FromArgb(255, 128, 128);
            else
                lblDia.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void ucDia_Load(object sender, EventArgs e)
        {
            Sundays();
            DisplayEvents();
        }

        private void DisplayEvents()
        {
            flowLayoutPanel1.Controls.Clear();
            lblDia.Text = string.Empty;
            if (_date == null) return;

            var date = _date.Value;
            lblDia.Text = date.Day.ToString();
            try
            {
                var lanc = LancamentoStore.Instance.GetLancamentosForMonth(date.Month, date.Year)
                    .Where(l => l.Date.Day == date.Day)
                    .ToList();
                if (lanc.Count == 0) return;
                lblDia.Text += " (" + lanc.Count + ")";

                // alimenta o flowLayoutPanel1 com os lançamentos do dia
                foreach (var l in lanc)
                {
                    var lbl = new Label
                    {
                        Text = l.Name,
                        Width = flowLayoutPanel1.Width - 4,
                        Height = 16,
                        Font = new Font("Segoe UI", 8, FontStyle.Bold),
                        ForeColor = l.Tipo == "Receita" ? ColorTranslator.FromHtml("#81B381") : ColorTranslator.FromHtml("#B38181"),
                        BackColor = l.Tipo == "Receita" ? ColorTranslator.FromHtml("#E3F4E3") : ColorTranslator.FromHtml("#F4E3E3"),
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(0, 1, 0, 0)
                    };
                    flowLayoutPanel1.Controls.Add(lbl);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

    }
}

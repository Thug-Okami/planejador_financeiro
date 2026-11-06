using System.Globalization;
using System.Linq;
using System.Text.Json;
using planejador_financeiroCS.Services;

namespace planejador_financeiroCS
{
    public partial class frmMenuPrincipal : Form
    {
        //variaveis para armazenar o mes e ano atual
        private int _month, _year;

        public frmMenuPrincipal()
        {
            InitializeComponent();
            Activated += frmMenuPrincipal_Activated;
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            showDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void showDays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;

            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            lblMes.Text = monthName.ToUpper() + " " + year;

            CalcSaldo();

            DateTime startofTheMonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            // o cabeçalho começa na segunda: segunda = 0 ... domingo = 6
            int week = ((int)startofTheMonth.DayOfWeek + 6) % 7;

            // células vazias antes do dia 1
            for (int i = 0; i < week; i++)
            {
                ucDia uc = new ucDia(null);
                flowLayoutPanel1.Controls.Add(uc);
            }
            for (int i = 1; i <= day; i++)
            {
                ucDia uc = new ucDia(new DateTime(year, month, i));
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void CalcSaldo()
        {
            var lancamentosDoMes = LancamentoStore.Instance.GetLancamentosForMonth(_month, _year);
            decimal totalRendas = lancamentosDoMes
                .Where(l => l.Tipo == "Receita")
                .Sum(l => l.Value);
            decimal totalDespesas = lancamentosDoMes
                .Where(l => l.Tipo == "Despesa")
                .Sum(l => l.Value);
            decimal saldo = totalRendas - totalDespesas;

            lblNumRenda.Text = totalRendas.ToString("C");
            lblNumDespesa.Text = totalDespesas.ToString("C");
            lblNumSaldo.Text = saldo.ToString("C");
            lblNumSaldoPrevisto.Text = CalculatePredictedBalance().ToString("C");
        }

        private decimal CalculatePredictedBalance()
        {
            var displayedMonth = new DateTime(_year, _month, 1);
            var endOfDisplayedMonth = displayedMonth.AddMonths(1).AddDays(-1);
            decimal predictedBalance = 0;

            foreach (var lancamento in LancamentoStore.Instance.GetAll())
            {
                decimal signedValue = lancamento.Tipo == "Despesa"
                    ? -lancamento.Value
                    : lancamento.Value;

                if (!lancamento.IsRecurringMonthly)
                {
                    if (lancamento.Date <= endOfDisplayedMonth)
                        predictedBalance += signedValue;

                    continue;
                }

                var startMonth = new DateTime(lancamento.Date.Year, lancamento.Date.Month, 1);
                if (startMonth > displayedMonth) continue;

                int monthCount = ((_year - lancamento.Date.Year) * 12)
                    + _month - lancamento.Date.Month + 1;
                predictedBalance += signedValue * monthCount;
            }

            return predictedBalance;
        }

        private void frmMenuPrincipal_Activated(object? sender, EventArgs e)
        {
            if (_month > 0 && _year > 0)
                showDays(_month, _year);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            _month += 1;
            if (_month > 12)
            {
                _month = 1;
                _year += 1;
            }
            showDays(_month, _year);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            _month -= 1;
            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }
            showDays(_month, _year);
            CalcSaldo();
        }

        private void btnCrud_Click(object sender, EventArgs e)
        {
            frmCrud form = new frmCrud();
            form.FormClosed += (_, _) => showDays(_month, _year);
            form.Show();

        }
    }
}

using System;
using System.Globalization;
using planejador_financeiroCS.Models;
using planejador_financeiroCS.Services;

namespace planejador_financeiroCS
{
    public partial class frmCrud : Form
    {
        private Guid? _selectedId;

        public frmCrud()
        {
            InitializeComponent();
        }

        private void frmCrud_Load(object sender, EventArgs e)
        {
            comboTipo.Items.AddRange(new object[] { "Receita", "Despesa" });
            comboTipo.SelectedIndex = 0;
            dateLancamento.Value = DateTime.Today;
            RefreshGrid();
            ClearFields();
        }

        private void Filter()
        {
            gridLancamentos.Rows.Clear();

            foreach (var item in LancamentoStore.Instance.GetAll()
                .Where(x => x.Name.Contains(textBoxFilter.Text) && x.IsRecurringMonthly == radioButtonRecorrente.Checked)
                .OrderBy(x => x.Date).ThenBy(x => x.Name))
            {
                AddGridRow(item);
            }
            ClearFields();
        }

        private void RefreshGrid()
        {
            gridLancamentos.Rows.Clear();
            foreach (var item in LancamentoStore.Instance.GetAll().OrderBy(x => x.Date).ThenBy(x => x.Name))
            {
                AddGridRow(item);
            }
        }

        private void AddGridRow(Lancamento item)
        {
            var rowIndex = gridLancamentos.Rows.Add(
                item.Name,
                item.Value.ToString("N2", CultureInfo.CurrentCulture),
                item.Tipo,
                item.Date.ToString("d", CultureInfo.CurrentCulture),
                item.IsRecurringMonthly ? "Sim" : "Não");
            var row = gridLancamentos.Rows[rowIndex];
            row.Tag = item.Id;
            row.DefaultCellStyle.BackColor = item.Tipo switch
            {
                "Receita" => ColorTranslator.FromHtml("#E3F4E3"),
                "Despesa" => ColorTranslator.FromHtml("#F4E3E3"),
                _ => gridLancamentos.DefaultCellStyle.ForeColor
            };
        }

        private void gridLancamentos_SelectionChanged(object sender, EventArgs e)
        {
            if (gridLancamentos.SelectedRows.Count == 0) return;

            if (gridLancamentos.SelectedRows[0].Tag is not Guid id) return;
            var item = LancamentoStore.Instance.GetById(id);
            if (item == null) return;

            _selectedId = item.Id;
            textNome.Text = item.Name;
            textValor.Text = item.Value.ToString("N2", CultureInfo.CurrentCulture);
            comboTipo.Text = item.Tipo;
            dateLancamento.Value = item.Date;
            checkRecorrente.Checked = item.IsRecurringMonthly;
            btnExcluir.Enabled = true;
            btnSalvar.Text = "Atualizar";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNome.Text))
            {
                MessageBox.Show("Informe o nome do lançamento.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textNome.Focus();
                return;
            }

            if (!decimal.TryParse(textValor.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out var value))
            {
                MessageBox.Show("Informe um valor válido.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textValor.Focus();
                return;
            }

            var name = textNome.Text.Trim();
            var tipo = comboTipo.Text.Trim();
            if (_selectedId.HasValue)
            {
                var updated = LancamentoStore.Instance.Update(new Lancamento
                {
                    Id = _selectedId.Value,
                    Name = name,
                    Value = value,
                    Tipo = tipo,
                    Date = dateLancamento.Value.Date,
                    IsRecurringMonthly = checkRecorrente.Checked
                });
                if (!updated)
                {
                    MessageBox.Show("O lançamento selecionado não foi encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RefreshGrid();
                    ClearFields();
                    return;
                }
            }
            else if (checkRecorrente.Checked)
            {
                LancamentoStore.Instance.AddRecurringMonthly(name, value, tipo, dateLancamento.Value);
            }
            else
            {
                LancamentoStore.Instance.AddOneTime(name, value, tipo, dateLancamento.Value);
            }

            RefreshGrid();
            ClearFields();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!_selectedId.HasValue) return;

            var answer = MessageBox.Show("Excluir o lançamento selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer != DialogResult.Yes) return;

            LancamentoStore.Instance.Delete(_selectedId.Value);
            RefreshGrid();
            ClearFields();
        }

        private void ClearFields()
        {
            _selectedId = null;
            gridLancamentos.ClearSelection();
            textNome.Clear();
            textValor.Clear();
            comboTipo.SelectedIndex = comboTipo.Items.Count > 0 ? 0 : -1;
            dateLancamento.Value = DateTime.Today;
            checkRecorrente.Checked = false;
            btnExcluir.Enabled = false;
            btnSalvar.Text = "Salvar";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnCancelFilter_Click(object sender, EventArgs e)
        {
            textBoxFilter.Clear();
            radioButtonRecorrente.Checked = false;
            RefreshGrid();
            ClearFields();
        }
    }
}

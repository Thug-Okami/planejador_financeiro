namespace planejador_financeiroCS
{
    partial class frmCrud
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
            gridLancamentos = new DataGridView();
            colNome = new DataGridViewTextBoxColumn();
            colValor = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colData = new DataGridViewTextBoxColumn();
            colRecorrente = new DataGridViewTextBoxColumn();
            labelNome = new Label();
            textNome = new TextBox();
            labelValor = new Label();
            textValor = new TextBox();
            labelTipo = new Label();
            comboTipo = new ComboBox();
            labelData = new Label();
            dateLancamento = new DateTimePicker();
            checkRecorrente = new CheckBox();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            textBoxFilter = new TextBox();
            radioButtonRecorrente = new RadioButton();
            lblFilter = new Label();
            btnSearch = new Button();
            btnCancelFilter = new Button();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridLancamentos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // gridLancamentos
            // 
            gridLancamentos.AllowUserToAddRows = false;
            gridLancamentos.AllowUserToDeleteRows = false;
            gridLancamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridLancamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridLancamentos.Columns.AddRange(new DataGridViewColumn[] { colNome, colValor, colTipo, colData, colRecorrente });
            gridLancamentos.Location = new Point(11, 57);
            gridLancamentos.MultiSelect = false;
            gridLancamentos.Name = "gridLancamentos";
            gridLancamentos.ReadOnly = true;
            gridLancamentos.RowHeadersVisible = false;
            gridLancamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridLancamentos.Size = new Size(776, 240);
            gridLancamentos.TabIndex = 0;
            gridLancamentos.SelectionChanged += gridLancamentos_SelectionChanged;
            // 
            // colNome
            // 
            colNome.HeaderText = "Nome";
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            // 
            // colValor
            // 
            colValor.HeaderText = "Valor";
            colValor.Name = "colValor";
            colValor.ReadOnly = true;
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            // 
            // colData
            // 
            colData.HeaderText = "Data";
            colData.Name = "colData";
            colData.ReadOnly = true;
            // 
            // colRecorrente
            // 
            colRecorrente.HeaderText = "Recorrente";
            colRecorrente.Name = "colRecorrente";
            colRecorrente.ReadOnly = true;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(11, 309);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 11;
            labelNome.Text = "Nome";
            // 
            // textNome
            // 
            textNome.Location = new Point(11, 327);
            textNome.Name = "textNome";
            textNome.Size = new Size(240, 23);
            textNome.TabIndex = 10;
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Location = new Point(269, 309);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(33, 15);
            labelValor.TabIndex = 9;
            labelValor.Text = "Valor";
            // 
            // textValor
            // 
            textValor.Location = new Point(269, 327);
            textValor.Name = "textValor";
            textValor.Size = new Size(120, 23);
            textValor.TabIndex = 8;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(407, 309);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(30, 15);
            labelTipo.TabIndex = 7;
            labelTipo.Text = "Tipo";
            // 
            // comboTipo
            // 
            comboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipo.FormattingEnabled = true;
            comboTipo.Location = new Point(407, 327);
            comboTipo.Name = "comboTipo";
            comboTipo.Size = new Size(130, 23);
            comboTipo.TabIndex = 6;
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Location = new Point(553, 309);
            labelData.Name = "labelData";
            labelData.Size = new Size(31, 15);
            labelData.TabIndex = 5;
            labelData.Text = "Data";
            // 
            // dateLancamento
            // 
            dateLancamento.Format = DateTimePickerFormat.Short;
            dateLancamento.Location = new Point(553, 327);
            dateLancamento.Name = "dateLancamento";
            dateLancamento.Size = new Size(130, 23);
            dateLancamento.TabIndex = 4;
            // 
            // checkRecorrente
            // 
            checkRecorrente.AutoSize = true;
            checkRecorrente.Location = new Point(11, 366);
            checkRecorrente.Name = "checkRecorrente";
            checkRecorrente.Size = new Size(124, 19);
            checkRecorrente.TabIndex = 3;
            checkRecorrente.Text = "Recorrente mensal";
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(11, 406);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(100, 30);
            btnNovo.TabIndex = 2;
            btnNovo.Text = "Limpar";
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(121, 406);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 30);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Location = new Point(231, 406);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(100, 30);
            btnExcluir.TabIndex = 0;
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new Point(45, 20);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(173, 23);
            textBoxFilter.TabIndex = 12;
            // 
            // radioButtonRecorrente
            // 
            radioButtonRecorrente.AutoSize = true;
            radioButtonRecorrente.Location = new Point(237, 21);
            radioButtonRecorrente.Name = "radioButtonRecorrente";
            radioButtonRecorrente.Size = new Size(82, 19);
            radioButtonRecorrente.TabIndex = 13;
            radioButtonRecorrente.TabStop = true;
            radioButtonRecorrente.Text = "Recorrente";
            radioButtonRecorrente.UseVisualStyleBackColor = true;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(5, 27);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(34, 15);
            lblFilter.TabIndex = 14;
            lblFilter.Text = "Filtro";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(697, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCancelFilter
            // 
            btnCancelFilter.Location = new Point(616, 20);
            btnCancelFilter.Name = "btnCancelFilter";
            btnCancelFilter.Size = new Size(75, 23);
            btnCancelFilter.TabIndex = 16;
            btnCancelFilter.Text = "Cancelar";
            btnCancelFilter.UseVisualStyleBackColor = true;
            btnCancelFilter.Click += btnCancelFilter_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(radioButtonRecorrente);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnCancelFilter);
            panel1.Controls.Add(textBoxFilter);
            panel1.Controls.Add(lblFilter);
            panel1.Location = new Point(12, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(775, 47);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 2);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 19;
            label1.Text = "Nome";
            // 
            // frmCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 448);
            Controls.Add(panel1);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(checkRecorrente);
            Controls.Add(dateLancamento);
            Controls.Add(labelData);
            Controls.Add(comboTipo);
            Controls.Add(labelTipo);
            Controls.Add(textValor);
            Controls.Add(labelValor);
            Controls.Add(textNome);
            Controls.Add(labelNome);
            Controls.Add(gridLancamentos);
            MaximizeBox = false;
            MaximumSize = new Size(816, 487);
            Name = "frmCrud";
            Text = "Lançamentos";
            Load += frmCrud_Load;
            ((System.ComponentModel.ISupportInitialize)gridLancamentos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridLancamentos;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colValor;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colData;
        private DataGridViewTextBoxColumn colRecorrente;
        private Label labelNome;
        private TextBox textNome;
        private Label labelValor;
        private TextBox textValor;
        private Label labelTipo;
        private ComboBox comboTipo;
        private Label labelData;
        private DateTimePicker dateLancamento;
        private CheckBox checkRecorrente;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnExcluir;
        private TextBox textBoxFilter;
        private RadioButton radioButtonRecorrente;
        private Label lblFilter;
        private Button btnSearch;
        private Button btnCancelFilter;
        private Panel panel1;
        private Label label1;
    }
}
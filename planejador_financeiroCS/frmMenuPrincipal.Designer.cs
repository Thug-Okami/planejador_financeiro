namespace planejador_financeiroCS
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSegunda = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblMes = new Label();
            btnBack = new Button();
            btnNext = new Button();
            panel1 = new Panel();
            lblNumSaldo = new Label();
            lblNumSaldoPrevisto = new Label();
            lblSaldoPrevisto = new Label();
            lblSaldo = new Label();
            lblResumoMes = new Label();
            lblDespesa = new Label();
            lblRenda = new Label();
            lblNumDespesa = new Label();
            lblNumRenda = new Label();
            btnCrud = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            panel6 = new Panel();
            label4 = new Label();
            panel7 = new Panel();
            label5 = new Label();
            panel8 = new Panel();
            label6 = new Label();
            panel9 = new Panel();
            label7 = new Label();
            btnDatePicker = new Button();
            btnToday = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // lblSegunda
            // 
            lblSegunda.AutoSize = true;
            lblSegunda.Location = new Point(31, 9);
            lblSegunda.Name = "lblSegunda";
            lblSegunda.Size = new Size(53, 15);
            lblSegunda.TabIndex = 2;
            lblSegunda.Text = "Segunda";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 75);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(776, 477);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMes.Location = new Point(12, 2);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(61, 32);
            lblMes.TabIndex = 8;
            lblMes.Text = "Mês";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(230, 11);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 9;
            btnBack.Text = "◀ Voltar";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(311, 11);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 10;
            btnNext.Text = "Avançar ▶";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblNumSaldo);
            panel1.Controls.Add(lblNumSaldoPrevisto);
            panel1.Controls.Add(lblSaldoPrevisto);
            panel1.Controls.Add(lblSaldo);
            panel1.Controls.Add(lblResumoMes);
            panel1.Controls.Add(lblDespesa);
            panel1.Controls.Add(lblRenda);
            panel1.Controls.Add(lblNumDespesa);
            panel1.Controls.Add(lblNumRenda);
            panel1.Controls.Add(btnCrud);
            panel1.Location = new Point(782, -1);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 570);
            panel1.TabIndex = 12;
            // 
            // lblNumSaldo
            // 
            lblNumSaldo.AutoSize = true;
            lblNumSaldo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumSaldo.Location = new Point(74, 249);
            lblNumSaldo.Name = "lblNumSaldo";
            lblNumSaldo.Size = new Size(64, 15);
            lblNumSaldo.TabIndex = 21;
            lblNumSaldo.Text = "SaldoNum";
            // 
            // lblNumSaldoPrevisto
            // 
            lblNumSaldoPrevisto.AutoSize = true;
            lblNumSaldoPrevisto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumSaldoPrevisto.Location = new Point(74, 335);
            lblNumSaldoPrevisto.Name = "lblNumSaldoPrevisto";
            lblNumSaldoPrevisto.Size = new Size(86, 15);
            lblNumSaldoPrevisto.TabIndex = 22;
            lblNumSaldoPrevisto.Text = "Saldo previsto";
            // 
            // lblSaldoPrevisto
            // 
            lblSaldoPrevisto.AutoSize = true;
            lblSaldoPrevisto.Location = new Point(27, 291);
            lblSaldoPrevisto.Name = "lblSaldoPrevisto";
            lblSaldoPrevisto.Size = new Size(81, 15);
            lblSaldoPrevisto.TabIndex = 23;
            lblSaldoPrevisto.Text = "Saldo previsto";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(27, 191);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(78, 15);
            lblSaldo.TabIndex = 20;
            lblSaldo.Text = "Saldo do mês";
            // 
            // lblResumoMes
            // 
            lblResumoMes.AutoSize = true;
            lblResumoMes.Location = new Point(45, 15);
            lblResumoMes.Name = "lblResumoMes";
            lblResumoMes.Size = new Size(92, 15);
            lblResumoMes.TabIndex = 19;
            lblResumoMes.Text = "Resumo do mês";
            // 
            // lblDespesa
            // 
            lblDespesa.AutoSize = true;
            lblDespesa.Location = new Point(23, 106);
            lblDespesa.Name = "lblDespesa";
            lblDespesa.Size = new Size(50, 15);
            lblDespesa.TabIndex = 18;
            lblDespesa.Text = "Despesa";
            // 
            // lblRenda
            // 
            lblRenda.AutoSize = true;
            lblRenda.Location = new Point(23, 44);
            lblRenda.Name = "lblRenda";
            lblRenda.Size = new Size(40, 15);
            lblRenda.TabIndex = 17;
            lblRenda.Text = "Renda";
            // 
            // lblNumDespesa
            // 
            lblNumDespesa.AutoSize = true;
            lblNumDespesa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumDespesa.ForeColor = Color.Red;
            lblNumDespesa.Location = new Point(57, 140);
            lblNumDespesa.Name = "lblNumDespesa";
            lblNumDespesa.Size = new Size(96, 15);
            lblNumDespesa.TabIndex = 16;
            lblNumDespesa.Text = "Depesas do mês";
            // 
            // lblNumRenda
            // 
            lblNumRenda.AutoSize = true;
            lblNumRenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumRenda.ForeColor = Color.ForestGreen;
            lblNumRenda.Location = new Point(55, 75);
            lblNumRenda.Name = "lblNumRenda";
            lblNumRenda.Size = new Size(85, 15);
            lblNumRenda.TabIndex = 15;
            lblNumRenda.Text = "Renda do mês";
            // 
            // btnCrud
            // 
            btnCrud.Location = new Point(23, 480);
            btnCrud.Name = "btnCrud";
            btnCrud.Size = new Size(159, 23);
            btnCrud.TabIndex = 14;
            btnCrud.Text = "Visualizar Lançamentos";
            btnCrud.UseVisualStyleBackColor = true;
            btnCrud.Click += btnCrud_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblSegunda);
            panel3.Location = new Point(12, 41);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(110, 34);
            panel3.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label2);
            panel4.Location = new Point(122, 41);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(110, 34);
            panel4.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 9);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Terça";
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label3);
            panel5.Location = new Point(232, 41);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(110, 34);
            panel5.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 9);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Quarta";
            // 
            // panel6
            // 
            panel6.BackColor = Color.WhiteSmoke;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label4);
            panel6.Location = new Point(342, 41);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(110, 34);
            panel6.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 9);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 2;
            label4.Text = "Quinta";
            // 
            // panel7
            // 
            panel7.BackColor = Color.WhiteSmoke;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label5);
            panel7.Location = new Point(452, 41);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(110, 34);
            panel7.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 9);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 2;
            label5.Text = "Sexta";
            // 
            // panel8
            // 
            panel8.BackColor = Color.WhiteSmoke;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(label6);
            panel8.Location = new Point(562, 41);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(110, 34);
            panel8.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 9);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 2;
            label6.Text = "Sabado";
            // 
            // panel9
            // 
            panel9.BackColor = Color.WhiteSmoke;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(label7);
            panel9.Location = new Point(672, 41);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(110, 34);
            panel9.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 9);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 2;
            label7.Text = "Domingo";
            // 
            // btnDatePicker
            // 
            btnDatePicker.Location = new Point(667, 11);
            btnDatePicker.Name = "btnDatePicker";
            btnDatePicker.Size = new Size(112, 23);
            btnDatePicker.TabIndex = 17;
            btnDatePicker.Text = "Selecionar Data";
            btnDatePicker.UseVisualStyleBackColor = true;
            btnDatePicker.Click += btnDatePicker_Click;
            // 
            // btnToday
            // 
            btnToday.Location = new Point(586, 11);
            btnToday.Name = "btnToday";
            btnToday.Size = new Size(75, 23);
            btnToday.TabIndex = 18;
            btnToday.Text = "Hoje";
            btnToday.UseVisualStyleBackColor = true;
            btnToday.Click += btnToday_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1000, 561);
            Controls.Add(lblMes);
            Controls.Add(btnToday);
            Controls.Add(btnDatePicker);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            Name = "frmMenuPrincipal";
            Text = "Planejador Financeiro";
            Load += frmMenuPrincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSegunda;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblMes;
        private Button btnBack;
        private Button btnNext;
        private Panel panel1;
        private Button btnCrud;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Panel panel5;
        private Label label3;
        private Panel panel6;
        private Label label4;
        private Panel panel7;
        private Label label5;
        private Panel panel8;
        private Label label6;
        private Panel panel9;
        private Label label7;
        private Label lblResumoMes;
        private Label lblDespesa;
        private Label lblRenda;
        private Label lblNumDespesa;
        private Label lblNumRenda;
        private Label lblNumSaldo;
        private Label lblNumSaldoPrevisto;
        private Label lblSaldoPrevisto;
        private Label lblSaldo;
        private Button btnDatePicker;
        private Button btnToday;
    }
}

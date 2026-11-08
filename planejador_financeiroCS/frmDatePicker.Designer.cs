namespace planejador_financeiroCS
{
    partial class frmDatePicker
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
            label1 = new Label();
            comboBoxMes = new ComboBox();
            numericUpDownAno = new NumericUpDown();
            btnDatePicker = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAno).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 35);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 0;
            label1.Text = "Selecione o mês e ano:";
            // 
            // comboBoxMes
            // 
            comboBoxMes.FormattingEnabled = true;
            comboBoxMes.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBoxMes.Location = new Point(50, 77);
            comboBoxMes.Name = "comboBoxMes";
            comboBoxMes.Size = new Size(37, 23);
            comboBoxMes.TabIndex = 1;
            comboBoxMes.Text = "1";
            // 
            // numericUpDownAno
            // 
            numericUpDownAno.Location = new Point(109, 78);
            numericUpDownAno.Maximum = new decimal(new int[] { 9998, 0, 0, 0 });
            numericUpDownAno.Minimum = new decimal(new int[] { 1960, 0, 0, 0 });
            numericUpDownAno.Name = "numericUpDownAno";
            numericUpDownAno.Size = new Size(55, 23);
            numericUpDownAno.TabIndex = 2;
            numericUpDownAno.Value = new decimal(new int[] { 1960, 0, 0, 0 });
            // 
            // btnDatePicker
            // 
            btnDatePicker.Location = new Point(51, 122);
            btnDatePicker.Name = "btnDatePicker";
            btnDatePicker.Size = new Size(113, 23);
            btnDatePicker.TabIndex = 3;
            btnDatePicker.Text = "Selecionar Data";
            btnDatePicker.UseVisualStyleBackColor = true;
            btnDatePicker.Click += btnDatePicker_Click;
            // 
            // frmDatePicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 194);
            Controls.Add(btnDatePicker);
            Controls.Add(numericUpDownAno);
            Controls.Add(comboBoxMes);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(248, 233);
            Name = "frmDatePicker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDatePicker";
            Load += frmDatePicker_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxMes;
        private NumericUpDown numericUpDownAno;
        private Button btnDatePicker;
    }
}
namespace planejador_financeiroCS
{
    partial class ucDia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            lblDia = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblDia);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(1);
            panel1.Size = new Size(110, 70);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 35);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(4, 1);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(19, 15);
            lblDia.TabIndex = 0;
            lblDia.Text = "00";
            // 
            // ucDia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "ucDia";
            Size = new Size(110, 70);
            Load += ucDia_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDia;
        private Label label2;
    }
}

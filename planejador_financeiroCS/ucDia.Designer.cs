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
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblDia = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(lblDia);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(1);
            panel1.Size = new Size(110, 78);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(4, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(102, 61);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Click += flowLayoutPanel1_Click;
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDia.Location = new Point(4, 1);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(21, 15);
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
            Size = new Size(110, 78);
            Load += ucDia_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDia;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}

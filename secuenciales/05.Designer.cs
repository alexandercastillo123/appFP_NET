namespace appFP_NET.secuenciales
{
    partial class _05
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
            txtb = new TextBox();
            txtk = new TextBox();
            lblb = new Label();
            lblk = new Label();
            txtm = new TextBox();
            txtg = new TextBox();
            buttonCalcular = new Button();
            lblm = new Label();
            lblg = new Label();
            SuspendLayout();
            // 
            // txtb
            // 
            txtb.Location = new Point(136, 216);
            txtb.Margin = new Padding(3, 4, 3, 4);
            txtb.Name = "txtb";
            txtb.ReadOnly = true;
            txtb.Size = new Size(102, 27);
            txtb.TabIndex = 51;
            // 
            // txtk
            // 
            txtk.Location = new Point(136, 160);
            txtk.Margin = new Padding(3, 4, 3, 4);
            txtk.Name = "txtk";
            txtk.ReadOnly = true;
            txtk.Size = new Size(102, 27);
            txtk.TabIndex = 50;
            // 
            // lblb
            // 
            lblb.AutoSize = true;
            lblb.Font = new Font("Segoe UI Black", 9F);
            lblb.Location = new Point(21, 219);
            lblb.Name = "lblb";
            lblb.Size = new Size(45, 20);
            lblb.TabIndex = 52;
            lblb.Text = "Bites";
            // 
            // lblk
            // 
            lblk.AutoSize = true;
            lblk.Font = new Font("Segoe UI Black", 9F);
            lblk.Location = new Point(21, 163);
            lblk.Name = "lblk";
            lblk.Size = new Size(75, 20);
            lblk.TabIndex = 49;
            lblk.Text = "Kilobites";
            // 
            // txtm
            // 
            txtm.Location = new Point(136, 102);
            txtm.Margin = new Padding(3, 4, 3, 4);
            txtm.Name = "txtm";
            txtm.ReadOnly = true;
            txtm.Size = new Size(102, 27);
            txtm.TabIndex = 46;
            // 
            // txtg
            // 
            txtg.Location = new Point(136, 49);
            txtg.Margin = new Padding(3, 4, 3, 4);
            txtg.Name = "txtg";
            txtg.Size = new Size(102, 27);
            txtg.TabIndex = 45;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(92, 294);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 47;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // lblm
            // 
            lblm.AutoSize = true;
            lblm.Font = new Font("Segoe UI Black", 9F);
            lblm.Location = new Point(21, 105);
            lblm.Name = "lblm";
            lblm.Size = new Size(86, 20);
            lblm.TabIndex = 48;
            lblm.Text = "Megabites";
            // 
            // lblg
            // 
            lblg.AutoSize = true;
            lblg.Font = new Font("Segoe UI Black", 9F);
            lblg.Location = new Point(21, 52);
            lblg.Name = "lblg";
            lblg.Size = new Size(79, 20);
            lblg.TabIndex = 44;
            lblg.Text = "Gigabites";
            // 
            // _05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 385);
            Controls.Add(txtb);
            Controls.Add(txtk);
            Controls.Add(lblb);
            Controls.Add(lblk);
            Controls.Add(txtm);
            Controls.Add(txtg);
            Controls.Add(buttonCalcular);
            Controls.Add(lblm);
            Controls.Add(lblg);
            Name = "_05";
            Text = "_05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtb;
        private TextBox txtk;
        private Label lblb;
        private Label lblk;
        private TextBox txtm;
        private TextBox txtg;
        private Button buttonCalcular;
        private Label lblm;
        private Label lblg;
    }
}
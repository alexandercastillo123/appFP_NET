namespace appFP_NET.condicionales
{
    partial class _08
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
            txtpt = new TextBox();
            txtea = new TextBox();
            lblpt = new Label();
            lblea = new Label();
            buttonCalcular = new Button();
            SuspendLayout();
            // 
            // txtpt
            // 
            txtpt.Location = new Point(227, 114);
            txtpt.Margin = new Padding(3, 4, 3, 4);
            txtpt.Name = "txtpt";
            txtpt.ReadOnly = true;
            txtpt.Size = new Size(102, 27);
            txtpt.TabIndex = 57;
            // 
            // txtea
            // 
            txtea.Location = new Point(227, 58);
            txtea.Margin = new Padding(3, 4, 3, 4);
            txtea.Name = "txtea";
            txtea.Size = new Size(102, 27);
            txtea.TabIndex = 56;
            // 
            // lblpt
            // 
            lblpt.AutoSize = true;
            lblpt.Font = new Font("Segoe UI Black", 9F);
            lblpt.Location = new Point(40, 117);
            lblpt.Name = "lblpt";
            lblpt.Size = new Size(112, 20);
            lblpt.TabIndex = 58;
            lblpt.Text = "Propina total:";
            // 
            // lblea
            // 
            lblea.AutoSize = true;
            lblea.Font = new Font("Segoe UI Black", 9F);
            lblea.Location = new Point(40, 61);
            lblea.Name = "lblea";
            lblea.Size = new Size(169, 20);
            lblea.TabIndex = 55;
            lblea.Text = "Examenes aprobados:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(132, 192);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 54;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // _08
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 258);
            Controls.Add(txtpt);
            Controls.Add(txtea);
            Controls.Add(lblpt);
            Controls.Add(lblea);
            Controls.Add(buttonCalcular);
            Name = "_08";
            Text = "_08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtpt;
        private TextBox txtea;
        private Label lblpt;
        private Label lblea;
        private Button buttonCalcular;
    }
}
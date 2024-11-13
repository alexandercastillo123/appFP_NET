namespace appFP_NET.secuenciales
{
    partial class _06
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
            txtvolumen = new TextBox();
            txtarea = new TextBox();
            lblvolumen = new Label();
            lblarea = new Label();
            txtradio = new TextBox();
            txtaltura = new TextBox();
            buttonCalcular = new Button();
            lblradio = new Label();
            lblaltura = new Label();
            SuspendLayout();
            // 
            // txtvolumen
            // 
            txtvolumen.Location = new Point(160, 228);
            txtvolumen.Margin = new Padding(3, 4, 3, 4);
            txtvolumen.Name = "txtvolumen";
            txtvolumen.ReadOnly = true;
            txtvolumen.Size = new Size(102, 27);
            txtvolumen.TabIndex = 42;
            // 
            // txtarea
            // 
            txtarea.Location = new Point(160, 172);
            txtarea.Margin = new Padding(3, 4, 3, 4);
            txtarea.Name = "txtarea";
            txtarea.ReadOnly = true;
            txtarea.Size = new Size(102, 27);
            txtarea.TabIndex = 41;
            // 
            // lblvolumen
            // 
            lblvolumen.AutoSize = true;
            lblvolumen.Font = new Font("Segoe UI Black", 9F);
            lblvolumen.Location = new Point(45, 231);
            lblvolumen.Name = "lblvolumen";
            lblvolumen.Size = new Size(75, 20);
            lblvolumen.TabIndex = 43;
            lblvolumen.Text = "Volumen";
            // 
            // lblarea
            // 
            lblarea.AutoSize = true;
            lblarea.Font = new Font("Segoe UI Black", 9F);
            lblarea.Location = new Point(45, 175);
            lblarea.Name = "lblarea";
            lblarea.Size = new Size(43, 20);
            lblarea.TabIndex = 40;
            lblarea.Text = "Area";
            // 
            // txtradio
            // 
            txtradio.Location = new Point(160, 114);
            txtradio.Margin = new Padding(3, 4, 3, 4);
            txtradio.Name = "txtradio";
            txtradio.Size = new Size(102, 27);
            txtradio.TabIndex = 37;
            // 
            // txtaltura
            // 
            txtaltura.Location = new Point(160, 61);
            txtaltura.Margin = new Padding(3, 4, 3, 4);
            txtaltura.Name = "txtaltura";
            txtaltura.Size = new Size(102, 27);
            txtaltura.TabIndex = 36;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(116, 306);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 38;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // lblradio
            // 
            lblradio.AutoSize = true;
            lblradio.Font = new Font("Segoe UI Black", 9F);
            lblradio.Location = new Point(45, 117);
            lblradio.Name = "lblradio";
            lblradio.Size = new Size(52, 20);
            lblradio.TabIndex = 39;
            lblradio.Text = "Radio";
            // 
            // lblaltura
            // 
            lblaltura.AutoSize = true;
            lblaltura.Font = new Font("Segoe UI Black", 9F);
            lblaltura.Location = new Point(45, 64);
            lblaltura.Name = "lblaltura";
            lblaltura.Size = new Size(55, 20);
            lblaltura.TabIndex = 35;
            lblaltura.Text = "Altura";
            // 
            // _06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 397);
            Controls.Add(txtvolumen);
            Controls.Add(txtarea);
            Controls.Add(lblvolumen);
            Controls.Add(lblarea);
            Controls.Add(txtradio);
            Controls.Add(txtaltura);
            Controls.Add(buttonCalcular);
            Controls.Add(lblradio);
            Controls.Add(lblaltura);
            Name = "_06";
            Text = "_06";
            Load += _06_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtvolumen;
        private TextBox txtarea;
        private Label lblvolumen;
        private Label lblarea;
        private TextBox txtradio;
        private TextBox txtaltura;
        private Button buttonCalcular;
        private Label lblradio;
        private Label lblaltura;
    }
}
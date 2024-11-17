namespace appFP_NET.secuenciales
{
    partial class _07
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
            lblperimetro = new Label();
            lblarea = new Label();
            txtbase = new TextBox();
            txtaltura = new TextBox();
            buttonCalcular = new Button();
            lblbase = new Label();
            lblaltura = new Label();
            txtperimetro = new TextBox();
            txtarea = new TextBox();
            SuspendLayout();
            // 
            // lblperimetro
            // 
            lblperimetro.AutoSize = true;
            lblperimetro.Font = new Font("Segoe UI Black", 9F);
            lblperimetro.Location = new Point(48, 222);
            lblperimetro.Name = "lblperimetro";
            lblperimetro.Size = new Size(84, 20);
            lblperimetro.TabIndex = 52;
            lblperimetro.Text = "Perímetro";
            // 
            // lblarea
            // 
            lblarea.AutoSize = true;
            lblarea.Font = new Font("Segoe UI Black", 9F);
            lblarea.Location = new Point(48, 166);
            lblarea.Name = "lblarea";
            lblarea.Size = new Size(43, 20);
            lblarea.TabIndex = 49;
            lblarea.Text = "Area";
            // 
            // txtbase
            // 
            txtbase.Location = new Point(163, 105);
            txtbase.Margin = new Padding(3, 4, 3, 4);
            txtbase.Name = "txtbase";
            txtbase.Size = new Size(102, 27);
            txtbase.TabIndex = 46;
            // 
            // txtaltura
            // 
            txtaltura.Location = new Point(163, 52);
            txtaltura.Margin = new Padding(3, 4, 3, 4);
            txtaltura.Name = "txtaltura";
            txtaltura.Size = new Size(102, 27);
            txtaltura.TabIndex = 45;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(119, 297);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 47;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // lblbase
            // 
            lblbase.AutoSize = true;
            lblbase.Font = new Font("Segoe UI Black", 9F);
            lblbase.Location = new Point(48, 108);
            lblbase.Name = "lblbase";
            lblbase.Size = new Size(42, 20);
            lblbase.TabIndex = 48;
            lblbase.Text = "Base";
            // 
            // lblaltura
            // 
            lblaltura.AutoSize = true;
            lblaltura.Font = new Font("Segoe UI Black", 9F);
            lblaltura.Location = new Point(48, 55);
            lblaltura.Name = "lblaltura";
            lblaltura.Size = new Size(55, 20);
            lblaltura.TabIndex = 44;
            lblaltura.Text = "Altura";
            // 
            // txtperimetro
            // 
            txtperimetro.Location = new Point(163, 219);
            txtperimetro.Margin = new Padding(3, 4, 3, 4);
            txtperimetro.Name = "txtperimetro";
            txtperimetro.ReadOnly = true;
            txtperimetro.Size = new Size(102, 27);
            txtperimetro.TabIndex = 51;
            // 
            // txtarea
            // 
            txtarea.Location = new Point(163, 163);
            txtarea.Margin = new Padding(3, 4, 3, 4);
            txtarea.Name = "txtarea";
            txtarea.ReadOnly = true;
            txtarea.Size = new Size(102, 27);
            txtarea.TabIndex = 50;
            // 
            // _07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 396);
            Controls.Add(txtperimetro);
            Controls.Add(txtarea);
            Controls.Add(lblperimetro);
            Controls.Add(lblarea);
            Controls.Add(txtbase);
            Controls.Add(txtaltura);
            Controls.Add(buttonCalcular);
            Controls.Add(lblbase);
            Controls.Add(lblaltura);
            Name = "_07";
            Text = "_07";
            Load += _07_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblperimetro;
        private Label lblarea;
        private TextBox txtbase;
        private TextBox txtaltura;
        private Button buttonCalcular;
        private Label lblbase;
        private Label lblaltura;
        private TextBox txtperimetro;
        private TextBox txtarea;
    }
}
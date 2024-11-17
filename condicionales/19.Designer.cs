namespace appFP_NET.condicionales
{
    partial class _19
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
            txtcodigo = new TextBox();
            lblcodigo = new Label();
            txtsexo = new TextBox();
            lbl2 = new Label();
            txtedad = new TextBox();
            lbl3 = new Label();
            buttonCalcular = new Button();
            SuspendLayout();
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(157, 147);
            txtcodigo.Margin = new Padding(3, 4, 3, 4);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.ReadOnly = true;
            txtcodigo.Size = new Size(102, 27);
            txtcodigo.TabIndex = 112;
            // 
            // lblcodigo
            // 
            lblcodigo.AutoSize = true;
            lblcodigo.Font = new Font("Segoe UI Black", 9F);
            lblcodigo.Location = new Point(38, 150);
            lblcodigo.Name = "lblcodigo";
            lblcodigo.Size = new Size(85, 20);
            lblcodigo.TabIndex = 111;
            lblcodigo.Text = "Categoria:";
            // 
            // txtsexo
            // 
            txtsexo.Location = new Point(157, 48);
            txtsexo.Margin = new Padding(3, 4, 3, 4);
            txtsexo.Name = "txtsexo";
            txtsexo.Size = new Size(102, 27);
            txtsexo.TabIndex = 109;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI Black", 9F);
            lbl2.Location = new Point(38, 51);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(95, 20);
            lbl2.TabIndex = 110;
            lbl2.Text = "Sexo F o M:";
            // 
            // txtedad
            // 
            txtedad.Location = new Point(157, 96);
            txtedad.Margin = new Padding(3, 4, 3, 4);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(102, 27);
            txtedad.TabIndex = 108;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI Black", 9F);
            lbl3.Location = new Point(38, 99);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(50, 20);
            lbl3.TabIndex = 107;
            lbl3.Text = "Edad:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(88, 209);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 106;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // _19
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 276);
            Controls.Add(txtcodigo);
            Controls.Add(lblcodigo);
            Controls.Add(txtsexo);
            Controls.Add(lbl2);
            Controls.Add(txtedad);
            Controls.Add(lbl3);
            Controls.Add(buttonCalcular);
            Name = "_19";
            Text = "_19";
            Load += _19_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtcodigo;
        private Label lblcodigo;
        private TextBox txtsexo;
        private Label lbl2;
        private TextBox txtedad;
        private Label lbl3;
        private Button buttonCalcular;
    }
}
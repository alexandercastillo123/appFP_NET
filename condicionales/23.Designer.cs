namespace appFP_NET.condicionales
{
    partial class _23
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
            txtreloj = new TextBox();
            lblreloj = new Label();
            buttonCalcular = new Button();
            txtfisi = new TextBox();
            txtmate = new TextBox();
            lblfisi = new Label();
            lblmate = new Label();
            txtpropina = new TextBox();
            lblpropina = new Label();
            SuspendLayout();
            // 
            // txtreloj
            // 
            txtreloj.Location = new Point(213, 189);
            txtreloj.Margin = new Padding(3, 4, 3, 4);
            txtreloj.Name = "txtreloj";
            txtreloj.ReadOnly = true;
            txtreloj.Size = new Size(102, 27);
            txtreloj.TabIndex = 97;
            // 
            // lblreloj
            // 
            lblreloj.AutoSize = true;
            lblreloj.Font = new Font("Segoe UI Black", 9F);
            lblreloj.Location = new Point(31, 192);
            lblreloj.Name = "lblreloj";
            lblreloj.Size = new Size(52, 20);
            lblreloj.TabIndex = 96;
            lblreloj.Text = "Reloj:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(135, 254);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 95;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // txtfisi
            // 
            txtfisi.Location = new Point(213, 90);
            txtfisi.Margin = new Padding(3, 4, 3, 4);
            txtfisi.Name = "txtfisi";
            txtfisi.Size = new Size(102, 27);
            txtfisi.TabIndex = 93;
            // 
            // txtmate
            // 
            txtmate.Location = new Point(213, 34);
            txtmate.Margin = new Padding(3, 4, 3, 4);
            txtmate.Name = "txtmate";
            txtmate.Size = new Size(102, 27);
            txtmate.TabIndex = 92;
            // 
            // lblfisi
            // 
            lblfisi.AutoSize = true;
            lblfisi.Font = new Font("Segoe UI Black", 9F);
            lblfisi.Location = new Point(31, 93);
            lblfisi.Name = "lblfisi";
            lblfisi.Size = new Size(129, 20);
            lblfisi.TabIndex = 94;
            lblfisi.Text = "Puntos de física:";
            // 
            // lblmate
            // 
            lblmate.AutoSize = true;
            lblmate.Font = new Font("Segoe UI Black", 9F);
            lblmate.Location = new Point(31, 37);
            lblmate.Name = "lblmate";
            lblmate.Size = new Size(175, 20);
            lblmate.TabIndex = 91;
            lblmate.Text = "Puntos de matemática:";
            // 
            // txtpropina
            // 
            txtpropina.Location = new Point(213, 138);
            txtpropina.Margin = new Padding(3, 4, 3, 4);
            txtpropina.Name = "txtpropina";
            txtpropina.ReadOnly = true;
            txtpropina.Size = new Size(102, 27);
            txtpropina.TabIndex = 90;
            // 
            // lblpropina
            // 
            lblpropina.AutoSize = true;
            lblpropina.Font = new Font("Segoe UI Black", 9F);
            lblpropina.Location = new Point(31, 141);
            lblpropina.Name = "lblpropina";
            lblpropina.Size = new Size(73, 20);
            lblpropina.TabIndex = 89;
            lblpropina.Text = "Propina:";
            // 
            // _23
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 309);
            Controls.Add(txtreloj);
            Controls.Add(lblreloj);
            Controls.Add(buttonCalcular);
            Controls.Add(txtfisi);
            Controls.Add(txtmate);
            Controls.Add(lblfisi);
            Controls.Add(lblmate);
            Controls.Add(txtpropina);
            Controls.Add(lblpropina);
            Name = "_23";
            Text = "_23";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtreloj;
        private Label lblreloj;
        private Button buttonCalcular;
        private TextBox txtfisi;
        private TextBox txtmate;
        private Label lblfisi;
        private Label lblmate;
        private TextBox txtpropina;
        private Label lblpropina;
    }
}
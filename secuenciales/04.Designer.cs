namespace appFP_NET.secuenciales
{
    partial class _04
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
            txtpulgadas = new TextBox();
            txtpies = new TextBox();
            buttonCalcular = new Button();
            lblpulgadas = new Label();
            lblpies = new Label();
            txtmetros = new TextBox();
            lblmetros = new Label();
            SuspendLayout();
            // 
            // txtpulgadas
            // 
            txtpulgadas.Location = new Point(193, 118);
            txtpulgadas.Margin = new Padding(3, 4, 3, 4);
            txtpulgadas.Name = "txtpulgadas";
            txtpulgadas.Size = new Size(102, 27);
            txtpulgadas.TabIndex = 11;
            // 
            // txtpies
            // 
            txtpies.Location = new Point(193, 54);
            txtpies.Margin = new Padding(3, 4, 3, 4);
            txtpies.Name = "txtpies";
            txtpies.Size = new Size(102, 27);
            txtpies.TabIndex = 10;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(127, 268);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 12;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // lblpulgadas
            // 
            lblpulgadas.AutoSize = true;
            lblpulgadas.Font = new Font("Segoe UI Black", 9F);
            lblpulgadas.Location = new Point(36, 121);
            lblpulgadas.Name = "lblpulgadas";
            lblpulgadas.Size = new Size(85, 20);
            lblpulgadas.TabIndex = 13;
            lblpulgadas.Text = "Pulgadas :";
            // 
            // lblpies
            // 
            lblpies.AutoSize = true;
            lblpies.Font = new Font("Segoe UI Black", 9F);
            lblpies.Location = new Point(36, 57);
            lblpies.Name = "lblpies";
            lblpies.Size = new Size(44, 20);
            lblpies.TabIndex = 9;
            lblpies.Text = "Pies:";
            // 
            // txtmetros
            // 
            txtmetros.Location = new Point(194, 182);
            txtmetros.Margin = new Padding(3, 4, 3, 4);
            txtmetros.Name = "txtmetros";
            txtmetros.ReadOnly = true;
            txtmetros.Size = new Size(102, 27);
            txtmetros.TabIndex = 14;
            // 
            // lblmetros
            // 
            lblmetros.AutoSize = true;
            lblmetros.Font = new Font("Segoe UI Black", 9F);
            lblmetros.Location = new Point(37, 185);
            lblmetros.Name = "lblmetros";
            lblmetros.Size = new Size(154, 20);
            lblmetros.TabIndex = 15;
            lblmetros.Text = "Estatura en metros :";
            // 
            // _04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 334);
            Controls.Add(txtmetros);
            Controls.Add(lblmetros);
            Controls.Add(txtpulgadas);
            Controls.Add(txtpies);
            Controls.Add(buttonCalcular);
            Controls.Add(lblpulgadas);
            Controls.Add(lblpies);
            Name = "_04";
            Text = "_04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtpulgadas;
        private TextBox txtpies;
        private Button buttonCalcular;
        private Label lblpulgadas;
        private Label lblpies;
        private TextBox txtmetros;
        private Label lblmetros;
    }
}
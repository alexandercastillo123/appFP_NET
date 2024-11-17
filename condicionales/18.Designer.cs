namespace appFP_NET.condicionales
{
    partial class _18
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
            lblmonto = new Label();
            lblcomedor = new Label();
            txtmonto = new TextBox();
            buttonCalcular = new Button();
            lblsalud = new Label();
            lblinvertido = new Label();
            SuspendLayout();
            // 
            // lblmonto
            // 
            lblmonto.AutoSize = true;
            lblmonto.Font = new Font("Segoe UI Black", 9F);
            lblmonto.Location = new Point(68, 67);
            lblmonto.Name = "lblmonto";
            lblmonto.Size = new Size(158, 20);
            lblmonto.TabIndex = 77;
            lblmonto.Text = "Monto de donación:";
            // 
            // lblcomedor
            // 
            lblcomedor.AutoSize = true;
            lblcomedor.Font = new Font("Segoe UI Black", 9F);
            lblcomedor.Location = new Point(68, 166);
            lblcomedor.Name = "lblcomedor";
            lblcomedor.Size = new Size(139, 20);
            lblcomedor.TabIndex = 75;
            lblcomedor.Text = "Comedor infantil:";
            // 
            // txtmonto
            // 
            txtmonto.Location = new Point(236, 64);
            txtmonto.Name = "txtmonto";
            txtmonto.Size = new Size(100, 27);
            txtmonto.TabIndex = 76;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(156, 272);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 73;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // lblsalud
            // 
            lblsalud.AutoSize = true;
            lblsalud.Font = new Font("Segoe UI Black", 9F);
            lblsalud.Location = new Point(68, 117);
            lblsalud.Name = "lblsalud";
            lblsalud.Size = new Size(128, 20);
            lblsalud.TabIndex = 74;
            lblsalud.Text = "Centro de salud:";
            // 
            // lblinvertido
            // 
            lblinvertido.AutoSize = true;
            lblinvertido.Font = new Font("Segoe UI Black", 9F);
            lblinvertido.Location = new Point(68, 211);
            lblinvertido.Name = "lblinvertido";
            lblinvertido.Size = new Size(148, 20);
            lblinvertido.TabIndex = 78;
            lblinvertido.Text = "Invertido en bolsa:";
            // 
            // _18
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 342);
            Controls.Add(lblinvertido);
            Controls.Add(lblmonto);
            Controls.Add(lblcomedor);
            Controls.Add(txtmonto);
            Controls.Add(buttonCalcular);
            Controls.Add(lblsalud);
            Name = "_18";
            Text = "_18";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblmonto;
        private Label lblcomedor;
        private TextBox txtmonto;
        private Button buttonCalcular;
        private Label lblsalud;
        private Label lblinvertido;
    }
}
namespace appFP_NET.secuenciales
{
    partial class _10
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
            txtinvertir = new TextBox();
            txtnumero = new TextBox();
            buttonCalcular = new Button();
            lblinvertir = new Label();
            lblnumero = new Label();
            SuspendLayout();
            // 
            // txtinvertir
            // 
            txtinvertir.Location = new Point(166, 136);
            txtinvertir.Margin = new Padding(3, 4, 3, 4);
            txtinvertir.Name = "txtinvertir";
            txtinvertir.ReadOnly = true;
            txtinvertir.Size = new Size(102, 27);
            txtinvertir.TabIndex = 11;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(166, 72);
            txtnumero.Margin = new Padding(3, 4, 3, 4);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(102, 27);
            txtnumero.TabIndex = 10;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(123, 199);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 12;
            buttonCalcular.Text = "&Invertir";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // lblinvertir
            // 
            lblinvertir.AutoSize = true;
            lblinvertir.Font = new Font("Segoe UI Black", 9F);
            lblinvertir.Location = new Point(77, 139);
            lblinvertir.Name = "lblinvertir";
            lblinvertir.Size = new Size(83, 20);
            lblinvertir.TabIndex = 13;
            lblinvertir.Text = "Invertido:";
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Font = new Font("Segoe UI Black", 9F);
            lblnumero.Location = new Point(77, 75);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(74, 20);
            lblnumero.TabIndex = 9;
            lblnumero.Text = "Número:";
            // 
            // _10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 281);
            Controls.Add(txtinvertir);
            Controls.Add(txtnumero);
            Controls.Add(buttonCalcular);
            Controls.Add(lblinvertir);
            Controls.Add(lblnumero);
            Name = "_10";
            Text = "_10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtinvertir;
        private TextBox txtnumero;
        private Button buttonCalcular;
        private Label lblinvertir;
        private Label lblnumero;
    }
}
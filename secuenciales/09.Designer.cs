namespace appFP_NET.secuenciales
{
    partial class _09
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
            txtsuma = new TextBox();
            txtnumero = new TextBox();
            btncalcular = new Button();
            lblsuma = new Label();
            lblnumero = new Label();
            SuspendLayout();
            // 
            // txtsuma
            // 
            txtsuma.Location = new Point(109, 91);
            txtsuma.Name = "txtsuma";
            txtsuma.ReadOnly = true;
            txtsuma.Size = new Size(90, 23);
            txtsuma.TabIndex = 11;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(109, 43);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(90, 23);
            txtnumero.TabIndex = 10;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(89, 143);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 3;
            btncalcular.Text = "C&alcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // lblsuma
            // 
            lblsuma.AutoSize = true;
            lblsuma.Font = new Font("Segoe UI Black", 9F);
            lblsuma.Location = new Point(37, 94);
            lblsuma.Name = "lblsuma";
            lblsuma.Size = new Size(44, 15);
            lblsuma.TabIndex = 0;
            lblsuma.Text = "Suma:";
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Font = new Font("Segoe UI Black", 9F);
            lblnumero.Location = new Point(37, 46);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(60, 15);
            lblnumero.TabIndex = 0;
            lblnumero.Text = "Número:";
            // 
            // _09
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 212);
            Controls.Add(txtsuma);
            Controls.Add(txtnumero);
            Controls.Add(btncalcular);
            Controls.Add(lblsuma);
            Controls.Add(lblnumero);
            Name = "_09";
            Text = "_09";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtsuma;
        private TextBox txtnumero;
        private Button btncalcular;
        private Label lblsuma;
        private Label lblnumero;
    }
}
namespace appFP_NET.condicionales
{
    partial class _14
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
            txtm = new TextBox();
            txtn = new TextBox();
            buttonCalcular = new Button();
            lblmc = new Label();
            lblnt = new Label();
            lblt = new Label();
            lbld = new Label();
            lblmonto = new Label();
            lblnumero = new Label();
            SuspendLayout();
            // 
            // txtm
            // 
            txtm.Location = new Point(208, 111);
            txtm.Name = "txtm";
            txtm.Size = new Size(100, 27);
            txtm.TabIndex = 58;
            // 
            // txtn
            // 
            txtn.Location = new Point(208, 55);
            txtn.Name = "txtn";
            txtn.Size = new Size(100, 27);
            txtn.TabIndex = 59;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(158, 384);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 49;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // lblmc
            // 
            lblmc.AutoSize = true;
            lblmc.Font = new Font("Segoe UI Black", 9F);
            lblmc.Location = new Point(39, 217);
            lblmc.Name = "lblmc";
            lblmc.Size = new Size(163, 20);
            lblmc.TabIndex = 55;
            lblmc.Text = "Monto de la compra:";
            // 
            // lblnt
            // 
            lblnt.AutoSize = true;
            lblnt.Font = new Font("Segoe UI Black", 9F);
            lblnt.Location = new Point(39, 163);
            lblnt.Name = "lblnt";
            lblnt.Size = new Size(148, 20);
            lblnt.TabIndex = 54;
            lblnt.Text = "Número de tarjeta:";
            // 
            // lblt
            // 
            lblt.AutoSize = true;
            lblt.Font = new Font("Segoe UI Black", 9F);
            lblt.Location = new Point(39, 325);
            lblt.Name = "lblt";
            lblt.Size = new Size(112, 20);
            lblt.TabIndex = 57;
            lblt.Text = "Total a pagar:";
            // 
            // lbld
            // 
            lbld.AutoSize = true;
            lbld.Font = new Font("Segoe UI Black", 9F);
            lbld.Location = new Point(39, 269);
            lbld.Name = "lbld";
            lbld.Size = new Size(89, 20);
            lbld.TabIndex = 56;
            lbld.Text = "Descuento:";
            // 
            // lblmonto
            // 
            lblmonto.AutoSize = true;
            lblmonto.Font = new Font("Segoe UI Black", 9F);
            lblmonto.Location = new Point(39, 114);
            lblmonto.Name = "lblmonto";
            lblmonto.Size = new Size(163, 20);
            lblmonto.TabIndex = 63;
            lblmonto.Text = "Monto de la compra:";
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Font = new Font("Segoe UI Black", 9F);
            lblnumero.Location = new Point(39, 58);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(148, 20);
            lblnumero.TabIndex = 62;
            lblnumero.Text = "Número de tarjeta:";
            // 
            // _14
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 450);
            Controls.Add(lblmonto);
            Controls.Add(lblnumero);
            Controls.Add(lblt);
            Controls.Add(lbld);
            Controls.Add(lblmc);
            Controls.Add(txtm);
            Controls.Add(txtn);
            Controls.Add(buttonCalcular);
            Controls.Add(lblnt);
            Name = "_14";
            Text = "_14";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtm;
        private TextBox txtn;
        private Button buttonCalcular;
        private Label lblmc;
        private Label lblnt;
        private Label lblt;
        private Label lbld;
        private Label lblmonto;
        private Label lblnumero;
    }
}
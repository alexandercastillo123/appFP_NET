namespace appFP_NET.condicionales
{
    partial class _16
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
            lblcosto = new Label();
            txtingreso = new Label();
            lblcm = new Label();
            txtc = new TextBox();
            txti = new TextBox();
            buttonCalcular = new Button();
            lblci = new Label();
            SuspendLayout();
            // 
            // lblcosto
            // 
            lblcosto.AutoSize = true;
            lblcosto.Font = new Font("Segoe UI Black", 9F);
            lblcosto.Location = new Point(34, 94);
            lblcosto.Name = "lblcosto";
            lblcosto.Size = new Size(129, 20);
            lblcosto.TabIndex = 72;
            lblcosto.Text = "Costo de la casa:";
            // 
            // txtingreso
            // 
            txtingreso.AutoSize = true;
            txtingreso.Font = new Font("Segoe UI Black", 9F);
            txtingreso.Location = new Point(34, 38);
            txtingreso.Name = "txtingreso";
            txtingreso.Size = new Size(134, 20);
            txtingreso.TabIndex = 71;
            txtingreso.Text = "Ingreso mensual:";
            txtingreso.Click += lblnumero_Click;
            // 
            // lblcm
            // 
            lblcm.AutoSize = true;
            lblcm.Font = new Font("Segoe UI Black", 9F);
            lblcm.Location = new Point(34, 197);
            lblcm.Name = "lblcm";
            lblcm.Size = new Size(120, 20);
            lblcm.TabIndex = 66;
            lblcm.Text = "Cuota mensual:";
            // 
            // txtc
            // 
            txtc.Location = new Point(203, 91);
            txtc.Name = "txtc";
            txtc.Size = new Size(100, 27);
            txtc.TabIndex = 69;
            // 
            // txti
            // 
            txti.Location = new Point(203, 35);
            txti.Name = "txti";
            txti.Size = new Size(100, 27);
            txti.TabIndex = 70;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(140, 251);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 64;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // lblci
            // 
            lblci.AutoSize = true;
            lblci.Font = new Font("Segoe UI Black", 9F);
            lblci.Location = new Point(34, 143);
            lblci.Name = "lblci";
            lblci.Size = new Size(104, 20);
            lblci.TabIndex = 65;
            lblci.Text = "Cuota inicial:";
            // 
            // _16
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 328);
            Controls.Add(lblcosto);
            Controls.Add(txtingreso);
            Controls.Add(lblcm);
            Controls.Add(txtc);
            Controls.Add(txti);
            Controls.Add(buttonCalcular);
            Controls.Add(lblci);
            Name = "_16";
            Text = "_16";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcosto;
        private Label txtingreso;
        private Label lblcm;
        private TextBox txtc;
        private TextBox txti;
        private Button buttonCalcular;
        private Label lblci;
    }
}
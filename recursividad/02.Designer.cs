namespace appFP_NET.recursividad
{
    partial class _02
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
            label1 = new Label();
            txtfactorial = new TextBox();
            lbl2 = new Label();
            txtnumero = new TextBox();
            lblnumero = new Label();
            buttonCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F);
            label1.Location = new Point(123, 64);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 124;
            label1.Text = "Fibonacci";
            // 
            // txtfactorial
            // 
            txtfactorial.Location = new Point(179, 172);
            txtfactorial.Margin = new Padding(3, 4, 3, 4);
            txtfactorial.Name = "txtfactorial";
            txtfactorial.ReadOnly = true;
            txtfactorial.Size = new Size(102, 27);
            txtfactorial.TabIndex = 123;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI Black", 9F);
            lbl2.Location = new Point(60, 175);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(83, 20);
            lbl2.TabIndex = 122;
            lbl2.Text = "Fibonacci:";
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(179, 121);
            txtnumero.Margin = new Padding(3, 4, 3, 4);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(102, 27);
            txtnumero.TabIndex = 121;
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Font = new Font("Segoe UI Black", 9F);
            lblnumero.Location = new Point(60, 124);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(74, 20);
            lblnumero.TabIndex = 120;
            lblnumero.Text = "Numero:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(110, 234);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 119;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // _02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 337);
            Controls.Add(label1);
            Controls.Add(txtfactorial);
            Controls.Add(lbl2);
            Controls.Add(txtnumero);
            Controls.Add(lblnumero);
            Controls.Add(buttonCalcular);
            Name = "_02";
            Text = "_02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtfactorial;
        private Label lbl2;
        private TextBox txtnumero;
        private Label lblnumero;
        private Button buttonCalcular;
    }
}
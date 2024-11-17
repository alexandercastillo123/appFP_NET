namespace appFP_NET.recursividad
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
            label3 = new Label();
            txtr = new TextBox();
            label1 = new Label();
            txtnumero = new TextBox();
            lblnumero = new Label();
            buttonCalcular = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F);
            label3.Location = new Point(51, 185);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 160;
            label3.Text = "Digitos:";
            // 
            // txtr
            // 
            txtr.Location = new Point(170, 178);
            txtr.Margin = new Padding(3, 4, 3, 4);
            txtr.Name = "txtr";
            txtr.ReadOnly = true;
            txtr.Size = new Size(102, 27);
            txtr.TabIndex = 159;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F);
            label1.Location = new Point(62, 59);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 158;
            label1.Text = "Digitos";
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(170, 115);
            txtnumero.Margin = new Padding(3, 4, 3, 4);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(102, 27);
            txtnumero.TabIndex = 157;
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Font = new Font("Segoe UI Black", 9F);
            lblnumero.Location = new Point(51, 118);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(74, 20);
            lblnumero.TabIndex = 156;
            lblnumero.Text = "Numero:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(106, 227);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 155;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // _07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 299);
            Controls.Add(label3);
            Controls.Add(txtr);
            Controls.Add(label1);
            Controls.Add(txtnumero);
            Controls.Add(lblnumero);
            Controls.Add(buttonCalcular);
            Name = "_07";
            Text = "_07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtr;
        private Label label1;
        private TextBox txtnumero;
        private Label lblnumero;
        private Button buttonCalcular;
    }
}
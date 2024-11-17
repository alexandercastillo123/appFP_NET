namespace appFP_NET.recursividad
{
    partial class _06
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
            txtr = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F);
            label1.Location = new Point(61, 47);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 142;
            label1.Text = "Potenciacion";
            // 
            // txtfactorial
            // 
            txtfactorial.Location = new Point(169, 154);
            txtfactorial.Margin = new Padding(3, 4, 3, 4);
            txtfactorial.Name = "txtfactorial";
            txtfactorial.Size = new Size(102, 27);
            txtfactorial.TabIndex = 141;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI Black", 9F);
            lbl2.Location = new Point(50, 157);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(77, 20);
            lbl2.TabIndex = 140;
            lbl2.Text = "Potencia:";
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(169, 103);
            txtnumero.Margin = new Padding(3, 4, 3, 4);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(102, 27);
            txtnumero.TabIndex = 139;
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Font = new Font("Segoe UI Black", 9F);
            lblnumero.Location = new Point(50, 106);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(74, 20);
            lblnumero.TabIndex = 138;
            lblnumero.Text = "Numero:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(105, 265);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 137;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // txtr
            // 
            txtr.Location = new Point(169, 216);
            txtr.Margin = new Padding(3, 4, 3, 4);
            txtr.Name = "txtr";
            txtr.ReadOnly = true;
            txtr.Size = new Size(102, 27);
            txtr.TabIndex = 144;
            txtr.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 145;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F);
            label3.Location = new Point(50, 223);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 146;
            label3.Text = "Resultado:";
            // 
            // _06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 383);
            Controls.Add(label3);
            Controls.Add(txtr);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtfactorial);
            Controls.Add(lbl2);
            Controls.Add(txtnumero);
            Controls.Add(lblnumero);
            Controls.Add(buttonCalcular);
            Name = "_06";
            Text = "_06";
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
        private TextBox txtr;
        private Label label2;
        private Label label3;
    }
}
namespace appFP_NET.condicionales
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
            buttonCalcular = new Button();
            txtp = new TextBox();
            lblpromedio = new Label();
            txtn2 = new TextBox();
            txtn1 = new TextBox();
            lbl2 = new Label();
            lbl1 = new Label();
            txtn3 = new TextBox();
            lbl3 = new Label();
            SuspendLayout();
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(90, 256);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 49;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // txtp
            // 
            txtp.Location = new Point(159, 194);
            txtp.Margin = new Padding(3, 4, 3, 4);
            txtp.Name = "txtp";
            txtp.ReadOnly = true;
            txtp.Size = new Size(102, 27);
            txtp.TabIndex = 105;
            // 
            // lblpromedio
            // 
            lblpromedio.AutoSize = true;
            lblpromedio.Font = new Font("Segoe UI Black", 9F);
            lblpromedio.Location = new Point(40, 197);
            lblpromedio.Name = "lblpromedio";
            lblpromedio.Size = new Size(88, 20);
            lblpromedio.TabIndex = 104;
            lblpromedio.Text = "Promedio:";
            // 
            // txtn2
            // 
            txtn2.Location = new Point(159, 95);
            txtn2.Margin = new Padding(3, 4, 3, 4);
            txtn2.Name = "txtn2";
            txtn2.Size = new Size(102, 27);
            txtn2.TabIndex = 102;
            // 
            // txtn1
            // 
            txtn1.Location = new Point(159, 39);
            txtn1.Margin = new Padding(3, 4, 3, 4);
            txtn1.Name = "txtn1";
            txtn1.Size = new Size(102, 27);
            txtn1.TabIndex = 101;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI Black", 9F);
            lbl2.Location = new Point(40, 98);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(78, 20);
            lbl2.TabIndex = 103;
            lbl2.Text = "2da nota:";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI Black", 9F);
            lbl1.Location = new Point(40, 42);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(81, 20);
            lbl1.TabIndex = 100;
            lbl1.Text = "1era nota:";
            // 
            // txtn3
            // 
            txtn3.Location = new Point(159, 143);
            txtn3.Margin = new Padding(3, 4, 3, 4);
            txtn3.Name = "txtn3";
            txtn3.Size = new Size(102, 27);
            txtn3.TabIndex = 99;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI Black", 9F);
            lbl3.Location = new Point(40, 146);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(83, 20);
            lbl3.TabIndex = 98;
            lbl3.Text = "3era nota:";
            // 
            // _04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 337);
            Controls.Add(txtp);
            Controls.Add(lblpromedio);
            Controls.Add(txtn2);
            Controls.Add(txtn1);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(txtn3);
            Controls.Add(lbl3);
            Controls.Add(buttonCalcular);
            Name = "_04";
            Text = "_04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonCalcular;
        private TextBox txtp;
        private Label lblpromedio;
        private TextBox txtn2;
        private TextBox txtn1;
        private Label lbl2;
        private Label lbl1;
        private TextBox txtn3;
        private Label lbl3;
    }
}
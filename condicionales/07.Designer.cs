namespace appFP_NET.condicionales
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
            buttonCalcular = new Button();
            txt2 = new TextBox();
            txt1 = new TextBox();
            lbl2 = new Label();
            lbl1 = new Label();
            txti = new TextBox();
            txt3 = new TextBox();
            lblmye = new Label();
            lbl3 = new Label();
            lbli = new Label();
            SuspendLayout();
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(111, 266);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 78;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // txt2
            // 
            txt2.Location = new Point(198, 93);
            txt2.Margin = new Padding(3, 4, 3, 4);
            txt2.Name = "txt2";
            txt2.Size = new Size(102, 27);
            txt2.TabIndex = 76;
            // 
            // txt1
            // 
            txt1.Location = new Point(198, 37);
            txt1.Margin = new Padding(3, 4, 3, 4);
            txt1.Name = "txt1";
            txt1.Size = new Size(102, 27);
            txt1.TabIndex = 75;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI Black", 9F);
            lbl2.Location = new Point(36, 96);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(104, 20);
            lbl2.TabIndex = 77;
            lbl2.Text = "2do número:";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI Black", 9F);
            lbl1.Location = new Point(36, 40);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(97, 20);
            lbl1.TabIndex = 74;
            lbl1.Text = "1er número:";
            // 
            // txti
            // 
            txti.Location = new Point(198, 197);
            txti.Margin = new Padding(3, 4, 3, 4);
            txti.Name = "txti";
            txti.ReadOnly = true;
            txti.Size = new Size(102, 27);
            txti.TabIndex = 72;
            // 
            // txt3
            // 
            txt3.Location = new Point(198, 141);
            txt3.Margin = new Padding(3, 4, 3, 4);
            txt3.Name = "txt3";
            txt3.Size = new Size(102, 27);
            txt3.TabIndex = 71;
            // 
            // lblmye
            // 
            lblmye.Location = new Point(0, 0);
            lblmye.Name = "lblmye";
            lblmye.Size = new Size(100, 23);
            lblmye.TabIndex = 79;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI Black", 9F);
            lbl3.Location = new Point(36, 144);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(99, 20);
            lbl3.TabIndex = 70;
            lbl3.Text = "3er número:";
            // 
            // lbli
            // 
            lbli.AutoSize = true;
            lbli.Font = new Font("Segoe UI Black", 9F);
            lbli.Location = new Point(36, 200);
            lbli.Name = "lbli";
            lbli.Size = new Size(160, 20);
            lbli.TabIndex = 80;
            lbli.Text = "Número intermedio:";
            // 
            // _07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 323);
            Controls.Add(lbli);
            Controls.Add(buttonCalcular);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(txti);
            Controls.Add(txt3);
            Controls.Add(lblmye);
            Controls.Add(lbl3);
            Name = "_07";
            Text = "_07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonCalcular;
        private TextBox txt2;
        private TextBox txt1;
        private Label lbl2;
        private Label lbl1;
        private TextBox txti;
        private TextBox txt3;
        private Label lblmye;
        private Label lbl3;
        private Label lbli;
    }
}
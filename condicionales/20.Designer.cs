namespace appFP_NET.condicionales
{
    partial class _20
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
            txt3 = new TextBox();
            lbl3 = new Label();
            lblorden = new Label();
            SuspendLayout();
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(111, 264);
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
            txt2.Location = new Point(167, 91);
            txt2.Margin = new Padding(3, 4, 3, 4);
            txt2.Name = "txt2";
            txt2.Size = new Size(102, 27);
            txt2.TabIndex = 76;
            // 
            // txt1
            // 
            txt1.Location = new Point(167, 35);
            txt1.Margin = new Padding(3, 4, 3, 4);
            txt1.Name = "txt1";
            txt1.Size = new Size(102, 27);
            txt1.TabIndex = 75;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI Black", 9F);
            lbl2.Location = new Point(26, 94);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(104, 20);
            lbl2.TabIndex = 77;
            lbl2.Text = "2do número:";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI Black", 9F);
            lbl1.Location = new Point(26, 38);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(97, 20);
            lbl1.TabIndex = 74;
            lbl1.Text = "1er número:";
            // 
            // txt3
            // 
            txt3.Location = new Point(167, 139);
            txt3.Margin = new Padding(3, 4, 3, 4);
            txt3.Name = "txt3";
            txt3.Size = new Size(102, 27);
            txt3.TabIndex = 71;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI Black", 9F);
            lbl3.Location = new Point(26, 142);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(99, 20);
            lbl3.TabIndex = 70;
            lbl3.Text = "3er número:";
            // 
            // lblorden
            // 
            lblorden.AutoSize = true;
            lblorden.Font = new Font("Segoe UI Black", 9F);
            lblorden.Location = new Point(26, 206);
            lblorden.Name = "lblorden";
            lblorden.Size = new Size(59, 20);
            lblorden.TabIndex = 79;
            lblorden.Text = "Orden:";
            lblorden.Click += label1_Click;
            // 
            // _20
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 318);
            Controls.Add(lblorden);
            Controls.Add(buttonCalcular);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(txt3);
            Controls.Add(lbl3);
            Name = "_20";
            Text = "_20";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCalcular;
        private TextBox txt2;
        private TextBox txt1;
        private Label lbl2;
        private Label lbl1;
        private TextBox txt3;
        private Label lbl3;
        private Label lblorden;
    }
}
namespace appFP_NET.repetitivas
{
    partial class _01
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
            txt4 = new TextBox();
            lbl4 = new Label();
            txt2 = new TextBox();
            txt1 = new TextBox();
            lbl2 = new Label();
            lbl1 = new Label();
            txt3 = new TextBox();
            lbl3 = new Label();
            buttonCalcular = new Button();
            SuspendLayout();
            // 
            // txt4
            // 
            txt4.Location = new Point(146, 186);
            txt4.Margin = new Padding(3, 4, 3, 4);
            txt4.Name = "txt4";
            txt4.ReadOnly = true;
            txt4.Size = new Size(102, 27);
            txt4.TabIndex = 114;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Segoe UI Black", 9F);
            lbl4.Location = new Point(27, 189);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(55, 20);
            lbl4.TabIndex = 113;
            lbl4.Text = "Resto:";
            // 
            // txt2
            // 
            txt2.Location = new Point(146, 87);
            txt2.Margin = new Padding(3, 4, 3, 4);
            txt2.Name = "txt2";
            txt2.Size = new Size(102, 27);
            txt2.TabIndex = 111;
            // 
            // txt1
            // 
            txt1.Location = new Point(146, 31);
            txt1.Margin = new Padding(3, 4, 3, 4);
            txt1.Name = "txt1";
            txt1.Size = new Size(102, 27);
            txt1.TabIndex = 110;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI Black", 9F);
            lbl2.Location = new Point(27, 90);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(68, 20);
            lbl2.TabIndex = 112;
            lbl2.Text = "Divisor:";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI Black", 9F);
            lbl1.Location = new Point(27, 34);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(91, 20);
            lbl1.TabIndex = 109;
            lbl1.Text = "Dividendo:";
            // 
            // txt3
            // 
            txt3.Location = new Point(146, 135);
            txt3.Margin = new Padding(3, 4, 3, 4);
            txt3.Name = "txt3";
            txt3.ReadOnly = true;
            txt3.Size = new Size(102, 27);
            txt3.TabIndex = 108;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI Black", 9F);
            lbl3.Location = new Point(27, 138);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(76, 20);
            lbl3.TabIndex = 107;
            lbl3.Text = "Cociente:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(77, 248);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 106;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // _01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 317);
            Controls.Add(txt4);
            Controls.Add(lbl4);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(txt3);
            Controls.Add(lbl3);
            Controls.Add(buttonCalcular);
            Name = "_01";
            Text = "_01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt4;
        private Label lbl4;
        private TextBox txt2;
        private TextBox txt1;
        private Label lbl2;
        private Label lbl1;
        private TextBox txt3;
        private Label lbl3;
        private Button buttonCalcular;
    }
}
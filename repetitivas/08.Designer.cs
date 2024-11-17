namespace appFP_NET.repetitivas
{
    partial class _08
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
            txt2 = new TextBox();
            txt1 = new TextBox();
            lbl2 = new Label();
            lbl1 = new Label();
            txt3 = new TextBox();
            lbl3 = new Label();
            buttonCalcular = new Button();
            SuspendLayout();
            // 
            // txt2
            // 
            txt2.Location = new Point(148, 112);
            txt2.Margin = new Padding(3, 4, 3, 4);
            txt2.Name = "txt2";
            txt2.Size = new Size(102, 27);
            txt2.TabIndex = 120;
            // 
            // txt1
            // 
            txt1.Location = new Point(148, 56);
            txt1.Margin = new Padding(3, 4, 3, 4);
            txt1.Name = "txt1";
            txt1.Size = new Size(102, 27);
            txt1.TabIndex = 119;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI Black", 9F);
            lbl2.Location = new Point(29, 115);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(91, 20);
            lbl2.TabIndex = 121;
            lbl2.Text = "Exponente:";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI Black", 9F);
            lbl1.Location = new Point(29, 59);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(47, 20);
            lbl1.TabIndex = 118;
            lbl1.Text = "Base:";
            // 
            // txt3
            // 
            txt3.Location = new Point(148, 160);
            txt3.Margin = new Padding(3, 4, 3, 4);
            txt3.Name = "txt3";
            txt3.ReadOnly = true;
            txt3.Size = new Size(102, 27);
            txt3.TabIndex = 117;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI Black", 9F);
            lbl3.Location = new Point(29, 163);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(87, 20);
            lbl3.TabIndex = 116;
            lbl3.Text = "Resultado:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(73, 223);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 115;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // _08
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 290);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(txt3);
            Controls.Add(lbl3);
            Controls.Add(buttonCalcular);
            Name = "_08";
            Text = "_08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt2;
        private TextBox txt1;
        private Label lbl2;
        private Label lbl1;
        private TextBox txt3;
        private Label lbl3;
        private Button buttonCalcular;
    }
}
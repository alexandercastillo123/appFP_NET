namespace appFP_NET.secuenciales
{
    partial class _11
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
            txt2i = new TextBox();
            txt1i = new TextBox();
            lbl2i = new Label();
            lbl1i = new Label();
            txt2 = new TextBox();
            txt1 = new TextBox();
            buttonCalcular = new Button();
            lbl2 = new Label();
            lbl1 = new Label();
            SuspendLayout();
            // 
            // txt2i
            // 
            txt2i.Location = new Point(171, 222);
            txt2i.Margin = new Padding(3, 4, 3, 4);
            txt2i.Name = "txt2i";
            txt2i.ReadOnly = true;
            txt2i.Size = new Size(102, 27);
            txt2i.TabIndex = 60;
            // 
            // txt1i
            // 
            txt1i.Location = new Point(171, 166);
            txt1i.Margin = new Padding(3, 4, 3, 4);
            txt1i.Name = "txt1i";
            txt1i.ReadOnly = true;
            txt1i.Size = new Size(102, 27);
            txt1i.TabIndex = 59;
            // 
            // lbl2i
            // 
            lbl2i.AutoSize = true;
            lbl2i.Font = new Font("Segoe UI Black", 9F);
            lbl2i.Location = new Point(33, 225);
            lbl2i.Name = "lbl2i";
            lbl2i.Size = new Size(136, 20);
            lbl2i.TabIndex = 61;
            lbl2i.Text = "2do intercambio:";
            // 
            // lbl1i
            // 
            lbl1i.AutoSize = true;
            lbl1i.Font = new Font("Segoe UI Black", 9F);
            lbl1i.Location = new Point(33, 169);
            lbl1i.Name = "lbl1i";
            lbl1i.Size = new Size(129, 20);
            lbl1i.TabIndex = 58;
            lbl1i.Text = "1er intercambio:";
            // 
            // txt2
            // 
            txt2.Location = new Point(171, 108);
            txt2.Margin = new Padding(3, 4, 3, 4);
            txt2.Name = "txt2";
            txt2.Size = new Size(102, 27);
            txt2.TabIndex = 55;
            // 
            // txt1
            // 
            txt1.Location = new Point(171, 55);
            txt1.Margin = new Padding(3, 4, 3, 4);
            txt1.Name = "txt1";
            txt1.Size = new Size(102, 27);
            txt1.TabIndex = 54;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(95, 299);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(114, 31);
            buttonCalcular.TabIndex = 56;
            buttonCalcular.Text = "&Intercambiar";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI Black", 9F);
            lbl2.Location = new Point(33, 111);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(107, 20);
            lbl2.TabIndex = 57;
            lbl2.Text = "2do Número:";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI Black", 9F);
            lbl1.Location = new Point(33, 58);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(100, 20);
            lbl1.TabIndex = 53;
            lbl1.Text = "1er Número:";
            // 
            // _11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 381);
            Controls.Add(txt2i);
            Controls.Add(txt1i);
            Controls.Add(lbl2i);
            Controls.Add(lbl1i);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(buttonCalcular);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "_11";
            Text = "_11";
            Load += _11_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt2i;
        private TextBox txt1i;
        private Label lbl2i;
        private Label lbl1i;
        private TextBox txt2;
        private TextBox txt1;
        private Button buttonCalcular;
        private Label lbl2;
        private Label lbl1;
    }
}
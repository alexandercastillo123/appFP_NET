namespace appFP_NET.repetitivas
{
    partial class _05
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
            lbl4 = new Label();
            txt1 = new TextBox();
            lbl1 = new Label();
            buttonCalcular = new Button();
            SuspendLayout();
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Segoe UI Black", 9F);
            lbl4.Location = new Point(35, 127);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(55, 20);
            lbl4.TabIndex = 122;
            lbl4.Text = "Tabla:";
            // 
            // txt1
            // 
            txt1.Location = new Point(154, 45);
            txt1.Margin = new Padding(3, 4, 3, 4);
            txt1.Name = "txt1";
            txt1.Size = new Size(102, 27);
            txt1.TabIndex = 119;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI Black", 9F);
            lbl1.Location = new Point(35, 48);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(74, 20);
            lbl1.TabIndex = 118;
            lbl1.Text = "Numero:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(85, 304);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 115;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // _05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 348);
            Controls.Add(lbl4);
            Controls.Add(txt1);
            Controls.Add(lbl1);
            Controls.Add(buttonCalcular);
            Name = "_05";
            Text = "_05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl4;
        private TextBox txt1;
        private Label lbl1;
        private Button buttonCalcular;
    }
}
namespace appFP_NET.condicionales
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
            txts = new TextBox();
            txtn = new TextBox();
            lbls = new Label();
            lbln = new Label();
            buttonCalcular = new Button();
            SuspendLayout();
            // 
            // txts
            // 
            txts.Location = new Point(149, 98);
            txts.Margin = new Padding(3, 4, 3, 4);
            txts.Name = "txts";
            txts.ReadOnly = true;
            txts.Size = new Size(102, 27);
            txts.TabIndex = 52;
            // 
            // txtn
            // 
            txtn.Location = new Point(149, 42);
            txtn.Margin = new Padding(3, 4, 3, 4);
            txtn.Name = "txtn";
            txtn.Size = new Size(102, 27);
            txtn.TabIndex = 51;
            // 
            // lbls
            // 
            lbls.AutoSize = true;
            lbls.Font = new Font("Segoe UI Black", 9F);
            lbls.Location = new Point(34, 101);
            lbls.Name = "lbls";
            lbls.Size = new Size(57, 20);
            lbls.TabIndex = 53;
            lbls.Text = "Signo:";
            // 
            // lbln
            // 
            lbln.AutoSize = true;
            lbln.Font = new Font("Segoe UI Black", 9F);
            lbln.Location = new Point(34, 45);
            lbln.Name = "lbln";
            lbln.Size = new Size(74, 20);
            lbln.TabIndex = 50;
            lbln.Text = "Número:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(105, 176);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 49;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // _11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 234);
            Controls.Add(txts);
            Controls.Add(txtn);
            Controls.Add(lbls);
            Controls.Add(lbln);
            Controls.Add(buttonCalcular);
            Name = "_11";
            Text = "_11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txts;
        private TextBox txtn;
        private Label lbls;
        private Label lbln;
        private Button buttonCalcular;
    }
}
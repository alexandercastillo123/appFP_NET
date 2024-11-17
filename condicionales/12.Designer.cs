namespace appFP_NET.condicionales
{
    partial class _12
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
            txtd = new TextBox();
            txtn = new TextBox();
            lbld = new Label();
            lbln = new Label();
            buttonCalcular = new Button();
            SuspendLayout();
            // 
            // txtd
            // 
            txtd.Location = new Point(154, 98);
            txtd.Margin = new Padding(3, 4, 3, 4);
            txtd.Name = "txtd";
            txtd.ReadOnly = true;
            txtd.Size = new Size(102, 27);
            txtd.TabIndex = 57;
            // 
            // txtn
            // 
            txtn.Location = new Point(154, 42);
            txtn.Margin = new Padding(3, 4, 3, 4);
            txtn.Name = "txtn";
            txtn.Size = new Size(102, 27);
            txtn.TabIndex = 56;
            // 
            // lbld
            // 
            lbld.AutoSize = true;
            lbld.Font = new Font("Segoe UI Black", 9F);
            lbld.Location = new Point(39, 101);
            lbld.Name = "lbld";
            lbld.Size = new Size(38, 20);
            lbld.TabIndex = 58;
            lbld.Text = "Día:";
            // 
            // lbln
            // 
            lbln.AutoSize = true;
            lbln.Font = new Font("Segoe UI Black", 9F);
            lbln.Location = new Point(39, 45);
            lbln.Name = "lbln";
            lbln.Size = new Size(74, 20);
            lbln.TabIndex = 55;
            lbln.Text = "Número:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(110, 176);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 54;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // _12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 238);
            Controls.Add(txtd);
            Controls.Add(txtn);
            Controls.Add(lbld);
            Controls.Add(lbln);
            Controls.Add(buttonCalcular);
            Name = "_12";
            Text = "_12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtd;
        private TextBox txtn;
        private Label lbld;
        private Label lbln;
        private Button buttonCalcular;
    }
}
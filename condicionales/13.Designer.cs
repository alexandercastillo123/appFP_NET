namespace appFP_NET.condicionales
{
    partial class _13
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
            txtn = new TextBox();
            lbld = new Label();
            lbln = new Label();
            buttonCalcular = new Button();
            SuspendLayout();
            // 
            // txtn
            // 
            txtn.Location = new Point(169, 116);
            txtn.Margin = new Padding(3, 4, 3, 4);
            txtn.Name = "txtn";
            txtn.Size = new Size(102, 27);
            txtn.TabIndex = 61;
            // 
            // lbld
            // 
            lbld.AutoSize = true;
            lbld.Font = new Font("Segoe UI Black", 9F);
            lbld.Location = new Point(59, 170);
            lbld.Name = "lbld";
            lbld.Size = new Size(29, 20);
            lbld.TabIndex = 63;
            lbld.Text = "Es:";
            // 
            // lbln
            // 
            lbln.AutoSize = true;
            lbln.Font = new Font("Segoe UI Black", 9F);
            lbln.Location = new Point(126, 58);
            lbln.Name = "lbln";
            lbln.Size = new Size(205, 20);
            lbln.TabIndex = 60;
            lbln.Text = "Número entero de 3 cifras:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(175, 222);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 59;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // _13
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 321);
            Controls.Add(txtn);
            Controls.Add(lbld);
            Controls.Add(lbln);
            Controls.Add(buttonCalcular);
            Name = "_13";
            Text = "_13";
            Load += _13_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtn;
        private Label lbld;
        private Label lbln;
        private Button buttonCalcular;
    }
}
namespace appFP_NET.condicionales
{
    partial class _03
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
            txttipo = new TextBox();
            txtangulo = new TextBox();
            lbltipo = new Label();
            lblangulo = new Label();
            buttonCalcular = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txttipo
            // 
            txttipo.Location = new Point(151, 104);
            txttipo.Margin = new Padding(3, 4, 3, 4);
            txttipo.Name = "txttipo";
            txttipo.ReadOnly = true;
            txttipo.Size = new Size(102, 27);
            txttipo.TabIndex = 47;
            // 
            // txtangulo
            // 
            txtangulo.Location = new Point(151, 48);
            txtangulo.Margin = new Padding(3, 4, 3, 4);
            txtangulo.Name = "txtangulo";
            txtangulo.Size = new Size(102, 27);
            txtangulo.TabIndex = 46;
            // 
            // lbltipo
            // 
            lbltipo.AutoSize = true;
            lbltipo.Font = new Font("Segoe UI Black", 9F);
            lbltipo.Location = new Point(36, 107);
            lbltipo.Name = "lbltipo";
            lbltipo.Size = new Size(49, 20);
            lbltipo.TabIndex = 48;
            lbltipo.Text = "Tipo:";
            // 
            // lblangulo
            // 
            lblangulo.AutoSize = true;
            lblangulo.Font = new Font("Segoe UI Black", 9F);
            lblangulo.Location = new Point(36, 51);
            lblangulo.Name = "lblangulo";
            lblangulo.Size = new Size(68, 20);
            lblangulo.TabIndex = 45;
            lblangulo.Text = "Ángulo:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(107, 182);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 44;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F);
            label1.Location = new Point(259, 48);
            label1.Name = "label1";
            label1.Size = new Size(15, 20);
            label1.TabIndex = 49;
            label1.Text = "°";
            label1.Click += label1_Click;
            // 
            // _03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 257);
            Controls.Add(label1);
            Controls.Add(txttipo);
            Controls.Add(txtangulo);
            Controls.Add(lbltipo);
            Controls.Add(lblangulo);
            Controls.Add(buttonCalcular);
            Name = "_03";
            Text = "_03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txttipo;
        private TextBox txtangulo;
        private Label lbltipo;
        private Label lblangulo;
        private Button buttonCalcular;
        private Label label1;
    }
}
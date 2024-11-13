namespace appFP_NET.secuenciales
{
    partial class _16
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
            txtsnt = new TextBox();
            txtsbr = new TextBox();
            lblsnt = new Label();
            lblsbr = new Label();
            txtsbs = new TextBox();
            txttotal = new TextBox();
            buttonCalcular = new Button();
            lblsbs = new Label();
            lbltotal = new Label();
            SuspendLayout();
            // 
            // txtsnt
            // 
            txtsnt.Location = new Point(149, 213);
            txtsnt.Margin = new Padding(3, 4, 3, 4);
            txtsnt.Name = "txtsnt";
            txtsnt.ReadOnly = true;
            txtsnt.Size = new Size(102, 27);
            txtsnt.TabIndex = 60;
            // 
            // txtsbr
            // 
            txtsbr.Location = new Point(149, 157);
            txtsbr.Margin = new Padding(3, 4, 3, 4);
            txtsbr.Name = "txtsbr";
            txtsbr.ReadOnly = true;
            txtsbr.Size = new Size(102, 27);
            txtsbr.TabIndex = 59;
            // 
            // lblsnt
            // 
            lblsnt.AutoSize = true;
            lblsnt.Font = new Font("Segoe UI Black", 9F);
            lblsnt.Location = new Point(34, 216);
            lblsnt.Name = "lblsnt";
            lblsnt.Size = new Size(102, 20);
            lblsnt.TabIndex = 61;
            lblsnt.Text = "Sueldo neto:";
            // 
            // lblsbr
            // 
            lblsbr.AutoSize = true;
            lblsbr.Font = new Font("Segoe UI Black", 9F);
            lblsbr.Location = new Point(34, 160);
            lblsbr.Name = "lblsbr";
            lblsbr.Size = new Size(111, 20);
            lblsbr.TabIndex = 58;
            lblsbr.Text = "Sueldo bruto:";
            // 
            // txtsbs
            // 
            txtsbs.Location = new Point(149, 99);
            txtsbs.Margin = new Padding(3, 4, 3, 4);
            txtsbs.Name = "txtsbs";
            txtsbs.ReadOnly = true;
            txtsbs.Size = new Size(102, 27);
            txtsbs.TabIndex = 55;
            // 
            // txttotal
            // 
            txttotal.Location = new Point(149, 46);
            txttotal.Margin = new Padding(3, 4, 3, 4);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(102, 27);
            txttotal.TabIndex = 54;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(105, 291);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 56;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // lblsbs
            // 
            lblsbs.AutoSize = true;
            lblsbs.Font = new Font("Segoe UI Black", 9F);
            lblsbs.Location = new Point(34, 102);
            lblsbs.Name = "lblsbs";
            lblsbs.Size = new Size(116, 20);
            lblsbs.TabIndex = 57;
            lblsbs.Text = "Sueldo basico:";
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Font = new Font("Segoe UI Black", 9F);
            lbltotal.Location = new Point(34, 49);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(98, 20);
            lbltotal.TabIndex = 53;
            lbltotal.Text = "Total horas:";
            // 
            // _16
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 362);
            Controls.Add(txtsnt);
            Controls.Add(txtsbr);
            Controls.Add(lblsnt);
            Controls.Add(lblsbr);
            Controls.Add(txtsbs);
            Controls.Add(txttotal);
            Controls.Add(buttonCalcular);
            Controls.Add(lblsbs);
            Controls.Add(lbltotal);
            Name = "_16";
            Text = "_16";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtsnt;
        private TextBox txtsbr;
        private Label lblsnt;
        private Label lblsbr;
        private TextBox txtsbs;
        private TextBox txttotal;
        private Button buttonCalcular;
        private Label lblsbs;
        private Label lbltotal;
    }
}
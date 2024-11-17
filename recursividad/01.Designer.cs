namespace appFP_NET.recursividad
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
            txtfactorial = new TextBox();
            lblfactorial = new Label();
            txtnumero = new TextBox();
            lblnumero = new Label();
            buttonCalcular = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtfactorial
            // 
            txtfactorial.Location = new Point(171, 145);
            txtfactorial.Margin = new Padding(3, 4, 3, 4);
            txtfactorial.Name = "txtfactorial";
            txtfactorial.ReadOnly = true;
            txtfactorial.Size = new Size(102, 27);
            txtfactorial.TabIndex = 117;
            // 
            // lblfactorial
            // 
            lblfactorial.AutoSize = true;
            lblfactorial.Font = new Font("Segoe UI Black", 9F);
            lblfactorial.Location = new Point(52, 148);
            lblfactorial.Name = "lblfactorial";
            lblfactorial.Size = new Size(78, 20);
            lblfactorial.TabIndex = 116;
            lblfactorial.Text = "Factorial:";
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(171, 94);
            txtnumero.Margin = new Padding(3, 4, 3, 4);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(102, 27);
            txtnumero.TabIndex = 115;
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Font = new Font("Segoe UI Black", 9F);
            lblnumero.Location = new Point(52, 97);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(74, 20);
            lblnumero.TabIndex = 114;
            lblnumero.Text = "Numero:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(102, 207);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 113;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F);
            label1.Location = new Point(115, 37);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 118;
            label1.Text = "Factorial";
            // 
            // _01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 296);
            Controls.Add(label1);
            Controls.Add(txtfactorial);
            Controls.Add(lblfactorial);
            Controls.Add(txtnumero);
            Controls.Add(lblnumero);
            Controls.Add(buttonCalcular);
            Name = "_01";
            Text = "_01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtfactorial;
        private Label lblfactorial;
        private TextBox txtnumero;
        private Label lblnumero;
        private Button buttonCalcular;
        private Label label1;
    }
}
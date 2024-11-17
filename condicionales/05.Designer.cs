namespace appFP_NET.condicionales
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
            txtnuevonumero = new TextBox();
            txtnumero = new TextBox();
            lblnuevonumero = new Label();
            lblnumero = new Label();
            buttonCalcular = new Button();
            SuspendLayout();
            // 
            // txtnuevonumero
            // 
            txtnuevonumero.Location = new Point(174, 109);
            txtnuevonumero.Margin = new Padding(3, 4, 3, 4);
            txtnuevonumero.Name = "txtnuevonumero";
            txtnuevonumero.ReadOnly = true;
            txtnuevonumero.Size = new Size(102, 27);
            txtnuevonumero.TabIndex = 52;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(174, 53);
            txtnumero.Margin = new Padding(3, 4, 3, 4);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(102, 27);
            txtnumero.TabIndex = 51;
            // 
            // lblnuevonumero
            // 
            lblnuevonumero.AutoSize = true;
            lblnuevonumero.Font = new Font("Segoe UI Black", 9F);
            lblnuevonumero.Location = new Point(33, 112);
            lblnuevonumero.Name = "lblnuevonumero";
            lblnuevonumero.Size = new Size(123, 20);
            lblnuevonumero.TabIndex = 53;
            lblnuevonumero.Text = "Nuevo número:";
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Font = new Font("Segoe UI Black", 9F);
            lblnumero.Location = new Point(33, 56);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(74, 20);
            lblnumero.TabIndex = 50;
            lblnumero.Text = "Número:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(104, 187);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 49;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // _05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 271);
            Controls.Add(txtnuevonumero);
            Controls.Add(txtnumero);
            Controls.Add(lblnuevonumero);
            Controls.Add(lblnumero);
            Controls.Add(buttonCalcular);
            Name = "_05";
            Text = "_05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnuevonumero;
        private TextBox txtnumero;
        private Label lblnuevonumero;
        private Label lblnumero;
        private Button buttonCalcular;
    }
}
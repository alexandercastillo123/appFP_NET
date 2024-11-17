namespace appFP_NET.condicionales
{
    partial class _21
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
            lbls = new Label();
            buttonCalcular = new Button();
            txtec = new TextBox();
            txtcodigo = new TextBox();
            lblec = new Label();
            lblcodigo = new Label();
            txte = new TextBox();
            lble = new Label();
            txts = new TextBox();
            SuspendLayout();
            // 
            // lbls
            // 
            lbls.AutoSize = true;
            lbls.Font = new Font("Segoe UI Black", 9F);
            lbls.Location = new Point(37, 224);
            lbls.Name = "lbls";
            lbls.Size = new Size(50, 20);
            lbls.TabIndex = 87;
            lbls.Text = "Sexo:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(122, 282);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 86;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // txtec
            // 
            txtec.Location = new Point(178, 122);
            txtec.Margin = new Padding(3, 4, 3, 4);
            txtec.Name = "txtec";
            txtec.ReadOnly = true;
            txtec.Size = new Size(102, 27);
            txtec.TabIndex = 84;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(178, 66);
            txtcodigo.Margin = new Padding(3, 4, 3, 4);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(102, 27);
            txtcodigo.TabIndex = 83;
            // 
            // lblec
            // 
            lblec.AutoSize = true;
            lblec.Font = new Font("Segoe UI Black", 9F);
            lblec.Location = new Point(37, 125);
            lblec.Name = "lblec";
            lblec.Size = new Size(98, 20);
            lblec.TabIndex = 85;
            lblec.Text = "Estado civil:";
            // 
            // lblcodigo
            // 
            lblcodigo.AutoSize = true;
            lblcodigo.Font = new Font("Segoe UI Black", 9F);
            lblcodigo.Location = new Point(37, 69);
            lblcodigo.Name = "lblcodigo";
            lblcodigo.Size = new Size(68, 20);
            lblcodigo.TabIndex = 82;
            lblcodigo.Text = "Codigo:";
            // 
            // txte
            // 
            txte.Location = new Point(178, 170);
            txte.Margin = new Padding(3, 4, 3, 4);
            txte.Name = "txte";
            txte.ReadOnly = true;
            txte.Size = new Size(102, 27);
            txte.TabIndex = 81;
            // 
            // lble
            // 
            lble.AutoSize = true;
            lble.Font = new Font("Segoe UI Black", 9F);
            lble.Location = new Point(37, 173);
            lble.Name = "lble";
            lble.Size = new Size(50, 20);
            lble.TabIndex = 80;
            lble.Text = "Edad:";
            // 
            // txts
            // 
            txts.Location = new Point(178, 221);
            txts.Margin = new Padding(3, 4, 3, 4);
            txts.Name = "txts";
            txts.ReadOnly = true;
            txts.Size = new Size(102, 27);
            txts.TabIndex = 88;
            // 
            // _21
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 368);
            Controls.Add(txts);
            Controls.Add(lbls);
            Controls.Add(buttonCalcular);
            Controls.Add(txtec);
            Controls.Add(txtcodigo);
            Controls.Add(lblec);
            Controls.Add(lblcodigo);
            Controls.Add(txte);
            Controls.Add(lble);
            Name = "_21";
            Text = "_21";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbls;
        private Button buttonCalcular;
        private TextBox txtec;
        private TextBox txtcodigo;
        private Label lblec;
        private Label lblcodigo;
        private TextBox txte;
        private Label lble;
        private TextBox txts;
    }
}
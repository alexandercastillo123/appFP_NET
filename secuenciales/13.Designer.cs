namespace appFP_NET.secuenciales
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
            txthipo = new TextBox();
            lblhipo = new Label();
            txtbase = new TextBox();
            txtaltura = new TextBox();
            buttonCalcular = new Button();
            lblbase = new Label();
            lblaltura = new Label();
            SuspendLayout();
            // 
            // txthipo
            // 
            txthipo.Location = new Point(210, 186);
            txthipo.Margin = new Padding(3, 4, 3, 4);
            txthipo.Name = "txthipo";
            txthipo.ReadOnly = true;
            txthipo.Size = new Size(102, 27);
            txthipo.TabIndex = 21;
            // 
            // lblhipo
            // 
            lblhipo.AutoSize = true;
            lblhipo.Font = new Font("Segoe UI Black", 9F);
            lblhipo.Location = new Point(53, 189);
            lblhipo.Name = "lblhipo";
            lblhipo.Size = new Size(107, 20);
            lblhipo.TabIndex = 22;
            lblhipo.Text = "Hipotennusa:";
            // 
            // txtbase
            // 
            txtbase.Location = new Point(209, 122);
            txtbase.Margin = new Padding(3, 4, 3, 4);
            txtbase.Name = "txtbase";
            txtbase.Size = new Size(102, 27);
            txtbase.TabIndex = 18;
            // 
            // txtaltura
            // 
            txtaltura.Location = new Point(209, 58);
            txtaltura.Margin = new Padding(3, 4, 3, 4);
            txtaltura.Name = "txtaltura";
            txtaltura.Size = new Size(102, 27);
            txtaltura.TabIndex = 17;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(143, 272);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 19;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // lblbase
            // 
            lblbase.AutoSize = true;
            lblbase.Font = new Font("Segoe UI Black", 9F);
            lblbase.Location = new Point(52, 125);
            lblbase.Name = "lblbase";
            lblbase.Size = new Size(47, 20);
            lblbase.TabIndex = 20;
            lblbase.Text = "Base:";
            // 
            // lblaltura
            // 
            lblaltura.AutoSize = true;
            lblaltura.Font = new Font("Segoe UI Black", 9F);
            lblaltura.Location = new Point(52, 61);
            lblaltura.Name = "lblaltura";
            lblaltura.Size = new Size(60, 20);
            lblaltura.TabIndex = 16;
            lblaltura.Text = "Altura:";
            // 
            // _13
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 342);
            Controls.Add(txthipo);
            Controls.Add(lblhipo);
            Controls.Add(txtbase);
            Controls.Add(txtaltura);
            Controls.Add(buttonCalcular);
            Controls.Add(lblbase);
            Controls.Add(lblaltura);
            Name = "_13";
            Text = "_13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txthipo;
        private Label lblhipo;
        private TextBox txtbase;
        private TextBox txtaltura;
        private Button buttonCalcular;
        private Label lblbase;
        private Label lblaltura;
    }
}
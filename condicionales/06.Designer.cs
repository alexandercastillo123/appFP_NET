namespace appFP_NET.condicionales
{
    partial class _06
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
            txt2 = new TextBox();
            txt1 = new TextBox();
            lbl2 = new Label();
            lbl1 = new Label();
            txtmye = new TextBox();
            txt3 = new TextBox();
            lblmye = new Label();
            lbl3 = new Label();
            txtmre = new TextBox();
            lblmre = new Label();
            buttonCalcular = new Button();
            SuspendLayout();
            // 
            // txt2
            // 
            txt2.Location = new Point(174, 88);
            txt2.Margin = new Padding(3, 4, 3, 4);
            txt2.Name = "txt2";
            txt2.Size = new Size(102, 27);
            txt2.TabIndex = 65;
            // 
            // txt1
            // 
            txt1.Location = new Point(174, 32);
            txt1.Margin = new Padding(3, 4, 3, 4);
            txt1.Name = "txt1";
            txt1.Size = new Size(102, 27);
            txt1.TabIndex = 64;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI Black", 9F);
            lbl2.Location = new Point(33, 91);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(81, 20);
            lbl2.TabIndex = 66;
            lbl2.Text = "2da edad:";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI Black", 9F);
            lbl1.Location = new Point(33, 35);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(84, 20);
            lbl1.TabIndex = 63;
            lbl1.Text = "1era edad:";
            // 
            // txtmye
            // 
            txtmye.Location = new Point(174, 192);
            txtmye.Margin = new Padding(3, 4, 3, 4);
            txtmye.Name = "txtmye";
            txtmye.ReadOnly = true;
            txtmye.Size = new Size(102, 27);
            txtmye.TabIndex = 61;
            // 
            // txt3
            // 
            txt3.Location = new Point(174, 136);
            txt3.Margin = new Padding(3, 4, 3, 4);
            txt3.Name = "txt3";
            txt3.Size = new Size(102, 27);
            txt3.TabIndex = 60;
            // 
            // lblmye
            // 
            lblmye.AutoSize = true;
            lblmye.Font = new Font("Segoe UI Black", 9F);
            lblmye.Location = new Point(33, 195);
            lblmye.Name = "lblmye";
            lblmye.Size = new Size(103, 20);
            lblmye.TabIndex = 62;
            lblmye.Text = "Mayor edad:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI Black", 9F);
            lbl3.Location = new Point(33, 139);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(86, 20);
            lbl3.TabIndex = 59;
            lbl3.Text = "3era edad:";
            // 
            // txtmre
            // 
            txtmre.Location = new Point(174, 253);
            txtmre.Margin = new Padding(3, 4, 3, 4);
            txtmre.Name = "txtmre";
            txtmre.ReadOnly = true;
            txtmre.Size = new Size(102, 27);
            txtmre.TabIndex = 68;
            // 
            // lblmre
            // 
            lblmre.AutoSize = true;
            lblmre.Font = new Font("Segoe UI Black", 9F);
            lblmre.Location = new Point(33, 256);
            lblmre.Name = "lblmre";
            lblmre.Size = new Size(103, 20);
            lblmre.TabIndex = 69;
            lblmre.Text = "Menor edad:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(104, 323);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 67;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // _06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 389);
            Controls.Add(txtmre);
            Controls.Add(lblmre);
            Controls.Add(buttonCalcular);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(txtmye);
            Controls.Add(txt3);
            Controls.Add(lblmye);
            Controls.Add(lbl3);
            Name = "_06";
            Text = "_06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt2;
        private TextBox txt1;
        private Label lbl2;
        private Label lbl1;
        private TextBox txtmye;
        private TextBox txt3;
        private Label lblmye;
        private Label lbl3;
        private TextBox txtmre;
        private Label lblmre;
        private Button buttonCalcular;
    }
}
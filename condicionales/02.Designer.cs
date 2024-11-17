namespace appFP_NET.condicionales
{
    partial class _02
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
            txttotal = new TextBox();
            txtdescuento = new TextBox();
            lbltotal = new Label();
            lbldescuento = new Label();
            txtimporte = new TextBox();
            txtcantidad = new TextBox();
            buttonCalcular = new Button();
            lblimporte = new Label();
            lblcantidad = new Label();
            txtcaramelos = new TextBox();
            lblcaramelos = new Label();
            SuspendLayout();
            // 
            // txttotal
            // 
            txttotal.Location = new Point(207, 215);
            txttotal.Margin = new Padding(3, 4, 3, 4);
            txttotal.Name = "txttotal";
            txttotal.ReadOnly = true;
            txttotal.Size = new Size(102, 27);
            txttotal.TabIndex = 60;
            // 
            // txtdescuento
            // 
            txtdescuento.Location = new Point(207, 159);
            txtdescuento.Margin = new Padding(3, 4, 3, 4);
            txtdescuento.Name = "txtdescuento";
            txtdescuento.ReadOnly = true;
            txtdescuento.Size = new Size(102, 27);
            txtdescuento.TabIndex = 59;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Font = new Font("Segoe UI Black", 9F);
            lbltotal.Location = new Point(28, 215);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(112, 20);
            lbltotal.TabIndex = 61;
            lbltotal.Text = "Total a Pagar:";
            // 
            // lbldescuento
            // 
            lbldescuento.AutoSize = true;
            lbldescuento.Font = new Font("Segoe UI Black", 9F);
            lbldescuento.Location = new Point(28, 159);
            lbldescuento.Name = "lbldescuento";
            lbldescuento.Size = new Size(89, 20);
            lbldescuento.TabIndex = 58;
            lbldescuento.Text = "Descuento:";
            // 
            // txtimporte
            // 
            txtimporte.Location = new Point(207, 101);
            txtimporte.Margin = new Padding(3, 4, 3, 4);
            txtimporte.Name = "txtimporte";
            txtimporte.ReadOnly = true;
            txtimporte.Size = new Size(102, 27);
            txtimporte.TabIndex = 55;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(207, 48);
            txtcantidad.Margin = new Padding(3, 4, 3, 4);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(102, 27);
            txtcantidad.TabIndex = 54;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(115, 323);
            buttonCalcular.Margin = new Padding(3, 4, 3, 4);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(86, 31);
            buttonCalcular.TabIndex = 56;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // lblimporte
            // 
            lblimporte.AutoSize = true;
            lblimporte.Font = new Font("Segoe UI Black", 9F);
            lblimporte.Location = new Point(28, 101);
            lblimporte.Name = "lblimporte";
            lblimporte.Size = new Size(74, 20);
            lblimporte.TabIndex = 57;
            lblimporte.Text = "Importe:";
            // 
            // lblcantidad
            // 
            lblcantidad.AutoSize = true;
            lblcantidad.Font = new Font("Segoe UI Black", 9F);
            lblcantidad.Location = new Point(28, 48);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(79, 20);
            lblcantidad.TabIndex = 53;
            lblcantidad.Text = "Cantidad:";
            // 
            // txtcaramelos
            // 
            txtcaramelos.Location = new Point(207, 272);
            txtcaramelos.Margin = new Padding(3, 4, 3, 4);
            txtcaramelos.Name = "txtcaramelos";
            txtcaramelos.ReadOnly = true;
            txtcaramelos.Size = new Size(102, 27);
            txtcaramelos.TabIndex = 62;
            // 
            // lblcaramelos
            // 
            lblcaramelos.AutoSize = true;
            lblcaramelos.Font = new Font("Segoe UI Black", 9F);
            lblcaramelos.Location = new Point(28, 272);
            lblcaramelos.Name = "lblcaramelos";
            lblcaramelos.Size = new Size(90, 20);
            lblcaramelos.TabIndex = 63;
            lblcaramelos.Text = "Caramelos:";
            // 
            // _02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 376);
            Controls.Add(txtcaramelos);
            Controls.Add(lblcaramelos);
            Controls.Add(txttotal);
            Controls.Add(txtdescuento);
            Controls.Add(lbltotal);
            Controls.Add(lbldescuento);
            Controls.Add(txtimporte);
            Controls.Add(txtcantidad);
            Controls.Add(buttonCalcular);
            Controls.Add(lblimporte);
            Controls.Add(lblcantidad);
            Name = "_02";
            Text = "_02";
            Load += _02_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txttotal;
        private TextBox txtdescuento;
        private Label lbltotal;
        private Label lbldescuento;
        private TextBox txtimporte;
        private TextBox txtcantidad;
        private Button buttonCalcular;
        private Label lblimporte;
        private Label lblcantidad;
        private TextBox txtcaramelos;
        private Label lblcaramelos;
    }
}
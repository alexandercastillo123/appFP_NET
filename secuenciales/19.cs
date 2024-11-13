using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP_NET.secuenciales
{
    public partial class _19 : Form
    {
        public _19()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int vendido = int.Parse(txttv.Text);

            double comision = (vendido / 100) * 9;
            double sbt = 500 + comision;
            double descuento = (sbt / 100) * 11;
            double snt = sbt - descuento;

            txtc.Text = comision.ToString("0.00");
            txtsbr.Text = sbt.ToString("0.00");
            txtd.Text = descuento.ToString("0.00");
            txtsnt.Text = snt.ToString("0.00");
        }
    }
}

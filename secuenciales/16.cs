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
    public partial class _16 : Form
    {
        public _16()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int horas = int.Parse(txttotal.Text);

            double sbc = horas * 5.34;
            double sbt = sbc + (sbc / 100) * 20;
            double snt = sbt - (sbt / 100) * 10;

            txtsbs.Text = sbc.ToString("0.00");
            txtsbr.Text = sbt.ToString("0.00");
            txtsnt.Text = snt.ToString("0.00");
        }
    }
}

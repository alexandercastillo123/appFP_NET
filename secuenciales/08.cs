using Microsoft.VisualBasic.Devices;
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
    public partial class _08 : Form
    {
        public _08()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int altura = int.Parse(txtaltura.Text);
            int radio = int.Parse(txtradio.Text);

            double areabs = Math.PI * radio * radio;
            double arealtl = 2 * Math.PI * radio * altura;
            double areatotal = 2 * areabs + arealtl;

            txtab.Text = areabs.ToString("0.00");
            txtal.Text = arealtl.ToString("0.00");
            txtat.Text = areatotal.ToString("0.00");
        }
    }
}

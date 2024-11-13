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
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void lblmetros_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int kilometros = int.Parse(txt1.Text);
            int pies = int.Parse(txt2.Text);
            int millas = int.Parse(txt3.Text);

            double tm = kilometros * 1000 + pies / 3.2808 + millas * 1609;
            double ty = tm * 1.0936;

            txttm.Text = tm.ToString("0.00");
            txtty.Text = ty.ToString("0.00");
        }
    }
}

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
    public partial class _17 : Form
    {
        public _17()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int Donacion = int.Parse(txtdonacion.Text);

            double salud = (Donacion / 100) * 25;
            double comedor = (Donacion / 100) * 35;
            double escuela = (Donacion / 100) * 25;
            double asilo = (Donacion / 100) * 15;

            txtcs.Text = salud.ToString("0.00");
            txtci.Text = comedor.ToString("0.00");
            txtei.Text = escuela.ToString("0.00");
            txtaa.Text = asilo.ToString("0.00");
        }
    }
}

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
    public partial class _06 : Form
    {
        public _06()
        {
            InitializeComponent();
        }

        private void _06_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int altura = int.Parse(txtaltura.Text);
            int radio = int.Parse(txtradio.Text);

            double area = 2 * Math.PI * radio * (radio + altura);
            double volumen = Math.PI * Math.Pow(radio, 2) * altura;

            txtarea.Text = area.ToString("0.00");
            txtvolumen.Text = volumen.ToString("0.00");
        }
    }
}

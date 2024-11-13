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
    public partial class _07 : Form
    {
        public _07()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int altura = int.Parse(txtaltura.Text);
            int bas = int.Parse(txtbase.Text);

            double area = altura * bas;
            double perimetro = 2 * (altura + bas);

            txtarea.Text = area.ToString("0.00");
            txtperimetro.Text = perimetro.ToString("0.00");
        }
    }
}

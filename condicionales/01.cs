using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace appFP_NET.condicionales
{
    public partial class _01 : Form
    {
        public _01()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(txtcantidad.Text);

            double i1 = 27 * cantidad;
            double i2 = 25 * cantidad;
            double i3 = 23 * cantidad;

            double d1 = ((i3 / 100) * 15);
            double d2 = ((i1 / 100) * 5);
            Double d3 = ((i2 / 100) * 5);

            double t1 = i1 - d2;
            double t2 = i2 - d3;
            double t3 = i3 - d1;

            if (cantidad > 0 && cantidad < 26)
            {
                txtimporte.Text = i1.ToString();
                txtdescuento.Text = d2.ToString();
                txttotal.Text = t1.ToString();
            }
            else if (cantidad > 25 && cantidad < 51)
            {
                txtimporte.Text = i2.ToString();
                txtdescuento.Text = d3.ToString();
                txttotal.Text = t2.ToString();
            }
            else if (cantidad > 50)
            {
                txtimporte.Text = i3.ToString();
                txtdescuento.Text = d1.ToString();
                txttotal.Text = t3.ToString();
            }
        }
    }
}

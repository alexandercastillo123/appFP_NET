using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP_NET.condicionales
{
    public partial class _20 : Form
    {
        public _20()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            int c = int.Parse(txt3.Text);

            // Verificar el orden de los números
            if (a < b && b < c)
            {
                lblorden.Text = ("Orden: Ascendente");
            }
            else if (a > b && b > c)
            {
                lblorden.Text = ("Orden: Descendente.");
            }
            else
            {
                lblorden.Text = ("Los números están en desorden.");
            }
        }
    }
}

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
    public partial class _11 : Form
    {
        public _11()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtn.Text);
            txts.Text = (numero > 0 ? "Positivo" : numero < 0 ? "Negativo" : "Cero");
        }
    }
}

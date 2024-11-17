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
    public partial class _12 : Form
    {
        public _12()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtn.Text);
            txtd.Text = (numero ==1 ? "Lunes" : numero ==2 ? "Martes" : numero == 3 ? "Miercoles" : numero == 4 ? "Jueves" : numero == 5 ? "Viernes" : numero == 6 ? "Sabado" : numero == 7 ? "Domingo" : "Error");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP_NET.repetitivas
{
    public partial class _01 : Form
    {
        public _01()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int dividendo = int.Parse(txt1.Text);
            int divisor = int.Parse(txt2.Text);

            // Inicializar variables para el cociente y el resto
            int cociente = 0;
            int resto = dividendo;

            // Realizar las restas sucesivas
            while (resto >= divisor)
            {
                resto -= divisor;
                cociente++;
            }

            // Mostrar el resultado
            txt3.Text = cociente.ToString();
            txt4.Text = resto.ToString();
        }
    }
}

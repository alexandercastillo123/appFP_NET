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
    public partial class _13 : Form
    {
        public _13()
        {
            InitializeComponent();
        }

        private void _13_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtn.Text);

            if (numero < 100 || numero > 999)
            {
                lbld.Text = ("El número debe tener exactamente tres cifras.");
            }
            else
            {
                // Extraer las cifras del número
                int centena = numero / 100;          // Centena (primer dígito)
                int decena = (numero / 10) % 10;     // Decena (segundo dígito)
                int unidad = numero % 10;            // Unidad (tercer dígito)

                // Verificar si las cifras son consecutivas en orden ascendente
                if (centena + 1 == decena && decena + 1 == unidad)
                {
                    lbld.Text = ("Las cifras son consecutivas en orden ascendente.");
                }
                // Verificar si las cifras son consecutivas en orden descendente
                else if (centena - 1 == decena && decena - 1 == unidad)
                {
                    lbld.Text = ("Las cifras son consecutivas en orden descendente.");
                }
                else
                {
                    lbld.Text = ("Las cifras no son consecutivas.");
                }

            }
        }
    }
}

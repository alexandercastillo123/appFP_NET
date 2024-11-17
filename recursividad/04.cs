using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP_NET.recursividad
{
    public partial class _04 : Form
    {
        public _04()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string cadena = txtnumero.Text;

            // Invertir la cadena usando un método
            string cadenaInvertida = InvertirCadena(cadena);

            // Mostrar la cadena invertida
            txtfactorial.Text = cadenaInvertida;
        }

        // Método para invertir la cadena
        private static string InvertirCadena(string cadena)
        {
            char[] caracteres = cadena.ToCharArray(); // Convertir a arreglo de caracteres
            Array.Reverse(caracteres); // Invertir el arreglo
            return new string(caracteres); // Convertir de nuevo a cadena
        }
    }
}

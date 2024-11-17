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
    public partial class _05 : Form
    {
        public _05()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string cadena = txtnumero.Text;

            // Comprobar si la cadena es un palíndromo
            bool esPalindromo = EsPalindromo(cadena);

            // Mostrar el resultado
            if (esPalindromo)
            {
                txtr.Text = "Si es";
            }
            else
            {
                txtr.Text = "No es";
            }
        }

        // Método para verificar si una cadena es un palíndromo
        private static bool EsPalindromo(string cadena)
        {
            // Convertir a minúsculas y eliminar espacios en blanco y caracteres no alfanuméricos
            string cadenaFiltrada = "";
            foreach (char c in cadena.ToLower())
            {
                if (char.IsLetterOrDigit(c))
                {
                    cadenaFiltrada += c;
                }
            }

            // Comprobar si la cadena filtrada es igual a su reverso
            int longitud = cadenaFiltrada.Length;
            for (int i = 0; i < longitud / 2; i++)
            {
                if (cadenaFiltrada[i] != cadenaFiltrada[longitud - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

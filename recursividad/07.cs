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
    public partial class _07 : Form
    {
        public _07()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtnumero.Text);

            // Calcular la cantidad de dígitos utilizando el método de conversión a cadena
            int cantidadDigitos = CalcularDigitos(numero);

            // Mostrar el resultado
            txtr.Text = cantidadDigitos.ToString();
        }

        // Método para calcular la cantidad de dígitos de un número
        private static int CalcularDigitos(int numero)
        {
            // Si el número es 0, tiene 1 dígito
            if (numero == 0)
            {
                return 1;
            }

            // Usar el valor absoluto para manejar números negativos
            int numeroAbs = Math.Abs(numero);

            // Calcular la cantidad de dígitos usando logaritmo
            int cantidadDigitos = (int)Math.Floor(Math.Log10(numeroAbs) + 1);

            return cantidadDigitos;
        }
    }
}

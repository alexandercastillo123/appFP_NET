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
    public partial class _06 : Form
    {
        public _06()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtnumero.Text);
            int m = int.Parse(txtfactorial.Text);

            // Calcular la potencia usando un método
            double resultado = Potencia(n, m);

            // Mostrar el resultado
            txtr.Text = resultado.ToString();
        }

        // Método para calcular la potencia de un número
        private static double Potencia(double baseNum, int exponente)
        {
            double resultado = 1;

            // Calcular potencia cuando el exponente es positivo
            for (int i = 0; i < Math.Abs(exponente); i++)
            {
                resultado *= baseNum;
            }

            // Si el exponente es negativo, calcular el inverso de la potencia
            if (exponente < 0)
            {
                resultado = 1 / resultado;
            }

            return resultado;
        }
    }
}

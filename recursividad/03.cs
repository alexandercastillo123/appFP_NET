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
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtnumero.Text);
            // Validar que n sea positivo
            if (n < 1)
            {
                Console.WriteLine("Por favor, ingrese un número entero positivo mayor o igual a 1.");
                return;
            }

            // Calcular la suma de los primeros n números naturales
            int suma = SumaNaturales(n);

            // Mostrar el resultado
            txtfactorial.Text = suma.ToString();
        }

        // Método iterativo para calcular la suma de los primeros n números naturales
        private static int SumaNaturales(int n)
        {
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }
            return suma;
        
    }
    }
}

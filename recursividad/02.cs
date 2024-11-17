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
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtnumero.Text);

            // Validar que n no sea negativo
            if (n < 0)
            {
                Console.WriteLine("Por favor, ingrese un número entero no negativo.");
                return;
            }

            // Calcular el número de Fibonacci usando un método iterativo
            int resultado = Fibonacci(n);

            // Mostrar el resultado
            txtfactorial.Text = resultado.ToString();
        }

        // Método iterativo para calcular el número de Fibonacci en la posición n
        private static int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            int fibPrev = 0;
            int fibCurr = 1;
            int fibNext = 0;

            for (int i = 2; i <= n; i++)
            {
                fibNext = fibPrev + fibCurr;
                fibPrev = fibCurr;
                fibCurr = fibNext;
            }

            return fibCurr;
        
    }
    }
}

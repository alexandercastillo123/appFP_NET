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
    public partial class _07 : Form
    {
        public _07()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt1.Text);

            // Validar que el número sea no negativo
            if (n < 0)
            {
                Console.WriteLine("El factorial no está definido para números negativos.");
                return;
            }

            // Calcular el factorial
            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            // Mostrar el resultado
            txt4.Text = factorial.ToString();
        }
    }
}

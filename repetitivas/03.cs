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
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txt1.Text);

            // Inicializar el contador de divisores
            int cantidadDivisores = 0;

            // Verificar los divisores
            for (int i = 1; i <= Math.Abs(numero); i++)  // Usamos Math.Abs para manejar números negativos
            {
                if (numero % i == 0)  // Si el residuo de la división es 0, es un divisor
                {
                    cantidadDivisores++;
                }
            }

            // Mostrar la cantidad de divisores
            txt4.Text = cantidadDivisores.ToString();
        }
    }
}

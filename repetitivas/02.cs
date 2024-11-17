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
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);

            // Inicializar una variable para almacenar el resultado
            int resultado = 0;

            // Realizar la multiplicación mediante sumas sucesivas
            for (int i = 0; i < Math.Abs(b); i++) // Se usa Math.Abs para manejar números negativos
            {
                resultado += a;
            }

            // Si el segundo número es negativo, cambiar el signo del resultado
            if (b < 0)
            {
                resultado = -resultado;
            }

            // Mostrar el resultado
            txt3.Text = resultado.ToString();
        }
    }
}

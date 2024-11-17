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
    public partial class _08 : Form
    {
        public _08()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt1.Text);
            int m = int.Parse(txt2.Text);

            // Inicializar el resultado a 1 (n^0 es 1)
            int resultado = 1;

            // Calcular la potencia mediante multiplicaciones sucesivas
            for (int i = 0; i < Math.Abs(m); i++)
            {
                resultado *= n;
            }

            // Si el exponente es negativo, calcular el inverso del resultado
            if (m < 0)
            {
                txt3.Text = resultado.ToString();
            }
            else
            {
                txt3.Text = resultado.ToString();
            }
        }
    }
}

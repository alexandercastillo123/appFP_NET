using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP_NET.condicionales
{
    public partial class _10 : Form
    {
        public _10()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int ae = int.Parse(txt2.Text);
            int i = int.Parse(txt3.Text);
            int o = int.Parse(txt4.Text);
            int u = int.Parse(txt5.Text);

            double[] numeros = { a, ae, i, o, u };

            double mayor = numeros.Max();
            double menor = numeros.Min();

            double promedio = (a + ae + i + o + u - mayor - menor)/3;
            lblne.Text = $"Notas eliminadas: Mayor = {mayor}, Menor = {menor}";
            lblp.Text = $"Promedio aprobatorio: {promedio:F2}";
        }
    }
}

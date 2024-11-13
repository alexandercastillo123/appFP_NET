using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace appFP_NET.secuenciales
{
    public partial class _10 : Form
    {
        public _10()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtnumero.Text);

            int c1 = numero / 1000; numero %= 1000;
            int c2 = numero / 100; numero %= 100;
            int c3 = numero / 10;
            int c4 = numero % 10;
            int d1 = c4 * 1000;
            int d2 = c3 * 100;
            int d3 = c2 * 10;
            int d4 = c1;

            int invertido = d1 + d2 + d3 + d4;

            txtinvertir.Text = invertido.ToString("");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP_NET.secuenciales
{
    public partial class _11 : Form
    {
        public _11()
        {
            InitializeComponent();
        }

        private void _11_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int nr = int.Parse(txt1.Text);
            int Nr = int.Parse(txt2.Text);

            int c1 = nr / 100; nr %= 100;
            int c2 = nr / 10;
            int c3 = nr % 10;
            int C1 = Nr / 100; Nr %= 100;
            int C2 = Nr / 10;
            int C3 = Nr % 10;

            int d1 = C3 * 100;
            int d2 = c2 * 10;
            int d3 = C1;
            int D1 = c3 * 100;
            int D2 = C2 * 10;
            int D3 = c1;

            int pin = d1 + d2 + d3;
            int sin = D1 + D2 + D3;

            txt1i.Text = pin.ToString("");
            txt2i.Text = sin.ToString("");
        }
    }
}

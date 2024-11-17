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
    public partial class _07 : Form
    {
        public _07()
        {
            InitializeComponent();
        }

        private void lblmye_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt1.Text);
            int b = int.Parse(txt2.Text);
            int c = int.Parse(txt3.Text);

            if (b < a && a < c) { txti.Text = a.ToString(); }
            else if (a < b && b < c) { txti.Text = b.ToString(); }
            else if (c < a && c < b) { txti.Text = c.ToString(); }
        }
    }
}

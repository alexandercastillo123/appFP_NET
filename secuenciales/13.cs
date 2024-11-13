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
    public partial class _13 : Form
    {
        public _13()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int altura = int.Parse(txtaltura.Text);
            int bas = int.Parse(txtbase.Text);

            double hipo = Math.Sqrt((altura * altura) + (bas * bas));

            txthipo.Text = hipo.ToString("0.00");
        }
    }
}

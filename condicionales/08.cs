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
    public partial class _08 : Form
    {
        public _08()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtea.Text);

            double propina = (n * 5) + 20;

            if (0==n && n < 4) { txtpt.Text = propina.ToString(); }
            
        }
    }
}

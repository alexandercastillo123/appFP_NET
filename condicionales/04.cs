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
    public partial class _04 : Form
    {
        public _04()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int no = int.Parse(txtn1.Text);
            int not = int.Parse(txtn2.Text);
            int nota = int.Parse(txtn3.Text);

            double pf = (no + not + nota + 2) / 3;
            double pn = (no + not + nota) / 3;

            if (nota > 9)
            {
                txtp.Text =pf.ToString();
            }
            else if (nota < 10)
            {
                txtp.Text =pn.ToString();
            }
        }
    }
}

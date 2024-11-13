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
    public partial class _05 : Form
    {
        public _05()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int Gigabites = int.Parse(txtg.Text);

            int Megabites = Gigabites * 1024;
            int Kilobites = Megabites * 1024;
            int Bites = Kilobites * 1024;

            txtm.Text = Megabites.ToString("0.00");
            txtk.Text = Kilobites.ToString("0.00");
            txtb.Text = Bites.ToString("0.00");
        }
    }
}

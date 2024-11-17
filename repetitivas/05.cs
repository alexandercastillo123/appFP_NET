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
    public partial class _05 : Form
    {
        public _05()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt1.Text);

            Console.WriteLine($"\nTabla de multiplicar del número {n}:");
            for (int i = 1; i <= 12; i++)
            {
                lbl4.Text = ($"{n} x {i} = {n * i}");
            }
        }
    }
}

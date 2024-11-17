namespace appFP_NET.condicionales
{
    public partial class _03 : Form
    {
        public _03()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int angulo = int.Parse(txtangulo.Text);

            if (angulo == 0)
            {
                txttipo.Text = "Nulo".ToString();
            }
            else if (angulo < 90 && 0 < angulo)
            {
                txttipo.Text = "Agudo".ToString();
            }
            else if (angulo == 90)
            {
                txttipo.Text = "Recto".ToString();
            }
            else if (angulo < 180 && 90 < angulo)
            {
                txttipo.Text = "Obtuso".ToString();
            }
            else if (angulo == 180)
            {
                txttipo.Text = "Llano".ToString();
            }
            else if (angulo < 360 && 180 < angulo)
            {
                txttipo.Text = "Concavo".ToString();
            }
            else if (angulo == 360)
            {
                txttipo.Text = "Completo".ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

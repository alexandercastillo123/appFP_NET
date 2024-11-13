namespace appFP_NET.secuenciales
{
    public partial class _01 : Form
    {
        public _01()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int varones = int.Parse(txtVarones.Text);
            int mujeres = int.Parse(txtMujeres.Text);

            int total = varones + mujeres;
            double pVarones = (double)varones * 100 / total;
            double pMujeres = (double)mujeres * 100 / total;

            lblPvarones.Text = string.Format("{0:0.00} %", pVarones);
            lblPmujeres.Text = string.Format("{0:0.00} %", pMujeres);
        }

        private void _01_Load(object sender, EventArgs e)
        {

        }
    }
}

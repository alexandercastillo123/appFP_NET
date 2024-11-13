namespace appFP_NET.secuenciales
{
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int metros = int.Parse(txtmetros.Text);

            double centimetros = metros * 100;
            double pulgadas = centimetros / 2.54;
            double pies = pulgadas / 12;
            double yardas = pies / 3;

            txtcentimetros.Text = centimetros.ToString("0.00");
            txtpulgadas.Text = pulgadas.ToString("0.00");
            txtpies.Text = pies.ToString("0.00");
            txtyardas.Text = yardas.ToString("0.00");
        }
        private void _02_Load(object sender, EventArgs e)
        {

        }
    }
}

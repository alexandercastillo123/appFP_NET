namespace appFP_NET.secuenciales
{
    public partial class _04 : Form
    {
        public _04()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int pies = int.Parse(txtpies.Text);
            int pulgadas = int.Parse(txtpulgadas.Text);

            double metros = pies * 0.3048 + pulgadas * 0.0254;

            txtmetros.Text = metros.ToString("0.00");
        }
    }
}

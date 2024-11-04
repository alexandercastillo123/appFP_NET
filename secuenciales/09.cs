namespace appFP_NET.secuenciales
{
    public partial class _09 : Form
    {
        public _09()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int numeros = int.Parse(txtnumero.Text);

            int c1 = numeros/ 1000; numeros %= 1000;
            int c2 = numeros / 100; numeros %= 100;
            int c3 = numeros / 10; numeros %= 10;
            int c4 = numeros % 10;

            txtsuma.Text = "" + (c1 + c2 + c3 + c4);
        }
    }
}

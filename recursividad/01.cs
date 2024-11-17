namespace appFP_NET.recursividad
{
    public partial class _01 : Form
    {
        public _01()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtnumero.Text);

            int resultado = SumarHasta(n);
            txtfactorial.Text = resultado.ToString();
        }

        // Función recursiva para sumar números
        static int SumarHasta(int n)
        {
            // Caso base
            if (n == 1)
                return 1;

            // Llamada recursiva
            return n + SumarHasta(n - 1);
        }
    }
}

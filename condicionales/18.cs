namespace appFP_NET.condicionales
{
    public partial class _18 : Form
    {
        public _18()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double montoDonacion = double.Parse(txtmonto.Text);

            double centroSalud;
            double comedorNinos;
            double inversionBolsa;

            // Verificar la cantidad de la donación y calcular la distribución
            if (montoDonacion >= 10000)
            {
                centroSalud = montoDonacion * 0.30; // 30% para el centro de salud
                comedorNinos = montoDonacion * 0.50; // 50% para el comedor de niños
                inversionBolsa = montoDonacion - (centroSalud + comedorNinos); // El resto se invierte
            }
            else
            {
                centroSalud = montoDonacion * 0.25; // 25% para el centro de salud
                comedorNinos = montoDonacion * 0.60; // 60% para el comedor de niños
                inversionBolsa = montoDonacion - (centroSalud + comedorNinos); // El resto se invierte
            }

            // Mostrar los resultados
            lblsalud.Text=($"Centro de Salud: ${centroSalud:F2}");
            lblcomedor.Text=($"Comedor de Niños: ${comedorNinos:F2}");
            lblinvertido.Text=($"Inversión en la Bolsa: ${inversionBolsa:F2}");
        }
    }
}

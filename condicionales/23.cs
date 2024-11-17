namespace appFP_NET.condicionales
{
    public partial class _23 : Form
    {
        public _23()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double notaMatematicas = double.Parse(txtmate.Text);
            double notaFisica = double.Parse(txtfisi.Text);

            double propinaMatematicas;
            double propinaFisica;

            // Calcular la propina por la nota en Matemáticas
            if (notaMatematicas > 17)
            {
                propinaMatematicas = 3.0;
            }
            else
            {
                propinaMatematicas = notaMatematicas * 1.0;
            }

            // Calcular la propina por la nota en Física
            if (notaFisica > 15)
            {
                propinaFisica = 2.0;
            }
            else
            {
                propinaFisica = notaFisica * 0.5;
            }

            // Calcular el total de la propina
            double totalPropina = propinaMatematicas + propinaFisica;

            // Calcular el promedio de las notas
            double promedio = (notaMatematicas + notaFisica) / 2;

            // Mostrar los resultados
            txtpropina.Text = totalPropina.ToString();

            // Verificar si el promedio es mayor a 16 para obsequiar el reloj
            if (promedio > 16)
            {
                txtreloj.Text = ("Sí");
            }
            else { txtreloj.Text = ("No"); }
        }
    }
}

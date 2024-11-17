using System.Data;

namespace appFP_NET.condicionales
{
    public partial class _05 : Form
    {
        public _05()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtnumero.Text);

            // Convertir el número a un array de dígitos
            int[] cifras = numero.ToString().Select(c => int.Parse(c.ToString())).ToArray();

            // Obtener la cifra mayor y la cifra menor
            int cifraMayor = cifras.Max();
            int cifraMenor = cifras.Min();

            // Formar el mayor y menor número de dos cifras
            int mayorNumero = cifraMayor * 10 + cifraMenor;

            txtnuevonumero.Text = mayorNumero.ToString();
        }
    }
}

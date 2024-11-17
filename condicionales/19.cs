namespace appFP_NET.condicionales
{
    public partial class _19 : Form
    {
        public _19()
        {
            InitializeComponent();
        }

        private void _19_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string sexo = txtsexo.Text.ToUpper();  // Asegurarse de que se ingrese en mayúsculas para la comparación

            // Leer la edad como entero
            int edad = int.Parse(txtedad.Text);

            // Determinar la categoría usando operadores ternarios
            string categoria = sexo == "F"
                                ? (edad < 23 ? "FA" : "FB")
                                : (edad < 25 ? "MA" : "MB");

            // Mostrar la categoría asignada en un Label
           txtcodigo.Text = "" + categoria;
        }

    }
    }


namespace appFP_NET.condicionales
{
    public partial class _02 : Form
    {
        public _02()
        {
            InitializeComponent();
        }

        private void _02_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            const double precioUnitario = 20.0;
            double descuento = 0;
            int caramelos = 0;

            int unidades = int.Parse(txtcantidad.Text);

            // Calcular el importe de la compra
            double importeCompra = unidades * precioUnitario;

            // Determinar el porcentaje de descuento según el importe de la compra
            if (importeCompra > 700)
            {
                descuento = 0.16;
            }
            else if (importeCompra >= 501)
            {
                descuento = 0.14;
            }
            else
            {
                descuento = 0.12;
            }

            // Calcular el descuento y el total a pagar
            double montoDescuento = importeCompra * descuento;
            double totalAPagar = importeCompra - montoDescuento;

            // Determinar la cantidad de caramelos según las unidades adquiridas
            if (unidades >= 1 && unidades <= 50)
            {
                caramelos = 5;
            }
            else if (unidades >= 51 && unidades <= 100)
            {
                caramelos = 10;
            }
            else if (unidades > 100)
            {
                caramelos = 15;
            }

            // Mostrar los resultados
            txtimporte.Text = importeCompra.ToString();
            txtdescuento.Text = montoDescuento.ToString();
            txttotal.Text = totalAPagar.ToString();
            txtcaramelos.Text = caramelos.ToString();
            
        }
        }
    }

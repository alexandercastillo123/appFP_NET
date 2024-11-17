using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFP_NET.condicionales
{
    public partial class _16 : Form
    {
        public _16()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double ingresoMensual = double.Parse(txti.Text);
            double costoCasa = double.Parse(txtc.Text);

            double cuotaInicial;
            int cuotasMensuales;
            double montoCuotaMensual;

            // Determinar la cuota inicial y el número de cuotas
            if (ingresoMensual < 1250)
            {
                cuotaInicial = costoCasa * 0.15; // 15% del costo de la casa
                cuotasMensuales = 120;
            }
            else
            {
                cuotaInicial = costoCasa * 0.30; // 30% del costo de la casa
                cuotasMensuales = 75;
            }

            // Calcular el monto de cada cuota mensual
            double montoRestante = costoCasa - cuotaInicial;
            montoCuotaMensual = montoRestante / cuotasMensuales;

            // Mostrar los resultados
            lblci.Text=($"Cuota Inicial: S/. {cuotaInicial:F2}");
            lblcm.Text=($"Monto de la Cuota Mensual: S/. {montoCuotaMensual:F2}");
        }

        private void lblnumero_Click(object sender, EventArgs e)
        {

        }
    }
}

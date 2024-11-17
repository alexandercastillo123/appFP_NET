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
    public partial class _21 : Form
    {
        public _21()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtcodigo.Text);

            int estadoCivil = numero / 1000;            // Primera cifra (estado civil)
            int edad = (numero / 10) % 100;             // Segunda y tercera cifra (edad)
            int sexo = numero % 10;                     // Última cifra (sexo)

            // Determinar el estado civil
            string estadoCivilDesc;
            switch (estadoCivil)
            {
                case 1: estadoCivilDesc = "Soltero"; break;
                case 2: estadoCivilDesc = "Casado"; break;
                case 3: estadoCivilDesc = "Divorciado"; break;
                case 4: estadoCivilDesc = "Viudo"; break;
                default: estadoCivilDesc = "Estado civil desconocido"; break;
            }

            // Determinar el sexo
            string sexoDesc;
            if (sexo == 1)
                sexoDesc = "Masculino";
            else if (sexo == 2)
                sexoDesc = "Femenino";
            else
                sexoDesc = "Sexo desconocido";

            // Mostrar los resultados
            txtec.Text= (""+estadoCivilDesc);
            txte.Text = ("" + edad);
            txts.Text = ("" +sexoDesc);
        }
    }
}

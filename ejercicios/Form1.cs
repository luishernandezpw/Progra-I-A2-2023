using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertirConversores_Click(object sender, EventArgs e)
        {
            int de, a;
            double cantidad, respuesta;

            de = cboDeConversores.SelectedIndex;
            a = cboAConversores.SelectedIndex;

            cantidad = double.Parse(txtCantidadConversores.Text);
            //Dolar,Euro,Quetzal,Lempira,Cordoba,Colon SV,Colon CR,Yenes,Rupias India,Libras Esterlinas
            double[] monedas = {1, 0.92, 7.86, 24.62, 36.56,8.75, 535.14, 145.52, 83.32, 0.79};

            respuesta = monedas[a] / monedas[de] * cantidad;
            lblRespuestaConversores.Text = "Respuesta: " + Math.Round(respuesta, 3);
        }
    }
}

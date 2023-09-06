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
    public partial class frmConverciones : Form
    {
        Parcial objParcial = new Parcial();
        public frmConverciones()
        {
            InitializeComponent();
        }
        private void btnConvertirConversores_Click(object sender, EventArgs e)
        {
            int de = cboDeConversores.SelectedIndex, a = cboAConversores.SelectedIndex, tipo = cboTipoConversor.SelectedIndex;
            double cantidad = double.Parse(txtCantidadConversores.Text), respuesta = 0;

            if( tipo==6 ){//temperatura
                respuesta = objParcial.convertir(de, a, cantidad);
            }else{
                respuesta = objParcial.convertir(tipo, de, a, cantidad);
            }

            lblRespuestaConversores.Text = "Respuesta: " + Math.Round(respuesta, 3);
        }
        private void cboTipoConversor_TextChanged(object sender, EventArgs e)
        {
            cboDeConversores.Items.Clear();
            cboDeConversores.Items.AddRange(objParcial.tiposConversores[cboTipoConversor.SelectedIndex]);

            cboAConversores.Items.Clear();
            cboAConversores.Items.AddRange(objParcial.tiposConversores[cboTipoConversor.SelectedIndex]);
        }
        

        private void frmConverciones_Load(object sender, EventArgs e)
        {
            cboTipoConversor.SelectedIndex = 0;
        }
    }
}

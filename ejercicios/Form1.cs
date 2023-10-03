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
        Conexion objConexion = new Conexion();
        DataSet miDs = new DataSet();
        public int posicion =0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            miDs.Clear();
            miDs = objConexion.obtenerDatos();
            mostrarMaterias();
            mostrarDatosMateria();
        }
        private void mostrarMaterias()
        {
            grdDatosMaterias.DataSource = miDs.Tables["materias"].DefaultView;
        }
        private void mostrarDatosMateria()
        {
            txtCodigoMateria.Text = miDs.Tables["materias"].Rows[posicion].ItemArray[1].ToString();
            txtNombreMateria.Text = miDs.Tables["materias"].Rows[posicion].ItemArray[2].ToString();
            txtUvMateria.Text = miDs.Tables["materias"].Rows[posicion].ItemArray[3].ToString();

            lblnRegistroMateria.Text = (posicion + 1) + " de " + miDs.Tables["materias"].Rows.Count;
        }

        private void btnSiguienteMateria_Click(object sender, EventArgs e)
        {
            if (posicion < miDs.Tables["materias"].Rows.Count-1){
                posicion++;
                mostrarDatosMateria();
            } else{
                MessageBox.Show("Ultimo Registro", "Registro de Materias");
            }
        }

        private void btnUltimoMateria_Click(object sender, EventArgs e)
        {
            posicion = miDs.Tables["materias"].Rows.Count - 1;
            mostrarDatosMateria();
        }

        private void btnAnteriorMateria_Click(object sender, EventArgs e)
        {
            if (posicion > 0){
                posicion--;
                mostrarDatosMateria();
            }else {
                MessageBox.Show("Primer regisro", "Registro de Materias");
            }
        }

        private void btnPrimeroMateria_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosMateria();
        }

        private void btnNuevoMateria_Click(object sender, EventArgs e)
        {
            
        }
    }
}

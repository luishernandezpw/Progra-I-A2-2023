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
    public partial class matricula : Form
    {
        public matricula()
        {
            InitializeComponent();
        }

        private void matricula_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_academicoDataSet.matriculaAlumnosPeriodos' Puede moverla o quitarla según sea necesario.
            this.dtMatriculaAlumnosPeriodos.Fill(this.db_academicoDataSet.matriculaAlumnosPeriodos);
            // TODO: esta línea de código carga datos en la tabla 'db_academicoDataSet.alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.db_academicoDataSet.alumnos);
            // TODO: esta línea de código carga datos en la tabla 'db_academicoDataSet.periodos' Puede moverla o quitarla según sea necesario.
            this.periodosTableAdapter.Fill(this.db_academicoDataSet.periodos);
            this.matriculaTableAdapter1.Fill(this.db_academicoDataSet.matricula);
            nRegistrosMatricula();
        }
        private void filtrarMatriculas(String valor, int opcion)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = matriculaDataGridView.DataSource;
                //bs.Filter = opcion == 0 ? "periodo=" + valor : "nombre like '%" + valor + "%'";
                bs.Filter = "periodo like '%" + valor + "%' OR nombre like '%" + valor + "%'";
                matriculaDataGridView.DataSource = bs;
                //erpAlumnos.SetError(txtBuscarAlumnos, "");
            }
            catch (Exception e)
            {

                //erpAlumnos.SetError(txtBuscarAlumnos, "Por favor ingrese un codigo o nombre del estudiante a buscr");
            }
        }
        private void nRegistrosMatricula()
        {
            lblnRegistroMatricula.Text = (matriculaBindingSource.Position + 1) + " de " + matriculaBindingSource.Count;
        }
        private void btnPrimeroMatricula_Click(object sender, EventArgs e)
        {
            matriculaBindingSource.MoveFirst();
            nRegistrosMatricula();
        }
        private void btnSiguienteMatricula_Click(object sender, EventArgs e)
        {
            matriculaBindingSource.MoveNext();
            nRegistrosMatricula();
        }
        private void btnUltimoMatricula_Click(object sender, EventArgs e)
        {
            matriculaBindingSource.MoveLast();
            nRegistrosMatricula();
        }
        private void btnAnteriorMatricula_Click(object sender, EventArgs e)
        {
            matriculaBindingSource.MovePrevious();
            nRegistrosMatricula();
        }

        private void btnNuevoMatricula_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnNuevoMatricula.Text == "Nuevo")
                {
                    btnNuevoMatricula.Text = "Guardar";
                    btnModificarMatricula.Text = "Cancelar";
                    estadoControles(true);

                    matriculaBindingSource.AddNew();
                }
                else
                {
                    matriculaBindingSource.EndEdit();
                    this.matriculaTableAdapter1.Update(db_academicoDataSet);
                    estadoControles(false);
                    btnNuevoMatricula.Text = "Nuevo";
                    btnModificarMatricula.Text = "Modificar";
                }
            }catch(Exception er) {
                //
            }
        }
        private void btnModificarMatricula_Click(object sender, EventArgs e)
        {
            if (btnModificarMatricula.Text == "Modificar"){
                btnNuevoMatricula.Text = "Guardar";
                btnModificarMatricula.Text = "Cancelar";
                estadoControles(true);

            }else{
                matriculaBindingSource.CancelEdit();

                estadoControles(false);
                btnNuevoMatricula.Text = "Nuevo";
                btnModificarMatricula.Text = "Modificar";
            }
        }
        private void estadoControles(Boolean estado)
        {
            cboAlumnoMatricula.Enabled = estado;
            cboPeriodoMatricula.Enabled = estado;
            dtFechaMatriucla.Enabled = estado;

            grbNavegacionMatricula.Enabled = !estado;
            btnEliminarMatricula.Enabled = !estado;
        }
        private void btnEliminarMatricula_Click(object sender, EventArgs e)
        {
            matriculaBindingSource.RemoveCurrent();
            this.matriculaTableAdapter1.Update(db_academicoDataSet);
            nRegistrosMatricula();
        }

        private void txtBuscarMatricula_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarMatriculas(txtBuscarMatricula.Text, 0);
            if (e.KeyValue == 13)
            {//tecla enter
                seleccionarMatricula();
            }
        }
        private void seleccionarMatricula()
        {
            try
            {
                matriculaBindingSource.Position = matriculaBindingSource.Find("idMatricula", matriculaDataGridView.CurrentRow.Cells["idMatricula"].Value.ToString());
                nRegistrosMatricula();
            }catch(Exception e)
            {
                //MessageBox.Show("Error: "+ e.Message);
            }
        }

        private void matriculaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarMatricula();
        }
    }
}
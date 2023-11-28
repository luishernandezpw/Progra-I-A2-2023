using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios
{
    public partial class inscripcion : Form
    {
        private int _idInscripcion = 0;
        public inscripcion()
        {
            InitializeComponent();
        }

        private void inscripcion_Load(object sender, EventArgs e)
        {
             // TODO: esta línea de código carga datos en la tabla 'db_academicoDataSet.dInscripcionMateria' Puede moverla o quitarla según sea necesario.
            this.dtDetalleInscripcionMateria.Fill(this.db_academicoDataSet.dInscripcionMateria);
            // TODO: esta línea de código carga datos en la tabla 'db_academicoDataSet.alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.db_academicoDataSet.alumnos);
            // TODO: esta línea de código carga datos en la tabla 'db_academicoDataSet.inscripcionMatriculaPerido' Puede moverla o quitarla según sea necesario.
            this.inscripcionMatriculaPeridoTableAdapter.Fill(this.db_academicoDataSet.inscripcionMatriculaPerido);

            nRegistroInscripcion();
        }

        private void nRegistroInscripcion()
        {
            lblnRegistroInscripcion.Text = (inscripcionMatriculaPeridoBindingSource.Position + 1) + " de " + inscripcionMatriculaPeridoBindingSource.Count;
        }
        private void estadoControles(Boolean estado)
        {
            fechaDateTimePicker.Enabled = estado;
            idAlumnoComboBox.Enabled = estado;

            grbNavegacionInscripcion.Enabled = !estado;
            btnEliminarInscripcion.Enabled = !estado;

            btnAgregarMateriaInscripcion.Enabled = estado;
            btnEliminarMateriaInscripcion.Enabled = estado;
        }
        private void btnSiguienteInscripcion_Click(object sender, EventArgs e)
        {
            inscripcionMatriculaPeridoBindingSource.MoveNext();
            nRegistroInscripcion();
        }

        private void btnUltimoInscripcion_Click(object sender, EventArgs e)
        {
            inscripcionMatriculaPeridoBindingSource.MoveLast();
            nRegistroInscripcion();
        }

        private void btnAnteriorInscripcion_Click(object sender, EventArgs e)
        {
            inscripcionMatriculaPeridoBindingSource.MovePrevious();
            nRegistroInscripcion();
        }

        private void btnPrimeroInscripcion_Click(object sender, EventArgs e)
        {
            inscripcionMatriculaPeridoBindingSource.MoveFirst();
            nRegistroInscripcion();
        }

        private void btnNuevoInscripcion_Click(object sender, EventArgs e)
        {
            if (btnNuevoInscripcion.Text == "Nuevo") {
                btnNuevoInscripcion.Text = "Guardar";
                btnModificarInscripcion.Text = "Cancelar";
                estadoControles(true);
                inscripcionMatriculaPeridoBindingSource.AddNew();
                idAlumnoComboBox.SelectedValue = 1;

            }else{//Guardar
                try
                {
                    this.Validate();
                    inscripcionMatriculaPeridoBindingSource.EndEdit();

                    inscripcionMatriculaPeridoTableAdapter.Connection.Open();
                    SqlCommand miCommand = new SqlCommand();
                    miCommand.Connection = inscripcionMatriculaPeridoTableAdapter.Connection;

                    
                    btnNuevoInscripcion.Text = "Nuevo";
                    btnModificarInscripcion.Text = "Modificar";
                    estadoControles(false);
                }catch(Exception error)
                {
                    MessageBox.Show("Error: " + error.Message);
                }
            }
        }

        private void btnModificarInscripcion_Click(object sender, EventArgs e)
        {
            if (btnModificarInscripcion.Text == "Modificar"){
                btnNuevoInscripcion.Text = "Guardar";
                btnModificarInscripcion.Text = "Cancelar";
                estadoControles(true);

            }else{//Cancelar
                dInscripcionMateriaBindingSource.CancelEdit();
                inscripcionMatriculaPeridoBindingSource.CancelEdit();

                btnNuevoInscripcion.Text = "Nuevo";
                btnModificarInscripcion.Text = "Modificar";
                estadoControles(false);
            }
        }

        private void btnAgregarMateriaInscripcion_Click(object sender, EventArgs e)
        {
            materias objMateria = new materias();
            objMateria.ShowDialog();
            if( objMateria._idMateria>0) {
                dInscripcionMateriaBindingSource.AddNew();

                dInscripcionMateriaDataGridView.CurrentRow.Cells["idMateria"].Value = objMateria._idMateria;
                dInscripcionMateriaDataGridView.CurrentRow.Cells["codigo"].Value = objMateria._codigo;
                dInscripcionMateriaDataGridView.CurrentRow.Cells["materia"].Value = objMateria._materia;
                dInscripcionMateriaDataGridView.CurrentRow.Cells["uv"].Value = objMateria._uv;
            }
        }

        private void btnEliminarMateriaInscripcion_Click(object sender, EventArgs e)
        {
            dInscripcionMateriaDataGridView.Rows.Remove(dInscripcionMateriaDataGridView.CurrentRow);
        }
    }
}

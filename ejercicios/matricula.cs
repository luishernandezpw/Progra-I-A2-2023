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
            // TODO: esta línea de código carga datos en la tabla 'db_academicoDataSet.alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.db_academicoDataSet.alumnos);
            // TODO: esta línea de código carga datos en la tabla 'db_academicoDataSet.periodos' Puede moverla o quitarla según sea necesario.
            this.periodosTableAdapter.Fill(this.db_academicoDataSet.periodos);
        }
      
    }
}

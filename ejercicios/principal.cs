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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materias objMaterias = new materias();
            objMaterias.MdiParent = this;
            objMaterias.Show();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alumnos objalumnos = new alumnos();
            objalumnos.MdiParent = this;
            objalumnos.Show();
        }

        private void matriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matricula objMatricula = new matricula();
            objMatricula.MdiParent = this;
            objMatricula.Show();
        }
    }
}

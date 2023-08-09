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

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(txtEdad.Text);
            if( edad>=18) {
                MessageBox.Show("Bienvenido, eres responsable de tus actos.");
            }
        }
    }
}

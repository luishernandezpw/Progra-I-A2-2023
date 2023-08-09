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

            /**
             * if extendido
             */
            /*if (edad <= 2 ){
                MessageBox.Show("Eres un bebe");
            } else if(edad<12) {
                MessageBox.Show("Eres un niño.");
            } else if (edad < 18){
                MessageBox.Show("Eres un adolescente");
            } else if (edad <= 65){
                MessageBox.Show("Eres mayor de edad");
            } else if(edad<=80){
                MessageBox.Show("Adulto Mayor");
            } else {
                MessageBox.Show("Larga vidad...");
            }*/

            /**
            * if ternario
            */
            String msg = edad <= 2 ? "Eres un bebe" : 
                edad < 12 ? "Eres un niño" : 
                edad < 18 ? "Eres un adolescente" :
                edad <=65 ? "Eres mayor de edad" : 
                edad <=80 ? "Eres adulto mayor" : "Larga vidad...";
            MessageBox.Show(msg);

            /**
           * switch
           */
            /*String msg;
            switch (edad){
                case 2:
                    msg = "Tienes 2 años";
                    break;

                case 12:
                    msg = "Tienes 12 años";
                    break;

                default:
                    msg = "Otra edad";
                    break;
            }
            MessageBox.Show(msg);*/

            /**
           * ciclo for
           */

        }
    }
}

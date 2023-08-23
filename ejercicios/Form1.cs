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
            int ntabla = int.Parse(txtNTablaMultiplicar.Text);
            String msg= "TABLA DE MULTIPLICAR DEL "+ ntabla +"\n";
            for(int i=1; i<=10; i++){
                msg += ntabla + "x" + i + "=" + (ntabla * i) + "\n";
            }
            MessageBox.Show(msg);
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text), 
                num2 = double.Parse(txtNum2.Text), 
                respuesta = sumar(num1, num2);
            MessageBox.Show("Respuesta: "+ respuesta);

            //Crear un programa en C# que genere la secuencia de los numeros fibonacci.
            /*
            0 + 1 = 1
            1 + 0 = 1
            1 + 1 = 2
            2 + 1 = 3
            3 + 2 = 5
            5 + 3 = 8
            8 + 5 = 13
            13 + 8 = 21
            21 + 13 = 34
            34 + 21 = 55
            ...
             */
            //Cree un programa en C# que determine si un numero es par o impar.
            //Cree un programa en C# que determine si un numero es primo o no.
        }

        double sumar(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}

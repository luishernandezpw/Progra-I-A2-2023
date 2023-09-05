using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    class Parcial
    {
        public String[][] tiposConversores = new String[][]{
            new String[]{"Dolar", "Euro", "Quetzal", "Lempira", "Cordoba", "Colon SV", "Colon CR", "Yenes", "Rupias India", "Libras Esterlinas"},//Monedas
            new String[]{"Libras", "Miligramos", "Gramos", "Onzas", "Tonelada Corta"}, //Masa
            new String[]{"Litro"}, //Volumen
            new string[]{"Metro", "Milimetro", "Centimetro", "Pulgada", "Pies", "Varas", "Yardas", "Kilometros", "Millas" }, //Longitud
            new String[]{ }//tiempo
        }; //Matriz dentada
        //Dolar,Euro,Quetzal,Lempira,Cordoba,Colon SV,Colon CR,Yenes,Rupias India,Libras Esterlinas
        public double[][] monedas = {
            new double[]{1, 0.92, 7.86, 24.62, 36.56, 8.75, 535.14, 145.52, 83.32, 0.79}, //Array Unidimensional
            new double[]{}, //masa
            new double[]{}, //volumen
            new double[]{1, 1000, 100, 39.3701, 3.28084, 1.1963081929167, 1.0936, 0.001, 0.000621371}, //longitud
            new double[]{ } //tiempo
        };
        public double convertir(int tipo, int de, int a, double cantidad)
        {
            return monedas[tipo][a] / monedas[tipo][de] * cantidad;
        }
    }
}

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
            new String[]{ },//tiempo
            new string[]{ }, //superficie
            new string[]{"Celsius", "Farenheit", "Kelvin"} //temperatura
        }; //Matriz dentada
        //Dolar,Euro,Quetzal,Lempira,Cordoba,Colon SV,Colon CR,Yenes,Rupias India,Libras Esterlinas
        double[][] valores = {
            new double[]{1, 0.92, 7.86, 24.62, 36.56, 8.75, 535.14, 145.52, 83.32, 0.79}, //Array Unidimensional
            new double[]{}, //masa
            new double[]{}, //volumen
            new double[]{1, 1000, 100, 39.3701, 3.28084, 1.1963081929167, 1.0936, 0.001, 0.000621371}, //longitud
            new double[]{ }, //tiempo
            new double[]{ } //superficie
        };
        public double convertir(int de, int a, double cantidad)
        {
            double grados = 0;
            if(de==0 && a == 1){//Celsius a Farenheit
                grados = cf(cantidad);
            }else if (de == 0 && a == 2){//celsius a kelvin
                grados = cantidad + 273.15;
            }else if (de == 1 && a == 0){//Farenheit a Celsius
                grados = (cantidad - 32) * 9 / 5;
            }else if (de == 1 && a == 2) {//Farenheit a kelvin
                grados = (cantidad - 32) * 5 / 9 + 273.15;
            }else if (de == 2 && a == 0){//Kelvin a Celsius
                grados = kc(cantidad);
            }else if (de == 2 && a == 1){//kelvin a Farenheit
                grados = cf( kc(cantidad) );
            }else{
                grados = cantidad;
            }
            return grados;
        }
        double cf(double cantidad)
        {
            return cantidad * 9 / 5 + 32;
        }
        double kc(double cantidad)
        {
            return cantidad - 273.15;
        }
        public double convertir(int tipo, int de, int a, double cantidad)
        {
            return valores[tipo][a] / valores[tipo][de] * cantidad;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Operacion
    {
        public double suma(double num1, double num2)
        {
            return num1 + num2;
        }

        public double resta(double num1, double num2)
        {
            return num1 - num2;
        }

        public double multiplicacion(double num1, double num2)
        {
            return num1 * num2;
        }

        public double division(double num1, double num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (Exception ex)
            {  
                Console.WriteLine("Error: " + ex.Message);
                return 0;
            }
        }    

        public double potencia(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }

        public double raizcuadrada(double num1)
        {
            return Math.Sqrt(num1);
        }

        public string salir()
        {
            return "Adios";
        }






    }

}

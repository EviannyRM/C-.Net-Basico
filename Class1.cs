using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_1
{
    internal class Practica1
    {
     static void Main()
        {

            Console.WriteLine ("Ingrese el primer numero: ");
            int num1= int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int suma = num1 + num2;

            int multiplicacion = num1 * num2;

            Console.WriteLine($"El resultado de la suma es: {suma}");

            Console.WriteLine($"El resultado de la multiplicacion es: {multiplicacion}");
        }
    }
 

}

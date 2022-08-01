using System;

namespace App5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            //solicitud de datos en pantalla
            Console.WriteLine("Introduzca un número");

            //almacenando datos en variable
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca otro número");
            num2 = int.Parse(Console.ReadLine());

            //declaracion de variables de operacion
            var suma = num1 + num2;
            var resta = num1 - num2;
            var multiplicacion = num1 * num2;
            var division = num1 / num2;

            //lectura de datos en pantalla
            Console.WriteLine("La suma de los números es: " + (suma));
            Console.WriteLine("La resta de los números es: " + (resta));
            Console.WriteLine("La multiplicación de los números es: " + (multiplicacion));
            Console.WriteLine("La división de los números es: " + (division));
        }
    }
}
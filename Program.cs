using System;

namespace Ejercicio4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar tres números y emitir un cartel aclaratorio
            //  si la suma de los dos primeros es mayor al producto del segundo con el tercero.
            
            int a, b, c, s, m;

            Console.WriteLine("Introduce el 1º numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el 2º numero");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el ultimo numero");
            c = int.Parse(Console.ReadLine());

            s = a + b;
            m = b * c;

            if (s > m)
                Console.WriteLine("La suma es mayor que la multiplicacion");
            else
                Console.WriteLine("La multiplicacion es mayor que la suma");

            Console.WriteLine("Fin del programa");
        }
    }
}

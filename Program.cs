using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperacionesCon2Numeros_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el operando 1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el operando 2:");
            int num2 = int.Parse(Console.ReadLine());

            int suma = num1 + num2;
            int resta = num1 - num2;
            int multi = num1 * num2;
            int divi = num1 / num2;
            int resto = num1 % num2;

            Console.WriteLine($"SUMA: {suma}");
            Console.WriteLine($"RESTA: {resta}");
            Console.WriteLine($"MULTIPLICACIÓN: {multi}");
            Console.WriteLine($"DIVISIÓN: {divi}");
            Console.WriteLine($"RESTO: {resto}");
        }
    }
}

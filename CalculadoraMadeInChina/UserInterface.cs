using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraMadeInChina
{
    class UserInterface
    {
        public static void PrintMainMenu ()
        {
            System.Console.WriteLine("  Calculadora Made in China");
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("0) Salir de la aplicacióm");
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("1) Sumar una serie de números");
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("2) Restar una serie de números");
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("3) Multiplicar una serie de números");
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("4) Dividir una serie de números");
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("5) Sacar Raíz");
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("6) Sumario de una serie de números");
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("7) Averiguar si tu número es primo");
        }
    }
}

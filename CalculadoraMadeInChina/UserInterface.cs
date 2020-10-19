using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraMadeInChina
{
    class UserInterface
    {
        public static void PrintMainMenu ()
        {
            System.Console.Clear();
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

        public static int ReadOption()
        {
            string option = System.Console.ReadLine();
            //Cuando algo puede petar se pone esto
            //Try para lo que queremos hacer, catch lo que saldría si no funcionara, y finally para que pase algo sin importar si ha petado
            try
            { 
                int result = System.Convert.ToInt32(option);
                return result;
            }
            catch (System.Exception e)
            {
                return -1;
            }
        }
    }
}

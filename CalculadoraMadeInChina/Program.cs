using System;

namespace CalculadoraMadeInChina
{
    class Program
    {
        public static void ManageMainMenu()
        {
            while (true)
            {
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadOption();
                if (option == 0)
                {
                    //break: si esta dentro de un bucle sale de ese bucle, si está dentro de un switch sale del switch
                    break;
                }
                else if (option == -1)
                {
                    System.Console.Clear()
                    System.Console.WriteLine("Opción no válida");
                }
                else if (option < 0 || option > 7)
                {
                    System.Console.Clear()
                    System.Console.WriteLine("Opción no válida, por favor escriba un número del 1 al 7");
                }
            }
            System.Console.WriteLine("Fin del menú principal");
        }
    

        static void Main(string[] args)
        {
            ManageMainMenu();
        }
    }
}

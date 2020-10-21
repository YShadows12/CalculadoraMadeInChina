using System;

namespace CalculadoraMadeInChina
{
    class Program
    {
        public static void ManageAddMenu()
        {
            int option = UserInterface.ReadOption();

            while (true)
            {
                UserInterface.PrintAddMenu();
                switch (option)
                {
                    case 0:
                        break;
                }
            }
        }

        public static void ManageMainMenu()
        {
            bool finished = false;

            while (finished == false)
            {
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadOption();
                

                switch (option)
                {
                    case -1:
                        System.Console.Clear();
                        System.Console.WriteLine("Opción no válida");
                        break;
                    //break: si esta dentro de un bucle sale de ese bucle, si está dentro de un switch sale del switch
                    //case son puntos de entrada del swtich y break son puntos de salida del switch, si no hubiera un break seguiría ejecutando a muerte todo lo demás hasta encontranrse con uno
                    case 1:
                        ManageAddMenu();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 0:
                        finished = true;
                        break;
                    default:
                        break;
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

using System;

namespace CalculadoraMadeInChina
{
    class Program
    {
        public static void ManageAddSubmenu(int Accumuled)
        {
            while (true)
            {
                UserInterface.PrintAddHeader();
                System.Console.WriteLine("Llevas acumulado: " + Accumuled);
                int number = ManageUtils.ReadInteger("Introduce otro número: ");
                Accumuled += number;
                System.Console.WriteLine("Llevas acumulado: " + Accumuled);
                UserInterface.PrintAddSubmenu();
                switch (option)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                }

            }
        }

        public static void ManageAddMenu()
        {
            while (true)
            {
                UserInterface.PrintAddHeader();
                int number1 = ManageUtils.ReadInteger("Introduzca el primer número");
                int number2 = ManageUtils.ReadInteger("Introduzca el segundo número");
                int result = number1 + number2;
                System.Console.WriteLine("El resultado es " + result);
                UserInterface.PrintAddSubmenu();
                int option = UserInterface.ReadOption();
                if(option == 0)
                {
                    return;
                }
                else if (option == 2)
                {
                    System.Console.Clear();
                }
                else if (option == 1)
                {
                    ManageAddSubmenu(result);
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

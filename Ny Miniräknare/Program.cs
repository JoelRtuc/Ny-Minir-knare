using System.Reflection;

namespace Ny_Miniräknare
{
    internal class Program
    {
        static void Main()
        {
            string räknesätt;
            int a = 0, b = 0;

            Console.WriteLine("Vilket räknesätt vill du använa? \"+-*/\"?");
            räknesätt = Console.ReadLine();

            Console.WriteLine("Vilka nummer vill du räkna med?");

            if(!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Ogiltigt");

                Main();
            }
            Console.WriteLine("och?");

            if (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Ogiltigt");

                Main();
            }

            try
            {
                switch (räknesätt)
                {
                    case "+":
                        Addition(a, b);
                        break;
                    case "-":
                        Subtraktion(a, b);
                        break;
                    case "*":
                        Multiplikation(a, b);
                        break;
                    case "/":
                        Division(a, b);
                        break;
                    default:
                        Console.WriteLine("Ogiltigt räknesätt");
                        Main();
                        break;
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("kan inte dela med 0!");
                Main();
            }

            void Addition(int a, int b)
            {
                Console.WriteLine(a + b);
            }

            void Subtraktion(int a, int b)
            {
                Console.WriteLine(a - b);
            }

            void Multiplikation(int a, int b)
            {
                Console.WriteLine(a * b);
            }

            void Division(int a, int b)
            {
                Console.WriteLine(a / b);
            }
        }
    }
}

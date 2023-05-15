using System;
namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, Elige que operacion desea hacer");
            Console.WriteLine("1 = Suma");
            Console.WriteLine("2 = Resta");
            Console.WriteLine("3 = Multiplicacion");
            Console.WriteLine("4 = Division");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x == 1)
            {
                Console.WriteLine("Introduce un numero: ");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce otro número: ");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Suma: {0} + {1} = {2}", numero1, numero2,
                numero1 + numero2);
            }
            else if (x == 2)
            {
                Console.WriteLine("Introduce un numero: ");
                int numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce otro número: ");
                int numero2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Resta: {0} - {1} = {2}", numero1, numero2,
                numero1 - numero2);
            }
        }
    }
}
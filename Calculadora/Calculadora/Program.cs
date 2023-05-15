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
        }
    }
}
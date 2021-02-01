using System;

namespace ExercicioGFT1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a,b,c;
            Console.WriteLine("Digite o valor da variável A: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da variável B: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da variável C: ");
            c = float.Parse(Console.ReadLine());
            double delta = Math.Pow(b, 2) - (4 * a * c);
            if (delta < 0 || a == 0)
            {
                Console.WriteLine("Impossível Calcular");
            }
            else
            {
                double raizdelta = Math.Sqrt(delta);
                double x1 = ((-(b)) + raizdelta) / (2 * a);
                double x2 = ((-(b)) - raizdelta) / (2 * a);
                Console.WriteLine(" X1 = " + x1.ToString("N5"));
                Console.WriteLine(" X2 = " + x2.ToString("N5"));
            }
            Console.ReadKey();
        }
    }
}

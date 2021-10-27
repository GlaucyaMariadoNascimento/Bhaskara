using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("-- Equação de segundo grau --");
   
            double a, b, c, x1, x2, delta;
               
       
            Console.WriteLine("Digite o valor de a: ");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de b: ");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de c: ");
            c = Double.Parse(Console.ReadLine());
            delta = (b*b) - 4*a*c;
            Console.WriteLine("O valor de Delta é: " + delta);
            x1 = (-b + Math.Sqrt(delta)) / 2 * a;
            x2 = (-b - Math.Sqrt(delta)) / 2 * a;
            
            if (a == 0)
            {
                Console.WriteLine("Não é uma equação de segundo grau!");
            }
            else if(delta < 0)
            {
                Console.WriteLine("A equação não possui raízes reais!");
            }
            else if(delta  > 0)
            {
                Console.WriteLine("Exite 2 raízes reais diferentes. X1:" + x1 + "x2:" + x2);
            }
            else if(delta == 0)
            {
                Console.WriteLine("Exite 2 raízes reais iguais. X1:" + x1 + "x2:" + x2);
            }
            Console.ReadKey();
        }   
    }
}

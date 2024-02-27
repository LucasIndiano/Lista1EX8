using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, menor = 0, maior = 0;
            Console.WriteLine("Digite 5 Números: ");
            a = int.Parse(Console.ReadLine());
            maior = a;
            menor = a;
            int cont = 4;

            while (cont > 0) {
                b = int.Parse(Console.ReadLine());

                if (b > maior) { maior = b; }
                if (b < menor) { menor = b; }
                cont--;
            }
            
            Console.WriteLine("Maior Número: " + maior);
            Console.WriteLine("Menor Número: " + menor);


            Console.ReadKey();
        }
    }
}

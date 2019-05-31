using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_02_parte_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0, d = 0, soma = 0;

            Console.Write("Digite um número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite um número: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite um número: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Digite um número: ");
            d = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 4; i++)
            {
                if (i == 1)
                {
                    if (a % 2 == 0)
                    {
                        soma += a;
                    }
                }

                else if (i == 2)
                {
                    if (b % 2 == 0)
                    {
                        soma += b;
                    }
                }

                else if (i == 3)
                {
                    if (c % 2 == 0)
                    {
                        soma += c;
                    }
                }

                else if (i == 4)
                {
                    if (d % 2 == 0)
                    {
                        soma += d;
                    }
                }
            }

            Console.WriteLine("A soma dos números pares é = " + soma);
            Console.ReadKey();
        }
    }
}

using System;
using System.Runtime.CompilerServices;

namespace ClassA
{
    class Program
    {
        static void Main()
        {
            // Definição das variáveis.
                double a , b, c, delta, r1, r2;
            
            // Pedir a entrada dos três valores para o usuário.
                Console.Write("Digite o valor de a:");
                a = double.Parse(Console.ReadLine()!);

                Console.Write("Digite o valor de b:");
                b = double.Parse(Console.ReadLine()!);

                Console.Write("Digite o valor de c:");
                c = double.Parse(Console.ReadLine()!);
            
            // Primeiro, o calculo do delta é feito, utilizando o método Math.pow para acelerar o cálculo.

                delta = Math.Pow(b,2) - 4 * a * c;

                // Parao resultado positivo do delta, utilizando o metodo Math.sqrt para calcular raiz do delta e calcular a fórmula.
                if (delta > 0)
                {
                    r1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    r2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine("Duas raizes reais:");
                    Console.WriteLine("Raiz 1 = " + r1);
                    Console.WriteLine("Raiz 2 = " + r2);
                }

                // Para Delta 0, existirá apenas uma raiz.
                else if (delta == 0)
                {
                    r1 = -b / (2 * a);
                    Console.WriteLine("Uma raiz leal:");
                    Console.WriteLine("Raiz = " + r1);
                }
                else
                {
                    Console.WriteLine("Nao existe raizes reais.");
                }

                Console.ReadKey();

                
            }

                
        }
}
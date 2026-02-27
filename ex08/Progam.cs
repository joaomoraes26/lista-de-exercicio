
using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número que não seja  negativo:");
        int n = int.Parse(Console.ReadLine()!);

        if (n < 0) // checa se o numero é positivo
        {
            Console.WriteLine("Número inválido. Digite um valor não negativo.");
            return;
        }

        int f0 = 0, f1 = 1; // da entrada dos primeiros numeros da sequencia 

        for (int i = 0; i <= n; i++) // loop que repete do zero até o numero digitado 
        {
            if (i == 0)
            {
                Console.Write(f0);
            }
            else if (i == 1)
            {
                Console.Write(", " + f1);
            }
            else // condição para calcular a sequencia
            {
                int fn = f0 + f1;
                Console.Write(", " + fn);
                f0 = f1;
                f1 = fn;
            }
        }

        Console.ReadKey();
    }
}
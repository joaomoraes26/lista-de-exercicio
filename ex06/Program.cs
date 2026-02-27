using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine()!);

        // tira o negativo
        numero = Math.Abs(numero);

        int contador = 0;

        // se o numero for zero, o contador aumenta instantaneo
        if (numero == 0)
        {
            contador = 1;
        }
        else
        {
            while (numero > 0)
            {
                numero = numero / 10; // divide por 10 para tirar o ultimo digito e incrementar no contador 
                contador++;
            }
        }

        Console.WriteLine("Quantidade de dígitos: " + contador); // exibe o resultado

        Console.ReadKey();
    }
}
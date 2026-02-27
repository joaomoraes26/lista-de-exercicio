using System;

class Investimento
{
    static void Main()
    { 
        // procura o valor investido mensal do cliente
        Console.Write("Digite o valor investido por mês: ");
        double depositoMensal = double.Parse(Console.ReadLine()!);
        
        // pergunta a taxa de juros mensal
        Console.Write("Digite a taxa de juros mensal (%): ");
        double taxa = double.Parse(Console.ReadLine()!) / 100.0;

        double saldo = 0;
        int ano = 1;
        string continuar = "s";

        // whule é utilizado para controlar o ano 

        while (continuar.ToLower() == "s")
        { 

        // o for é utilizado para controlar cada mes
            for (int mes = 1; mes <= 12; mes++)
            {
                saldo += depositoMensal;   // adiciona o depósito do mes
                saldo += saldo * taxa;     // aplica juros sobre o saldo
            }

            Console.WriteLine($"Saldo após o ano {ano}: R$ {saldo:F2}");

            Console.Write("Deseja calcular o próximo ano? (s/n): ");
            continuar = Console.ReadLine()!;

            ano++;
        }

        Console.WriteLine("Programa encerrado.");
        Console.ReadKey();
    }
}
using System;

class Program
{
    static void Main()
{
       
       // Pega as nformações do produto e guarda em variaveis 

        Console.Write("Digite o nome do produto: ");
        string nome = Console.ReadLine()!;

        Console.Write("Digite o preço do produto: ");
        double preco = double.Parse(Console.ReadLine()!);

        Console.Write("Digite a quantidade comprada: ");
        int quantidade = int.Parse(Console.ReadLine()!);

        double total = preco * quantidade;
        double desconto = 0;

        // calcula o desconto de acordo com a quantidade comprada 
        if (quantidade <= 10)
        {
            desconto = 0;
        }
        else if (quantidade >= 11 && quantidade <= 20)
        {
            desconto = 0.10; // desconto de 10%
        }
        else if (quantidade >= 21 && quantidade <= 50)
        {
            desconto = 0.20; // desconto de 20%
        }
        else if (quantidade > 50)
        {
            desconto = 0.25; // desconto de 25%
        }
           
           // calcula o valor final da compra 
        double valorFinal = total - (total * desconto);

        Console.WriteLine("\nProduto comprado: " + nome);
        Console.WriteLine("Valor total a ser pago: R$ " + valorFinal.ToString("F2")); // formata o número para que ele apareça com duas casas decimais

        Console.ReadKey();
    }
}
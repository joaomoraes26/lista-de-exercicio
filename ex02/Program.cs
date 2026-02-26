using System;
class Program
{
    static void Main()
    {
        // Definição das variáveis.

        // Variaveis para guardar os pontos, 3 pontos por se tratar de uma dimensão 3D.
        double x1, y1, z1;
        double x2, y2, z2;
        
        // Variável para guardar o valor da distância.
        double distancia;


        // Pede a entrada de cada ponto para o usuário.

        Console.Write("Digite x1 para a coordenada X do primeiro ponto: ");
        x1 = double.Parse(Console.ReadLine()!);

        Console.Write("Digite y1 para a coordenada Y do primeiro ponto: ");
        y1 = double.Parse(Console.ReadLine()!);

        Console.Write("Digite z1 para a coordenada Z do primeiro ponto: ");
        z1 = double.Parse(Console.ReadLine()!);

        Console.Write("Digite x2 para a coordenada X do segundo ponto: ");
        x2 = double.Parse(Console.ReadLine()!);

        Console.Write("Digite y2 para a coordenada Y do segundo ponto: ");
        y2 = double.Parse(Console.ReadLine()!);

        Console.Write("Digite z2 para a coordenada Z do segundo ponto: ");
        z2 = double.Parse(Console.ReadLine()!);

        // Utilização da fórmula da distância para chegar ao resultado.
        distancia = Math.Sqrt(
            Math.Pow(x2 - x1, 2) +
            Math.Pow(y2 - y1, 2) +
            Math.Pow(z2 - z1, 2)
        );

        Console.WriteLine("A distância entre os pontos é: " + distancia);

        Console.ReadKey();
    }
}
using System;

class SistemaAluno
{
    static void Main()
    {  
        // usuário informa as notas 

        Console.Write("Digite a primeira nota: ");
        double n1 = double.Parse(Console.ReadLine()!); 

        Console.Write("Digite a segunda nota: ");
        double n2 = double.Parse(Console.ReadLine()!); 

        Console.Write("Digite a terceira nota: ");
        double n3 = double.Parse(Console.ReadLine()!);

        double media = CalcularMedia(n1, n2, n3); // variavel para guardar a média

        string status = VerificarStatus(media); // informa o status do estudante 

        Console.WriteLine($"\nMédia: {media:F2}");
        Console.WriteLine($"Status: {status}");
    }

    // função que calcula média 
    static double CalcularMedia (double nota1, double nota2, double nota3)
    {
        return (nota1 + nota2 + nota3) / 3.0;
    }

    //função que informa o status do aluno
    static string VerificarStatus(double media)
    {
        if (media > 6)
        {
            return "Aprovado";
        }
        else if (media >= 4)
        {
            return "Verificação Suplementar";
        }
        else
        {
            return "Reprovado";
        }
    }
}
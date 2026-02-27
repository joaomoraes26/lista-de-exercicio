using System;

class DecimalParaRomano
{
    static void Main()
    {
        int numero = LerNumero(); // pega o numero digitado

        int centena = ObterCentena(numero); //
        int dezena = ObterDezena(numero);
        int unidade = ObterUnidade(numero);

        string romano = ConverterRomano(centena, dezena, unidade);

        Console.WriteLine($"\nNúmero em romano: {romano}");
    }

    // função para ler o número escrito
    static int LerNumero()
    {
        Console.Write("Digite um número entre 0 e 999: ");
        return int.Parse(Console.ReadLine()!);
    }

    // pega qual a centena do numero escrito pelo usuario
    static int ObterCentena(int numero)
    {
        return numero / 100;
    }

    // pega a dezena escrita pelo usuario 
    static int ObterDezena(int numero)
    {
        return (numero % 100) / 10;
    }

    // pega a unidade escrita pelo usuário
    static int ObterUnidade(int numero)
    {
        return numero % 10;
    }

    // função que converte para o numero romano
    static string ConverterRomano(int centena, int dezena, int unidade)
    {
        string[] romanosCentena =
        { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" }; // vetor da centena em romano 

        string[] romanosDezena =
        { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" }; // vetor da dezena em romano 

        string[] romanosUnidade =
        { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" }; // vetor da unidade me romano

        return romanosCentena[centena] + romanosDezena[dezena] + romanosUnidade[unidade]; // retorna o numero escrito
    }
}
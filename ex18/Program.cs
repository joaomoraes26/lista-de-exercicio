using System;

class NumeroPorExtenso
{
    static void Main()
    {
        int numero = LerNumero(); 

        if (numero == 0)
        {
            Console.WriteLine("zero");
        }
        else
        {
            Console.WriteLine(ConverterNumero(numero));
        }
    }

    
    static int LerNumero() // função para ler o numero que o usuario inseriu
    {
        Console.Write("Digite um número até 9 dígitos: ");
        return int.Parse(Console.ReadLine()!);
    }

    // 
    static string ConverterNumero(long numero) // checagem de grandeza do numero inserido
    {
        string resultado = "";

        int milhoes = (int)(numero / 1000000);
        int milhares = (int)((numero % 1000000) / 1000);
        int resto = (int)(numero % 1000);

        if (milhoes > 0)
        {
            resultado += ConverterGrupo(milhoes) + 
                        (milhoes == 1 ? " milhão " : " milhões ");
        }

        if (milhares > 0)
        {
            resultado += ConverterGrupo(milhares) + " mil ";
        }

        if (resto > 0)
        {
            resultado += ConverterGrupo(resto);
        }

        return resultado.Trim();
    }

    
    static string ConverterGrupo(int numero) // conversão do numero menor que 1000
    {
        string[] unidades =  // unidades
        { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };

        string[] especiais = //numeros entre dez e vitne
        { "dez", "onze", "doze", "treze", "quatorze", "quinze",
          "dezesseis", "dezessete", "dezoito", "dezenove" };

        string[] dezenas = // dezenas
        { "", "", "vinte", "trinta", "quarenta", "cinquenta",
          "sessenta", "setenta", "oitenta", "noventa" };

        string[] centenas =  // centenas
        { "", "cento", "duzentos", "trezentos", "quatrocentos",
          "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };

        if (numero == 100)
            return "cem";

        int c = numero / 100; // variaveis para guardar posição de cada numero
        int d = (numero % 100) / 10;
        int u = numero % 10;

        string resultado = "";

        if (c > 0)
            resultado += centenas[c] + " ";

        if (d == 1)
        {
            resultado += especiais[u];
        }
        else
        {
            if (d > 1)
                resultado += dezenas[d] + " ";

            if (u > 0)
                resultado += unidades[u];
        }

        return resultado.Trim();
    }
}
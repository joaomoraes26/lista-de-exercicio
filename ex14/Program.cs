using System;

class Vetores
{
    static void Main()
    {
        int[] v1 = new int[50]; //criação do primeiro vetor 
        int[] v2 = new int[50]; // criação do segundo vetor 
        int[] vFinal = new int[100]; // junção dos dois vetores 

        Random random = new Random(); // método que gera números aleatórios 

        // Preencher os vetores com números aleatórios
        for (int i = 0; i < 50; i++)
        {
            v1[i] = random.Next(1, 1000); // preenchimento do primeiro vetor com números de 1 a 1000
            v2[i] = random.Next(1, 1000); // peenchimento do segundo vetor com números de 1 a 1000
        }

        Array.Sort(v1); // organiza os vetores em ordem crescente 
        Array.Sort(v2);

        
        int i1 = 0, i2 = 0, iFinal = 0; // combinação dos vetores 

        while (i1 < 50 && i2 < 50) // loop para comparação e ordenação do vetor 
        {
            if (v1[i1] < v2[i2]) // se o numero do primeiro, for menor que o numero do segundo, ele sera jogado para o vetor final de maneira ordenada
            {
                vFinal[iFinal++] = v1[i1++]; 
            }
            else
            {
                vFinal[iFinal++] = v2[i2++]; // da mesma forma, mas no caso com o numero do segundo menor que o numero do primeiro
            }
        }
        
        Console.WriteLine("Vetor Final Ordenado:\n"); // mostra o resultado 
        MostrarVetor(vFinal);
    }

    static void MostrarVetor(int[] v) // função para mostrar o vetor ordenado
    {
        foreach (int num in v)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
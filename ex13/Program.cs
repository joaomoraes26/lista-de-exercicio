using System;

class OrdenarVetor
{
    static void Main()
    {
        int[] vetor = new int[100]; // Cria o vetor para 100 números 
        Random random = new Random(); // atributo ara geração de números aleatórios

        for (int i = 0; i < vetor.Length; i++) // loop que preenche os espaços do vetor 
        {
            vetor[i] = random.Next(1, 1000); // numeros aleatórios de 1 a 1000
        }

        Console.WriteLine("Vetor antes da ordenação:\n"); // mostra o vetor desordenado
        MostrarVetor(vetor);

        // Ordenando o vetor
        Array.Sort(vetor); // método que organiza os vetores em ordem crescente     

        Console.WriteLine("\nVetor depois da ordenação:\n");
        MostrarVetor(vetor);
    }

    static void MostrarVetor(int[] v) // função criada para mostrar o vetor 
    {
        foreach (int num in v) // para cada numero dentro do vetor
        {
            Console.Write(num + " "); // imprime o numero 
        }
        Console.WriteLine();
    }
}

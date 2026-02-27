using System;

class Loop
{
    static void Main(string[] args)
    {
        for (int i = 2; i <= 8; i = i + 2) // i começa e incrementa de 2 em 2 até chegar em 8 // 2,4,6,8
        {
            for (int j = i; j <= 4; j++) // j começa com o valor de I e vai incrementando até chegar em 4
            {
                for (int k = 1; k <= j; k = k + i) // k começa em 1 e incrementa até o valor de J
                {
                    Console.WriteLine(i + ", " + j + ", " + k);
                }
            }
        }

        Console.ReadKey();
    }
}

/*
SAÍDA :
2, 2, 1
2, 3, 1
2, 3, 3
2, 4, 1
2, 4, 3
4, 4, 1
*/
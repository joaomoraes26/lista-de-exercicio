using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++) // primeiro número
        {
            for (int j = 1; j <= 10; j++) // segundo número
            {
                Console.WriteLine(i + " x " + j + " = " + (i * j));
            }

            Console.WriteLine(); //linha para separar as tabuadas
        }

        Console.ReadKey();
    }
}
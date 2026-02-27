using System;

class JogoDaVelhaMelhorJogada
{
    static void Main()
    {
        char[,] jogo = new char[3, 3]; // criação do plano de jogo da velha 

        for (int i = 0; i < 3; i++) // linha do tabuleiro, de 0 a 2
{
        string linha = Console.ReadLine().Trim(); // lê a string com 3 tipos de variaveis, onde podem ser X, O e . (representação de espaço vazio)

        while (linha.Length < 3) // checa se a entrada do usuário tem apenas 3 digitos
    {
        Console.WriteLine("Linha inválida...");
        linha = Console.ReadLine().Trim();
    }

        for (int j = 0; j < 3; j++) // copia as caracteres escritas para a matriz que representa o plano de jogo
        tab[i, j] = linha[j];

        Console.Write("Qual é o seu símbolo? (X/O): "); // pergunta com qual símbolo o usuário vai jogar
        
        char eu = char.ToUpper(Console.ReadLine().Trim()[0]); // guarda a variável de usuário, onde o .Trim é responsável por tirar o espaço da caractere do usuário
        char adv = (eu == 'X') ? 'O' : 'X'; // define o símbolo do adversário 
    
   var win;
   
}
    }
}
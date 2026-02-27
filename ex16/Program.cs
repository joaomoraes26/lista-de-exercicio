using System;

class ConversorTempo
{
    static void Main()
    {
        int totalSegundos = LerSegundos();

        int horas = CalcularHoras(totalSegundos);
        int minutos = CalcularMinutos(totalSegundos);
        int segundos = CalcularSegundosRestantes(totalSegundos);

        EscreverResultado(horas, minutos, segundos);
    }

        static int LerSegundos() 
    {
        Console.Write("Digite o tempo em segundos: ");
        return int.Parse(Console.ReadLine()!);
    }

    static int CalcularHoras(int totalSegundos) // método que calcula as horas 
    {
        return totalSegundos / 3600;
    }
 
    static int CalcularMinutos(int totalSegundos)  // método que calcula os minutos
    {
        return (totalSegundos % 3600) / 60;
    }
    static int CalcularSegundosRestantes(int totalSegundos) // método que calcula os segundos 
    {
        return totalSegundos % 60;
    }
    static void EscreverResultado(int horas, int minutos, int segundos) // método que escreve o resultado
    {
        Console.WriteLine($"\n{horas} hora(s), {minutos} minuto(s) e {segundos} segundo(s).");
    }
}
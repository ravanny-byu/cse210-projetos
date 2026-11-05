
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("================================");
        Console.WriteLine("       MEU PROGRAMA DE DIÁRIO");
        Console.WriteLine("================================");

        Diario diario = new Diario();
        GeradorDePerguntas gerador = new GeradorDePerguntas();

        Console.WriteLine("Programa iniciado com sucesso!");
    }
}

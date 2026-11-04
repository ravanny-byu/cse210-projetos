using System;

class Program
{
    static void Main(string[] args)
    {
        

string jogarNovamente = "sim";

while (jogarNovamente == "sim")
{
    // Gerar um número mágico aleatório entre 1 e 100
    Random random = new Random();
    int numeroMagico = random.Next(1, 101);

    int palpite = -1;
    int tentativas = 0;

    Console.WriteLine("\nBem-vindo ao jogo de adivinhação!");
    Console.WriteLine("Tente descobrir o número mágico entre 1 e 100.");

    // Continuar enquanto o jogador não acertar
    while (palpite != numeroMagico)
    {
        Console.Write("Qual é o seu palpite? ");
        palpite = int.Parse(Console.ReadLine());

        // Contar as tentativas
        tentativas++;

        // Comparar o palpite com o número mágico
        if (palpite < numeroMagico)
        {
            Console.WriteLine("Mais alto");
        }
        else if (palpite > numeroMagico)
        {
            Console.WriteLine("Mais baixo");
        }
        else
        {
            Console.WriteLine("Você adivinhou!");
            Console.WriteLine($"Você precisou de {tentativas} tentativas.");
        }
    }

    // Perguntar se deseja jogar novamente
    Console.Write("Deseja jogar novamente? ");
    jogarNovamente = Console.ReadLine().ToLower();
}

Console.WriteLine("\nObrigado por jogar!");

    }
}
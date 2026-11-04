
using System;

class Program
{
    // Exibe uma mensagem de boas-vindas
    static void ExibirBoasVindas()
    {
        Console.WriteLine("Bem-vindo ao programa!");
    }

    // Solicita e retorna o nome do usuário
    static string PerguntarNomeUsuario()
    {
        Console.Write("Por favor, insira seu nome: ");
        string nome = Console.ReadLine();

        return nome;
    }

    // Solicita e retorna o número favorito
    static int PerguntarNumeroFavorito()
    {
        Console.Write("Por favor, insira seu número favorito: ");
        int numero = int.Parse(Console.ReadLine());

        return numero;
    }

    // Recebe um número e retorna seu quadrado
    static int ElevarAoQuadrado(int numero)
    {
        return numero * numero;
    }

    // Exibe o nome e o resultado
    static void ExibirResultado(string nome, int resultado)
    {
        Console.WriteLine($"{nome}, o quadrado do seu número é {resultado}");
    }

    // Função principal do programa
    static void Main(string[] args)
    {
        ExibirBoasVindas();

        string nomeUsuario = PerguntarNomeUsuario();

        int numeroFavorito = PerguntarNumeroFavorito();

        int resultado = ElevarAoQuadrado(numeroFavorito);

        ExibirResultado(nomeUsuario, resultado);
    }
}


using System;

class Program
{
    static void Main(string[] args)
    {
        Curriculo meuCurriculo = new Curriculo();

        Console.WriteLine("===== CADASTRO DE CURRÍCULO =====");

        Console.Write("Digite seu nome: ");
        meuCurriculo._nome = Console.ReadLine();

        Console.Write("\nQuantos empregos deseja cadastrar? ");
        int quantidade = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"\n--- Emprego {i + 1} ---");

            Emprego emprego = new Emprego();

            Console.Write("Nome da empresa: ");
            emprego._empresa = Console.ReadLine();

            Console.Write("Cargo ocupado: ");
            emprego._cargo = Console.ReadLine();

            Console.Write("Ano de início: ");
            emprego._anoInicio = int.Parse(Console.ReadLine());

            Console.Write("Ano de término: ");
            emprego._anoFim = int.Parse(Console.ReadLine());

            meuCurriculo._empregos.Add(emprego);
        }

        meuCurriculo.Exibir();
    }
}

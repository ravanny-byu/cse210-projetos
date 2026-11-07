
using System;

class Program
{
    static void Main(string[] args)
    {
        Diario diario = new Diario();
        GeradorDePerguntas gerador = new GeradorDePerguntas();

        string arquivo = "meu_diario.txt";
        bool executando = true;

        while (executando)
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("       MEU PROGRAMA DE DIÁRIO");
            Console.WriteLine("================================");
            Console.WriteLine("1. Escrever uma nova entrada");
            Console.WriteLine("2. Exibir todas as entradas");
            Console.WriteLine("3. Salvar diário");
            Console.WriteLine("4. Carregar diário");
            Console.WriteLine("5. Sair");
            Console.Write("\nEscolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    string pergunta = gerador.ObterPerguntaAleatoria();

                    Console.WriteLine("\nPergunta do dia:");
                    Console.WriteLine(pergunta);

                    Console.Write("\nSua resposta: ");
                    string resposta = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(resposta))
                    {
                        string data = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                        Registro novoRegistro = new Registro(data, resposta);

                        diario.AdicionarRegistro(novoRegistro);
                    }
                    else
                    {
                        Console.WriteLine("A resposta não pode ficar vazia.");
                    }
                    break;

                case "2":
                    diario.ExibirTodos();
                    break;

                case "3":
                    diario.SalvarNoArquivo(arquivo);
                    break;

                case "4":
                    diario.CarregarDoArquivo(arquivo);
                    break;

                case "5":
                    executando = false;
                    Console.WriteLine("\nObrigado por utilizar seu diário!");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}

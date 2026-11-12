using System;

class Program
{
    static void Main(string[] args)
    {
        // Cria a referência bíblica
        Referencia referencia = new Referencia("João", 3, 16);

        // Texto de exemplo da escritura
        string texto = "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito para que todo aquele que nele crê não pereça mas tenha a vida eterna";

        // Cria o objeto Escritura
        Escritura escritura = new Escritura(referencia, texto);

        // Loop principal do programa
        while (!escritura.EstaCompletamenteOculta())
        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("     MEMORIZADOR DE ESCRITURAS");
            Console.WriteLine("=================================");
            Console.WriteLine();

            Console.WriteLine(escritura.ObterTexto());

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para ocultar palavras.");
            Console.WriteLine("Digite 'sair' para encerrar.");
            Console.Write("Sua escolha: ");

            string escolha = Console.ReadLine() ?? "";

            if (escolha.Trim().ToLower() == "sair")
            {
                break;
            }

            // Oculta três palavras visíveis aleatoriamente
            escritura.OcultarPalavrasAleatorias(3);
        }

        Console.Clear();

        if (escritura.EstaCompletamenteOculta())
        {
            Console.WriteLine("Parabéns! Você memorizou a escritura!");
        }
        else
        {
            Console.WriteLine("Sessão encerrada. Continue praticando!");
        }
    }
}

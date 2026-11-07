
using System;
using System.Collections.Generic;
using System.IO;

public class Diario
{
    // Lista que armazena os registros
    private List<Registro> _registros = new List<Registro>();

    // Adiciona um novo registro
    public void AdicionarRegistro(Registro novoRegistro)
    {
        _registros.Add(novoRegistro);
        Console.WriteLine("Registro adicionado com sucesso!");
    }

    // Exibe todos os registros
    public void ExibirTodos()
    {
        if (_registros.Count == 0)
        {
            Console.WriteLine("O diário ainda não possui registros.");
            return;
        }

        Console.WriteLine("\n========== MEU DIÁRIO ==========");

        foreach (Registro registro in _registros)
        {
            registro.Exibir();
        }
    }

    // Salva os registros em um arquivo
    public void SalvarNoArquivo(string arquivo)
    {
        try
        {
            List<string> linhas = new List<string>();

            foreach (Registro registro in _registros)
            {
                linhas.Add(registro.Data + "|" + registro.Texto);
            }

            File.WriteAllLines(arquivo, linhas);

            Console.WriteLine("Diário salvo com sucesso!");
        }
        catch (IOException)
        {
            Console.WriteLine("Erro ao salvar o diário.");
        }
    }

    // Carrega os registros de um arquivo
    public void CarregarDoArquivo(string arquivo)
    {
        try
        {
            if (!File.Exists(arquivo))
            {
                Console.WriteLine("Arquivo não encontrado.");
                return;
            }

            _registros.Clear();

            string[] linhas = File.ReadAllLines(arquivo);

            foreach (string linha in linhas)
            {
                int separador = linha.IndexOf('|');

                if (separador >= 0)
                {
                    string data = linha.Substring(0, separador);
                    string texto = linha.Substring(separador + 1);

                    Registro registro = new Registro(data, texto);

                    _registros.Add(registro);
                }
            }

            Console.WriteLine("Diário carregado com sucesso!");
        }
        catch (IOException)
        {
            Console.WriteLine("Erro ao carregar o diário.");
        }
    }
}


using System;

public class Registro
{
    // Atributos privados
    private string _data;
    private string _texto;

    // Propriedades para acessar os dados
    public string Data
    {
        get { return _data; }
    }

    public string Texto
    {
        get { return _texto; }
    }

    // Construtor
    public Registro(string data, string texto)
    {
        _data = data;
        _texto = texto;
    }

    // Exibe o registro
    public void Exibir()
    {
        Console.WriteLine($"Data: {_data}");
        Console.WriteLine($"Registro: {_texto}");
        Console.WriteLine("--------------------------------");
    }
}

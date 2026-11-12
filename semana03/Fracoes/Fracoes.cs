
using System;

public class Fracao
{
    // Atributos privados
    private int _numerador;
    private int _denominador;

    // Construtor padrão: 1/1
    public Fracao()
    {
        _numerador = 1;
        _denominador = 1;
    }

    // Construtor com apenas o numerador
    public Fracao(int numerador)
    {
        _numerador = numerador;
        _denominador = 1;
    }

    // Construtor com numerador e denominador
    public Fracao(int numerador, int denominador)
    {
        _numerador = numerador;
        _denominador = denominador;
    }

    // Getter e Setter do numerador
    public int ObterNumerador()
    {
        return _numerador;
    }

    public void DefinirNumerador(int numerador)
    {
        _numerador = numerador;
    }

    // Getter e Setter do denominador
    public int ObterDenominador()
    {
        return _denominador;
    }

    public void DefinirDenominador(int denominador)
    {
        if (denominador == 0)
        {
            throw new ArgumentException("O denominador não pode ser zero.");
        }

        _denominador = denominador;
    }

    // Retorna a fração em formato de texto
    public string ObterFracaoEmTexto()
    {
        return $"{_numerador}/{_denominador}";
    }

    // Retorna a fração em formato decimal
    public double ObterFracaoEmDecimal()
    {
        return (double)_numerador / _denominador;
    }
}

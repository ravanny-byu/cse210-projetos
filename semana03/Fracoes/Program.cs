
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Testando os três construtores

        Fracao fracao1 = new Fracao();
        Fracao fracao2 = new Fracao(5);
        Fracao fracao3 = new Fracao(3, 4);
        Fracao fracao4 = new Fracao(1, 3);

        // Exibindo a primeira fração
        Console.WriteLine(fracao1.ObterFracaoEmTexto());
        Console.WriteLine(fracao1.ObterFracaoEmDecimal()
            .ToString(CultureInfo.InvariantCulture));

        // Exibindo a segunda fração
        Console.WriteLine(fracao2.ObterFracaoEmTexto());
        Console.WriteLine(fracao2.ObterFracaoEmDecimal()
            .ToString(CultureInfo.InvariantCulture));

        // Exibindo a terceira fração
        Console.WriteLine(fracao3.ObterFracaoEmTexto());
        Console.WriteLine(fracao3.ObterFracaoEmDecimal()
            .ToString(CultureInfo.InvariantCulture));

        // Exibindo a quarta fração
        Console.WriteLine(fracao4.ObterFracaoEmTexto());
        Console.WriteLine(fracao4.ObterFracaoEmDecimal()
            .ToString(CultureInfo.InvariantCulture));

        // Testando getters e setters
        Fracao fracao5 = new Fracao();

        fracao5.DefinirNumerador(6);
        fracao5.DefinirDenominador(8);

        Console.WriteLine("\nTeste dos Getters e Setters:");

        Console.WriteLine("Numerador: " +
            fracao5.ObterNumerador());

        Console.WriteLine("Denominador: " +
            fracao5.ObterDenominador());

        Console.WriteLine("Fração: " +
            fracao5.ObterFracaoEmTexto());

        Console.WriteLine("Decimal: " +
            fracao5.ObterFracaoEmDecimal()
            .ToString(CultureInfo.InvariantCulture));
    }
}

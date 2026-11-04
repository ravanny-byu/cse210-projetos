using System;

class Program
{
    static void Main(string[] args)
    {

// Criar uma lista para armazenar os números
List<int> numeros = new List<int>();

Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");

// Receber os números do usuário
int numero = -1;

while (numero != 0)
{
    Console.Write("Insira o número: ");
    numero = int.Parse(Console.ReadLine());

    if (numero != 0)
    {
        numeros.Add(numero);
    }
}

// Verificar se a lista possui números
if (numeros.Count > 0)
{
    // 1. Calcular a soma
    int soma = numeros.Sum();

    // 2. Calcular a média
    double media = (double)soma / numeros.Count;

    // 3. Encontrar o maior número
    int maiorNumero = numeros.Max();

    Console.WriteLine($"A soma é: {soma}");
    Console.WriteLine($"A média é: {media}");
    Console.WriteLine($"O maior número é: {maiorNumero}");

    // DESAFIO ADICIONAL 1
    // Encontrar o menor número positivo
    int? menorPositivo = null;

    foreach (int n in numeros)
    {
        if (n > 0)
        {
            if (menorPositivo == null || n < menorPositivo)
            {
                menorPositivo = n;
            }
        }
    }

    if (menorPositivo != null)
    {
        Console.WriteLine($"O menor número positivo é: {menorPositivo}");
    }
    else
    {
        Console.WriteLine("Não existe número positivo na lista.");
    }

    // DESAFIO ADICIONAL 2
    // Ordenar os números em ordem crescente
    numeros.Sort();

    Console.WriteLine("A lista reordenada é:");

    foreach (int n in numeros)
    {
        Console.WriteLine(n);
    }
}
else
{
    Console.WriteLine("Nenhum número foi inserido.");
}

    }
}
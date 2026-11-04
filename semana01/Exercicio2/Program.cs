using System;

class Program
{
    static void Main(string[] args)
    {
        
Console.Write("Digite sua nota numérica: ");
int nota = int.Parse(Console.ReadLine());

string letra;

// Determinar a nota conceitual
if (nota >= 90)
{
    letra = "A";
}
else if (nota >= 80)
{
    letra = "B";
}
else if (nota >= 70)
{
    letra = "C";
}
else if (nota >= 60)
{
    letra = "D";
}
else
{
    letra = "F";
}

// Exibir a nota conceitual
Console.WriteLine($"Sua nota é: {letra}");

// Verificar aprovação
if (nota >= 70)
{
    Console.WriteLine("Parabéns! Você foi aprovado no curso!");
}
else
{
    Console.WriteLine("Continue se esforçando! Na próxima vez você conseguirá.");
}

   // Determinar o sinal da nota (+ ou -)
int ultimoDigito = nota % 10;
string sinal = "";

if (nota >= 60 && nota < 100)
{
    if (ultimoDigito >= 7 && letra != "A")
    {
        sinal = "+";
    }
    else if (ultimoDigito < 3 && letra != "F")
    {
        sinal = "-";
    }
}

// Exibir a nota com o sinal
Console.WriteLine($"Sua nota com sinal é: {letra}{sinal}"); }
    
}

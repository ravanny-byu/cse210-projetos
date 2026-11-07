
using System;
using System.Collections.Generic;

public class GeradorDePerguntas
{
    // Lista de perguntas para o diário
    private List<string> _perguntas = new List<string>
    {
        "O que aconteceu de importante no seu dia?",
        "Pelo que você é grato hoje?",
        "Qual foi o maior desafio que você enfrentou hoje?",
        "O que você aprendeu de novo?",
        "Qual foi o momento mais feliz do seu dia?",
        "O que você gostaria de melhorar amanhã?",
        "Quem fez algo bom por você hoje?",
        "Qual é uma meta que deseja alcançar?"
    };

    // Gerador de números aleatórios
    private Random _random = new Random();

    // Retorna uma pergunta aleatória
    public string ObterPerguntaAleatoria()
    {
        int indice = _random.Next(_perguntas.Count);

        return _perguntas[indice];
    }
}

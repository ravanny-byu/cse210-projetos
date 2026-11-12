
using System;
using System.Collections.Generic;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();

        string[] partes = texto.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries
        );

        foreach (string parte in partes)
        {
            Palavra palavra = new Palavra(parte);
            _palavras.Add(palavra);
        }
    }

    public string ObterTexto()
    {
        List<string> textos = new List<string>();

        foreach (Palavra palavra in _palavras)
        {
            textos.Add(palavra.ObterTexto());
        }

        return $"{_referencia.ObterTexto()} {string.Join(" ", textos)}";
    }

    public void OcultarPalavrasAleatorias(int numeroParaOcultar)
    {
        List<Palavra> palavrasVisiveis = new List<Palavra>();

        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                palavrasVisiveis.Add(palavra);
            }
        }

        Random random = new Random();

        for (int i = 0;
             i < numeroParaOcultar && palavrasVisiveis.Count > 0;
             i++)
        {
            int indice = random.Next(palavrasVisiveis.Count);

            palavrasVisiveis[indice].Ocultar();

            palavrasVisiveis.RemoveAt(indice);
        }
    }

    public bool EstaCompletamenteOculta()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                return false;
            }
        }

        return true;
    }
}

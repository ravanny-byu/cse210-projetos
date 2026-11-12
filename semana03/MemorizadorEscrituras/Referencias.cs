
public class Referencia
{
    // Atributos privados
    private string _livro;
    private int _capitulo;
    private int _versiculo;
    private int _ultimoVersiculo;

    // Construtor para um único versículo
    public Referencia(string livro, int capitulo, int versiculo)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = versiculo;
        _ultimoVersiculo = versiculo;
    }

    // Construtor para um intervalo de versículos
    public Referencia(string livro, int capitulo, int versiculo, int ultimoVersiculo)
    {
        _livro = livro;
        _capitulo = capitulo;
        _versiculo = versiculo;
        _ultimoVersiculo = ultimoVersiculo;
    }

    // Retorna a referência em formato de texto
    public string ObterTexto()
    {
        if (_versiculo == _ultimoVersiculo)
        {
            return $"{_livro} {_capitulo}:{_versiculo}";
        }
        else
        {
            return $"{_livro} {_capitulo}:{_versiculo}-{_ultimoVersiculo}";
        }
    }
}

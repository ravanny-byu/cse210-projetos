
public class Palavra
{
    // Atributos privados
    private string _texto;
    private bool _estaOculta;

    // Construtor
    public Palavra(string texto)
    {
        _texto = texto;
        _estaOculta = false;
    }

    // Oculta a palavra
    public void Ocultar()
    {
        _estaOculta = true;
    }

    // Exibe a palavra novamente
    public void Exibir()
    {
        _estaOculta = false;
    }

    // Verifica se a palavra está oculta
    public bool EstaOculta()
    {
        return _estaOculta;
    }

    // Retorna a palavra ou os sublinhados
    public string ObterTexto()
    {
        if (_estaOculta)
        {
            return new string('_', _texto.Length);
        }

        return _texto;
    }
}

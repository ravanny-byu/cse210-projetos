using System;

namespace VideosYouTube
{
    public class Comentario
    {
        private string _nomeAutor;
        private string _textoComentario;

        public Comentario(string nomeAutor, string textoComentario)
        {
            _nomeAutor = nomeAutor;
            _textoComentario = textoComentario;
        }

        public void Exibir()
        {
            Console.WriteLine($"   - {_nomeAutor}: \"{_textoComentario}\"");
        }
    }
}
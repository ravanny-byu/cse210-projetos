using System;
using System.Collections.Generic;

namespace VideosYouTube
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> listaVideos = new List<Video>();

            Video primeiroVideo = new Video("Review Completo: Cafeteira Espresso Pro X", "Café & Rotina", 740);
            Comentario comentario1A = new Comentario("Lucas Almeida", "Ótima análise, a pressão da extração faz diferença.");
            Comentario comentario1B = new Comentario("Marina Costa", "Comprei esse modelo após o review e estou adorando.");
            Comentario comentario1C = new Comentario("Rafael Mendes", "Como fica a limpeza diária do vaporizador?");
            primeiroVideo.AdicionarComentario(comentario1A);
            primeiroVideo.AdicionarComentario(comentario1B);
            primeiroVideo.AdicionarComentario(comentario1C);
            listaVideos.Add(primeiroVideo);

            Video segundoVideo = new Video("Testando Tênis de Corrida AeroRun 2026 em 21 km", "Passo Certo", 915);
            Comentario comentario2A = new Comentario("Beatriz Rocha", "O amortecimento segura bem nas provas longas?");
            Comentario comentario2B = new Comentario("Thiago Nunes", "Muito bom o teste real de rua, sem enrolação.");
            Comentario comentario2C = new Comentario("Camila Ferreira", "Peguei meio número maior e ficou perfeito no pé.");
            Comentario comentario2D = new Comentario("Diego Santos", "Vocês testaram na chuva também?");
            segundoVideo.AdicionarComentario(comentario2A);
            segundoVideo.AdicionarComentario(comentario2B);
            segundoVideo.AdicionarComentario(comentario2C);
            segundoVideo.AdicionarComentario(comentario2D);
            listaVideos.Add(segundoVideo);

            Video terceiroVideo = new Video("Setup de Mesa Minimalista: Fone PulseWave ANC", "Tech em Foco", 580);
            Comentario comentario3A = new Comentario("Fernanda Lima", "O cancelamento de ruído ajuda muito no home office.");
            Comentario comentario3B = new Comentario("Gustavo Oliveira", "Qual a autonomia real com o ANC ligado?");
            Comentario comentario3C = new Comentario("Patrícia Souza", "Visual bem limpo e confortável para longas horas.");
            terceiroVideo.AdicionarComentario(comentario3A);
            terceiroVideo.AdicionarComentario(comentario3B);
            terceiroVideo.AdicionarComentario(comentario3C);
            listaVideos.Add(terceiroVideo);

            foreach (Video videoAtual in listaVideos)
            {
                videoAtual.ExibirDetalhes();
            }

            Console.WriteLine("--------------------------------------------------");
        }
    }
}
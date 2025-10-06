using System;

namespace MyApp
{
    internal class Program
    {
        public class Livro
        {
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public int AnoPublicacao { get; set; }

            public Livro(string titulo, string autor, int anoPublicacao)
            {
                Titulo = titulo;
                Autor = autor;
                AnoPublicacao = anoPublicacao;
            }


            public void ExibirDetalhes()
            {
                Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Ano de Publicação: {AnoPublicacao}");
            }
        }


        static void Main(string[] args)
        {
            Livro livro = new Livro("Diario de um bana", "Jeff Kinney", 2007);
            livro.ExibirDetalhes();
        }
    }
}

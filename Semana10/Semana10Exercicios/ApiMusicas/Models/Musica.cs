using System.ComponentModel.DataAnnotations;

namespace ApiMusicas.Models
{
    public class Musica
    {
        public int Id { get; internal set; }
       [Required(ErrorMessage = "O nome do artista é obrigatório.")]
        public string Nome { get; set; }
        public TimeSpan Duracao { get; set; }
        public Album Album { get; set; }
        public Artista Artista { get; set; }

        public Musica(string nome, TimeSpan duracao, Artista artista)
        {
            Nome = nome;
            Duracao = duracao;
            Artista = artista;
        }
    }


}

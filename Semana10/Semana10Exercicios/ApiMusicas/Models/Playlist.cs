using System.ComponentModel.DataAnnotations;

namespace ApiMusicas.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome da Playlist obrigatório.")]
        public string Nome { get; set; }
        public List<Musica> Musicas { get; set; }


        public Playlist()
        {
           
        }
        public Playlist(string nome)
        {
            Nome = nome;
        }
        public void AdicionarMusicas(Musica musica)
        {
            Musicas = new List<Musica>();

            Musicas.Add(musica);
        }
    }

}

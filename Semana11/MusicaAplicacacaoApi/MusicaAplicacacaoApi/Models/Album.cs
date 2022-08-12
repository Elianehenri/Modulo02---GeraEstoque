namespace MusicaAplicacacaoApi.Models
{
    public class Album
    {
        public int Id { get; internal set; }
        public string Nome { get; set; }
        public int AnoLancamento { get; set; }
        public int ArtistaId { get; set; }
        public Artista Artista { get; set; }
        public List<Musica>Musicas { get; set; }

      
    }
}

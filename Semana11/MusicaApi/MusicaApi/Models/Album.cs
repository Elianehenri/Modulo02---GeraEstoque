namespace MusicaApi.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int AnoLancamento { get; set; }
        public string CapaUrl { get; set; }


        //mapear
        public virtual int ArtistaId { get; set; }//chave estrangeira
        public virtual Artista Artista { get; set; }//relacionamento entre artista e o album
        public virtual List<Musica> Musicas { get; set; }
    }
}

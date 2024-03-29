﻿namespace MusicaApi.Models
{
    public class Artista
    {
        public int Id { get; internal set; }

        public string Nome { get; set; }
        public string NomeArtistico { get; set; }
        public string? FotoUrl { get; set; }

        public virtual List<Musica> Musicas { get; set; }
        public virtual List<Album> Albuns { get; set; }

       
    }
}

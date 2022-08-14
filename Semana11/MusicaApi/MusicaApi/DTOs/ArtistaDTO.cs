using System.ComponentModel.DataAnnotations;

namespace MusicaApi.DTOs
{
    public class ArtistaDTOs
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }
        public string NomeArtistico { get; set; }
        public string FotoUrl { get; set; }
    }
}

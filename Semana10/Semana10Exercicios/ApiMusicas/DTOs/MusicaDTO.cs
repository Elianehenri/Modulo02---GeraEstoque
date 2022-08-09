using System.ComponentModel.DataAnnotations;

namespace ApiMusicas.DTOs
{
    public class MusicaDTO
    {
        [Required(ErrorMessage = "O nome da Musica é obrigatório.")]
        [StringLength(40)]
        public string Nome { get; set; }
        //public TimeSpan Duracao { get; set; }
        public double Duracao { get; set; }
        public int IdArtista { get; set; }
        public int IdAlbum { get; set; }
    }
}

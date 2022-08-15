using System.ComponentModel.DataAnnotations;

namespace MusicaApi.DTOs
{
    public class PlaylistDTO
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }
    }
}

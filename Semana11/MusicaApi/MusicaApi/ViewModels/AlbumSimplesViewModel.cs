using MusicaApi.Models;

namespace MusicaApi.ViewModels
{
    public class AlbumSimplesViewModel
    {
        public AlbumSimplesViewModel(Album album)
        {
            Id = album.Id;
            Nome = album.Nome;
            AnoLancamento = album.AnoLancamento;
            CapaUrl = album.CapaUrl;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int AnoLancamento { get; set; }
        public string CapaUrl { get; set; }
    }
}

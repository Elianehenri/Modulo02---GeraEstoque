using MusicaApi.Models;

namespace MusicaApi.ViewModels
{
    public class PlaylistViewModel
    {
        public PlaylistViewModel(Playlist playlist)
        {
            Id = playlist.Id;
            Nome = playlist.Nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
    }
}

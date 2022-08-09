using ApiMusicas.DTOs;
using ApiMusicas.Models;
using ApiMusicas.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiMusicas.Controllers
{
    [ApiController]
    [Route("api/aplalist")]
    public class PlaylistsController : ControllerBase

    {
        private readonly PlaylistRepositorio _playlistRepositorio;
        private readonly MusicaRepositorio _musicasRepositorio;

        public PlaylistsController(PlaylistRepositorio playlistRepositorio, MusicaRepositorio musicasRepositorio)
        {
            _playlistRepositorio = playlistRepositorio;
            _musicasRepositorio = musicasRepositorio;
        }

        [HttpGet]
        public ActionResult<Playlist> Get()
        {

            return Ok(_playlistRepositorio.ObterTodasPlaylist());
        }

        [HttpPost]
        public ActionResult<Playlist> Post(
            [FromBody] PlayListDTO novaLista)
        {
            var playlist = new Playlist(
                novaLista.Nome);
            _playlistRepositorio.AdicionarPlaylist(playlist);

            return Ok(playlist);
        }

        //PUT
        [HttpPut("{idPlaylist}")]
        public ActionResult<Playlist> Put(
         [FromRoute] Musica body,
         [FromRoute] int MusicaId
     )
        {
            var playlista = _playlistRepositorio.ObterPorId(MusicaId);

            playlista.Nome = body.Nome;

            //_playlistRepositorio.AdicionarMusicaNaPlaylist(playlista);

            return Ok(playlista);
        }

        //DELETE
        [HttpDelete("{idPlaylist}")]
        public ActionResult Delete(int idPlaylist)
        {
            _playlistRepositorio.RemoverPlaylist(idPlaylist);

            return NoContent();
        }

    }

}



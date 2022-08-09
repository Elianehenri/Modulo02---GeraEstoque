using ApiMusicas.DTOs;
using ApiMusicas.Models;
using ApiMusicas.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiMusicas.Controllers
{
    [ApiController]
    [Route("api/musicas")]
    public class MusicasController : ControllerBase
    {

        private readonly MusicaRepositorio _musicasRepositorio;
        private readonly ArtistaRepositorio _artistaRepositorio;
        private readonly AlbumRepositorio _albumRepositorio;


        public MusicasController(
            MusicaRepositorio musicaRepositorio,
            ArtistaRepositorio artistaRepositorio,
            AlbumRepositorio albumRepositorio
            )
        {

            _musicasRepositorio = musicaRepositorio;
            _artistaRepositorio = artistaRepositorio;
            _albumRepositorio = albumRepositorio;

        }
        
        [HttpGet()]
        public ActionResult<Musica> Get(
            [FromQuery] string nomeMusica)
        {
            return Ok(_musicasRepositorio.ObterTodos(nomeMusica));

        }

        [HttpGet("{idMusicas}/musicas")]
        public ActionResult<Musica> GetMusicasPorIdAlbum(
            [FromRoute] int idMusicas
        )
        {
            return Ok(_musicasRepositorio.ObterPorAlbum(idMusicas));
        }

        [HttpGet("{idArtista}/artistas")]
        public ActionResult<Musica> GetObterPorArtista(
            [FromQuery] int idArtista)
        {

            return Ok(_musicasRepositorio.ObterPorArtista( idArtista));

        }
        // POST
        //[HttpPost]
        //public ActionResult<Musica> Post(
        //    [FromBody] Musica novaMusica)
        //{

        //    var musica = new Musica(
        //        novaMusica.Nome,
        //        novaMusica.Duracao,
        //        novaMusica.Artista);

        //    _musicasRepositorio.Criar(musica);

        //    return Ok(musica);
        //}

        [HttpPost]
        public ActionResult<Musica> Post(
        [FromBody] MusicaDTO musicaDTO
    )
        {
            var artista = _artistaRepositorio.ObterPorId(musicaDTO.IdArtista);
            var album = _albumRepositorio.ObterPorId(musicaDTO.IdAlbum);
            var musicaNova = new Musica(
                musicaDTO.Nome,
                musicaDTO.Duracao,
                artista
            );
            musicaNova.Album = album;
            _musicasRepositorio.Criar(musicaNova);
            return Ok(musicaNova);

        }




        //PUT
        [HttpPut("{idMusicas}")]
        public ActionResult<Musica> Put(
         [FromRoute] Musica body,
         [FromRoute] int MusicaId
     )
        {
            var musica = _musicasRepositorio.ObterPorId(MusicaId);

            musica.Nome = body.Nome;
            musica.Duracao = body.Duracao;
            musica.Artista = body.Artista;

            _musicasRepositorio.EditarMusica(MusicaId, musica);

            return Ok(musica);
        }
       //DELETE
        [HttpDelete("{idMusicas}")]
        public ActionResult Delete(int idMusicas)
        {
            _musicasRepositorio.Remover(idMusicas);

            return NoContent();
        }

    }
}

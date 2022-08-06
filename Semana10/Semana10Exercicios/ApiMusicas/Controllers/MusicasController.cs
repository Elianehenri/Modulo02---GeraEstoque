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
        private readonly AlbumRepositorio _albumRepositorio;
       


        public MusicasController(MusicaRepositorio musicaRepositorio)
        {

            _musicasRepositorio = musicaRepositorio;

        }
        [HttpGet]
        public ActionResult<Musica> Get()
        {
            return Ok(_musicasRepositorio.ObterTodos());
        }
        [HttpGet("{idMusicas}/musicas")]
        public ActionResult<Musica> GetMusicasPorIdAlbum(
            [FromRoute] int idMusicas
        )
        {
            return Ok(_musicasRepositorio.ObterPorAlbum(idMusicas));
        }

        //POST
        [HttpPost]
        public ActionResult<Album> Post(
           [FromBody] Musica novaMusica
       )
        {
            var musica = new Musica(
               novaMusica.Nome,
               novaMusica.Duracao,
               novaMusica.Artista);


            _musicasRepositorio.Criar(musica);

            return Ok(musica);
        }

        //PUT
        [HttpPut("{idMusicas}")]
        public ActionResult<Musica> Put(
         [FromRoute] Musica body,
         [FromRoute] int idMusicas
     )
        {
            var musica = _musicasRepositorio.ObterPorId(idMusicas);

            musica.Nome = body.Nome;
            musica.Duracao = body.Duracao;
            musica.Artista = body.Artista;


            return Ok(musica);
        }
        //DELETE
        [HttpDelete("{idMusicas}")]
        public ActionResult Delete(int idMusicas)
        {
            _albumRepositorio.Remover(idMusicas);

            return NoContent();
        }

    }
}

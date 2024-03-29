﻿using ApiMusicas.DTOs;
using ApiMusicas.Models;
using ApiMusicas.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiMusicas.Controllers
{
    [ApiController]
    [Route("api/albuns")]
    public class AlbunsController : ControllerBase
    {
        private readonly AlbumRepositorio _albumRepositorio;
        private readonly ArtistaRepositorio _artistaRepositorio;
        private readonly MusicaRepositorio _musicasRepositorio;


        public AlbunsController(
        AlbumRepositorio albumRepositorio,
        ArtistaRepositorio artistaRepositorio,
        MusicaRepositorio musicaRepositorio)
        {
            _albumRepositorio = albumRepositorio;
            _artistaRepositorio = artistaRepositorio;
            _musicasRepositorio = musicaRepositorio;
        }

        [HttpGet]
        public ActionResult<Album> Get()
        {
            return Ok(_albumRepositorio.ObterTodos());
        }

        [HttpGet("{idAlbum}/musicas")]
        public ActionResult<Musica> GetMusicasPorIdAlbum(
            [FromRoute] int idAlbum
        )
        {
            return Ok(_musicasRepositorio.ObterPorAlbum(idAlbum));
        }

        [HttpPost]
        public ActionResult<Album> Post(
            [FromBody] AlbumDTO albumJson
        )
        {
            var artista = _artistaRepositorio.ObterPorId(albumJson.ArtistaId);

            var album = new Album(
                albumJson.Nome,
                albumJson.AnoLancamento,
                albumJson.CapaUrl,
                artista
            );

            _albumRepositorio.Criar(album);

            return Ok(album);
        }

        [HttpPut("{idAlbum}")]
        public ActionResult<Album> Put(
            [FromBody] AlbumDTO albumJson,
            [FromRoute] int idAlbum
        )
        {
            var artista = _artistaRepositorio.ObterPorId(albumJson.ArtistaId);

            var album = _albumRepositorio.Atualizar(
                idAlbum,
                new Album(
                    albumJson.Nome,
                    albumJson.AnoLancamento,
                    albumJson.CapaUrl,
                    artista
                )
            );

            return Ok(album);
        }

        [HttpDelete("{idAlbum}")]
        public ActionResult Delete(
            int idAlbum
        )
        {
            _albumRepositorio.Remover(idAlbum);

            return NoContent();
        }
    }
}

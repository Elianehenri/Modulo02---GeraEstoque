﻿using Microsoft.AspNetCore.Mvc;
using MusicaApi.Data;
using MusicaApi.Models;
using MusicaApi.ViewModels;
using Microsoft.EntityFrameworkCore;
using MusicaApi.DTOs;

namespace MusicaApi.Controllers
{
    [ApiController]
    [Route("api/albuns")]
    public class AlbunsController : ControllerBase
    {
        private readonly MusicDbContext _context;

        public AlbunsController(MusicDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<AlbumArtistaViewModel>> Get()
        {
            return Ok(
                _context.Albuns
                .Include(a => a.Artista)
                .Select(a => new AlbumArtistaViewModel(a))
                .ToList()
            );
        }

        [HttpGet("{id}")]
        public ActionResult<AlbumCompletoViewModel> GetPorId(
            [FromRoute] int id
        )
        {
            var album = _context.Albuns
                .Include(a => a.Artista)
                .Include(a => a.Musicas)
                .Where(a => a.Id == id)
                .Select(a => new AlbumCompletoViewModel(a))
                .FirstOrDefault();

            if (album == null) return NotFound();

            return Ok(album);
        }

        [HttpPost]
        public ActionResult<AlbumCompletoViewModel> Post(
            [FromBody] CricaoAlbumDTO albumDTO
        )
        {
            if (_context.Albuns.Any(a => a.ArtistaId == albumDTO.ArtistaId && a.Nome == albumDTO.Nome))
            {
                return BadRequest(new RetornoComFalhaViewModel("Album já cadastrado."));
            }

            var artista = _context.Artistas.Find(albumDTO.ArtistaId);

            if (artista == null) return NotFound(new RetornoComFalhaViewModel("Artista não encontrado."));

            var album = new Album
            {
                Nome = albumDTO.Nome,
                AnoLancamento = albumDTO.AnoLancamento,
                CapaUrl = albumDTO.CapaUrl,
                ArtistaId = artista.Id,
                Musicas = albumDTO.Musicas?.Select(m => new Musica
                {
                    ArtistaId = artista.Id,
                    Nome = m.Nome,
                    Duracao = m.Duracao
                }).ToList()
            };

            _context.Albuns.Add(album);

            _context.SaveChanges();

            album.Artista = artista;

            return Created("api/albuns", new AlbumCompletoViewModel(album));
        }

        [HttpPut("{id}")]
        public ActionResult<AlbumCompletoViewModel> Put(
            [FromRoute] int id,
            [FromBody] EdicaoAlbumDTO edicaoAlbumDTO
        )
        {
            var album = _context.Albuns
                .Include(a => a.Artista)
                .Include(a => a.Musicas)
                .FirstOrDefault(a => a.Id == id);

            if (album == null)
                return NotFound(new RetornoComFalhaViewModel("Album não encontrado."));

            album.Nome = edicaoAlbumDTO.Nome;
            album.CapaUrl = edicaoAlbumDTO.CapaUrl;
            album.AnoLancamento = edicaoAlbumDTO.AnoLancamento;

            _context.SaveChanges();

            return Ok(new AlbumCompletoViewModel(album));
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(
            [FromRoute] int id
        )
        {
            var album = _context.Albuns
                .Include(a => a.Musicas)
                .FirstOrDefault(a => a.Id == id);

            if (album == null)
                return NotFound(new RetornoComFalhaViewModel("Album não encontrado."));

            if (album.Musicas != null && album.Musicas.Any())
            {
                _context.Musicas.RemoveRange(album.Musicas);
            }
            _context.Albuns.Remove(album);
            _context.SaveChanges();

            // 204
            return NoContent();
        }
    }
}
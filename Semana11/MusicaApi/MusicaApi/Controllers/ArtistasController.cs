using Microsoft.AspNetCore.Mvc;
using MusicaApi.Data;
using MusicaApi.DTOs;
using MusicaApi.Models;
using MusicaApi.ViewModels;

namespace MusicaApi.Controllers;
[ApiController]
[Route("api/artistas")]
public class ArtistasController : ControllerBase
{
    private readonly MusicDbContext _context;

    public ArtistasController(MusicDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<List<Artista>> Get()
    {
        return Ok(_context.Artistas.ToList());
    }

    [HttpGet("{id}")]
    public ActionResult<Artista> GetPorId(
        [FromRoute] int id
    )
    {
        var artista = _context.Artistas.Find(id);

        if (artista == null) return NotFound();

        return Ok(artista);
    }

    [HttpPost]
    public ActionResult<Artista> Post(
        [FromBody] ArtistaDTOs artistaDTO
    )
    {
        if (_context.Artistas.Any(a => a.Nome == artistaDTO.Nome))
        {
            return BadRequest(new RetornoComFalhaViewModel("Já existe um artista com esse nome"));
        }

        var artista = new Artista
        {
            Nome = artistaDTO.Nome,
            NomeArtistico = artistaDTO.NomeArtistico,
            FotoUrl = artistaDTO.FotoUrl
        };

        _context.Artistas.Add(artista);

        _context.SaveChanges();

        return Created("api/artistas", artista);
    }

    [HttpPut("{id}")]
    public ActionResult<Artista> Put(
        [FromRoute] int id,
        [FromBody] ArtistaDTOs artistaDTO
    )
    {
        var artista = _context.Artistas.Find(id);

        if (artista == null)
            return NotFound(new RetornoComFalhaViewModel("Artista não encontrado."));

        artista.Nome = artistaDTO.Nome;
        artista.NomeArtistico = artistaDTO.NomeArtistico;
        artista.FotoUrl = artistaDTO.FotoUrl;

        _context.SaveChanges();

        return Ok(artista);
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(
        [FromRoute] int id
    )
    {
        var artista = _context.Artistas.Find(id);

        if (artista == null)
            return NotFound(new RetornoComFalhaViewModel("Artista não encontrado."));

        _context.Artistas.Remove(artista);
        _context.SaveChanges();

        // 204
        return NoContent();
    }


}


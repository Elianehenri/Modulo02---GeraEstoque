using Microsoft.EntityFrameworkCore;
using MusicaApi.Models;

namespace MusicaApi.Data;

    public class MusicDbContext : DbContext
    {
    private readonly IConfiguration _configuration;

    public MusicDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public DbSet<Artista> Artistas { get; set; }
    public DbSet<Album> Albuns { get; set; }
    public DbSet<Musica> Musicas { get; set; }
    public DbSet<Playlist> Playlists { get; set; }
    public DbSet<PlaylistMusica> PlaylistMusicas { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer(
            _configuration.GetConnectionString("ConexaoBanco")
        );
    }

    //subescrever 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);//construir nossos mapeamento

        //Artista
        modelBuilder.Entity<Artista>(entidade =>
        {
            entidade.ToTable("Artistas");

            entidade.HasKey(a => a.Id);

            entidade
                .Property(a => a.Nome)
                .HasMaxLength(150)
                .IsRequired();

            entidade
                .Property(a => a.NomeArtistico)
                .HasMaxLength(150);

            entidade
                .Property(a => a.FotoUrl)
                .HasMaxLength(80);

            entidade
           .HasData(new[]{
                new Artista {
                    Id = 1,
                    Nome = "Aline Barros",
                    NomeArtistico = "Aline Barros",
                    FotoUrl = null
                },
                new Artista {
                    Id = 2,
                    Nome = "Fernanda Brun",
                    NomeArtistico = "Fernanda Brun",
                    FotoUrl = null
                }
           });

        });

        //Album
        modelBuilder.Entity<Album>(entidade =>
        {
            entidade.ToTable("Albuns");

            entidade.HasKey(a => a.Id);

            entidade
                .Property(a => a.Nome)
                .HasMaxLength(150)
                .IsRequired();

            entidade
                .Property(a => a.AnoLancamento)
                .IsRequired();

            entidade
                .Property(a => a.CapaUrl)
                .HasMaxLength(80);

            //mapear relacionamento do album com o artista 1:N

            entidade
                .HasOne(album => album.Artista)
                .WithMany(artista => artista.Albuns)
                .HasForeignKey(album => album.ArtistaId);
        });

        //Musica
        modelBuilder.Entity<Musica>(entidade =>
        {
            entidade.ToTable("Musicas");

            entidade.HasKey(m => m.Id);

            entidade
                .Property(m => m.Nome)
                .HasMaxLength(150)
                .IsRequired();

            entidade
                .Property(m => m.Duracao);


            //mapear relacionamente entre musica e album
            entidade
                .HasOne(m => m.Album)
                .WithMany(a => a.Musicas)
                .HasForeignKey(m => m.AlbumId);

            entidade
               .HasOne(m => m.Artista)
               .WithMany(a => a.Musicas)
               .HasForeignKey(m => m.ArtistaId);


        });

        modelBuilder.Entity<Playlist>(entidade =>
        {
            entidade.ToTable("Playlists");

            entidade.HasKey(p => p.Id);

            entidade
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<PlaylistMusica>(entidade =>
        {
            entidade.ToTable("PlaylistMusicas");

            entidade.HasKey(p => new { p.PlaylistId, p.MusicaId });

            entidade
                .HasOne(pm => pm.Playlist)
                .WithMany(p => p.Musicas)
                .HasForeignKey(pm => pm.PlaylistId);

            entidade
                .HasOne(pm => pm.Musica)
                .WithMany()
                .HasForeignKey(pm => pm.MusicaId);
        });
    }
}
    

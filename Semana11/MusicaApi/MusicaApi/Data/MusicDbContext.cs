﻿using Microsoft.EntityFrameworkCore;
using MusicaApi.Models;

namespace MusicaApi.Data
{
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(
                _configuration.GetConnectionString("ConexaoBanco")
            );
        }
    }

}
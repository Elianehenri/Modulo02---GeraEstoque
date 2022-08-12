using Microsoft.EntityFrameworkCore;
using MusicaAplicacacaoApi.Models;

namespace MusicaAplicacacaoApi.Data
{
    public class MusicDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public MusicDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(
                _configuration.GetConnectionString("ConexaoBanco")
            );
        }
    }
}

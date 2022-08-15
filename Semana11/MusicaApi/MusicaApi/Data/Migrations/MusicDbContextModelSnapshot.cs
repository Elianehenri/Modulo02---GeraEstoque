﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicaApi.Data;

#nullable disable

namespace MusicaApi.Data.Migrations
{
    [DbContext(typeof(MusicDbContext))]
    partial class MusicDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MusicaApi.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AnoLancamento")
                        .HasColumnType("int");

                    b.Property<int>("ArtistaId")
                        .HasColumnType("int");

                    b.Property<string>("CapaUrl")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("ArtistaId");

                    b.ToTable("Albuns", (string)null);
                });

            modelBuilder.Entity("MusicaApi.Models.Artista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FotoUrl")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("NomeArtistico")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Artistas", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Aline Barros",
                            NomeArtistico = "Aline Barros"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Fernanda Brun",
                            NomeArtistico = "Fernanda Brun"
                        });
                });

            modelBuilder.Entity("MusicaApi.Models.Musica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AlbumId")
                        .HasColumnType("int");

                    b.Property<int>("ArtistaId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Duracao")
                        .HasColumnType("time");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.HasIndex("ArtistaId");

                    b.ToTable("Musicas", (string)null);
                });

            modelBuilder.Entity("MusicaApi.Models.Playlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Playlists", (string)null);
                });

            modelBuilder.Entity("MusicaApi.Models.PlaylistMusica", b =>
                {
                    b.Property<int>("PlaylistId")
                        .HasColumnType("int");

                    b.Property<int>("MusicaId")
                        .HasColumnType("int");

                    b.HasKey("PlaylistId", "MusicaId");

                    b.HasIndex("MusicaId");

                    b.ToTable("PlaylistMusicas", (string)null);
                });

            modelBuilder.Entity("MusicaApi.Models.Album", b =>
                {
                    b.HasOne("MusicaApi.Models.Artista", "Artista")
                        .WithMany("Albuns")
                        .HasForeignKey("ArtistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artista");
                });

            modelBuilder.Entity("MusicaApi.Models.Musica", b =>
                {
                    b.HasOne("MusicaApi.Models.Album", "Album")
                        .WithMany("Musicas")
                        .HasForeignKey("AlbumId");

                    b.HasOne("MusicaApi.Models.Artista", "Artista")
                        .WithMany("Musicas")
                        .HasForeignKey("ArtistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Artista");
                });

            modelBuilder.Entity("MusicaApi.Models.PlaylistMusica", b =>
                {
                    b.HasOne("MusicaApi.Models.Musica", "Musica")
                        .WithMany()
                        .HasForeignKey("MusicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicaApi.Models.Playlist", "Playlist")
                        .WithMany("Musicas")
                        .HasForeignKey("PlaylistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musica");

                    b.Navigation("Playlist");
                });

            modelBuilder.Entity("MusicaApi.Models.Album", b =>
                {
                    b.Navigation("Musicas");
                });

            modelBuilder.Entity("MusicaApi.Models.Artista", b =>
                {
                    b.Navigation("Albuns");

                    b.Navigation("Musicas");
                });

            modelBuilder.Entity("MusicaApi.Models.Playlist", b =>
                {
                    b.Navigation("Musicas");
                });
#pragma warning restore 612, 618
        }
    }
}

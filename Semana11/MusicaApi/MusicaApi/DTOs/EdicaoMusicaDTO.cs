﻿using System.ComponentModel.DataAnnotations;

namespace MusicaApi.DTOs
{
    public class EdicaoMusicaDTO
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }
        public TimeSpan Duracao { get; set; }
    }
}

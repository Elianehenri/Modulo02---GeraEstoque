using System;
using System.Collections.Generic;

namespace exercicio10Scaf
{
    public partial class Pessoa
    {
        public Pessoa()
        {
            Pets = new HashSet<Pet>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Email { get; set; }
        public string? Telefone { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }
    }
}

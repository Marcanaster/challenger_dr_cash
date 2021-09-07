using System;

namespace DrCash.Domain.Dtos.Livro
{
    public class LivroCreateDto
    {
        public string Nome { get; set; }
        public Guid GeneroId { get; set; }
        public int QuantidadeCopias { get; set; }
    }
}

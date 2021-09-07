using DrCash.Domain.Entities.Base;
using System;
using System.Collections.Generic;

namespace DrCash.Domain.Entities
{
    public class LivroEntity : BaseEntity
    {
        public string Nome { get;  set; }
        public Guid GeneroId { get; set; }
        public virtual GeneroEntity Genero { get; set; }
        public int QuantidadeCopias { get; set; }
        public virtual ICollection<AutorLivroEntity> AutoresLivros { get; set; }
    }
}

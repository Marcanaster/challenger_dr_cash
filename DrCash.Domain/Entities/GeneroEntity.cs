using DrCash.Domain.Entities.Base;
using System.Collections.Generic;

namespace DrCash.Domain.Entities
{
    public class GeneroEntity : BaseEntity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<LivroEntity> Livros { get;  set; }
    }
}

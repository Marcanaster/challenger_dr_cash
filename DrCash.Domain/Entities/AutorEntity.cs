using DrCash.Domain.Entities.Base;
using DrCash.Domain.Entities.ValueObjects;
using System.Collections.Generic;

namespace DrCash.Domain.Entities
{
    public class AutorEntity : BaseEntity
    {
        public Nome Nome { get; set; }
        public virtual ICollection<AutorLivroEntity> AutoresLivros { get; set; }
    }
}

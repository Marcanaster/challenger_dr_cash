using System;

namespace DrCash.Domain.Entities
{
    public class AutorLivroEntity
    {
        public Guid AutorId { get;  set; }
        public Guid LivroId { get;  set; }
        public virtual AutorEntity Autor { get;  set; }
        public virtual LivroEntity Livro { get;  set; }
    }
}

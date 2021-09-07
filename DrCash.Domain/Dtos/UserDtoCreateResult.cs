using DrCash.Domain.Entities.ValueObjects;
using System;

namespace DrCash.Domain.Dtos
{
    public class UserDtoCreateResult
    {
        public Guid Id { get; set; }
        public Nome Nome { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public DateTime CreatAt { get; set; }
    }
}

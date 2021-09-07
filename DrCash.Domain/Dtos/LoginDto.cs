using System.ComponentModel.DataAnnotations;

namespace DrCash.Domain.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Login é um campo obrigatório para acessar!")]
        public string Login { get; set; }
        public string password { get; set; }
    }
}

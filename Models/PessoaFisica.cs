using System.ComponentModel.DataAnnotations;

namespace AppBarganhaWEB.Models
{
    public class PessoaFisica : Usuario
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
    }
}

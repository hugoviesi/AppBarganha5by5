using System.ComponentModel.DataAnnotations;

namespace AppBarganhaWEB.Models

{
    public class PessoaJuridica : Usuario
    {
        [Required]
        public string RazaoSocial { get; set; }

        public string NomeFantasia { get; set; }
        [Required]
        public string Cnpj { get; set; }

        //public string Documentos { get; seSt; } ou foto?
    }
}

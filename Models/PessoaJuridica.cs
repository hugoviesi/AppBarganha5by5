using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppBarganhaWEB.Models

{
    public class PessoaJuridica : Usuario
    {
        [Required]
        public string RazaoSocial { get; set; }

        public string NomeFantasia { get; set; }
        
        [Required]
        public string Cnpj { get; set; }

        public string FotoDocumento { get; set; }

        [NotMapped]
        public IFormFile ArquivoDocumento { get; set; }
    }
}

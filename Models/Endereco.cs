using System.ComponentModel.DataAnnotations;

namespace AppBarganhaWEB.Models

{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        [Required]
        public string Cep { get; set; }

    }
}
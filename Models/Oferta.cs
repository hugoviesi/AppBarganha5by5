using System;

namespace AppBarganhaWEB.Models
{
    public class Oferta
    {
        public string IdUsuarioOfertante { get; set; }
        public string IdAnuncio { get; set; }
        public DateTime DataOferta { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }

    }
}

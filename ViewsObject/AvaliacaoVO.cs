using AppBarganhaWEB.Models;

namespace AppBarganhaWEB.ViewsObject
{
    public class AvaliacaoVO
    {
        public Anuncio Anuncio { get; set; }
        public Oferta Oferta { get; set; }
        public Usuario Usuario { get; set; }
        public string Modo { get; set; }
    }
}

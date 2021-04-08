using AppBarganhaWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBarganhaWEB.ViewsObject
{
    public class OfertasPorAnuncioVO
    {
        public List<Oferta> Ofertas { get; set; }
        public Anuncio Anuncio { get; set; }
    }
}

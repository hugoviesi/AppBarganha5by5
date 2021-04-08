using AppBarganhaWEB.Models;
using System.Collections.Generic;

namespace AppBarganhaWEB.ViewsObject
{
    public class HomeVO
    {
        public UsuarioLogado UsuarioLogado { get; set; }

        public List<Anuncio> Anuncios { get; set; }

    }
}

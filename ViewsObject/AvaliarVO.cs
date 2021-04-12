using AppBarganhaWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBarganhaWEB.ViewsObject
{
    public class AvaliarVO
    {
        public string Modo { get; set; }
        public Oferta Oferta { get; set; }
        public Usuario Usuario { get; set; }
        public string Pontos { get; set; }
    }
}

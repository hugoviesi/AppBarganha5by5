using System;

namespace AppBarganhaWEB.Models
{
    public class UsuarioLogado
    {
        public string Nome { get; set; }
        public TipoUsuario Tipo { get; set; }
        public string Id { get; set; }
        public Int64 key { get; set; }
        public DateTime dtConnection { get; set; }
    }
}

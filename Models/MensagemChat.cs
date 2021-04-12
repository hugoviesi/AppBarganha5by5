using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBarganhaWEB.Models
{
    public class MensagemChat
    {
        public Int64 Destino { get; set; }
        public UsuarioLogado Mensageiro { get; set; }
        public string mensagem { get; set; }
    }
}

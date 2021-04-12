using AppBarganhaWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBarganhaWEB.Repositorio
{
    public class Connections
    {
        private readonly Dictionary<string, UsuarioLogado> connections =
            new Dictionary<string, UsuarioLogado>();


        public void Add(string uniqueID, UsuarioLogado usuario)
        {
            if (!connections.ContainsKey(uniqueID))
                connections.Add(uniqueID, usuario);
        }

        public string GetUserId(long id)
        {
            return (from con in connections
                    where con.Value.key == id
                    select con.Key).FirstOrDefault();
        }

        public List<UsuarioLogado> GetAllUser()
        {
            return (from con in connections
                    select con.Value
            ).ToList();
        }
    }
}

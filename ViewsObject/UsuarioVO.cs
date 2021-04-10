using AppBarganhaWEB.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace AppBarganhaWEB.ViewsObject
{
    public class UsuarioVO
    {
        public string id { get; set; }
        public string TipoUsuario { get; set; } //= "Pessoa Jurídica";
        public string Login { get; set; }
        public string Senha { get; set; }
        public Endereco Endereco { get; set; }
        public List<int> InteressesSelecionados { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public IFormFile Documentos { get; set; }
        public IFormFile Foto { get; set; }

        public List<Categoria> GetInteresses(List<int> selecionados)
        {
            var interesses = new List<Categoria>();

            foreach (var item in selecionados)
            {
                interesses.Add((Categoria)item);
            }

            return interesses;
        }
    }
}

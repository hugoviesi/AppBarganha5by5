using AppBarganhaWEB.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppBarganhaWEB.ViewsObject
{
    public class AnuncioVO
    {
        public IFormFile picAnuncio { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Nome { get; set; }
        public List<int> InteressesSelecionados { get; set; }

        [NotMapped]
        public IFormFile ArquivoFoto { get; set; }
        public string Foto { get; set; }

        public List<Categoria> GetCategorias()
        {
            var interesses = new List<Categoria>();

            foreach (var item in InteressesSelecionados)
            {
                interesses.Add((Categoria)item);
            }

            return interesses;
        }
    }
}

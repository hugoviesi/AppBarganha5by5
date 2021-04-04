using System.Collections.Generic;

namespace AppBarganhaWEB.Models
{
    public class AnuncioVO
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Nome { get; set; }
        public List<int> InteressesSelecionados { get; set; }

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

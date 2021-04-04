using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace AppBarganhaWEB.Models
{
    public class Anuncio
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataPublicacao { get; set; }

        public decimal Valor { get; set; }

        public string Nome { get; set; }
        public List<Categoria> Categorias { get; set; }

        public string IdUsuario { get; set; }

    }
}

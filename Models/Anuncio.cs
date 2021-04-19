using Microsoft.AspNetCore.Http;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppBarganhaWEB.Models
{
    public class Anuncio
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataPublicacao { get; set; }
        public DateTime DataFinal { get; set; }
        public decimal Valor { get; set; }
        public string Nome { get; set; }
        public List<Categoria> Categorias { get; set; }

        public string IdUsuario { get; set; }

        public StatusAnuncio Status { get; set; }
        public string Foto { get; set; }

        [NotMapped]
        public IFormFile ArquivoFoto { get; set; }

        public bool Ativo { get; set; }
    }
}

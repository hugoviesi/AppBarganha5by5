using Microsoft.AspNetCore.Http;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppBarganhaWEB.Models
{
    public class Usuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        [Required]
        public string Login { get; set; }
        
        [Required]
        public string Senha { get; set; }
        public int Notificacao { get; set; }
        public bool Status { get; set; }
        public int QtdAnuncios { get; set; }
        public Endereco Endereco { get; set; }        
        public int Pontuacao { get; set; }
        public List<Categoria> Interesses { get; set; }
        public IFormFile ArquivoFoto { get; set; }
        public string Foto { get; set; }
    }
}
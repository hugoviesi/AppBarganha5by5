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
        
        public Endereco Endereco { get; set; }    
        
        public int Pontuacao { get; set; }

        public bool Vip { get; set; }

        public List<Categoria> Interesses { get; set; }

        public IFormFile Foto { get; set; }

        public string CaminhoFoto { get; set; }
    }
}
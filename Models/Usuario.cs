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
        public string Foto { get; set; } //TODO: REMOVER
        public int Pontuacao { get; set; }
        public bool Vip { get; set; } //TODO: REMOVER
        public List<Categoria> Interesses { get; set; }
    }
}
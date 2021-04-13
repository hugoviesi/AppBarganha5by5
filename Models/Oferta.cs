using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace AppBarganhaWEB.Models
{
    public class Oferta
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string IdUsuarioOfertante { get; set; }
        public string IdAnuncio { get; set; }
        public DateTime DataOferta { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public bool OfertanteAvaliado { get; set; }
        public bool AnuncianteAvaliado { get; set; }
        public OfertaStatus Status { get; set; }

    }
}

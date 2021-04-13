using AppBarganhaWEB.Models;
using AppBarganhaWEB.Utils;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace AppBarganhaWEB.Services
{
    public class OfertaService
    {
        private readonly IMongoCollection<Oferta> _oferta;

        public OfertaService(IBarganhaDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _oferta = database.GetCollection<Oferta>("Oferta");
        }

        public Oferta Get(string id) =>
            _oferta.Find(oferta => oferta.Id == id).FirstOrDefault();

        public List<Oferta> GetPorUsuarioOfertante(string id) =>
            _oferta.Find<Oferta>(oferta => oferta.IdUsuarioOfertante == id).ToList();

        public List<Oferta> GetPorAnuncio(string idAnuncio) =>
            _oferta.Find<Oferta>(oferta => oferta.IdAnuncio == idAnuncio).ToList();

        public Oferta Create(Oferta oferta)
        {
            _oferta.InsertOne(oferta);
            return oferta;
        }

        public void Update(string id, Oferta ofertaIn) =>
            _oferta.ReplaceOne(oferta => oferta.Id == id, ofertaIn);

        public void Remove(Oferta ofertaIn) =>
            _oferta.DeleteOne(oferta => oferta.Id == ofertaIn.IdUsuarioOfertante);

        public void Remove(string id) =>
            _oferta.DeleteOne(oferta => oferta.Id == id);
    }
}

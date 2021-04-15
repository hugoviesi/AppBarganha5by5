using AppBarganhaWEB.Models;
using AppBarganhaWEB.Utils;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace AppBarganhaWEB.Services
{
    public class AnuncioService
    {
        private readonly IMongoCollection<Anuncio> _anuncios;

        public AnuncioService(IBarganhaDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _anuncios = database.GetCollection<Anuncio>("Anuncio");
        }

        public List<Anuncio> Get() =>
            _anuncios.Find(anuncio => true).ToList();

        public Anuncio Get(string id) =>
            _anuncios.Find<Anuncio>(anuncio => anuncio.Id == id).FirstOrDefault();

        public List<Anuncio> GetForUser(string usuarioId) =>
            _anuncios.Find<Anuncio>(anuncio => anuncio.IdUsuario == usuarioId).ToList();

        public Anuncio Create(Anuncio anuncio)
        {
            _anuncios.InsertOne(anuncio);
            return anuncio;
        }

        public void Update(string id, Anuncio anuncioIn) =>
            _anuncios.ReplaceOne(anuncio => anuncio.Id == id, anuncioIn);

        public void Remove(Anuncio anuncioIn) =>
            _anuncios.DeleteOne(anuncio => anuncio.Id == anuncioIn.Id);

        public void Remove(string id) =>
            _anuncios.DeleteOne(anuncio => anuncio.Id == id);

        public List<Anuncio> GetPorCategoriaEmAberto(List<Categoria> categorias, string idUsuarioLogado)
        {
            return _anuncios.Find<Anuncio>(
                anuncio => anuncio.Categorias.Any(c => categorias.Contains(c)) 
                && anuncio.IdUsuario != idUsuarioLogado
                && anuncio.Status == StatusAnuncio.ABERTO).ToList();
        }

        public long QtdAnunciosUsuario(string idUsuario)
        {
            return _anuncios.CountDocuments(anuncio => anuncio.IdUsuario == idUsuario);
        }


    }
}

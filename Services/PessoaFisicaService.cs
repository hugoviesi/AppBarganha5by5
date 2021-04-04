using AppBarganhaWEB.Models;
using AppBarganhaWEB.Utils;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace AppBarganha.Services
{
    public class PessoaFisicaService
    {
        private readonly IMongoCollection<PessoaFisica> _pessoaFisica;

        public PessoaFisicaService(IBarganhaDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _pessoaFisica = database.GetCollection<PessoaFisica>("PessoaFisica");
        }

        public List<PessoaFisica> Get() =>
        _pessoaFisica.Find(pessoaFisica => true).ToList();

        public PessoaFisica Get(string id) =>
            _pessoaFisica.Find<PessoaFisica>(pessoaFisica => pessoaFisica.Id == id).FirstOrDefault();

        public PessoaFisica Create(PessoaFisica pessoaFisica)
        {
            _pessoaFisica.InsertOne(pessoaFisica);
            return pessoaFisica;
        }

        public void Update(string id, PessoaFisica pessoaFisicaIn) =>
            _pessoaFisica.ReplaceOne(pessoaFisica => pessoaFisica.Id == id, pessoaFisicaIn);

        public void Remove(PessoaFisica pessoaFisicaIn) =>
            _pessoaFisica.DeleteOne(pessoaFisica => pessoaFisica.Id == pessoaFisicaIn.Id);

        public void Remove(string id) =>
            _pessoaFisica.DeleteOne(pessoaFisica => pessoaFisica.Id == id);

        public PessoaFisica Login(string login, string senha) =>
            _pessoaFisica.Find<PessoaFisica>(pessoaFisica => pessoaFisica.Login == login && pessoaFisica.Senha == senha).FirstOrDefault();
    }
}
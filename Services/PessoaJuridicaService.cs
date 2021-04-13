using AppBarganhaWEB.Models;
using AppBarganhaWEB.Utils;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace AppBarganha.Services
{
    public class PessoaJuridicaService
    {
        private readonly IMongoCollection<PessoaJuridica> _PessoaJuridica;

        public PessoaJuridicaService(IBarganhaDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _PessoaJuridica = database.GetCollection<PessoaJuridica>("PessoaJuridica");
        }

        public List<PessoaJuridica> Get() =>
        _PessoaJuridica.Find(pessoaJuridica => true).ToList();

        public PessoaJuridica Get(string id) =>
            _PessoaJuridica.Find<PessoaJuridica>(pessoaJuridica => pessoaJuridica.Id == id).FirstOrDefault();

        public PessoaJuridica GetDocumento(string documento) =>
            _PessoaJuridica.Find<PessoaJuridica>(pessoaJuridica => pessoaJuridica.Cnpj == documento).FirstOrDefault();

        public PessoaJuridica GetLogin(string login) =>
            _PessoaJuridica.Find<PessoaJuridica>(pessoaJuridica => pessoaJuridica.Login == login).FirstOrDefault();

        public PessoaJuridica Create(PessoaJuridica pessoaJuridica)
        {
            _PessoaJuridica.InsertOne(pessoaJuridica);
            return pessoaJuridica;
        }

        public void Update(string id, PessoaJuridica pessoaJuridicaIn) =>
            _PessoaJuridica.ReplaceOne(pessoaJuridica => pessoaJuridica.Id == id, pessoaJuridicaIn);

        public void Remove(PessoaJuridica pessoaJuridicaIn) =>
            _PessoaJuridica.DeleteOne(pessoaJuridica => pessoaJuridica.Id == pessoaJuridicaIn.Id);

        public void Remove(string id) =>
            _PessoaJuridica.DeleteOne(pessoaJuridica => pessoaJuridica.Id == id);

        public PessoaJuridica Login(string login, string senha) =>
            _PessoaJuridica.Find<PessoaJuridica>(pessoaJuridica => pessoaJuridica.Login == login && pessoaJuridica.Senha == senha).FirstOrDefault();

    }
}
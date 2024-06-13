using Models;
using MongoDB.Driver;
using ProjAPIBanco.Utils;

namespace ProjAPIBanco.Service
{
    public class BancoService
    {
        private readonly IMongoCollection<Banco> _banco;
        public BancoService (IBancoSettings settings)
        {
            var client = new MongoClient(settings.StringConexao);
            var database = client.GetDatabase(settings.NomeBancoDados);
            _banco = database.GetCollection<Banco>(settings.BancoCollectionName);
        }

        public List<Banco> GetBanco() => _banco.Find(n => true).ToList();
        public Banco Create(Banco banco)
        {
            _banco.InsertOne(banco);
            return banco;
        }
    }
    
}

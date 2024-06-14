namespace ProjAPIEndereco.Utils
{
    public interface IEnderecoSettings
    {
        public string EnderecosCollectionName { get; set; }
        public string StringConexao { get; set; }
        public string NomeBancoDados { get; set; }
    }
}

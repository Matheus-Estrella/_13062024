namespace ProjAPIEndereco.Utils
{
    public class EnderecoSettings : IEnderecoSettings
    {
        public string EnderecosCollectionName {  get; set; }
        public string StringConexao { get; set; }
        public string NomeBancoDados { get; set; }
    }
}

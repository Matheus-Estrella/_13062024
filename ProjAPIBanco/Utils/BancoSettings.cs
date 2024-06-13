namespace ProjAPIBanco.Utils
{
    public class BancoSettings : IBancoSettings
    {
        public string BancoCollectionName { get ; set ; }
        public string StringConexao { get; set; }
        public string NomeBancoDados { get; set; }
    }
}

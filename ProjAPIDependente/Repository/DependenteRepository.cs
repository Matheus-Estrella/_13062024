using Models;

namespace ProjAPIDependente.Repository
{
    public class DependenteRepository
    {
        private string string_conn { get; set; }
        public DependenteRepository()
        {
            string_conn = @"Data Source=127.0.0.1; Initial Catalog=ProjAndreVeiculos_professor; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";
        }

        //public bool Insert(Dependente dependente)
        //{

        //    try
        //    {

        //    }
        //    catch (Exception ex) { }
        //    return true;
        //}
    }
}

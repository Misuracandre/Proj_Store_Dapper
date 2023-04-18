using System.Configuration;
using System.Data.SqlClient;
using Dapper;
using Models;
// para instalar o dapper, baixar o nuget no Repositories

namespace Repositories // interface = contratos
{
    public class StoreRepository : IStoreRepository // a StoreRepository que implementa a interface, mas eu acesso pela interface
    {
        private string Conn { get; set; }

        public StoreRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString; // instalar system.configuration.ConfigurationManager
        }
        public List<Store> GetAll()
        {
            using (var db = new SqlConnection(Conn))
            {
                var stores = db.Query<Store>(Store.GETALL);
                return (List<Store>)stores; // dapper é só esses pedaçoes que facilitam a query
            } // faz cast de enumerable para list no return, para retornar no getAll
        }

        public bool Insert(Store store)
        {
            var status = false;
            using (var db = new SqlConnection(Conn))// o using delimita o inicio e o fim da existencia do objeto
            {
                db.Open();
                db.Execute(Store.INSERT, store);
                status = true;
            }
            return status;
        }
    }
}
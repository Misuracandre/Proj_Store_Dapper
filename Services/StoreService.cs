using Models;
using Repositories;

namespace Services
{
    public class StoreService // assinatura é um metodo, só que assinatura n tem implementacao, usa a injecao
    {
        private IStoreRepository storeRepository; // contrato definido, é a definicao da estrutura da classe
        public StoreService()
        {
            storeRepository = new StoreRepository(); // ela é do tipo interface, mas recebe um objeto StoreRepository, ele recebe uma injecao de dependencia
        }

        public bool Insert(Store store)
        {
            return storeRepository.Insert(store); // implementacao da insercao de dados
        }

        public List<Store> GetAll()
        {
            return storeRepository.GetAll();
        }
    }
}
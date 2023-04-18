using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models; // new item configuration file, dentro do projeto

namespace Repositories // contratos, assinaturas de interface
{
    public interface IStoreRepository // acessar o contrato pela interface
    {
        bool Insert(Store s);

        List<Store> GetAll();
    }
}

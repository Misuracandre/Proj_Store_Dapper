using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// newsoft.json, instalar para usar no toString, uma lib que molda no formato json

namespace Models
{
    public class Store
    {
        public readonly static string INSERT = "insert into store (Description, Address)" + "values (@Description, @Address)";
        // por ser static, da pra passar pra outra classe
        public readonly static string GETALL = "select Id, Description, Address from Store";
        public int Id { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteSQL.Models.DB
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public int YearOfEstablishment { get; set; }

        public List<Model> Models { get;set; }
    }
}

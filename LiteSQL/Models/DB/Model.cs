using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteSQL.Models.DB
{
    public class Model
    {
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public int YearOfStartProduction { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}

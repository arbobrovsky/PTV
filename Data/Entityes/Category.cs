using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entityes
{
    public class Category
    {
        public int CategoryId { get; set; }
        public int CategoryDeparmen { get; set; }
        public string TypeDeparmen { get; set; }
        public int NormsId { get; set; }
        public virtual Norms Norms { get; set; }
    }
}

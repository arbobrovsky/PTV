using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entityes
{
    public class Warehouse
    {
        public int WarehouseId { get; set; }
        public int CountPTV_Norms { get; set; }
        public int PTVId { get; set; }
        public int CountPTV_Now { get; set; }
        public decimal Summa { get; set; }
    }
}

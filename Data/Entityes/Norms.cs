using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entityes
{
    public class Norms
    {
        public int NormsId { get; set; }
        public int? PTVId { get; set; }
        public virtual PTV PTV { get; set; }
        public int ReserveId { get; set; }
        public virtual Reserve Reserve { get; set; }
        public int WarehouseId { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public int BattleСrewId { get; set; }
        public virtual Warehouse BattleСrew { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get;set;}
    }
}

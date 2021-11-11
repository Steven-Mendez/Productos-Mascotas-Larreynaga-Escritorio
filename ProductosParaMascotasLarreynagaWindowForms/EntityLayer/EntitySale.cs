using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntitySale
    {
        public int SaleId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }

        public enum EntitySake
        {
            SaleId,
            CustomerId,
            EmployeeId,
            Date,
            All
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntitySaleDetail
    {
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public enum EntitySaleDetailAttribute
        {
            SaleId,
            ProductId,
            Price,
            Quantity,
            All
        }
    }
}

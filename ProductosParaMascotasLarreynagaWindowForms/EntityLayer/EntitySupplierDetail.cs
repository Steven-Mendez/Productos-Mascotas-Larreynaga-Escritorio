using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntitySupplierDetail
    {
        public int SupplierId { get; set; }
        public int ProductId { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public decimal PurcharsePrice { get; set; }

        public enum EntitySupplierDetailAttribute
        {
            SupplierId,
            ProductId,
            Date,
            Quantity,
            PurchasePrice,
            All
        }
    }
}

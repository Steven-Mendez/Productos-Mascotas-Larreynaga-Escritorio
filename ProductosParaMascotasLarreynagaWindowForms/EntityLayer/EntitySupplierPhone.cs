using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntitySupplierPhone
    {
        public int PhoneId { get; set; }
        public int SupplierId { get; set; }
        public string PhoneNumber { get; set; }

        public enum EntitySupplierPhoneAttribute
        {
            PhoneId,
            SupplierId,
            PhoneNumber,
            All
        }
    }
}

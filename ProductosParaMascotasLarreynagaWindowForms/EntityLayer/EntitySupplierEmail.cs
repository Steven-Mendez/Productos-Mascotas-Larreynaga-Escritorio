using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntitySupplierEmail
    {
        public int EmailId { get; set; }
        public int SupplierId { get; set; }
        public string Email { get; set; }

        public enum EntitySupplierEmailAttribute
        {
            EmailId,
            SupplierId,
            Email,
            All
        }
    }
}

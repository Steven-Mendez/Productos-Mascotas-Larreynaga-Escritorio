using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntitySupplier
    {
        public int SupplierId { get; set; }
        public int MunicipalityId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }

        public enum EntitySupplierAttribute
        {
            SupplierId,
            MunicipalityId,
            Name,
            Address,
            StreetNumber,
            StreetName,
            All
        }
    }
}

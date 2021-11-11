using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntitySupplier
    {
        public int SupplierID { get; set; }
        public int MunicipalityID { get; set; }
        public string Name { get; set; }
        public string Addres { get; set; }
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }

        public enum EntitySupplierAttribute
        {
            SupplierID,
            MunicipalityID,
            Name,
            Addres,
            StreetNumber,
            StreetName,
            All
        }
    }
}

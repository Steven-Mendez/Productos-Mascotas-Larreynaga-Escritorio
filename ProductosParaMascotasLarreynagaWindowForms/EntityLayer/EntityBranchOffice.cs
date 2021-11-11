using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBranchOffice
    {
        public int BranchOfficeId { get; set; }
        public int MunicipalityId { get; set; }
        public string Name { get; set; }
        public int Address { get; set; }
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }

        public enum EntityBranchOfficeAttribute
        {
            BranchOfficeId,
            MunicpalityId,
            Name,
            Address,
            StreetNumber,
            StreetName,
            All
        }
    }
}

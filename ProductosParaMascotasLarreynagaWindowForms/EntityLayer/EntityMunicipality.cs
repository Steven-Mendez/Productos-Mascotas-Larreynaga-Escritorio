using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityMunicipality
    {
        public int MunicipalityId { get; set; }
        public int DepartamentId { get; set; }
        public string Name { get; set; }

        public enum EntityMunicipalityAttribute
        {
            MunicipalityId,
            DepartmentId,
            Name,
            All
        }
    }
}

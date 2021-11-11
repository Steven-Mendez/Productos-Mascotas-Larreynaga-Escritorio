using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDepartment
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public enum EntityDepartmentAttribute
        {
            DepartmentId,
            Name,
            All
        }
    }
}

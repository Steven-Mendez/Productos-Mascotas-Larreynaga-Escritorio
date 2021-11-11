using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityEmployeePosition
    {
        public int EmployeePositionId { get; set; }
        public string Name { get; set; }

        public enum EntityEmployeePositionAttribute
        {
            EmployeePositionId,
            Name,
            All
        }
    }
}

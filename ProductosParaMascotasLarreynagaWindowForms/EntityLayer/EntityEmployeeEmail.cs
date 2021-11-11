using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityEmployeeEmail
    {
        public int EmailId { get; set; }
        public int EmployeeId { get; set; }
        public string Email { get; set; }

        public enum EntityEmployeeEmailAttribute
        {
            EmailId,
            EmployeeId,
            Email,
            All
        }
    }
}

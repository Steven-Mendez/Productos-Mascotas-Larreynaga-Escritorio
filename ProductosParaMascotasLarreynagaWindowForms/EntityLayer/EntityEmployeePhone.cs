using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityEmployeePhone
    {
        public int PhoneId { get; set; }
        public int EmployeeId { get; set; }
        public string Number { get; set; }

        public enum EntityEmployeePhoneAttribute
        {
            PhoneId,
            EmployeeId,
            Number,
            All
        }
    }
}

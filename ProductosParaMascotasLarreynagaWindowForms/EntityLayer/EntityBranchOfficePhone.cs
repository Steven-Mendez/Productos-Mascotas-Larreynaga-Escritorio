using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBranchOfficePhone
    {
        public int PhoneId { get; set; }
        public int BranchOfficeId { get; set; }
        public string PhoneNumber { get; set; }

        public enum EntityBranchOfficePhoneAttribute
        {
            PhoneId,
            BranchOfficeId,
            PhoneNumber,
            All
        }
    }
}

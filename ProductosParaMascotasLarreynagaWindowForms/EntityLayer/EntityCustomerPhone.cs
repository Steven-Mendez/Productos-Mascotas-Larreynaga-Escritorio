using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityCustomerPhone
    {
        public int PhoneId { get; set; }
        public int CustomerId { get; set; }
        public string Number { get; set; }

        public enum EntityCustomerPhoneAttribute
        {
            PhoneId,
            CustomerId,
            Number,
            All
        }
    }
}

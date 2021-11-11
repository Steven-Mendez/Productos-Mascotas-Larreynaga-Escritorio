using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityCustomerEmail
    {
        public int EmailId { get; set; }
        public int CustomerId { get; set; }
        public string Email { get; set; }

        public enum EntityCustomerEmailAttribute
        {
            EmailId,
            CustomerId,
            Email,
            All
        }
    }
}

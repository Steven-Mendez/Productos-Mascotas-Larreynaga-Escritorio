using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityCustomer
    {
        public int CustomerId { get; set; }
        public int MunicipalityId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstSurname { get; set; }
        public string SecondSurname { get; set; }
        public string Identification { get; set; }
        public int StreetNumber { get; set; }
        public int StreetName { get; set; }

        public enum EntityCustomerAttribute
        {
            CustomerId,
            MunicipalityId,
            FirstName,
            SecondName,
            Identification,
            StreetNumber,
            StreetName,
            All
        }
    }
}

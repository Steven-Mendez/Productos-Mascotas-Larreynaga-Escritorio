using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityEmployee
    {
        public int EmployeeId { get; set; }
        public int EmployeePositionId { get; set; }
        public int BranchOfficeId { get; set; }
        public int MunicipalityId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FirstSurname { get; set; }
        public string SecondSurname { get; set; }
        public string Identification { get; set; }
        public string Address { get; set; }
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }

        public enum EntityEmployeeAttribute
        {
            EmployeeId,
            EmployeePositionId,
            BranchOfficeId,
            MunicipalityId,
            FirstName,
            SecondName,
            FirstSurname,
            SecondSurname,
            Identification,
            Address,
            StreetNumber,
            StreetName,
            All
        }
    }
}

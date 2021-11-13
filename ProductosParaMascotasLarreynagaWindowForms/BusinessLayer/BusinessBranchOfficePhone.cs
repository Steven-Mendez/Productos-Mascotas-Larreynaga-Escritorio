using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntityBranchOfficePhone;

namespace BusinessLayer
{
    public class BusinessBranchOfficePhone
    {
        private readonly DataBranchOfficePhone _dataBranchOfficePhone = new DataBranchOfficePhone();

        public DataTable Get(string search = "", EntityBranchOfficePhoneAttribute attribute = EntityBranchOfficePhoneAttribute.All, EntityOrderType orderType = EntityOrderType.ASC)
        {
            return _dataBranchOfficePhone.Select(search, attribute, orderType);
        }

        public int Add(EntityBranchOfficePhone branchOfficePhone)
        {
            return _dataBranchOfficePhone.Insert(branchOfficePhone);
        }

        public int Edit(EntityBranchOfficePhone branchOfficePhone)
        {
            return _dataBranchOfficePhone.Update(branchOfficePhone);
        }

        public int Delete(EntityBranchOfficePhone branchOfficePhone)
        {
            return _dataBranchOfficePhone.Delete(branchOfficePhone);
        }
    }
}

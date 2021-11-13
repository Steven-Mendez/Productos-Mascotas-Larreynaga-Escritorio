using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EntityLayer;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntityBranchOffice;

namespace BusinessLayer
{
    public class BusinessBranchOffice
    {
        private readonly DataBranchOffice _dataBranchOffice = new DataBranchOffice();

        public DataTable Get(string search = "", EntityBranchOfficeAttribute attribute = EntityBranchOfficeAttribute.All, EntityOrderType orderType = EntityOrderType.ASC)
        {
            return _dataBranchOffice.Select(search, attribute, orderType);
        }

        public int Add(EntityBranchOffice branchOffice)
        {
            return _dataBranchOffice.Insert(branchOffice);
        }

        public int Edit(EntityBranchOffice branchOffice)
        {
            return _dataBranchOffice.Update(branchOffice);
        }

        public int Delete(EntityBranchOffice branchOffice)
        {
            return _dataBranchOffice.Delete(branchOffice);
        }
    }
}

using DataLayer;
using EntityLayer;
using System.Data;
using static EntityLayer.EntityCustomer;

namespace BusinessLayer
{
    public class BusinessCustomer
    {
        private readonly DataCustomer _dataBranchOffice = new DataCustomer();

        public DataTable Get(string search = "", EntityCustomerAttribute attribute = EntityCustomerAttribute.All, EntityOrderType orderType = EntityOrderType.ASC)
        {
            return _dataBranchOffice.Select(search, attribute, orderType);
        }

        public int Add(EntityCustomer entity)
        {
            return _dataBranchOffice.Insert(entity);
        }

        public int Edit(EntityCustomer entity)
        {
            return _dataBranchOffice.Update(entity);
        }

        public int Delete(EntityCustomer entity)
        {
            return _dataBranchOffice.Delete(entity);
        }
    }
}

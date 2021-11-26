using DataLayer;
using EntityLayer;
using System.Data;
using static EntityLayer.EntityCustomer;

namespace BusinessLayer
{
    public class BusinessCustomer
    {
        private readonly DataCustomer _data = new DataCustomer();

        public DataTable Get(string search = "", EntityCustomerAttribute attribute = EntityCustomerAttribute.All, EntityOrderType orderType = EntityOrderType.ASC)
        {
            return _data.Select(search, attribute, orderType);
        }

        public int Add(EntityCustomer entity)
        {
            return _data.Insert(entity);
        }

        public int Edit(EntityCustomer entity)
        {
            return _data.Update(entity);
        }

        public int Delete(EntityCustomer entity)
        {
            return _data.Delete(entity);
        }

        public DataTable SelectEngine(string search)
        {
            return _data.SelectEngine(search);
        }
    }
}

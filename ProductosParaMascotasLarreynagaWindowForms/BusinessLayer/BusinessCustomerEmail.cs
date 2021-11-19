using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntityCustomerEmail;

namespace BusinessLayer
{
    public class BusinessCustomerEmail
    {
        private readonly DataCustomerEmail _data = new DataCustomerEmail();

        public DataTable Get(string search = "", EntityCustomerEmailAttribute attribute = EntityCustomerEmailAttribute.All, EntityOrderType orderType = EntityOrderType.ASC)
        {
            return _data.Select(search, attribute, orderType);
        }

        public int Add(EntityCustomerEmail entity)
        {
            return _data.Insert(entity);
        }

        public int Edit(EntityCustomerEmail entity)
        {
            return _data.Update(entity);
        }

        public int Delete(EntityCustomerEmail entity)
        {
            return _data.Delete(entity);
        }
    }
}

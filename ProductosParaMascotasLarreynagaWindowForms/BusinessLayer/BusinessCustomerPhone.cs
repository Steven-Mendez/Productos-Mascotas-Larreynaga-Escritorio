using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntityCustomerPhone;

namespace BusinessLayer
{
    public class BusinessCustomerPhone
    {
        private readonly DataCustomerPhone _data = new DataCustomerPhone();

        public DataTable Get(string search = "", EntityCustomerPhoneAttribute attribute = EntityCustomerPhoneAttribute.All, EntityOrderType orderType = EntityOrderType.ASC)
        {
            return _data.Select(search, attribute, orderType);
        }

        public int Add(EntityCustomerPhone entity)
        {
            return _data.Insert(entity);
        }

        public int Edit(EntityCustomerPhone entity)
        {
            return _data.Update(entity);
        }

        public int Delete(EntityCustomerPhone entity)
        {
            return _data.Delete(entity);
        }
    }
}

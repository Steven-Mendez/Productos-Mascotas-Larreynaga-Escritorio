using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntityEmployeePhone;

namespace BusinessLayer
{
    public class BusinessEmployeePhone
    {
        private readonly DataEmployeePhone _data = new DataEmployeePhone();

        public DataTable Get(string search = "", EntityEmployeePhoneAttribute attribute = EntityEmployeePhoneAttribute.All, EntityOrderType orderType = EntityOrderType.ASC)
        {
            return _data.Select(search, attribute, orderType);
        }

        public int Add(EntityEmployeePhone entity)
        {
            return _data.Insert(entity);
        }

        public int Edit(EntityEmployeePhone entity)
        {
            return _data.Update(entity);
        }

        public int Delete(EntityEmployeePhone entity)
        {
            return _data.Delete(entity);
        }
    }
}

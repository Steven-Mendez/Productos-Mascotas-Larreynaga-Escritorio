using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntitySupplierPhone;

namespace BusinessLayer
{
    public class BusinessSupplierPhone
    {
        private readonly DataSupplierPhone _data = new DataSupplierPhone();

        public DataTable Get(string search = "", EntitySupplierPhoneAttribute attribute = EntitySupplierPhoneAttribute.All, EntityOrderType orderType = EntityOrderType.ASC)
        {
            return _data.Select(search, attribute, orderType);
        }

        public int Add(EntitySupplierPhone entity)
        {
            return _data.Insert(entity);
        }

        public int Edit(EntitySupplierPhone entity)
        {
            return _data.Update(entity);
        }

        public int Delete(EntitySupplierPhone entity)
        {
            return _data.Delete(entity);
        }
    }
}

using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntitySupplierEmail;

namespace BusinessLayer
{
    public class BusinessSupplierEmail
    {
        private readonly DataSupplierEmail _data = new DataSupplierEmail();

        public DataTable Get(string search = "", EntitySupplierEmailAttribute attribute = EntitySupplierEmailAttribute.All, EntityOrderType orderType = EntityOrderType.ASC)
        {
            return _data.Select(search, attribute, orderType);
        }

        public int Add(EntitySupplierEmail entity)
        {
            return _data.Insert(entity);
        }

        public int Edit(EntitySupplierEmail entity)
        {
            return _data.Update(entity);
        }

        public int Delete(EntitySupplierEmail entity)
        {
            return _data.Delete(entity);
        }
    }
}

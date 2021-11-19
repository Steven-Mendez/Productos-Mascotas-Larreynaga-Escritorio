using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntitySupplierDetail;

namespace BusinessLayer
{
    public class BusinessSupplierDetail
    {
        private readonly DataSupplierDetail _data = new DataSupplierDetail();

        public DataTable Get(string search = "", EntitySupplierDetailAttribute attribute = EntitySupplierDetailAttribute.All, EntityOrderType orderType = EntityOrderType.ASC)
        {
            return _data.Select(search, attribute, orderType);
        }

        public int Add(EntitySupplierDetail entity)
        {
            return _data.Insert(entity);
        }

        public int Edit(EntitySupplierDetail entity)
        {
            return _data.Update(entity);
        }

        public int Delete(EntitySupplierDetail entity)
        {
            return _data.Delete(entity);
        }
    }
}

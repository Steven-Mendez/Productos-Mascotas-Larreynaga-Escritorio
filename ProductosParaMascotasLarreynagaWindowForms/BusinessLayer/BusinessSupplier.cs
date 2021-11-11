using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntitySupplier;

namespace BusinessLayer
{
    public class BusinessSupplier
    {
        private readonly DataSupplier _dataSupplier = new DataSupplier();

        public DataTable Get(string search = "", EntitySupplierAttribute attribute = EntitySupplierAttribute.All, EntityOrderType orderType = EntityOrderType.ASC)
        {
            return _dataSupplier.Select(search, attribute, orderType);
        }

        public int Add(EntitySupplier supplier)
        {
            return _dataSupplier.Insert(supplier);
        }

        public int Edit(EntitySupplier supplier)
        {
            return _dataSupplier.Update(supplier);
        }

        public int Delete(EntitySupplier supplier)
        {
            return _dataSupplier.Delete(supplier);
        }
    }
}

using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntitySale;

namespace BusinessLayer
{
    public class BusinessSale
    {
        private readonly DataSale _data = new DataSale();

        public DataTable Get(string search = "", EntitySaleAttribute attribute = EntitySaleAttribute.All, EntityOrderType orderType = EntityOrderType.ASC)
        {
            return _data.Select(search, attribute, orderType);
        }

        public int Add(EntitySale entity)
        {
            return _data.Insert(entity);
        }

        public int Edit(EntitySale entity)
        {
            return _data.Update(entity);
        }

        public int Delete(EntitySale entity)
        {
            return _data.Delete(entity);
        }

        public int LastIdentity()
        {
            return _data.LastIdentity();
        }
    }
}

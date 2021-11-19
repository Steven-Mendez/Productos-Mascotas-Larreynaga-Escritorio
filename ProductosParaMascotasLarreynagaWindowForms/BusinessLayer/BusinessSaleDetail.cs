using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntitySaleDetail;

namespace BusinessLayer
{
    public class BusinessSaleDetail
    {
        private readonly DataSaleDetail _data = new DataSaleDetail();

        public DataTable Get(string search = "", EntitySaleDetailAttribute attribute = EntitySaleDetailAttribute.All, EntityOrderType orderType = EntityOrderType.ASC)
        {
            return _data.Select(search, attribute, orderType);
        }

        public int Add(EntitySaleDetail entity)
        {
            return _data.Insert(entity);
        }

        public int Edit(EntitySaleDetail entity)
        {
            return _data.Update(entity);
        }

        public int Delete(EntitySaleDetail entity)
        {
            return _data.Delete(entity);
        }
    }
}

using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntityEmployee;

namespace BusinessLayer
{
    public class BusinessEmployee
    {
        private readonly DataEmployee _data = new DataEmployee();

        public DataTable Get(string search = "", EntityEmployeeAttribute attribute = EntityEmployeeAttribute.All, EntityOrderType orderType = EntityOrderType.ASC)
        {
            return _data.Select(search, attribute, orderType);
        }

        public int Add(EntityEmployee entity)
        {
            return _data.Insert(entity);
        }

        public int Edit(EntityEmployee entity)
        {
            return _data.Update(entity);
        }

        public int Delete(EntityEmployee entity)
        {
            return _data.Delete(entity);
        }
    }
}

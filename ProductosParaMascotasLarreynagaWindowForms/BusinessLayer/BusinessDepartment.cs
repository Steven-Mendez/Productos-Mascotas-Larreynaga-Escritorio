using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntityDepartment;

namespace BusinessLayer
{
    public class BusinessDepartment
    {
        private readonly DataDepartment _data = new DataDepartment();

        public DataTable Get(string search = "", EntityDepartmentAttribute attribute = EntityDepartmentAttribute.All, EntityOrderType orderType = EntityOrderType.ASC)
        {
            return _data.Select(search, attribute, orderType);
        }

        public int Add(EntityDepartment entity)
        {
            return _data.Insert(entity);
        }

        public int Edit(EntityDepartment entity)
        {
            return _data.Update(entity);
        }

        public int Delete(EntityDepartment entity)
        {
            return _data.Delete(entity);
        }
    }
}

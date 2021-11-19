using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntityEmployeePosition;

namespace BusinessLayer
{
    public class BusinessEmployeePosition
    {
        private readonly DataEmployeePosition _data = new DataEmployeePosition();

        public DataTable Get(string search = "", EntityEmployeePositionAttribute attribute = EntityEmployeePositionAttribute.All, EntityOrderType orderType = EntityOrderType.ASC)
        {
            return _data.Select(search, attribute, orderType);
        }

        public int Add(EntityEmployeePosition entity)
        {
            return _data.Insert(entity);
        }

        public int Edit(EntityEmployeePosition entity)
        {
            return _data.Update(entity);
        }

        public int Delete(EntityEmployeePosition entity)
        {
            return _data.Delete(entity);
        }
    }
}

using DataLayer;
using EntityLayer;
using System.Data;
using static EntityLayer.EntityEmployeeEmail;

namespace BusinessLayer
{
    public class BusinessEmployeeEmail
    {
        private readonly DataEmployeeEmail _data = new DataEmployeeEmail();

        public DataTable Get(string search = "", EntityEmployeeEmailAttribute attribute = EntityEmployeeEmailAttribute.All, EntityOrderType orderType = EntityOrderType.ASC)
        {
            return _data.Select(search, attribute, orderType);
        }

        public int Add(EntityEmployeeEmail entity)
        {
            return _data.Insert(entity);
        }

        public int Edit(EntityEmployeeEmail entity)
        {
            return _data.Update(entity);
        }

        public int Delete(EntityEmployeeEmail entity)
        {
            return _data.Delete(entity);
        }
    }
}

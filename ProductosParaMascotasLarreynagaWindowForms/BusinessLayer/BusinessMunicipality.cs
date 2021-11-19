using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntityMunicipality;

namespace BusinessLayer
{
    public class BusinessMunicipality
    {
        private readonly DataMunicipality _data = new DataMunicipality();

        public DataTable Get(string search = "", EntityMunicipalityAttribute attribute = EntityMunicipalityAttribute.All, EntityOrderType orderType = EntityOrderType.ASC)
        {
            return _data.Select(search, attribute, orderType);
        }

        public int Add(EntityMunicipality entity)
        {
            return _data.Insert(entity);
        }

        public int Edit(EntityMunicipality entity)
        {
            return _data.Update(entity);
        }

        public int Delete(EntityMunicipality entity)
        {
            return _data.Delete(entity);
        }
    }
}

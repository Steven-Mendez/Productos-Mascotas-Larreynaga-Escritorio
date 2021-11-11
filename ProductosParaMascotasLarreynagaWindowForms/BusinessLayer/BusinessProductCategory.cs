using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityLayer.EntityProductCategory;

namespace BusinessLayer
{
    public class BusinessProductCategory
    {
        private readonly DataProductCategory _dataProductCategory = new DataProductCategory();

        public DataTable Get(string search, EntityProductCategoryAttribute attribute, EntityOrderType orderType)
        {
            return _dataProductCategory.SearchProductCategory(search, attribute, orderType);
        }

        public int Add(EntityProductCategory category)
        {
            return _dataProductCategory.InsertProductCategory(category);
        }

        public int Edit(EntityProductCategory category)
        {
            return _dataProductCategory.EditProductCategory(category);
        }

        public int Delete(EntityProductCategory category)
        {
            return _dataProductCategory.DeleteProductCategory(category);
        }
    }
}

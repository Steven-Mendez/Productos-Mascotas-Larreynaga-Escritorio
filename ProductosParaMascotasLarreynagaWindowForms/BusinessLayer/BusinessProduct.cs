using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer;
using System.Data;

namespace BusinessLayer
{
    public class BusinessProduct
    {
        private readonly DataProduct _DataProduct = new DataProduct();

        public DataTable Get(string search, EntityProductAttribute atribute, EntityOrderType orderType)
        {
            return _DataProduct.SearchProduct(search, atribute, orderType);
        }

        public byte[] GetImage(int id)
        {
            return _DataProduct.SearchProductImage(id);
        }

        public int Add(EntityProduct product)
        {
            return _DataProduct.InsertProduct(product);
        }

        public int Edit(EntityProduct product)
        {
            return _DataProduct.EditProduct(product);
        }

        public int Delete(EntityProduct product)
        {
            return _DataProduct.DeleteProduct(product);
        }
    }
}

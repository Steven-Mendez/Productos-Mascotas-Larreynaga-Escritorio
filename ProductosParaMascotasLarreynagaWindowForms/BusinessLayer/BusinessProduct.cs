using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer;

namespace BusinessLayer
{
    public class BusinessProduct
    {
        private readonly DataProduct _DataProduct = new DataProduct();

        public List<EntityProduct> Get(string search)
        {
            return _DataProduct.SelectProduct(search);
        }

        public int Add(EntityProduct product)
        {
            return _DataProduct.InsertProduct(product);
        }

        public int Edit(EntityProduct product)
        {
            return _DataProduct.UpdateProduct(product);
        }
    }
}

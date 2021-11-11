using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityProductCategory
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public enum EntityProductCategoryAttribute
        {
            CategoryID,
            Name,
            All
        }
    }
}

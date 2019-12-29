using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind_KP.Models
{
    public class CategoriesResult
    {
        public Categories GetDetail(string id)
        {

            return null;
        }
    }

    public class Categories
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }
}

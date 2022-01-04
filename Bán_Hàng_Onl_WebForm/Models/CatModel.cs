using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bán_Hàng_Onl_WebForm.Models
{
    public class CatModel
    {
        private Final_projectEntities2 context;

        public CatModel()
        {
            context = new Final_projectEntities2(); 
        }

        public List<Product> ListProduct()
        {
            var list = context.Database.SqlQuery<Product>("sp_Product_ListAll").ToList();
            return list;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class CategoryResult
    {
        //CategoriesPostModel CategoriesPostModel { get; set; }
        //Categories categories { get; set; }

        public Categories MethodConvert(CategoriesPostModel CategoriesPostModel)
        {
            Categories categories = new Categories();
            if (CategoriesPostModel.CategoryID != null)
                categories.CategoryID = CategoriesPostModel.CategoryID.Value;
            categories.CategoryName = CategoriesPostModel.CategoryName;
            if (CategoriesPostModel.Description != null || CategoriesPostModel.Description != "") 
                categories.Description = CategoriesPostModel.Description;
            if (CategoriesPostModel.Picture != null || CategoriesPostModel.Picture != "" || CategoriesPostModel.Picture.Length < 20) 
            {
                string StrBinary = CategoriesPostModel.Picture.Substring(23);
                categories.Picture = Convert.FromBase64String(StrBinary);
            }


            return categories;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public sealed class ListsRepository
    {
        public ListsRepository() { }

        public static ListsRepository Repository { get; set; } = new ListsRepository();

        public List<CategoriesModel> Categories { get; set; } = new List<CategoriesModel>
        {
            new CategoriesModel
            {
                Name = "Vegetales"
            },

            new CategoriesModel
            {
                Name = "Frutos"
            },

            new CategoriesModel
            {
                Name = "Lacteos"
            }
        };

        public List<ProductsModel> Products { get; set; } = new List<ProductsModel>
        {
            new ProductsModel
            {
                Category = Repository.Categories[0].Name,
                Product_Name = "Verdura",
                Product_Price = 08.94
            },
            new ProductsModel
            {
                Category = Repository.Categories[1].Name,
                Product_Name = "Banana",
                Product_Price = 07.24
            },
            new ProductsModel
            {
                Category = Repository.Categories[2].Name,
                Product_Name = "Leche de vaca",
                Product_Price = 64.58
            }
        };
    }
}

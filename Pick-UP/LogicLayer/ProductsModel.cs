using System;

namespace LogicLayer
{
    public class ProductsModel : DataAbstraction
    {
        public string Category { get; set; }
        public double Price { get; set; }

        //public ProductsModel(string category, string product_Name, double product_Price)
        //{
        //    Category = category;
        //    Product_Name = product_Name;
        //    Product_Price = product_Price;
        //}
    }
}

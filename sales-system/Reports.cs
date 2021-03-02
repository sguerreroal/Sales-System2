using System;
using System.Collections.Generic;
using System.Text;

namespace sales_system
{
    public class Reports
    {
        public Salesman[] Salesmans = new Salesman[20];
        int salesmanCount = 0;

        public Sale[] Sales = new Sale[20];
        int saleCount = 0;

        public Product[] products = new Product[20];
        int productCount = 0;

        public void AddSalesman(Salesman newSalesman)
        {
            Salesmans[salesmanCount] = newSalesman;
            salesmanCount++;
        }

        public void AddSale(Sale newSale)
        {
            Sales[saleCount] = newSale;
            saleCount++;
        }

        public void Addproduct(Product newProduct)
        {
            products[productCount] = newProduct;
            productCount++;
        }
    }
}

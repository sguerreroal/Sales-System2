using System;

namespace sales_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Salesman S1 = new Salesman();
            S1.Name = "Teo";
            S1.Age = 30;

            Salesman S2 = new Salesman();
            S2.Name = "Nata";
            S2.Age = 25;

            Salesman S3 = new Salesman();
            S3.Name = "Edi";
            S3.Age = 31;

            Salesman S4 = new Salesman();
            S4.Name = "Dani";
            S4.Age = 20;      


            Product Pro1 = new Product();
            Pro1.Name = "Polo";
            Pro1.Price = 120;

            Product Pro2 = new Product();
            Pro2.Name = "Jean";
            Pro2.Price = 100;

            Product Pro3 = new Product();
            Pro3.Name = "Shoes";
            Pro3.Price = 150;

            Product Pro4 = new Product();
            Pro4.Name = "T-Shirt";
            Pro4.Price = 80;

            Product Pro5 = new Product();
            Pro5.Name = "Dress";
            Pro5.Price = 200;

            Product Pro6 = new Product();
            Pro6.Name = "sunglasses";
            Pro6.Price = 50;

            

            Sale sale1 = new Sale();
            sale1.Product = "Jean";
            sale1.Seller = "TEO";
            sale1.comments = "Jean for Women Color Gray";

            Sale sale2 = new Sale();
            sale2.Product = "Polo";
            sale2.Seller = "Nata";
            sale2.comments = "Polo siza M";

            Sale sale3 = new Sale();
            sale3.Product = "Shoes";
            sale3.Seller = "Valen";
            sale3.comments = "Shoes siza 39";

            Sale sale4 = new Sale();
            sale4.Product = "Dress";
            sale4.Seller = "Edi";
            sale4.comments = "Dress for women color RED";

            Sale sale5 = new Sale();
            sale5.Product = "sunglasses";
            sale5.Seller = "Edi";
            sale5.comments = "sunglasses for Kid";

            Sale sale6 = new Sale();
            sale6.Product = "Polo";
            sale6.Seller = "Ricky";
            sale6.comments = "Polo siza S";


            Reports reports = new Reports();
            reports.AddSalesman(S1);
            reports.AddSalesman(S2);
            reports.AddSalesman(S3);
            reports.AddSalesman(S4);

            reports.Addproduct(Pro1);
            reports.Addproduct(Pro2);
            reports.Addproduct(Pro3);
            reports.Addproduct(Pro4);
            reports.Addproduct(Pro5);
            reports.Addproduct(Pro6);

            reports.AddSale(sale1);
            reports.AddSale(sale2);
            reports.AddSale(sale3);
            reports.AddSale(sale4);
            reports.AddSale(sale5);
            reports.AddSale(sale6);


            /* int GetsumSale(int sale1, int sale2, int sale3)
            {
                int endsale = ( sale1 + sale2 + sale3);
                return endsale;
            }

            Console.WriteLine("Sales total amount: " + GetsumSale(Pro1.Price,Pro2.Price,Pro3.Price));*/

            void soldCheapest(Sale[] sales, Product[] products)
            {
                int valourCheapest=10000;
                string namesalesman=" ";
                for(int i=0; i< sales.Length; i++)
                {
                    for (int j = 0; j < products.Length; j++)
                    {
                        if (products[j]!= null && sales[i] != null)
                        { 
                        
                            if (valourCheapest > products[j].Price && products[j].Name==sales[i].Product)
                            {
                                valourCheapest = products[j].Price;
                                namesalesman = sales[i].Seller;                                
                            }
                        }
                    }
                }

                Console.WriteLine("The seller that sold the product cheapest was :  " + namesalesman + ".\n");
            }

            soldCheapest(reports.Sales,reports.products);

            void productAverage(Product[] products)
            {
                int productstotal = 0;
                int amounttotal = 0;

                for (int i = 0; i < products.Length;  i++)
                {
                    if (products[i] != null)
                    {
                        productstotal = productstotal + products[i].Price;
                        amounttotal++;
                    }                    
                }
                Console.WriteLine("The price average of the prodcuts is of : " + (productstotal / amounttotal)+ ".\n");

            }

            productAverage(reports.products);

            void unitproduct(Sale[] Sales, string productName)
           {
               int amountpro = 0;
               for (int i = 0; i < Sales.Length; i++)
               {
                   if (Sales[i] != null)
                   {
                       if (productName == Sales[i].Product)
                       {
                           amountpro = amountpro + 1;
                       }
                   }
               }
               Console.WriteLine("The product " + productName + " has been sold " + amountpro + " times.\n");
           }

           unitproduct(reports.Sales, "Polo");


           void expensiveproduct(Product[] products)
           {
               string namepro = "";
               int pricepro = 0;

               for (int i = 0; i < products.Length; i++)
               {
                   if (products[i] != null) 
                   {
                       if (pricepro < products[i].Price)
                       {
                           pricepro = products[i].Price;
                           namepro = products[i].Name;
                       }
                   }                     

               }
               Console.WriteLine("The product most expensive is a " + namepro + " with a price of " + pricepro + ".\n");
           }
           expensiveproduct(reports.products);
        }
    }
}

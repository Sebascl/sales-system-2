using System;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {

            Business business = new Business();

            Product p1 = new Product();
            p1.Name = "Hamburguesa";
            p1.Price = 15000;
            business.AddProduct(p1);

            Product p2 = new Product();
            p2.Name = "Batido";
            p2.Price = 8000;
            business.AddProduct(p2);

            Product p3 = new Product();
            p3.Name = "Salchipapa";
            p3.Price = 10000;
            business.AddProduct(p3);


            Seller s1 = new Seller();
            s1.Name = "Pedro";
            s1.Age = 29;
            business.AddSeller(s1);

            Seller s2 = new Seller();
            s2.Name = "Mateo";
            s2.Age = 37;
            business.AddSeller(s2);

            Seller s3 = new Seller();
            s3.Name = "Hector";
            s3.Age = 23;
            business.AddSeller(s3);


            Sale sale1 = new Sale();
            sale1.Product = p1;
            sale1.Seller = s1;
            sale1.Comments = "Without onion";
            business.AddSale(sale1);

            Sale sale2 = new Sale();
            sale2.Product = p3;
            sale2.Seller = s2;
            sale2.Comments = "No sauce";
            business.AddSale(sale2);

            Sale sale3 = new Sale();
            sale3.Product = p2;
            sale3.Seller = s3;
            sale3.Comments = "Without tomato";
            business.AddSale(sale3);

            string CheapestProductSeller = business.CheapestProductSeller().Name;
            string TheMostExpensiveProduct = business.TheMostExpensiveProduct().Name;
            float ProductPriceAverage = business.ProductsPriceAverage();
            int AvailableProducts = business.AvailableProducts();


            System.Console.WriteLine("Sales Total Amount = " + (sale1.Product.Price+sale2.Product.Price+sale3.Product.Price));
            System.Console.WriteLine("The seller who has sold the cheapest product is " + CheapestProductSeller);
            System.Console.WriteLine("The Most expensive product is " + TheMostExpensiveProduct);
            System.Console.WriteLine("The Product Price Average is " + ProductPriceAverage);
            System.Console.WriteLine("The Total Available Products are " + AvailableProducts);

        }
    }
}

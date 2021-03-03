using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    class Business
    {
        public Product[] Products = new Product[20];
        public int productCount = 0;
        public Sale[] Sales = new Sale[20];
        public int saleCount = 0;
        public Seller[] Sellers = new Seller[20];
        public int sellerCount = 0;

        public void AddProduct(Product newProduct)
        {
            Products[productCount] = newProduct;
            productCount++;
        }

        public void AddSale(Sale newSale)
        {
            Sales[saleCount] = newSale;
            saleCount++;
        }

        public void AddSeller (Seller newSeller)
        {
            Sellers[sellerCount] = newSeller;
            sellerCount++;
        }

        public Seller CheapestProductSeller()
        {
            Sale CheapestProduct = Sales[0];
            for (int i=0; i<saleCount; i++)
            {
                if (Sales[i].Product.Price < CheapestProduct.Product.Price)
                {
                    CheapestProduct = Sales[i];
                }
            }
            return CheapestProduct.Seller;
        }

        public Product TheMostExpensiveProduct()
        {
            Product MostExpensiveProduct = Products[0];
            for (int i=0; i < productCount; i++)
            {
                if(Products[i].Price > MostExpensiveProduct.Price)
                {
                    MostExpensiveProduct = Products[i];
                }
            }
            return MostExpensiveProduct;
        }

        public float ProductsPriceAverage()
        {
            float PlusProducts = 0;

            for (int i=0; i < productCount; i++)
            {
                PlusProducts = PlusProducts + Products[i].Price;
            }
            PlusProducts = PlusProducts / productCount;
            return PlusProducts;
        }

        public int AvailableProducts()
        {
            int UnitProduct = 0;
            for (int i = 0; i < productCount; i++)
            {
                UnitProduct++;
            }
            return UnitProduct;
        }

    }
}

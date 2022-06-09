using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class Library
    {
        Product[] Products;

        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
         }
            public void GetJournalsCount() 
        {
            int count = 0;
            foreach(var item in Products) 
            {
                if (item is Journal)

                    count++;
            }
            return count;
        }
         public void GetBooksCount() 
        {
            int count = 0;
            foreach(var item in Products) 
            {
                if (item is Book)
                    count++;
            }
            return count;
        }
       public void GetProducts()     
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        ///<summary>Retrieve a product</summary>
        ///

        public Product Retrieve(int productId)
        {
            // Creating the instance of the Product class.
            // Pass in the requested id.
            Product product = new Product(productId);

            if (productId ==1)
            {
                product.CurrentPrice = 99.99M;
                product.ProductDescription = "a typical description";
                product.ProductName = "A Name";
            }
            return product;
        }

        ///<summary>Saves the current product</summary>
        public bool Save(Product product)
        {
            // Code that saves the passed in product
            return true;
        }
       
    }
}

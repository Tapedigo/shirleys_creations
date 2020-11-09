using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace shirleys_creations
{
    public class ProductManager
    {
        
        string location = Path.Combine(Directory.GetCurrentDirectory(),"Products.json");
        Products productsDisplay = new Products();
        public static List<Products> DeserializeProducts(string fileName)
        {
            var products = new List<Products>();
            var serializer = new JsonSerializer();
            using (var r = new StreamReader(fileName))
            using (var jr = new JsonTextReader(r))
            {
                products = serializer.Deserialize<List<Products>>(jr);
            }
            return products;
        }
        
        public void ViewAllProducts()
        {
            foreach (var product in productsDisplay.Name)
            {
                Console.WriteLine(product.ToString());
            }
        }
        public void ViewAllProductTypes()
        {
            foreach (var type in productsDisplay.TypeOfProduct)
            {
                Console.WriteLine(type.ToString());
            }
        }

    }

}
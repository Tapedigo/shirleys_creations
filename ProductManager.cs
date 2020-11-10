using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace shirleys_creations
{
    public class ProductManager
    {
        string location = Path.Combine(Directory.GetCurrentDirectory(),"Products.json");
        public static IList<Products> DeserializeProducts(string fileName)
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

        Products products = new Products();
        public void ViewAllProducts()
        {
            foreach (var name in products.Name)
            {
                Console.WriteLine(name);
            }
        }
        public void ViewAllProductTypes()
        {
            foreach (var type in products.TypeOfProduct)
            {
                Console.WriteLine(type);
            }
        }
    }

}
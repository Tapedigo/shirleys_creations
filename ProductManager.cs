using System;
using System.Collections.Generic;
using System.IO;
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
            List<Products> products = new List<Products>();
        public void ViewAllProducts()
        {
            foreach (var i in products)
            {
                Console.WriteLine(i.Name);
            }
        }
        public void ViewAllProductTypes()
        {
            foreach (var type in products)
            {
                Console.WriteLine(type.TypeOfProduct);
            }
        }

    }

}
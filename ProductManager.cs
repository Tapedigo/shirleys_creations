using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace shirleys_creations
{
    public class ProductManager
    {   
        public List<Products> DeserializeProducts()
        {
            string location = Path.Combine(Directory.GetCurrentDirectory(),"Products.json");
            var products = new List<Products>();
            var serializer = new JsonSerializer();
            using (var r = new StreamReader(location))
            using (var jr = new JsonTextReader(r))
            {
                products = serializer.Deserialize<List<Products>>(jr);
            }
            return products;
        }
        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Shirley's Creations!");
            Console.WriteLine("Select what you would like to do today?");
            Console.WriteLine("0. Exit the store");
            Console.WriteLine("1. View all products in the store");
            Console.WriteLine("3. Request a custom order");
            Console.WriteLine("4. Ask Shirley a question");
            Console.WriteLine("5. Return to main menu");
        }
        public void PromptToReturn()
        {
            Console.Write("Press enter to return to main menu. ");
        }
    }
}
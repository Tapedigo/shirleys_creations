using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace shirleys_creations
{
    public class ProductManager
    {   
        // Json Reader Method
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
        // Main menu
        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Shirley's Creations!");
            Console.WriteLine("Select what you would like to do today?");
            Console.WriteLine("0. Exit the store");
            Console.WriteLine("1. View all products in the store");
            Console.WriteLine("2. View the price of each Product in USD");
            Console.WriteLine("3. Request a custom order/Ask Shirley a question");
            Console.WriteLine("4. View the price of each Product in GBP");
            Console.WriteLine("5. View the price of each Product in CAD");
            Console.WriteLine("6. Add products to cart/checkout");
        }
        public void PromptToReturn()
        {
            Console.Write("Press type home and press enter to return to main menu. ");
        }

        public void Inquries()
        {
            string textFileLocation = Path.Combine(Directory.GetCurrentDirectory(), "Test.txt");
            string question;
            string prompt = "What would you like to ask Shirley?: ";
            
            Console.Write(prompt);
            question = Console.ReadLine();
            StreamWriter w = new StreamWriter(textFileLocation);
            w.Write("\r\nLog Entry : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine(question);
            w.Close();
        }
    }
}
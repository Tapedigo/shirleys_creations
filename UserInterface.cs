using System;

namespace shirleys_creations
{
    public class UserInterface
    {
        private ProductManager _productManager = new ProductManager();
        internal void UserInterfaceMenu()
        {
            bool keepGoing = false;
            
            while (!keepGoing)
            {
                Console.WriteLine("Welcome to Shirley's Creations!");
                Console.WriteLine("Select what you would like to do today?");
                Console.WriteLine("0. Exit the store");
                Console.WriteLine("1. View all products in the store");
                Console.WriteLine("2. View all categories of products in the store.");
                Console.WriteLine("3. Request a custom order");
                Console.WriteLine("4. Ask Shirley a question");
                Console.WriteLine("5. Return to main menu");
                string userInput = Console.ReadLine();
                
                switch (userInput)
                {
                    case "0":
                    {
                    keepGoing = true;
                    break;
                    }
                    case "1": 
                    {
                    _productManager.ViewAllProducts();
                    break;
                    }
                    case "2":
                    {
                    _productManager.ViewAllProductTypes();
                    break;
                    }
                    
                }
            }
        }
    }
}

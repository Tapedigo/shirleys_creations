using System;
using System.Collections.Generic;
using System.IO;

namespace shirleys_creations
{
    public class UserInterface
    {
        private List<Products> _products = new List<Products>();

        private ProductManager _productManager = new ProductManager();
        public void ViewAllProducts()
        {
            foreach (var product in _productManager.DeserializeProducts())
            {
                _productManager.DeserializeProducts();
                Console.WriteLine($"{product.Name}: {product.Description}");
            }
        }
        // public void ViewAllProductTypes()
        // {
            
        //     foreach (var type in _productManager.DeserializeProducts())
        //     {
        //         Console.WriteLine(type.TypeOfProduct);
        //     }
        // }
        public void UserInterfaceMenu()
        {
            bool keepGoing = false;
            _productManager.DisplayWelcome();
            while (!keepGoing)
            {
                string userInput = Console.ReadLine();
                
                switch (userInput)
                {
                    case "":
                    {
                    _productManager.DisplayWelcome();
                    break;
                    }
                    case "0":
                    {
                    keepGoing = true;
                    break;
                    }
                    case "1": 
                    {
                    ViewAllProducts();
                    _productManager.PromptToReturn();
                    break;
                    }
                    case "2":
                    {
                    // ViewAllProductTypes();
                    // _productManager.PromptToReturn();
                    break;
                    }
                }
            }
        }
    }
    }

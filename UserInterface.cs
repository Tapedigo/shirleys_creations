using System;
using System.Collections.Generic;
using System.IO;

namespace shirleys_creations
{
    public class UserInterface
    {
        private List<Products> _products = new List<Products>();
        private ProductManager _productManager = new ProductManager();
        private ConvertPriceToPound _convertToPound = new ConvertPriceToPound();
        public void ViewAllProducts()
        {
            foreach (var product in _productManager.DeserializeProducts())
            {
                _productManager.DeserializeProducts();
                Console.WriteLine($"{product.Name}: {product.Description}");
                Console.WriteLine("");
            }
        }
        // Price in Different Currencies
        public void ViewAllProductsPrices()
        {
            foreach (var product in _productManager.DeserializeProducts())
            {
                _productManager.DeserializeProducts();
                Console.WriteLine($" {product.Name}: ${product.Price}");
                Console.WriteLine("");
            }
        }
        public void ViewAllPricesInGbp()
        {
            foreach (var price in _convertToPound.priceInGbp())
            {
                Console.WriteLine($"{price}");
            }
        }
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
                        ViewAllProductsPrices();
                        _productManager.PromptToReturn();
                    break;
                    }
                    case "3":
                    {
                        _productManager.Inquries();
                        _productManager.PromptToReturn();
                        break;
                    }
                    case "4":
                    {
                        ViewAllPricesInGbp();
                        _productManager.PromptToReturn();
                        break;
                    }
                }
            }
        }
    }
    }

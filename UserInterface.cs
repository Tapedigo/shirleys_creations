using System;
using System.Collections.Generic;
using ExchangeRate_API;

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
            List<string> productsName = new List<string>();
            List<double> poundPrice = new List<double>();
            foreach (var item in _productManager.DeserializeProducts())
            {
                productsName.Add(item.Name);
            }
            foreach (var item in _convertToPound.priceInGbp())
            {
                poundPrice.Add(item);
            }
            
            for (int i = 0; i <  productsName.Count; i++)
            {
                Console.WriteLine(productsName[i].ToString());
                Console.WriteLine($"£{poundPrice[i]}");
                Console.WriteLine("");
            }
        }

        public void ViewAllPricesInCDollar()
        {
            List<string> productsName = new List<string>();
            List<double> cDollarPrice = new List<double>();
            foreach (var item in _productManager.DeserializeProducts())
            {
                productsName.Add(item.Name);
            }
            foreach (var item in _convertToPound.priceInGbp())
            {
                cDollarPrice.Add(item);
            }
            
            for (int i = 0; i <  productsName.Count; i++)
            {
                Console.WriteLine(productsName[i].ToString());
                Console.WriteLine($"{cDollarPrice[i]}$");
                Console.WriteLine("");
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
                    case "5":
                    {
                        ViewAllPricesInCDollar();
                        _productManager.PromptToReturn();
                        break;
                    }
                }
            }
        }
    }
    }

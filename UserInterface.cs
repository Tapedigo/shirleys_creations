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
        List<string> productsInCart = new List<string>();
        List<string> checkList = new List<string>();
        public void ViewAllProductNames()
        {
            foreach (var product in _productManager.DeserializeProducts())
            {
                _productManager.DeserializeProducts();
                Console.WriteLine($"{product.Name}");
            }
        }
        public void ViewAllProducts()
        {
            foreach (var product in _productManager.DeserializeProducts())
            {
                _productManager.DeserializeProducts();
                Console.WriteLine($"{product.Name}: {product.Description}");
                Console.WriteLine("");
            }
        }
        public void CartWelcomeMessage()
        {
              foreach (var p in _productManager.DeserializeProducts())
            {
                checkList.Add(p.Name.ToLower());
            }
            Console.WriteLine("Enter the word home to return to main menu");
            Console.WriteLine($"Enter the word one to add {checkList[0]} to cart.");
            Console.WriteLine($"Enter the word two to add {checkList[1]} to cart.");
            Console.WriteLine($"Enter the word three to add {checkList[2]} to cart.");
            Console.WriteLine($"Enter the word four to add {checkList[3]} to cart.");
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
                    case "home":
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
                    case "6":
                    {
                        CartWelcomeMessage();
                        _productManager.PromptToReturn();
                        break;
                    }
                    case "zero":
                    {
                         foreach (var item in productsInCart)
                        {
                        Console.WriteLine(item);
                        }
                        break;
                    }
                    case "one":
                    {
                        Console.WriteLine($"{checkList[0]} added to cart!");
                        productsInCart.Add(checkList[0]);
                        Console.WriteLine("");
                        CartWelcomeMessage();
                        Console.WriteLine("");
                        break;
                    }
                    case "two":
                    {
                        Console.WriteLine($"{checkList[1]} added to cart!");
                        productsInCart.Add(checkList[1]);
                        Console.WriteLine("");
                        CartWelcomeMessage();
                        Console.WriteLine("");
                        break;
                    }
                    case "three":
                    {
                        Console.WriteLine($"{checkList[2]} added to cart!");
                        productsInCart.Add(checkList[2]);
                        Console.WriteLine("");
                        CartWelcomeMessage();
                        Console.WriteLine("");
                        break;
                    }
                    case "four":
                    {
                        Console.WriteLine($"{checkList[3]} added to cart!");
                        productsInCart.Add(checkList[3]);
                        Console.WriteLine("");
                        CartWelcomeMessage();
                        Console.WriteLine("");
                        break;
                    }
                    case "":
                    {
                        Console.WriteLine("Please select a product");
                        CartWelcomeMessage();
                        break;
                    }
                    case "checkout":
                    {
                        Console.WriteLine("Your order is on it's way! Goodbye see you again soon");
                        _productManager.DisplayWelcome();
                        break;
                    }
                }
            }
        }
    }
    }

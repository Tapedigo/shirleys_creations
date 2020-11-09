using System;
using System.Collections.Generic;
using System.IO;

namespace shirleys_creations
{
    class Program
    {
        static void Main(string[] args)
        {
            string location = Path.Combine(Directory.GetCurrentDirectory(),"Products.json");
            var product = ProductManager.DeserializeProducts(location);
            var products = new List<Products>();
            var userInterface = new UserInterface();
            userInterface.UserInterfaceMenu();
        }
    }
}

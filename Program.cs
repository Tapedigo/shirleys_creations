using System;
using System.Collections.Generic;
using System.IO;

namespace shirleys_creations
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInterface = new UserInterface();
            userInterface.UserInterfaceMenu();
            //string location = Path.Combine(Directory.GetCurrentDirectory(),"Products.json");
            //ProductManager.DeserializeProducts(location);
        }
    }
}

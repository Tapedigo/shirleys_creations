using System;
using System.Collections.Generic;
using ExchangeRate_API;

namespace shirleys_creations
{
    public class ConvertPriceToPound
    {
        private API_Obj _aPI_Obj = new API_Obj();
        private ProductManager _productManager = new ProductManager();

        public List<decimal> pound;
        public List<decimal> CovertToPound()
        
        {
            foreach (var Usdrate in _productManager.DeserializeProducts())
            {
                pound.Add(Usdrate.Price * _aPI_Obj.conversion_rates.GBP);
            }
            return pound; 
        }
    }
}
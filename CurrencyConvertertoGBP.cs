using System;
using System.Collections.Generic;
using ExchangeRate_API;

namespace shirleys_creations
{
    public class ConvertPriceToPound
    {
        private ProductManager _productManager = new ProductManager();
        private Rates _rates = new Rates();
        public List<double> priceInGbp()
        {
            List<double> priceInPound;
            double poundRate = _rates.ConversionRates();
            foreach (var product in _productManager.DeserializeProducts())
            {
                double result = product.Price * poundRate;
                priceInPound.Add(result);
            }
            return priceInPound;
        }
    }
}
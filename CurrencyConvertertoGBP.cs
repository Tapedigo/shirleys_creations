using System;
using System.Collections.Generic;

namespace shirleys_creations
{
    public class ConvertPriceToPound
    {
        private ProductManager _productManager = new ProductManager();
        private Rates _rates = new Rates();
        private ConversionRate rate = new ConversionRate();
        double poundRate = rate.GBP;
        public List<double> poundPrice = new List<double>();
        public List<double> priceInGbp()
        {
            foreach (var product in _productManager.DeserializeProducts())
            {
                double result = product.Price * poundRate;
                poundPrice.Add(result);
            }
            return poundPrice;
        }
    }
}
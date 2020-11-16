using System;
using System.Collections.Generic;

namespace shirleys_creations
{
    public class ConvertPriceToPound
    {
        private ProductManager _productManager = new ProductManager();
        private ConversionRate _conversionRate = new ConversionRate();
        public List<double> poundPrice = new List<double>();
        public List<double> priceInGbp()
        {
            foreach (var product in _productManager.DeserializeProducts())
            {
                double tempUSD = product.Price;
                double tempGBP = _conversionRate.GBP;
                double result = tempGBP * tempUSD;
                poundPrice.Add(result);
            }
            return poundPrice;
        }
    }
}
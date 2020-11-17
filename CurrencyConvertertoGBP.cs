using System;
using System.Collections.Generic;
using shirleys_creations;

namespace ExchangeRate_API
{
    public class ConvertPriceToPound
    {
        private ProductManager _productManager = new ProductManager();
        private Rates _rates = new Rates();
        public List<double> poundPrice = new List<double>();
        public List<double> priceInGbp()
        {
            API_Obj api = Rates.Import();
            foreach (var products in _productManager.DeserializeProducts())
            {
                double tempUSD = products.Price;
                double tempGBP = api.conversion_rates.GBP;
                double result = tempGBP * tempUSD;
                poundPrice.Add(result);
            }
            return poundPrice;
        }
    }
}
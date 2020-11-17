using System.Collections.Generic;
using shirleys_creations;

namespace ExchangeRate_API
{
    public class ConvertPriceToCDollar
    {
        private ProductManager _productManager = new ProductManager();
        private Rates _rates = new Rates();
        public List<double> cDollarPrice = new List<double>();
        public List<double> priceInGbp()
        {
            API_Obj api = Rates.Import();
            foreach (var products in _productManager.DeserializeProducts())
            {
                double tempUSD = products.Price;
                double tempCAD = api.conversion_rates.CAD;
                double result = tempCAD * tempUSD;
                cDollarPrice.Add(result);
            }
            return cDollarPrice;
        }
    }
}
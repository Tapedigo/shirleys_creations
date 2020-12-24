using System.Collections.Generic;
using shirleys_creations;
using Xunit;

namespace shirley_creations_test
{
    public class Tests
    {
        ProductManager _projectManager = new ProductManager();
        private List<string> _listOfProductsNames = new List<string>();
        private List<double> _listOfProductsPrice = new List<double>();
        public void AssignProductsToTestList()
        {
            foreach (var product in _projectManager.DeserializeProducts())
            {
                _listOfProductsNames.Add(product.Name);
                _listOfProductsPrice.Add(product.Price);
            }
        }
        [Fact]
        public void TestName()
        {
            AssignProductsToTestList();
            string expected = "70s Band T-shirt Quilt";
            Assert.Equal(_listOfProductsNames[0],expected);
        }
    }
}
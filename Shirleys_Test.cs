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
        [Fact]
        public void AssignProductsToTestList()
        {
            foreach (var product in _projectManager.DeserializeProducts())
            {
                _listOfProductsNames.Add(product.Name);
                _listOfProductsPrice.Add(product.Price);
            }
        }
        [Fact]
        public void TestNames()
        {
            AssignProductsToTestList();
            string expected = "70s Band T-shirt Quilt";
            Assert.Equal(_listOfProductsNames[0],expected);
            string expected1 = "Standard Black and Red Quilt";
            Assert.Equal(_listOfProductsNames[1],expected1);
            string expected2 = "Superhero T-Shirt Quilt";
            Assert.Equal(_listOfProductsNames[2],expected2);
            string expected3 = "Standard Cloth Quilt Themed Mask";
            Assert.Equal(_listOfProductsNames[3],expected3);
        }
    }
}
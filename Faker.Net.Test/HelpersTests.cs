using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Faker.Tests
{
    [TestClass]
    public class HelpersTests
    {
        [TestMethod]
        public void GetAvailableLocaleTypesTest()
        {
            var result = Helpers.GetAvailableLocaleTypes();
            Assert.IsTrue(result.Length > 1);
        }
    }
}

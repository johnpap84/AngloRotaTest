using AngloRota.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AngloRotaTest
{
    [TestClass]
    public class StringOperationsTest
    {
        [TestMethod]
        public void FirstLettersToUpperCaseTest()
        {
            /// Arrange
            string source = "john pap";
            string expected = "John Pap";

            /// Act
            string result = StringOperations.FirstLettersToUpperCase(source);

            /// Assert
            Assert.AreEqual(expected, result);
        }
    }
}

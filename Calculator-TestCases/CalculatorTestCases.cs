using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace Calculator_TestCases
{
    [TestClass]
    public class CalculatorTestCases
    {
        [TestMethod]
        public void testAdd()
        {
            SimpleMath math = new SimpleMath();
            double res = math.Calculate(1, 2, "Add");
            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void testSubtract()
        {
            SimpleMath math = new SimpleMath();
            double res = math.Calculate(7, 2, "Sub");
            Assert.AreEqual(5, res);
        }
        [TestMethod]
        public void testMultiply()
        {
            SimpleMath math = new SimpleMath();
            double res = math.Calculate(5, 10, "Mult");
            Assert.AreEqual(50, res);
        }
        [TestMethod]
        public void testDivide()
        {
            SimpleMath math = new SimpleMath();
            double res = math.Calculate(44, 11, "Div");
            Assert.AreEqual(4, res);
        }
    }
}

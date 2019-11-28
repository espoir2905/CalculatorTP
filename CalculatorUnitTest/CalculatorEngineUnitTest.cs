using System;
using Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorEngineUnitTest
    {
        [TestMethod]
        public void TestMethodadd()
        {
            int a = 1;
            int b = 2;
            int exp = 3;
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.add(a, b);
            Assert.AreEqual(exp, actual);
          
            
        }
        [TestMethod]
        public void TestMethodSub()
        {
            int a = 5;
            int b = 10;
            int sub = -5;
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.sub(a, b);
            Assert.AreEqual(sub, actual);
        }
        [TestMethod]
        public void TestMethodMul()
        {
            int a = 5;
            int b = 10;
            int mul = 50;
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Mul(a, b);
            Assert.AreEqual(mul, actual);
        }
        [TestMethod]
        public void TestMethodDiv()
        {
            int a = 10;
            int b = 10;
            int div = 1;
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Div(a, b);
            Assert.AreEqual(div, actual);
        }
        [TestMethod]
        public void TestMethodDivByZero()
        {
            int a = 6;
            int b = 0;
            int div = int.MinValue;
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Div(a, b);
            Assert.AreEqual(div, actual);
        }

    }
}

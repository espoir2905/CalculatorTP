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
            int actual = engine.addition(a, b);
            Assert.AreEqual(exp, actual);
          
            
        }
        [TestMethod]
        public void TestMethodSub()
        {
            int a = 5;
            int b = 10;
            int sub = -5;
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.subdivision(a, b);
            Assert.AreEqual(sub, actual);
        }
        [TestMethod]
        public virtual void TestMethodMul()
        {
            int a = 5;
            int b = 10;
            int mul = 50;
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Multiplication(a, b);
            Assert.AreEqual(mul, actual);
        }
        [TestMethod]
        public virtual void TestMethodDiv()
        {
            int a = 10;
            int b = 10;
            int div = 1;
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Division(a, b);
            Assert.AreEqual(div, actual);
        }
        [TestMethod]
        public virtual void TestMethodDivByZero()
        {
            int a = 6;
            int b = 0;
            int div = int.MinValue;
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Division(a, b);
            Assert.AreEqual(div, actual);
        }

    }
}

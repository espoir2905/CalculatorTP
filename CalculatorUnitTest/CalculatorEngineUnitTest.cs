using System;
using Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorEngineUnitTest
    {
        [TestMethod]
        public virtual void TestMethodaddition()
        {
            int a = 1;
            int b = 2;
            int exp = 3;
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Addition(a, b);
            Assert.AreEqual(exp, actual);
          
            
        }
        [TestMethod]
        public void TestMethodSubstraction()
        {
            int a = 5;
            int b = 10;
            int sub = -5;
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Substraction(a, b);
            Assert.AreEqual(sub, actual);
        }
        [TestMethod]
        public virtual void TestMethodMuliplication()
        {
            int a = 5;
            int b = 10;
            int mul = 50;
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Multiplication(a, b);
            Assert.AreEqual(mul, actual);
        }
        [TestMethod]
        public virtual void TestMethodDivision()
        {
            int a = 10;
            int b = 10;
            int div = 1;
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Division(a, b);
            Assert.AreEqual(div, actual);
        }
        [TestMethod]
        public virtual void TestMethodDivisionByZero()
        {
            int a = 6;
            int b = 0;
            int div = int.MinValue;
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Division(a, b);
            Assert.AreEqual(div, actual);
        }
        [TestMethod]
        public void TestMethodSquareRoot()
        {
            int a = 25;
            
            int RacineCarre =5;
            CalculatorEngine engine = new CalculatorEngine();
           double actual = engine.SquareRoot(a);
            Assert.AreEqual(RacineCarre, actual);
        }
        [TestMethod]
        public void TestMethodSquare()
        {
            int a = 5;
            int Carre = 25;
            CalculatorEngine engine = new CalculatorEngine();
            double actual = engine.Square(a);
            Assert.AreEqual(Carre, actual);
        }
        [TestMethod]
        public void TestMethodpercentage()
        {
            int a = 50;
            Double pourcentage = 0.5;
            CalculatorEngine engine = new CalculatorEngine();
            double actual = engine.percentage(a);
            Assert.AreEqual(pourcentage, actual);
        }

    }
}

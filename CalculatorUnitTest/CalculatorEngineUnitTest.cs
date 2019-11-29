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
            int Exp = 3;
            CalculatorEngine engine = new CalculatorEngine();
            int Actual = engine.Addition(a, b);
            Assert.AreEqual(Exp, Actual);
          
            
        }
        [TestMethod]
        public void TestMethodSubstraction()
        {
            int a = 5;
            int b = 10;
            int Sub = -5;
            CalculatorEngine engine = new CalculatorEngine();
            int Actual = engine.Substraction(a, b);
            Assert.AreEqual(Sub, Actual);
        }
        [TestMethod]
        public virtual void TestMethodMuliplication()
        {
            int a = 5;
            int b = 10;
            int Mul = 50;
            CalculatorEngine engine = new CalculatorEngine();
            int Actual = engine.Multiplication(a, b);
            Assert.AreEqual(Mul, Actual);
        }
        [TestMethod]
        public virtual void TestMethodDivision()
        {
            int a = 10;
            int b = 10;
            int Div = 1;
            CalculatorEngine engine = new CalculatorEngine();
            int Actual = engine.Division(a, b);
            Assert.AreEqual(Div, Actual);
        }
        [TestMethod]
        public virtual void TestMethodDivisionByZero()
        {
            int a = 6;
            int b = 0;
            int Div = int.MinValue;
            CalculatorEngine engine = new CalculatorEngine();
            int actual = engine.Division(a, b);
            Assert.AreEqual(Div, actual);
        }
        [TestMethod]
        public void TestMethodSquareRoot()
        {
            int a = 25;
            
            int RacineCarre =5;
            CalculatorEngine engine = new CalculatorEngine();
           double Actual = engine.SquareRoot(a);
            Assert.AreEqual(RacineCarre, Actual);
        }
        [TestMethod]
        public void TestMethodSquare()
        {
            int a = 5;
            int Carre = 25;
            CalculatorEngine engine = new CalculatorEngine();
            double Actual = engine.Square(a);
            Assert.AreEqual(Carre, Actual);
        }
        [TestMethod]
        public void TestMethodpercentage()
        {
            int a = 50;
            Double Pourcentage = 0.5;
            CalculatorEngine engine = new CalculatorEngine();
            double actual = engine.Percentage(a);
            Assert.AreEqual(Pourcentage, actual);
        }

    }
}

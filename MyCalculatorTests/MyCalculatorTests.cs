using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculatorLib;
//использование атрибутов Test
using System;

namespace MyCalculatorLib.Tests
{
    [TestClass]
    public class MyCalculatorTests
    {
        [TestMethod]
        public void Sum_10and20_30return()
        {
            //arrange - задание начальных данных
            double x = 10;
            double y = 20;
            double expected = 30;

            //act - выполнение
            MyCalc myCalc = new MyCalc(x);
            double actual = myCalc.Sum(y);

            //assert - проверка выполнения
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Div_10and2_return5()
        {
            //arrange - задание начальных данных
            double x = 10;
            double y = 2;
            double expected = 5;

            //act - выполнение
            MyCalc myCalc = new MyCalc(x);
            var actual = myCalc.Div(y);

            //assert - проверка выполнения
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Div_20and0_returnExictance()
        {
            //arrange
            double x = 20;
            double y = 0;
            Exception except = null;

            //act
            try
            {
                MyCalc myCalc = new MyCalc(x);
                double actual = myCalc.Div(y);
            }
            catch (Exception ex) { except = ex; }

            //assert
            Assert.IsNotNull(except);
        }
        [TestMethod]
        public void Sqrt_10_return3_16()
        {
            double x = 10;
            double expected = Math.Sqrt(x);

            MyCalc myCalc = new MyCalc(x);
            double actual = myCalc.Sqrt();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sqrt_Negatve10_returnException()
        {
            double x = -10;
            Exception expected = null;

            try
            {
                MyCalc myCalc = new MyCalc(x);
                myCalc.Sqrt();
            }
            catch (Exception ex) { expected = ex; }

            Assert.IsNotNull(expected);
        }
        [TestMethod]
        public void PerimetrTriagle_10and8and7_return25()
        {
            double a = 10;
            double b = 8;
            double c = 7;
            double expected = 25;

            MyCalc myCalc = new MyCalc(0);
            double actual = myCalc.PerimetrTriagle(a, b, c);

            Assert.AreEqual(expected, actual);
                
        }
    }
}

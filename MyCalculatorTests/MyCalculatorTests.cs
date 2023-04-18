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
            double x = 10;
            double y = 2;
            double expected = 5;

            MyCalc myCalc = new MyCalc(x);
            var actual = myCalc.Div(y);

            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void Div_20and0_returnExictance()
        //{
        //    double x = 20;
        //    double y = 0;
        //    DivideByZeroException expected = new DivideByZeroException();

        //    MyCalc myCalc = new MyCalc(x);


        //    Assert.AreEqual(expected, myCalc.Div(y));
        //}
        [TestMethod]
        public void Sqrt_10_return()
        {
            double x = 10;
            double expected = Math.Sqrt(x);

            MyCalc myCalc = new MyCalc(x);
            double actual = myCalc.Sqrt();

            Assert.AreEqual(expected, actual);

        }
        //[TestMethod]
        //public void Sqrt_Negatve10_returnException()
        //{
        //    double x = -10;
        //    Exception expected = new Exception();

        //    MyCalc myCalc = new MyCalc(x);
        //    double actual = myCalc.Sqrt();

            
        //}
    }
}

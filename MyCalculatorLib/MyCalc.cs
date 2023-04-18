using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculatorLib
{

    public class MyCalc
    {
        public double Value { get; private set; }

        public MyCalc(double value)
        {
            Value = value;
        }
        public double Sum(double x)
        {
            Value += x;
            return Value;
        }
        public double Sub(double x)
        {
            Value -= x;
            return Value;
        }
        public double Div(double x)
        {
            try
            {
                Value /= x;
                return Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public double Multi(double x)
        {
            Value *= x;
            return Value;
        }
        public double Sqrt(int round)
        {
            try
            {
                return Math.Round(Math.Sqrt(Value), round);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public double SquareCircle(double x)
        {
            try
            {
                return x * x * Math.PI;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public double PerimetrTriagle(double a, double b, double c)
        {
            Exception ex = null;
            try
            {
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    throw ex = new Exception("NegativeNumber");
                }
                else if (a + b <= c || a + c <= b || b + c <= a)
                {
                    throw ex = new Exception("Check");
                }
                else
                {
                    return a + b + c;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            
        }
        public void Reset()
        {
            Value = 0;
        }
    }
}

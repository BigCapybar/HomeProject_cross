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
            if (x == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                Value /= x;
                return Value;
            }

        }
        public double Multi(double x)
        {
            Value *= x;
            return Value;
        }
        public double Sqrt()
        {
            if (Value < 0)
                throw new Exception("NegativeNumber");
            else
                return Math.Sqrt(Value);
        }



    }
}

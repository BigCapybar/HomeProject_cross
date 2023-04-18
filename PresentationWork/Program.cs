using MyCalculatorLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCalc myCalc = new MyCalc(20);
            Console.WriteLine(myCalc.Sqrt(4));
            Console.WriteLine(myCalc.Div(5));
            Console.WriteLine(myCalc.PerimetrTriagle(5,10,8));
            Console.ReadLine();
        }
    }
}

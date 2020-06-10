using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSwigCallback
{
    internal class MyCSharpCalc : MyCalc
    {
        public MyCSharpCalc() : base()
        {
        }

        public override int add(int arg0, int arg1)
        {
            return arg0 + arg1;
        }

        public override int Mul(int arg0, int arg1)
        {
            return arg0 * arg1;
        }

        public override void Print(string arg0)
        {
            Console.WriteLine(arg0 + " ::::printed from c# :D");
        }
    }
}
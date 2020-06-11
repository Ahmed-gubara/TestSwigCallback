using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSwigCallback
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("begin");
                MyCalc x = new MyCSharpCalc();
                var r = new Result();
                x.DoMath(1, 2, r);
                Console.WriteLine(r.addResult.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("exception " + e.ToString());
            }
            finally
            {
                Console.WriteLine("end");
                Console.ReadKey(false);
            }
        }
    }
}
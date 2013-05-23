using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using acmp_0008_Arithmetic;

namespace UsageArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            int c = 30;
            System.Console.WriteLine("a = {0}", a);
            System.Console.WriteLine("a = {0}", b);
            System.Console.WriteLine("a = {0}", c);

            Arithmetic arith = new Arithmetic();
            System.Console.WriteLine("result = {0}", arith.arithmetic(a, b, c));

            System.Console.WriteLine();
            a = 5;
            b = 6;
            c = 10;
            System.Console.WriteLine("a = {0}", a);
            System.Console.WriteLine("a = {0}", b);
            System.Console.WriteLine("a = {0}", c);

            System.Console.WriteLine("result = {0}", arith.arithmetic(a, b, c));
        }
    }
}

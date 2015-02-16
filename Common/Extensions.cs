using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class Extensions
    {
        public static void Print(this object obj)
        {
            Console.WriteLine(obj);
        }

        public static void P(this object obj)
        {
            obj.Print();
        }

        public static void PrintFormat(this string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }

        public static void PF(this string format, params object[] args)
        {
            format.PrintFormat(args);
        }

        public static void Wait()
        {
            Console.ReadKey();
        }

        public static void Border()
        {
            "---------------------------------------------------------".P();
        }
    }
}

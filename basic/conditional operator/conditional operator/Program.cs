using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age ;
            Console.Write("enter your age : ");
            age=Convert.ToInt32(Console.ReadLine());
            if (age >= 0)
            {
                Console.WriteLine("valid age");
            }
            else {
                Console.WriteLine("invalid age");
            }
            string result = age >= 0 ? "valid" : "invalid";
            Console.WriteLine(result);
        }
    }
}

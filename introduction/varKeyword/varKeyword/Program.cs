using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var datatype compiler will figure out the data type based on the value we initialized
            var age = 10;//int32
            Console.WriteLine(age);

            var bigNumber = 90000000L;//int64
            Console.WriteLine(bigNumber);

            var negative = -55.2D;//double
            Console.WriteLine(negative);

            var precision = 3.1416F;//float
            Console.WriteLine(precision);

            var money = 24.99M;//decimal
            Console.WriteLine(money);

            var name = "partho";
            Console.WriteLine(name);

            var letter = 'a';
            Console.WriteLine(letter);
        }
    }
}

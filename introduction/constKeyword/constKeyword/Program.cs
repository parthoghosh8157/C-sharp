using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vat = 20;
            vat = 10;
            const int fixedvat = 20;
            //fixedvat=10;//this will give error beacuse contant value can not change
            Console.WriteLine(vat);
            Console.WriteLine(fixedvat);
            //program to calculate total price with vat
            decimal price;
            Console.Write("Price of the Product :");
            price =Convert.ToDecimal(Console.ReadLine());
            Console.Write("total price is :");
            Console.WriteLine(price+(price*(fixedvat/100m)));

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            while (a < 10)
            {
                Console.Write(a+" ");
                a++;
            }
            Console.WriteLine();
            a= 1;
            do
            {
                Console.Write(a+" ");
                a++;
            }while (a < 10);
        }
    }
}

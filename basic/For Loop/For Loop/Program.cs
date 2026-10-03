using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= num; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("How many time you want me to say i love you: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i+" I love you");
                
            }
        }
    }
}

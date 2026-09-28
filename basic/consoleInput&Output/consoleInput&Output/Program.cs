using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleInput_Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello My Name is Gobindo Chandra Ghosh");
            Console.Write("Enter Your Name : ");
            String name=Console.ReadLine();
            Console.Write("what is your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("So, you are " + name + " and you are " + age + " years old");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello My Name is Gobindo Chandra Ghosh");

            Console.Write("Enter Your Name : ");
            String name = Console.ReadLine();

            Console.Write("what is your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("So, you are " + name + " and you are " + age + " years old");
            if(age < 0 || age>150)
            {
                Console.WriteLine(" but your age seems invalid");
            }
            else
            {
                if (age >= 18 && age < 60)
                {
                    Console.WriteLine(" You are adult");
                }
                else if (age >= 60)
                {
                    Console.WriteLine(" you are old ");
                }
            }
            Console.Write("Enter the first number: ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            int answer = numberA * numberB;

            Console.Write("value of "+numberA+"*"+numberB+": ");
            int finalAnswere = Convert.ToInt32(Console.ReadLine());
            if(answer == finalAnswere)
            {
                Console.WriteLine("well done");
            }
            else
            {
                Console.WriteLine("your answer is not correct ");
            }
        }
    }
}

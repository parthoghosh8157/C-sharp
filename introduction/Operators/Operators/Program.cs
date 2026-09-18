using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 21;
            age++;//increment age by 1(equivalent operation are "age=age+1" and "age+=1")
            Console.WriteLine(age);
            age--;//decriment age by 1(equivalent operation are "age=age-1" and "age-=1")
            Console.WriteLine(age);
            age *= 2;//multiplication operatiopn(equivalent operation is "age=age*2")
            Console.WriteLine(age);
            age /= 2;//division operatiopn(equivalent operation is "age=age/2") note : for intiger datatype it ignore fraction values after division.
            Console.WriteLine(age);

            string name = "partho";
            name += " ghosh.";//name-=" ghosh" is not posible
            Console.WriteLine(name);

            char ch = 'a';
            ch += 'b';//add two ascii values of 'a' and 'b' and store the equivalent latter into ch.
            Console.WriteLine(ch);
            Console.WriteLine();
            Console.WriteLine();
            //incriment and decrement operator 
            int number = 10;
            Console.WriteLine(number);//actual number
            Console.WriteLine(number++);//after post increment
            Console.WriteLine(number--);//after post decrement
            Console.WriteLine(++number);//after pre increment
            Console.WriteLine(--number);//after pre decrement
        }
    }
}

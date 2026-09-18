using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covertionBetweenStringAndNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textAge = "21";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textBigNumber = "-9000000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);

            string textNegative = "-55.2";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);
            String textPrecition = "5.000001";
            float precition = Convert.ToSingle(textPrecition);
            Console.WriteLine(precition);

            String textMoney = "14.99";
            decimal money =Convert.ToDecimal(textMoney);
            Console.WriteLine(money);
        }
    }
}

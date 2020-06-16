using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Step156
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n                                                        Math App 3\n=======================================================================================================================");
            Console.WriteLine("Enter a number:");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number if you'd like or press enter:");
            string userNum2 = Console.ReadLine();

            if (String.IsNullOrEmpty(userNum2))
            {
                int result = Class1.Method(userNum1);
                Console.WriteLine(userNum1 + " x 4 = " + result);
            }
            else
            {
                int convertInput2 = Convert.ToInt32(userNum2);
                int result = Class1.Method(userNum1, convertInput2);
                Console.WriteLine("(" + userNum1 + " + " + convertInput2 + ") x 4 = " + result);
            }

            Console.ReadLine();
        }
    }
}

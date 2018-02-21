using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)

        {
            int number1, number2;

            Console.WriteLine("Please enter a number:");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Thank you. One more:");
            number2 = int.Parse(Console.ReadLine());


            int sum = number1 + number2;

            if(sum<=10)
            {
                Console.WriteLine("Adding the two numbers result is less than 10 " );

            }

           else if (sum > 10 && sum<=20)
            {
                Console.WriteLine("Adding the two numbers result is less than 20 ");

            }

            else
            {
                Console.WriteLine("Adding the two numbers result is greater than 20 ");

            }
            Console.ReadLine();


        }
    }
}

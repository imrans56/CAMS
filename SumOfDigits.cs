using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    // To get the Sum of Digits of the given Number 
    internal class SumOfDigits
    {

        
        public void GetSumOfDigits()
        {
            // To give the Directions to the user in Console
            Console.WriteLine("Enter the Number");

            // To get the number from the Console and to convert string into int
          int number = Convert.ToInt32(Console.ReadLine());
          //String name= Console.ReadLine();
            int Temp = number;
            int sum = 0;

            while (Temp > 0)
            {

                sum = sum + Temp % 10;
                Temp = Temp / 10;

            }

            Console.WriteLine("Total Sum of the Number " + number + " is " + sum);

        }

    }
}

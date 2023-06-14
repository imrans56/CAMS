using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    internal class FactorialOfNumber
    {

        public void Factorial() {
            int i, fact = 1, number;
            Console.WriteLine("Enter The Number for Factorial");
           

             number = Convert.ToInt32(Console.ReadLine()); 
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Factorial of given number " + number + " is " + fact);

        }
    }
}

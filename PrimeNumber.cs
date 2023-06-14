using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    internal class PrimeNumber
    {
        List<int> result = new List<int>();
       
        public List<int> GetePrimeNumbersTillN() {
            Console.WriteLine("Enter the number to get Prime Numbers");
            int number = Convert.ToInt32(Console.ReadLine());
            int count=0;
            
            
               
            for (int i = 2; i <= number; i++)
                {
                // using loop2 to check whether given number is divisible by the numbers
                // from 2 to n-1.
                for (int j = 2; j <= i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        if (count > 0)
                            break;

                    }
                }
                // if given count is 0 then it is prime number else it is not prime number
                if (count == 0) 
                { result.Add(i); 
                }
                else
                { count = 0; }
            }
            return result;
        }


    }
}

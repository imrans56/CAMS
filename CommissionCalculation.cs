using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    internal class CommissionCalculation
    {
        // Declaring The Properties for Monthly Sale
        public int FirstMonthSale { get; set; }
        public int SecondMonthSale { get; set; }
        public int ThirdMonthSale { get; set; }
        // Default monthly commission rate is 3%

        public int MonthlyCommission { get; set; } = 3; 
        public int QuarterTotalSale { get; set; }


        // function to get Input from User Side.
        public int GetInput()
        {




            // Taking the Data from the Input and Converting it.
            // Changing Data type from String to Int32

            Console.WriteLine("Enter first month sales: ");
            FirstMonthSale = Convert.ToInt32(Console.ReadLine());

           
            Console.WriteLine("Enter second month sales: ");
            SecondMonthSale = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter Third month sales: ");
            ThirdMonthSale = Convert.ToInt32(Console.ReadLine());



            // 3 Month total sales is sum of all 3 month sales
            QuarterTotalSale = FirstMonthSale + SecondMonthSale + ThirdMonthSale;

            return QuarterTotalSale;
        }
        public int GetMonthlyComission()



        {
            int total3Monthsale = GetInput();
            if (FirstMonthSale > 5000 && SecondMonthSale > 5000 && ThirdMonthSale > 5000)
            {
                return (total3Monthsale * MonthlyCommission) / 100;
            }
            else
            {
                return 0;
            }
        }

        public int GetQuarterlyComission()
        {

            // If the total sales for the quarter is greater than or equal to 20000, the commission is 12% of the total sales.

            if (QuarterTotalSale >= 20000)
            {
                return (QuarterTotalSale * 12) / 100;
            }
            
            // If the total sales for the quarter is between 15000 and 20000, the commission is 10% of the total sales.

            else if (QuarterTotalSale >= 15000 && QuarterTotalSale < 20000)
            {
                return (QuarterTotalSale * 10) / 100;
            }
            // If the total sales for the quarter is between 10000 and 15000, the commission is 5% of the total sales.



            else if (QuarterTotalSale >= 10000 && QuarterTotalSale < 15000)
            {
                return (QuarterTotalSale * 5) / 100;
            }
            // If the total sales for the quarter is less than 10000, there is no commission.



            else if (QuarterTotalSale < 10000)
            {
                return (QuarterTotalSale * 0) / 100;
            }
            else
            {
                return 0;
            }
        }

        public int GetTotalComission()
        {



            // This method calculates the total commission by calling the GetMonthlyComission() and GetQuarterlyComission() methods
            int MonthlyComission = GetMonthlyComission();
            int QuarterlyComission = GetQuarterlyComission();



            // It then prints the monthly and quarterly commission amounts to the console
            Console.WriteLine("Monthly Commission: " + MonthlyComission);
            Console.WriteLine("Quarterly Commission: " + QuarterlyComission);



            // Finally, it returns the sum of monthly and quarterly commission
            return MonthlyComission + QuarterlyComission;
        }



    }
}

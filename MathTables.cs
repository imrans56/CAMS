using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    // Writing codes for creating Math Tables till 12
    internal class MathTables
    {
        public ArrayList PrintTables()
        {

            
            ArrayList arrayList = new ArrayList();
            Console.WriteLine("Enter Number to Print the Table");
            int number = Convert.ToInt32(Console.ReadLine());
            

            for(int i=1; i<=12; i++) {
                // Console.WriteLine(i + "*" + number + " = " + (i * number));

                arrayList.Add(i + "*" + number + " = " + (i * number));
            }

            return arrayList;

        }

    }
}

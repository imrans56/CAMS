using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{

    // To check whether the given String is Palindrome or not
    internal class Palindrome
    {
        public string CheckPalindrome() {


            Console.WriteLine("Enter a String to check");

            // Taking the Input from the Console
            string str= Console.ReadLine();
            string reverse = "";
            
            // Writing logic to check the given String is Palindrome or not
            for (int i = str.Length - 1; i>=0;  i--) //String Reverse  
            
            {
                reverse = reverse+ str[i];
            }

            if(str.Equals(reverse))
            {
                // Console.WriteLine("Given String "+ str+" is Palindrome");
                return "Given String " + str + " is Palindrome";
            }
            else {

               // Console.WriteLine("Given String "+str+" is Not Palindrome");
               return "Given String "+str+" is Not Palindrome";
            }
        }
    }
}

// See https://aka.ms/new-console-template for more information
using Assignment01;
using System.Collections;

Console.WriteLine("Welcome !");

CommissionCalculation commission = new CommissionCalculation();
commission.GetTotalComission();

SumOfDigits sum=new SumOfDigits();
sum.GetSumOfDigits();



FactorialOfNumber fact=new FactorialOfNumber();
fact.Factorial();


Palindrome palindrome=new Palindrome();
//Console.WriteLine(palindrome.CheckPalindrome());



MathTables math= new MathTables();
ArrayList arrayList= math.PrintTables();
foreach(string i in arrayList)
{
    Console.WriteLine(i);
}


PrimeNumber p2 = new PrimeNumber();
//Console.WriteLine(p2.GetePrimeNumbersTillN(10));

List<int> list = p2.GetePrimeNumbersTillN();
Console.WriteLine("Prime Number");
foreach (int i in list)
{
    Console.Write(i + " ");
}
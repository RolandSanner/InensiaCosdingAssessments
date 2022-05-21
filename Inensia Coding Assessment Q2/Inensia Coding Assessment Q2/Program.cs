using System;

namespace Inensia_Coding_Assessment_Q2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input Gross Salary : ");
            double Salary = double.Parse(Console.ReadLine());
            double tax;
            double SocialContributions;
            double NetSalary;
            if (Salary <= 1000)
            {
                NetSalary = 1 * Salary;
            }
            else if (Salary > 1000 && Salary < 3000)
            {
                SocialContributions = .15 * (Salary - 1000);
                tax = .10 * (Salary - 1000);
                NetSalary = Salary - (tax + SocialContributions);

            }  else if (Salary > 1000 && Salary > 3000)
            {
                SocialContributions = .15 * 2000; // since this checkss to see if the salary is over 3000, we can simply multiply the SocialContributions tax by 2000.
                tax = .10 * (Salary - 1000);
                NetSalary = Salary - (tax + SocialContributions);
            } else
            {
                NetSalary = Salary;
            }


            Console.WriteLine("Net salary is {0:C}", NetSalary);
            Console.ReadKey();
        }
    }
}

// Simple ways to implement more taxes would be to create static classes that will always be applied,
// I could also make a form that allows the programmer to add as many new taxes as they would like.
// Given more time You could easily create a Calculator app that is customizable to the users needs.

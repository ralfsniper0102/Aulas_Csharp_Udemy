using System;
using UpcastingDowncasting.Entities;

namespace UpcastingDowncasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(500.0, 1002, "Maria", 0.0);

            //UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(200.0, 1003, "Bob",0.0);
            Account acc3 = new BusinessAccount(0.01, 1004, "Anna", 0.0);


            //DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0); 

            if (acc3 is BusinessAccount) //// teste para 
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
            }

            Console.WriteLine("Hello World!");
        }
    }
}

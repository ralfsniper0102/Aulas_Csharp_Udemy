using System;
using UpcastingDowncasting.Entities;

namespace OverlapVirtualOverrideBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(2132,"Rafael", 10000);
            Account acc2 = new BusinessAccount(10000, 32324, "Rebeca", 10000);

            acc1.Withdraw(10);
            acc2.Withdraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}

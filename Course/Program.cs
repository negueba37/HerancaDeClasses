using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bobo ", 100.00, 2000);
            account.Balance = 200;
            Console.WriteLine(account.Balance);
        }
    }
}

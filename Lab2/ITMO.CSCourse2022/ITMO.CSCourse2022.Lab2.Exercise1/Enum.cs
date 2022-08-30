using System;


namespace ITMO.CSCourse2022.Lab2.Exercise1
{
    enum AccountType { Cheking, Deposit }
    class Enum
    {
        static void Main()
        {
            AccountType goldAccount = AccountType.Cheking;
            AccountType platinumAccount = AccountType.Deposit;

            Console.WriteLine("The Customer Account Type is {0}", goldAccount);
            Console.WriteLine("The Customer Account Type is {0}", platinumAccount);

        }
    }
}

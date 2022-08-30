using System;


namespace ITMO.CSCourse2022.Lab2.Exercise2
{
    public enum AccountType { Cheking, Deposit }
    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    }
    class Struct
    {
        
        static void Main()
        {
            BankAccount goldAccount;

            goldAccount.accNo = 123;
            goldAccount.accType = AccountType.Cheking;
            goldAccount.accBal = (decimal)3200.00;


            Console.WriteLine("***Account Summary***");
            Console.WriteLine("Acct Number {0}", goldAccount.accNo);
            Console.WriteLine("Acct Type {0}", goldAccount.accType);
            Console.WriteLine("Acct Balance $ {0}", goldAccount.accBal);
            Console.ReadLine();
        }
    }
}

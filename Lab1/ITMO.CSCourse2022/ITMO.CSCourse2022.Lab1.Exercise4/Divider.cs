using System;


namespace ITMO.CSCourse2022.Lab1.Exercise4
{
    internal class Divider
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the first integer");
                string temp = Console.ReadLine();
                int i = Int32.Parse(temp);

                Console.WriteLine("Please enter the second integer");
                temp = Console.ReadLine();
                int j = Int32.Parse(temp);

                int k = i / j;
                Console.WriteLine("Result of deviding {0} by {1} is {2}", i, j, k);

            }
            catch (Exception ex)
            {
                Console.WriteLine("An exeption was thrown: {0}", ex);
            }
            Console.Read();
        }
    }
}

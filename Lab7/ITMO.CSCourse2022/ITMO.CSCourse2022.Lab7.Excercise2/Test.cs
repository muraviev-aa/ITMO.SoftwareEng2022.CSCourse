using System;
namespace Utils
{
    public class Test
    {
        public static void Main()
        {
            string message;
            Console.WriteLine("Enter string to revers: ");
            message = Console.ReadLine();

            Utils.Revers(ref message);

            Console.WriteLine(message);

        }
    }
}


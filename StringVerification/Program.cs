using System;
using System.Text.RegularExpressions;

namespace StringVerification
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString, myRegularExpression;
            bool matchState = true;

            do 
            {
                Console.WriteLine("The default regular expression checks for at least one digit. ");
                Console.Write("Enter a refular expression (or press ENTER to use the default): ");
                myRegularExpression = Console.ReadLine();
                var strChecker = new Regex(@myRegularExpression);
                Console.Write("Enter some input: ");
                myString = Console.ReadLine();
                matchState = strChecker.IsMatch(myString);
                Console.WriteLine("{0} matches {1}? {2}", myString, myRegularExpression, matchState.ToString());
                Console.WriteLine("Press ESC to terminate program or press any other key to try again. ");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}

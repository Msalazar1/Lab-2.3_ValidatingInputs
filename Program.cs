using System;
using System.Text.RegularExpressions;

namespace ValidatingInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your First Name:");
            String entryName = Console.ReadLine();
            Regex reg = new Regex(@"^[A-Z]+[a-z]{1,30}$");
            bool matched = reg.IsMatch(entryName);
            //Console.WriteLine(matched);

            if (matched == false)
                Console.WriteLine("Invalid naming convention. Please capitalize the first letter of your name.  Try again.");
            else if (matched == true)
                Console.WriteLine("That is a valid name!");

            Console.WriteLine("Please enter a valid email address:");
            string entryEmail = Console.ReadLine();
            Regex reg2 = new Regex(@"^([\w]{5,30})@([\w]{5,10})((\.(\w){2,3}))$");
            bool matched2 = reg2.IsMatch(entryEmail);
            //Console.WriteLine(matched2);

            if (matched2 == false)
                Console.WriteLine("Invalid email address. Try again.");
            else if (matched2 == true)
            Console.WriteLine("This is a valid email address!");

            Console.WriteLine("Please enter a valid phone number using the following convention XXX-XXX-XXXX:");
            string entryNumber = Console.ReadLine();
            Regex reg3 = new Regex(@"^([0-9]{3})+\-([0-9]{3})+\-([0-9]{4})$");
            bool matched3 = reg3.IsMatch(entryNumber);
            //Console.WriteLine(matched3);

            if (matched3 == false)
                Console.WriteLine("Invalid number. Try again.");
            else if (matched3 == true)
            Console.WriteLine("This is a valid phone number!");

            Console.WriteLine("Please enter a Date using the convention dd/mm/yyyy:");
            string entryDate = Console.ReadLine();
            Regex reg4 = new Regex(@"^([0-9]{2})\/([0-9]{2})\/([0-9]{4})$");
            bool matched4 = reg4.IsMatch(entryDate);
            //Console.WriteLine(matched4);

            if (matched4 == false)
                Console.WriteLine("Invalid Date. Try again.");
            else if (matched4 == true)
                Console.WriteLine("This is a valid Date!");




        }

    }
}

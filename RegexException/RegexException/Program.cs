using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexException
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //UC1
            Validation person = new Validation();
            Console.WriteLine("Enter The First Name: ");
            string firstName = Console.ReadLine();
            person.ValidateFirstName(firstName);

            //UC2
            Console.WriteLine("-------------------------");
            Console.WriteLine("Enter The Last Name: ");
            string lastName = Console.ReadLine();
            person.ValidateLastName(lastName);

            //UC3
            Console.WriteLine("-------------------------");
            Console.WriteLine("Enter The Email_ID: ");
            string EmailID = Console.ReadLine();
            person.ValidateEmail(EmailID);

            //UC4
            Console.WriteLine("-------------------------");
            Console.WriteLine("Enter The Phone_Number: ");
            string Phone_Number = Console.ReadLine();
            person.ValidatePhoneNumber(Phone_Number);

            //UC5
            Console.WriteLine("-------------------------");
            Console.WriteLine("Enter The Password: ");
            string password = Console.ReadLine();
            person.Validate_Password_RuleOne(password);

            //UC6
            Console.WriteLine("-------------------------");
            Console.WriteLine("Enter The Password: ");
            string passwordTwo = Console.ReadLine();
            person.Validate_Password_RuleOne(passwordTwo);

            //UC7
            Console.WriteLine("-------------------------");
            Console.WriteLine("Enter The Password: ");
            string passwordThree = Console.ReadLine();
            person.Validate_Password_RuleOne(passwordThree);

            //UC8
            Console.WriteLine("-------------------------");
            Console.WriteLine("Enter The Password: ");
            string passwordFour = Console.ReadLine();
            person.Validate_Password_RuleOne(passwordFour);
        }
    }
}
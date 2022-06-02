using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexException
{
    public class Validation
    {
        public string FirstName = ("^[A-Z]{1}[A-Za-z]{3,}$");
        public string LastName = ("^[A-Z]{1}[A-Za-z]{3,}$");
        public string Email = ("^[A-Za-z]{3,}@[a-z]{3,}.[a-z]{3,}$");
        public string ValidateFirstName(string firstNamevalid)
        {
            Regex regex = new Regex(FirstName);
            try
            {
                if (regex.IsMatch(firstNamevalid))
                {
                    return "FirstName is Valid";
                }
                else
                {
                    throw new CustomException(CustomException.Exceptiontype.FirstName, "First Name is InValid");
                }
            }
            catch
            {
                throw new CustomException(CustomException.Exceptiontype.FirstName, "First Name is InValid");
            }
        }
        public string ValidateLastName(string lastNamevalid)
        {
            Regex regex = new Regex(LastName);
            try
            {
                if (regex.IsMatch(lastNamevalid))
                {
                    return "LastName is Valid";
                }
                else
                {
                    throw new CustomException(CustomException.Exceptiontype.LastName, "Last Name is InValid");
                }
            }
            catch
            {
                throw new CustomException(CustomException.Exceptiontype.LastName, "Last Name is InValid");
            }
        }
        public string ValidateEmail(string emailvalid)
        {
            Regex regex = new Regex(Email);
            try
            {
                if (regex.IsMatch(emailvalid))
                {
                    return "Email is Valid";
                }
                else
                {
                    throw new CustomException(CustomException.Exceptiontype.Email, "Email ID is InValid");
                }
            }
            catch
            {
                throw new CustomException(CustomException.Exceptiontype.Email, "Email ID is InValid");
            }

        }
    }
}
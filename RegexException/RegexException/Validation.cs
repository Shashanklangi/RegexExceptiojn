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
        public string PhoneNumber = ("^[A-Za-z]{3,}@[a-z]{3,}.[a-z]{3,}$");
        public string PassWordRuleOne = ("^[A-z0-9a-z@#&*+]{8,}$");
        public string PassWordRuleTwo = ("^[A-Z]{1,}[A-z0-9a-z@#&*+]{8,}$");
        public string PassWordRuleThree = ("^[A-Z]{1,}[0-9A-Za-z!@#$%^&*-]{6,}[0-9]{1,}$");
        public string PassWordRuleFour = ("^[A-Z]{1,}[A-Za-z0-9]{5,}[!@#$%^&*+]{1}[0-9]{1,}$");
        public string allEmails = ("^[A-Za-z0-9]+([.+_-]?[A-Za-z0-9])*@[A-Za-z0-9]+.([c]{1}[o]{1}[m]{1})*([n]{1}[e]{1}[t]{1})*[,]*([.][a]{1}[u]{1})*([.][c]{1}[o]{1}[m]{1})*$");

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
        public string ValidatePhoneNumber(string phonenumber)
        {
            Regex regex = new Regex(PhoneNumber);
            try
            {
                if (regex.IsMatch(phonenumber))
                {
                    return "PhoneNumber is Valid";
                }
                else
                {
                    throw new CustomException(CustomException.Exceptiontype.PhoneNumber, "PhoneNumber is InValid");
                }
            }
            catch
            {
                throw new CustomException(CustomException.Exceptiontype.PhoneNumber, "PhoneNumber is InValid");
            }
        }
        public string Validate_Password_RuleOne(string password)
        {
            Regex regex = new Regex(PassWordRuleOne);
            try
            {
                if (regex.IsMatch(PassWordRuleOne))
                {
                    return "Password is Valid";
                }
                else
                {
                    throw new CustomException(CustomException.Exceptiontype.Password, "Password is InValid");
                }
            }
            catch
            {
                throw new CustomException(CustomException.Exceptiontype.Password, "Password is InValid");
            }
        }
        public string Validate_Password_RuleTwo(string passwordTwo)
        {
            Regex regex = new Regex(PassWordRuleTwo);
            try
            {
                if (regex.IsMatch(PassWordRuleTwo))
                {
                    return "Password is Valid";
                }
                else
                {
                    throw new CustomException(CustomException.Exceptiontype.Password, "Password is InValid");
                }
            }
            catch
            {
                throw new CustomException(CustomException.Exceptiontype.Password, "Password is InValid");
            }
        }
        public string Validate_Password_RuleThree(string passwordThree)
        {
            Regex regex = new Regex(PassWordRuleThree);
            try
            {
                if (regex.IsMatch(PassWordRuleThree))
                {
                    return "Password is Valid";
                }
                else
                {
                    throw new CustomException(CustomException.Exceptiontype.Password, "Password is InValid");
                }
            }
            catch
            {
                throw new CustomException(CustomException.Exceptiontype.Password, "Password is InValid");
            }
        }
        public string Validate_Password_RuleFour(string passwordfour)
        {
            Regex regex = new Regex(PassWordRuleFour);
            try
            {
                if (regex.IsMatch(PassWordRuleFour))
                {
                    return "Password is Valid";
                }
                else
                {
                    throw new CustomException(CustomException.Exceptiontype.Password, "Password is InValid");
                }
            }
            catch
            {
                throw new CustomException(CustomException.Exceptiontype.Password, "Password is InValid");
            }
        }
        public string Validate_All_Emails(string allemails)
        {
            Regex regex = new Regex(allEmails);
            try
            {
                if (regex.IsMatch(allEmails))
                {
                    return "Email is Valid";
                }
                else
                {
                    throw new CustomException(CustomException.Exceptiontype.Email, "Email is InValid");
                }
            }
            catch
            {
                throw new CustomException(CustomException.Exceptiontype.Email, "Email is InValid");
            }
        }
    }
}
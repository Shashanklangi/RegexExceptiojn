using NUnit.Framework;
using RegexException;

namespace UnitTest1
{
    public class Tests
    {
        Validation person;
        [SetUp]
        public void Setup()
        {
            person = new Validation();
        }

        [Test]
        public void Validating_Firstname()
        {
            //Arrange
            string firstname = " ";
            string expected = "First Name is InValid";
            try
            {
                person.ValidateFirstName(firstname);
            }
            catch (CustomException exception)
            {
                Assert.AreEqual(expected,exception.Message);
            }
        }
        [Test]
        public void Validating_Lastname()
        {
            //Arrange
            string lastname = " ";
            string expected = "Last Name is InValid";
            try
            {
                person.ValidateLastName(lastname);
            }
            catch (CustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}
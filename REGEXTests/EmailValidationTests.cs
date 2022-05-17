using Microsoft.VisualStudio.TestTools.UnitTesting;
using REGEX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REGEX.Tests
{
    [TestClass()]
    public class EmailValidationTests
    {
        [TestMethod()]
        public void EmailIDTest()
        {
            EmailValidation ur1 = new EmailValidation();
            ur1.Email_ID("abc@yahoo.com");
            Assert.AreEqual(true, ur1.Email_ID("abc@yahoo.com"));
        }

        [TestMethod()]
        public void EmailIDTest2()
        {
            EmailValidation ur2 = new EmailValidation();
            ur2.Email_ID("abc-100@yahoo.com");
            Assert.AreEqual(true, ur2.Email_ID("abc-100@yahoo.com"));
        }

        [TestMethod()]
        public void EmailIDTest3()
        {
            EmailValidation ur3 = new EmailValidation();
            ur3.Email_ID("abc.100@yahoo.com");
            Assert.AreEqual(true, ur3.Email_ID("abc.100@yahoo.com"));
        }

        [TestMethod()]
        public void EmailIDTest4()
        {
            EmailValidation ur4 = new EmailValidation();
            ur4.Email_ID("abc111@abc.com");
            Assert.AreEqual(true, ur4.Email_ID("abc111@abc.com"));
        }

        [TestMethod()]
        public void EmailIDTest5()
        {
            EmailValidation ur5 = new EmailValidation();
            ur5.Email_ID("abc-100@abc.net");
            Assert.AreEqual(true, ur5.Email_ID("abc100@abc.net"));
        }

        [TestMethod()]
        public void EmailIDTest6()
        {
            EmailValidation ur6 = new EmailValidation();
            ur6.Email_ID("abc.100@abc.com.au");
            Assert.AreEqual(true, ur6.Email_ID("abc.100@abc.com.au"));
        }

        [TestMethod()]
        public void EmailIDTest7()
        {
            EmailValidation ur7 = new EmailValidation();
            ur7.Email_ID("abc@1.com");
            Assert.AreEqual(true, ur7.Email_ID("abc@1.com"));
        }

        [TestMethod()]
        public void EmailIDTest8()
        {
            EmailValidation ur8 = new EmailValidation();
            ur8.Email_ID("abc@gmail.com.com");
            Assert.AreEqual(true, ur8.Email_ID("abc@gmail.com.com"));
        }

        [TestMethod()]
        public void EmailIDTest9()
        {
            EmailValidation ur9 = new EmailValidation();
            ur9.Email_ID("abc+100@gmail.com");
            Assert.AreEqual(true, ur9.Email_ID("abc+100@gmail.com"));
        }
    }
}
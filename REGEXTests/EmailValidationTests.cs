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
            EmailValidation ur9 = new EmailValidation();
            ur9.Email_ID("abc.100@abc.com.au");
            Assert.AreEqual(true, ur9.Email_ID("abc.100@abc.com.au"));

        }
    }
}
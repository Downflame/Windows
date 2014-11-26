using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TakingNames.BL;

namespace UnitTestProject1
{
    [TestClass]
    public class UserNamePasswordTest
    {
        [TestMethod]
        public void PasswordIsValid()
        {
            UserNamePassword unp = new UserNamePassword();

            unp.password1 = "tes1t";
            unp.password2 = "tes1t";

            string expected = unp.password1;

            string actual = unp.password2;

            Assert.AreEqual( expected, actual);
        }
    }
}

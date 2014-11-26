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

            unp.password1 = "test";
            unp.password2 = "test";

            string expected = "test";

            var actual = unp.ValidatePassword();

            Assert.AreEqual(expected, actual);
        }
    }
}

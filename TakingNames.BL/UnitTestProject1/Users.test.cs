using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TakingNames.BL;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            Users users = new Users();
            users.FirstName = "Fred";
            users.LastName = "Jones";

            string expected = "Jones, Fred";

            string actual = users.FullName;

            Assert.AreEqual(expected, actual);


        }
    }
}

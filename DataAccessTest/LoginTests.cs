using DataAccess;
using NUnit.Framework;

namespace DataAccessTest
{
    public class LoginTests
    {
        [Test]
        public void LoginXml_Test()
        {
            var actual = LoggingService.LoginXml("piotrek", "placki");
            Assert.IsTrue(actual);
        }
    }
}
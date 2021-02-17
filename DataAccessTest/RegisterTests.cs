using ApplicationCore;
using DataAccess;
using NUnit.Framework;

namespace DataAccessTest
{
    public class RegisterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        /*[Test]
        public void RegisterToXml_Test()
        {
            User user = new User()
            {
                Login = "piotrek",
                Password = "placki",
            };
                
            var aktualna = RegisterService.RegisterInXml(user);
            Assert.IsTrue(aktualna);
        }*/
        
        [Test]
        public void IsLoginSameAsRegisteredBefore_Test()
        {
            var aktualna = RegisterService.IsLoginSameAsRegisteredBefore("AlicjaTerazMnieKocha");
            
            Assert.IsTrue(aktualna);
        }
    }
}
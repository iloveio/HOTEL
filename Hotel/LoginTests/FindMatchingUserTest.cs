using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoggingApp;
using HumanResourcesLib;

namespace LoginTests
{
    [TestClass]
    public class FindMatchingUserTest
    {
        [TestMethod]
        public void StartSession_Login_testLogin_password_qwerty123_should_Return_Director()
        {
            UserSession newsession = new UserSession();

            newsession.Login = "testLogin";
            newsession.Password = "qwerty123";

            newsession.StartSession();

            Assert.IsNotNull(newsession.Session);
            Assert.IsInstanceOfType(newsession.Session, typeof(Director));
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void StartSession_wrong_Password_should_throw_nullReference_exception()
        {
            UserSession newsession = new UserSession();

            newsession.Login = "testLogin";
            newsession.Password = "qwerty12";

            newsession.StartSession();

        }
    }
}

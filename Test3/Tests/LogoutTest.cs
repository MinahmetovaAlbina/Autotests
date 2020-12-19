using System.Threading;
using NUnit.Framework;

namespace Test3
{
    [TestFixture]
    public class N5LogoutTest : TestBase
    {
        [Test]
        public void LogoutTest()
        {
            app.Navigate.OpenMenu();
            app.Navigate.OpenSettings();
            Thread.Sleep(5000);
            app.Auth.ClickOnLogoutButton();
            Thread.Sleep(5000);

            Assert.AreEqual("Log in", app.Auth.GetHead1LoginPage());
        }
    }
}

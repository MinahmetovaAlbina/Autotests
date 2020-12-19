using System.Threading;
using NUnit.Framework;

namespace Test3
{
    [TestFixture]
    public class N1LoginTest : TestBase
    {
        [Test]
        public void LogIn()
        {
            var user = new AccauntData("mememe3ka14@gmail.com", "123456789");

            app.Navigate.OpenHomePage();
            app.Auth.EnterEmail(user);
            app.Auth.EnterPassword(user);
            app.Auth.ClickOnLoginButton();
            Thread.Sleep(5000);

            app.Navigate.OpenMenu();
            app.Navigate.OpenSettings();
            var actualLogin = app.Navigate.getAccountLogin();
            app.Navigate.CloseSettings();
            Assert.AreEqual(user.Login, actualLogin);
        }
    }
}

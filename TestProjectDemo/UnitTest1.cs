using NUnit.Framework;
using TestProjectDemo.Driver;
using TestProjectDemo.Page;

namespace TestProjectDemo
{
    public class TestClass
    {
        private LoginPage _loginPage;
        private HomePage _homePage;

        [SetUp]

        public void BeforeScenario()
        {
            WebDrivers.Initialize();
            _loginPage = new LoginPage();
            _homePage = new HomePage();

        }

        [TearDown]
        public void AfterScenario()
        {
            WebDrivers.CleanUp();
        }




        [Test]
        public void TC01_LoginAndFillData()
        {
            Login("ana", "12345");

            _homePage.Country.SendKeys("serbia");
            _homePage.Address.SendKeys("Beograd 22");
            _homePage.EMail.SendKeys("mail@mail.com");
            _homePage.Phone.SendKeys("38112345");
            _homePage.SaveButton.Click();

            Assert.That("Saved",Is.EqualTo(_homePage.SaveText.Text));
        }





        public void Login(string name, string pass)
        {
            _loginPage.LoginOnPage(name, pass);
        }
    }
}
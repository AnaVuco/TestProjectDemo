using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectDemo.Driver;

namespace TestProjectDemo.Page
{
    public class LoginPage

    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement FullName => driver.FindElement(By.Id("name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => driver.FindElement(By.Id("login"));

        public void LoginOnPage(string name, string password)
        {
            FullName.SendKeys(name);
            Password.SendKeys(password);
            LoginButton.Click();
        }
    }

}

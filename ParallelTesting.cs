using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using seleniumC_.BaseClass;
using OpenQA.Selenium.Support.UI;
using seleniumC_.Utilities;
namespace seleniumC_
{
    [TestFixture]
    public class ParallelTesting : BaseTest
    {
        IWebDriver driver;

        [Test, Category("UAT Testing"),Category("Module1")]
        public void TestMethod() {

            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod2()
        {

            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod3()
        {

            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod4()
        {

            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod5()
        {

            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod6()
        {

            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod7()
        {

            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod8()
        {

            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod9()
        {

            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod10()
        {

            var Driver = new BrowserUtility().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();
        }

    }
}

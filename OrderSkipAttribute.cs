using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace seleniumC_
{
    [TestFixture]
    public class OrderSkipAttribute
    {
        [Test, Order(1), Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            Assert.Ignore("defect 12345");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/register/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test, Order(0), Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            // Ścieżka do geckodriver.exe
            string geckoDriverPath = @"C:\Users\Filip\Desktop\geckodriver.exe";

            // Ustawienia Firefox
            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = @"C:\Program Files\Mozilla Firefox\firefox.exe"; // Ścieżka do firefox.exe

            // Utworzenie serwisu geckodriver
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(geckoDriverPath);

            using (IWebDriver driver = new FirefoxDriver(service, options))
            {
                driver.Url = "https://www.facebook.com/register/";
                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
                emailTextField.SendKeys("Selenium C#");
                driver.Close();
            }
        
        //[Test, Category("OrderSkipAttribute")] nie ma explorera
        //public void TestMethod3()
        //{
        //    IWebDriver driver = new InternerExplorerDriver();
        //    driver.Url = "https://www.facebook.com/register/";
        //    IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
        //    emailTextField.SendKeys("Selenium C#");
        //    driver.Close();
        //}
    }
    }
}

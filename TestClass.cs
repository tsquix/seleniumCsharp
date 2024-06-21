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
namespace seleniumC_
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test, Category("Smoke Testing")]
        public void TestMethod() {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            IWebElement monthDropList = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropList);
             //element.SelectByText("March");
            element.SelectByIndex(1);
            element.SelectByValue("7");
            Thread.Sleep(5000);
        }
        [Test, Category("Rehression Testing")]
        public void TestMethod2()
        {

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");

        }
        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(5000);

        }

    }
}

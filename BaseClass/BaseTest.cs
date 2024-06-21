using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumC_.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Open() {

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url="https://www.facebook.com/register/";


        }
        [TearDown]
        public void Close()
        {

            driver.Quit();
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
namespace seleniumC_ {
    [TestFixture]
    public class SeleniumCSharpTutorial04
		{
        [Test]
        [Author("Filip", "stochelf@gmail.com")]
        [Description("facebook login verify")]
        [TestCaseSource("DataDrivenTesting")]
		public void Test1(String urlName)
		{

            IWebDriver driver = null;
            try
            {
                 driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                // driver.Url="https://www.facebook.com/register/";
                driver.Url = urlName;
                 IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
                // IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='abc']"));
                emailTextField.SendKeys("Selenium C#");
                driver.Quit();
            }
            catch(Exception e) 
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\Filip\\source\\repos\\seleniumC#\\Screenshots\\s1.jpeg");//, ScreenshotImageFormat.jpeg
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally 
            {
                if (driver!=null)
                {
                    driver.Quit();
                }
            }
           
        }

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/register/");
            //list.Add("https://www.youtube.com");
            //list.Add("https://www.gmail.com");

            return list;
        }

        //[Test]
        //[Author("Filip", "stochelf@gmail.com")]
        //[Description("facebook login verify")]
        //public void Test2()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Url="https://www.facebook.com/register/";
        //    IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@name='reg_email__']"));
        //    emailTextField.SendKeys("Selenium C#");
        //    driver.Quit();
        //}

    }
}
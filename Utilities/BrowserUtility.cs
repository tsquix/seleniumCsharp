﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumC_.Utilities
{
    public class BrowserUtility
    {
        public IWebDriver Init(IWebDriver driver){

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url="https://www.facebook.com/register/";
            return driver;
        }
    }
}

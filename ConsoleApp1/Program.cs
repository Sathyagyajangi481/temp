﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {




            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://cricket.yahoo.net/";

            driver.Manage().Window.Maximize();












        }
    }
}

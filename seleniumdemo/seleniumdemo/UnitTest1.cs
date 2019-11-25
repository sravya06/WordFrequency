using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace seleniumdemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
                String url = "https://localhost:44347/WebForm1.aspx";
                ChromeDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                driver.FindElement(By.Id("FileUpload1")).SendKeys("C:\\Users\\ssriramoju\\Desktop\\test.txt");
                driver.FindElement(By.Id("TextBox1")).SendKeys("browser");
                driver.FindElement(By.Id("Upload")).Click();

        }
    }
}

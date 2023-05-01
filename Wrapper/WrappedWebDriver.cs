using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Login_Project.Wrapper
{
    internal class WrappedWebDriver
    {
        private readonly IWebDriver _webDriver;

        public WrappedWebDriver(IWebDriver webDriver)
        {
            _webDriver = webDriver;

        }

        public T Wait<T>(Func<IWebDriver, T?> condition)
        {
            
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(15));
            return wait.Until(condition)!;
           
            
        }
        
    }
}

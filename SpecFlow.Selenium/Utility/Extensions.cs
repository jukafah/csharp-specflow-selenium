using System.Diagnostics;
using OpenQA.Selenium;

namespace SpecFlow.Selenium.Utility
{
    public static class Extensions
    {
        public static IWebElement WaitForEnabled(this IWebElement element, int timeSpan = 10000)
        {
           Stopwatch watch = new Stopwatch();
           
           watch.Start();
           while (watch.Elapsed.Milliseconds < timeSpan)
           {
               if (element.Enabled)
                   return element;
           }

           throw new ElementNotInteractableException();
        }
        
        public static IWebElement WaitForVisible(this IWebElement element, int timeSpan = 10000)
        {
            Stopwatch watch = new Stopwatch();
           
            watch.Start();
            while (watch.Elapsed.Milliseconds < timeSpan)
            {
                if (element.Displayed)
                    return element;
            }

            throw new ElementNotVisibleException();
        }
        
        public static IWebElement WaitForText(this IWebElement element, int timeSpan = 10000)
        {
            Stopwatch watch = new Stopwatch();
           
            watch.Start();
            while (watch.Elapsed.Milliseconds < timeSpan)
            {
                if (element.Text.Length > 0)
                    return element;
            }

            throw new ElementNotVisibleException();
        }
        
        public static IWebElement WaitForText(this IWebElement element, string text, int timeSpan = 10000)
        {
            Stopwatch watch = new Stopwatch();
           
            watch.Start();
            while (watch.Elapsed.Seconds < timeSpan)
            {
                if (element.Text == text)
                    return element;
            }

            throw new NoSuchElementException();
        }
    }
}
using System;

namespace HelloSelenium {  
    class Program
    {
        static void Main(string[] args)
        {
            Selenium selenium = new Selenium();
            selenium.loadNordstromWebsite();
        }
    }
}

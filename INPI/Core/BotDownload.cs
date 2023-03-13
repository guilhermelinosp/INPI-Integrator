using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace INPI.Core
{
    internal class BotDownload
    {
        public static string? NumberFile { get; set; }

        public static void Execute()
        {
            string pathDownload = @"C:\developer\INPI Integrator\INPI\Storage\";

            EdgeOptions options = new();

            options.AddUserProfilePreference("download.default_directory", pathDownload);

            using IWebDriver driver = new EdgeDriver(options);

            driver.Navigate().GoToUrl("http://revistas.inpi.gov.br/rpi/");

            IWebElement element = driver.FindElement(By.XPath("/html/body/div[4]/div/table[1]/tbody/tr[2]/td[1]"));

            NumberFile = element.Text;

            Thread.Sleep(1000);

            driver.Navigate().GoToUrl(@"http://revistas.inpi.gov.br/txt/RM" + NumberFile + ".zip");

            Thread.Sleep(3000);

            driver.Navigate().GoToUrl(@"http://revistas.inpi.gov.br/txt/P" + NumberFile + ".zip");

            Thread.Sleep(3000);

            driver.Quit();

            Console.WriteLine("Finished downloading files");
        }
    }
}
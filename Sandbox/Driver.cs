using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Sandbox;

public class Driver
{
    private const string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

    private const string cookieClassName =
        "a-m-de a-aui_72554-c a-aui_accordion_a11y_role_354025-t1 a-aui_killswitch_csa_logger_372963-c a-aui_pci_risk_banner_210084-c a-aui_preload_261698-c a-aui_rel_noreferrer_noopener_309527-c a-aui_template_weblab_cache_333406-c a-aui_tnr_v2_180836-c a-meter-animate";

    private IWebDriver _driver;


    public void OpenBrowser(string url)
    {
        // initialize the driver with the path of google chrome
        _driver = new ChromeDriver(chromePath);
        _driver.Navigate().GoToUrl(url);

        // accept the cookies 
        var cookieButton = _driver.FindElement(By.Id("sp-cc-accept"));
        cookieButton?.Click();
        Console.WriteLine("Conditions has been accepted");

        // add the article in the bracket 
        var addButton = _driver.FindElement(By.Id("add-to-cart-button"));
        addButton?.Click();
        _driver.Close();
        
        // go to the checkout 
        var toCheckout = _driver.FindElement(By.Id("sw-gtc"));
        toCheckout?.Click();
    }
}
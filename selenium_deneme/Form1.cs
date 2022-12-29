//FATÝH MEHMED BÝLGÝN
//CONTACT:mehmedbilgin7@gmail.com
//28-12-2022
//TheHive Version:4.1.24-1

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading.Tasks;
using System.Linq;
using static System.Windows.Forms.Design.AxImporter;

namespace selenium_deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private  void button1_Click(object sender, EventArgs e)
        {
            //hiding command prompt
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            IWebDriver driver = new ChromeDriver(service);
            driver.Navigate().GoToUrl("the_hive_ip:9000/index.html");
            driver.Manage().Window.Size = new System.Drawing.Size(1532, 819);
            driver.FindElement(By.CssSelector(".form-group:nth-child(1) > .form-control")).Click();
            driver.FindElement(By.CssSelector("body > div > div.login-box > div.login-box-body > form > div:nth-child(1) > input")).SendKeys("your_mail");
            driver.FindElement(By.CssSelector(".input")).SendKeys("your_password");
            driver.FindElement(By.CssSelector(".btn")).Click();
            Thread.Sleep(5000);
            IWebElement element;
            IWebElement elements;
            IList<IWebElement> options;
            IWebElement options1;
            int i = 0;
            string[] list;
            while (true)
            {
                //click of alerts window
                driver.FindElement(By.CssSelector("#th-navbar-collapse > ul:nth-child(1) > li:nth-child(4) > a")).Click();
                Thread.Sleep(2000);
                //check for alert
                element = driver.FindElement(By.CssSelector("#th-navbar-collapse > ul:nth-child(1) > li:nth-child(4) > a > span"));
                if (element.Text != "")
                {//importing case and assigning actions

                    //click of alerts window 
                    driver.FindElement(By.CssSelector("#th-navbar-collapse > ul:nth-child(1) > li.active > a")).Click() ;
                    Thread.Sleep(2000);
                    //click of alert preview
                    driver.FindElement(By.CssSelector("body > div > app-container > div > div > ui-view > div > div > div > div.box-body > div:nth-child(4) > div:nth-child(2) > table > tbody:nth-child(2) > tr:nth-child(1) > td.clearfix > div:nth-child(2) > a")).Click();
                    Thread.Sleep(2000);
                    //click of import as empty case button
                    driver.FindElement(By.CssSelector("body > div.modal.fade.in > div > div > div.modal-footer.text-left > form > div > div > span > button")).Click() ;
                    Thread.Sleep(1000);
                    //click of assign action
                    driver.FindElement(By.CssSelector("body > div:nth-child(2) > app-container > div > div > ui-view > div > div.col-md-9 > div:nth-child(2) > div > div.case-page-content > div.row.case-details > div.col-md-8 > dl:nth-child(6) > dd > updatable-user > div > span.updatable-input-value-wrapper")).Click();
                    Thread.Sleep(1000);
                    //click for monitoring assignable users 
                    driver.FindElement(By.CssSelector("body > div:nth-child(2) > app-container > div > div > ui-view > div > div.col-md-9 > div:nth-child(2) > div > div.case-page-content > div.row.case-details > div.col-md-8 > dl:nth-child(6) > dd > updatable-user > div > span:nth-child(2) > div > button.btn.btn-default.btn-sm.dropdown-toggle")).Click();
                    Thread.Sleep(3000);
                    //taking assignable users count
                    elements = driver.FindElement(By.CssSelector("body > div:nth-child(2) > app-container > div > div > ui-view > div > div.col-md-9 > div:nth-child(2) > div > div.case-page-content > div.row.case-details > div.col-md-8 > dl:nth-child(6) > dd > updatable-user > div > span:nth-child(2) > div > ul"));
                    list = elements.Text.Split("\n");
                    //taking users
                    options1 = driver.FindElement(By.CssSelector("body > div:nth-child(2) > app-container > div > div > ui-view > div > div.col-md-9 > div:nth-child(2) > div > div.case-page-content > div.row.case-details > div.col-md-8 > dl:nth-child(6) > dd > updatable-user > div > span:nth-child(2) > div > ul"));
                    options = options1.FindElements(By.TagName("li"));
                    //choosing user and assigning
                    options[i].Click();
                    i++;
                    if (i == list.Length)
                    {
                        i = 0;
                    }
                    Thread.Sleep(1000);
                }
                

            }
            
            
            
        }
    }
}   
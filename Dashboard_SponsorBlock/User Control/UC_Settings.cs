using Dashboard_SponsorBlock.Function;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Threading;
using System.Windows;
using System.Windows.Forms;

namespace Dashboard_SponsorBlock.User_Control
{
    public partial class UC_Settings : UserControl
    {
        public UC_Settings()
        {
            InitializeComponent();

            tbPathSelenium.Enabled = false;
            tbUserID.Enabled = false;
            tbAllSettingSBlock.Enabled = false;
            btChooseFileUserID.Enabled = false;
            btPasteUserID.Enabled = false;
            btChooseFileAllOptions.Enabled = false;
            btPasteAllOptions.Enabled = false;
        }

        private void btSavePage_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFolder("Hãy chọn thư mục bạn muốn lưu file");
        }

        private void btImportPage_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFile();
        }

        private void btChooseRestAllVideo_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFile();
        }

        private void btChooseRestVideonoSBlock_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFile();
        }

        private void btChooseRestVideoyesSBlock_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFile();
        }

        private void btChooseRestSBlocker_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFile();
        }

        private void btChooseFolderSelenium_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFolder("Hãy chọn thư mục muốn lưu trữ profile Selenium");
            tbPathSelenium.Text = Path;
        }

        private void btChooseFileUserID_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFile("Hãy chọn file chứa User ID");
            if (Path != "")
            {
                StreamReader streread = new StreamReader(Path);
                string res = streread.ReadToEnd();
                tbUserID.Text = res;
            }            
        }

        private void btChooseFileAllOptions_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFile("Hãy chọn file chứa toàn bộ cài đặt SponsorBlock");
            if (Path != "")
            {
                StreamReader streread = new StreamReader(Path);
                string res = streread.ReadToEnd();
                tbAllSettingSBlock.Text = res;
            }
        }

        private void btRunSetupSelenium_Click(object sender, System.EventArgs e)
        {
            Thread thr = new Thread(() =>
            {
                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                ChromeOptions option = new ChromeOptions();
                option.AddArguments("--lang=vi-VN");
                option.AddExcludedArgument("enable-automation");
                option.AddAdditionalCapability("useAutomationExtension", false);
                option.AddArguments("--disable-notifications");
                option.AddArgument(@"user-data-dir=" + tbPathSelenium.Text);
                ChromeDriver chromeDriver = new ChromeDriver(driverService, option);

                chromeDriver.Navigate().GoToUrl("https://chrome.google.com/webstore/detail/adblock-on-youtube/emngkmlligggbbiioginlkphcmffbncb/related?hl=vi");
                WebDriverWait wait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(30));
                wait.Until((x) =>
                {
                    return ((IJavaScriptExecutor)chromeDriver).ExecuteScript("return document.readyState").Equals("complete");
                });

                chromeDriver.FindElementByXPath("/html/body/div[5]/div[2]/div/div/div[2]/div[2]/div/div").Click();
                chromeDriver.SwitchTo().Alert().Accept();
            });
            thr.Start();            
        }

        private void rbOnlyUserID_CheckedChanged(object sender, System.EventArgs e)
        {
            btChooseFileUserID.Enabled = true;
            btPasteUserID.Enabled = true;
            btChooseFileAllOptions.Enabled = false;
            btPasteAllOptions.Enabled = false;

            tbAllSettingSBlock.Text = "";
        }

        private void rbImportAllOptions_CheckedChanged(object sender, System.EventArgs e)
        {
            btChooseFileUserID.Enabled = false;
            btPasteUserID.Enabled = false;
            btChooseFileAllOptions.Enabled = true;
            btPasteAllOptions.Enabled = true;

            tbUserID.Text = "";
        }

        private void btPasteUserID_Click(object sender, System.EventArgs e)
        {
            tbUserID.Text = Clipboard.GetText();
        }

        private void btPasteAllOptions_Click(object sender, System.EventArgs e)
        {
            tbAllSettingSBlock.Text = Clipboard.GetText();
        }
    }
}

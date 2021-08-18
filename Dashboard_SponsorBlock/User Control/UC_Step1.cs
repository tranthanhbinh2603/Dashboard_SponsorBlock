using Dashboard_SponsorBlock.Function;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Dashboard_SponsorBlock.User_Control
{
    public partial class UC_Step1 : UserControl
    {
        class VideoInfo
        {
            public string IDVideo { get; set; }
            public string Time { get; set; }
            public string NameVideo { get; set; }
            public string NameChannel { get; set; }
        }

        public UC_Step1()
        {
            InitializeComponent();
            //Khởi tạo form lúc ban đầu

            //Khoá tuỳ chọn & Sửa đổi Textbox
            tbPathOutput.Enabled = false;
            rtbListPage.Enabled = true;
            tbPathVideo.Enabled = false;
            btGetPathVideo.Enabled = false;
            npdNumberThread.Enabled = true;

            //Bật backup and restore
            btSaveAsFilePage.Enabled = true;
            btCopyListPage.Enabled = true;
            tbMailSendPage.Enabled = true;
            btSendPageMail.Enabled = true;
            btPasteClipboard.Enabled = true;
            btImportFile.Enabled = true;
            btRewriteFilePage.Enabled = true;
        }

        void RunningPage(List<String> page, int[]pc)
        {
            // Tạo list chứa video
            List<VideoInfo> listvideo = new List<VideoInfo>();

            //Bắt đầu tạo process
            List<ChromeDriver> listChrome = new List<ChromeDriver>();
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            ChromeOptions option = new ChromeOptions();
            option.AddExcludedArgument("enable-automation");
            option.AddAdditionalCapability("useAutomationExtension", false);
            option.AddArguments("--disable-notifications");
            for (int i = 1; i <= npdNumberThread.Value; i++)
            {
                ChromeDriver driver = new ChromeDriver(driverService, option);
                listChrome.Add(driver);
            }
            for (int i = 0; i < npdNumberThread.Value; i++)
            {
                if (i == 0)
                {
                    int copyi = i;
                    Thread thr = new Thread(() =>
                    {
                        for (int z = 0; z < pc[copyi]; z++)
                        {
                            //Tách dữ liệu
                            string link = page[z].Substring(0, page[z].IndexOf(','));
                            string videoPrevious = page[z].Substring(page[z].IndexOf(',') + 1, page[z].Length - page[z].IndexOf(',') - 1);

                            //Xử lí vấn đề quét page
                            int cs = 0;
                            if (link.IndexOf("https://") == -1)
                            {
                                listChrome[copyi].Navigate().GoToUrl("https://" + link);
                            }
                            else
                            {
                                listChrome[copyi].Navigate().GoToUrl(link);
                            }

                            Regex reg = new Regex(@"<a id=""video-title"" class=""yt-simple-endpoint style-scope ytd-grid-video-renderer"" aria-label="".*?"" title=""(?<Name_Video>.*?)"" href=""(?<Link>.*?)"">.*?</a>");
                            foreach (Match item in reg.Matches(listChrome[copyi].PageSource.ToString()))
                            {
                                foreach (Capture cap in item.Groups["Link"].Captures)
                                {
                                    listvideo.Add(new VideoInfo() { IDVideo = cap.ToString().Substring(cap.ToString().IndexOf('=') + 1, cap.ToString().Length - cap.ToString().IndexOf('=') - 1) });
                                }
                                foreach (Capture cap1 in item.Groups["Name_Video"].Captures)
                                {
                                    listvideo[cs].NameVideo = WebUtility.HtmlDecode(cap1.ToString());
                                    cs++;
                                }
                            }

                            Invoke((Action)(() =>
                            {
                                StreamWriter stream = new StreamWriter(tbPathOutput.Text + @"\AllVideo.txt");
                                foreach (var item in listvideo)
                                {
                                    stream.WriteLine("{0}, {1}", item.IDVideo, item.NameVideo);
                                }
                                stream.Close();
                            }));
                            Thread.Sleep(1000);
                        }
                        listChrome[copyi].Quit();
                        listChrome.Remove(listChrome[copyi]);
                    });
                    thr.Start();

                    //for (int z = 0; z <= pc[i]; z++)
                    //{
                    //    //Tách dữ liệu
                    //    string link = page[z].Substring(0, page[z].IndexOf(','));
                    //    string videoPrevious = page[z].Substring(page[z].IndexOf(',') + 1, page[z].Length - page[z].IndexOf(',') - 1);

                    //    //Xử lí vấn đề quét page
                    //    listChrome[i].Navigate().GoToUrl("https://" + link);
                    //    Thread.Sleep(1000);
                    //}
                    //listChrome[i].Quit();
                    //listChrome.Remove(listChrome[i]);
                }
                else
                {
                    //Thread thr = new Thread(() =>
                    //{
                    //    for (int z = pc[i - 2]; z < pc[i - 1]; z++)
                    //    {
                    //        //Tách dữ liệu
                    //        string link = page[z].Substring(1, page[z].IndexOf(',') - 1);
                    //        string videoPrevious = page[z].Substring(page[z].IndexOf(','), page[z].Length - page[z].IndexOf(','));

                    //        //Xử lí vấn đề quét page
                    //        listChrome[i].Navigate().GoToUrl(link);
                    //        Thread.Sleep(8000);
                    //    }
                    //    //Class_Step1.Get_Video_InPage(1, pc[i - 1]);
                    //});
                    //thr.Start();
                    MessageBox.Show("Có vẽ vượt quá");
                }
            }

            while (listChrome.Count != 0)
            {
                Thread.Sleep(500);
            }

            MessageBox.Show("Đã xong");
        }

        private void btChoosePathOutput_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFolder("Chọn vị trí mà bạn muốn lưu toàn bộ kết quả trả ra (Tổng cộng là 3 - 4 file)");
            tbPathOutput.Text = Path;
        }

        private void btSaveAsFilePage_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFile("Hãy chọn file để lưu. Nó sẽ bị ghi đè.");
            if (Path != "")
            {
                Class_Root.MessageBox2Button(System.Drawing.Color.Yellow, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Yellow, "Cảnh báo", "Nếu bạn chọn file đó, nó sẽ bị ghi đè đấy.\nBạn chắc chắn chứ?", "OK", "Không");
            }
        }

        private void btGetPathVideo_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFile("Chọn file chứa toàn bộ các video theo đúng định dạng.");
        }

        private void btImportFile_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFile("Hãy chọn file chứa toàn bộ các trang bị đánh giá để Import");
            if (Path != "")
            {
                Class_Root.MessageBox2Button(System.Drawing.Color.Red, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Red, "Chú ý!", "Việc này sẽ ghi đè nội dung hiện tại.\nChắc chắn?", "OK", "Cancel");
            }
        }

        private void rbChooseCrawl_CheckedChanged(object sender, System.EventArgs e)
        {
            rtbListPage.Enabled = true;
            npdNumberThread.Enabled = true;
            btSaveAsFilePage.Enabled = true;
            btCopyListPage.Enabled = true;
            tbMailSendPage.Enabled = true;
            btSendPageMail.Enabled = true;
            btPasteClipboard.Enabled = true;
            btImportFile.Enabled = true;
            btRewriteFilePage.Enabled = true;
        }

        private void rbChooseImportListVideo_CheckedChanged(object sender, System.EventArgs e)
        {
            rtbListPage.Enabled = false;
            npdNumberThread.Enabled = false;
            btSaveAsFilePage.Enabled = false;
            btCopyListPage.Enabled = false;
            tbMailSendPage.Enabled = false;
            btSendPageMail.Enabled = false;
            btPasteClipboard.Enabled = false;
            btImportFile.Enabled = false;
            btRewriteFilePage.Enabled = false;

            tbPathVideo.Enabled = true;
            btGetPathVideo.Enabled = true;
        }

        private void btCopyListPage_Click(object sender, System.EventArgs e)
        {
            if (rtbListPage.Text != "")
            {
                Clipboard.SetText(rtbListPage.Text);
            }
        }

        private void btPasteClipboard_Click(object sender, System.EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                rtbListPage.Text = Clipboard.GetText(TextDataFormat.Rtf);
            }
            else
            if (Clipboard.ContainsText(TextDataFormat.UnicodeText))
            {
                rtbListPage.Text = Clipboard.GetText(TextDataFormat.UnicodeText);
            }
            else
            if (Clipboard.ContainsText(TextDataFormat.CommaSeparatedValue))
            {
                rtbListPage.Text = Clipboard.GetText(TextDataFormat.UnicodeText);
            }
            else
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                rtbListPage.Text = Clipboard.GetText(TextDataFormat.Text);
            }
        }

        private void btSendPageMail_Click(object sender, System.EventArgs e)
        {
            Class_Root.SendMail("hoctap.tranthanhbinh@gmail.com", "tranthanhbinh", tbMailSendPage.Text, "Gửi dữ liệu backup các trang theo dõi", rtbListPage.Text);
        }

        private void btRewriteFilePage_Click(object sender, EventArgs e)
        {
            StreamWriter stream = new StreamWriter(tbPathOutput.Text + @"\AllVideo.txt");
            stream.WriteLine(rtbListPage.Text);
            stream.Close();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
                
        private void btRun_Click(object sender, EventArgs e)
        {

            if (tbPathOutput.Text != "")
            {
                //Lưu file lại
                StreamWriter stream = new StreamWriter(tbPathOutput.Text + @"\AllVideo.txt");
                stream.WriteLine(rtbListPage.Text);
                stream.Close();

                //Đếm dòng - Chia từng phần cho từng thread. Vừa ghi mảng link luôn
                int countLine = 0;
                List<String> listdata = new List<string>();
                StreamReader streread = new StreamReader(tbPathOutput.Text + @"\AllVideo.txt");
                string res = streread.ReadLine();
                while (res != null)
                {
                    if (res != "")
                    {
                        countLine++;
                        listdata.Add(res);
                    }
                    res = streread.ReadLine();
                }
                streread.Close();
                int[] pc = new int[50];
                for (int i = 0; i < 50; i++)
                {
                    pc[i] = 0;
                }
                Class_Root.Chiaphan(countLine, (int)npdNumberThread.Value, ref pc);

                //Thực thi đa luồng 
                Thread thr = new Thread(() =>
                {
                    RunningPage(listdata, pc);
                });
                thr.Start();

            }   
        }
    }
}

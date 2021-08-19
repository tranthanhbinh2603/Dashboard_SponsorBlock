using Dashboard_SponsorBlock.Function;
using OpenQA.Selenium;
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
            #region Tạo các trình Selenium
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
            #endregion

            for (int i = 0; i < npdNumberThread.Value; i++)
            {
                if (i == 0)
                {
                    int copyi = i;
                    int cs_video = 1;
                    List<VideoInfo> listvideo = new List<VideoInfo>();
                    Thread thr = new Thread(() =>
                    {  
                        for (int z = 0; z < pc[copyi]; z++)
                        {
                            #region Tách dữ liệu tạo ra 2 trường Page và List chứa những video trước đó
                            string link = page[z].Substring(0, page[z].IndexOf(','));
                            string videoPrevious = page[z].Substring(page[z].IndexOf(',') + 1, page[z].Length - page[z].IndexOf(',') - 1);
                            #endregion

                            #region Đi đến trang cần tìm. Tiện lấy tên kênh luôn.
                            if (link.IndexOf("https://") == -1)
                            {
                                listChrome[copyi].Navigate().GoToUrl("https://" + link);
                            }
                            else
                            {
                                listChrome[copyi].Navigate().GoToUrl(link);
                            }
                            string nameChannel = Class_Step1.Get_Channel_Name(listChrome[copyi].PageSource.ToString());
                            #endregion

                            #region Tạo list chứa các thông tin: link, name, time, name channel
                            List<string> linkVideo = new List<string>();
                            List<string> nameVideo = new List<string>();
                            List<string> timeVideo = new List<string>();
                            #endregion

                            bool Next = true;
                            while (Next)
                            {   
                                #region Thực thi lấy thông tin: link, name, time, name channel
                                Class_Step1.Get_Link_Video(listChrome[copyi].PageSource.ToString(), ref linkVideo);
                                Class_Step1.Get_Page_Video(listChrome[copyi].PageSource.ToString(), ref nameVideo);
                                Class_Step1.Get_Time_Video(listChrome[copyi].PageSource.ToString(), ref timeVideo);                               
                                #endregion

                                #region Xác nhận ra được video cũ, video mới
                                List<string> listVideoPre = new List<string>();
                                string[] step = videoPrevious.Split(',');
                                foreach (var item in step)
                                {
                                    listVideoPre.Add(item);
                                }
                                int kq = Class_Step1.Scan_2_List(linkVideo, listVideoPre, cs_video);
                                if (kq == -1)
                                {
                                    IJavaScriptExecutor js = listChrome[copyi] as IJavaScriptExecutor;
                                    Int64 dataFromJS = (Int64)js.ExecuteScript("return document.documentElement.scrollHeight;");
                                    listChrome[copyi].ExecuteScript("window.scrollTo(0, " + dataFromJS + ");");

                                    cs_video = linkVideo.Count;

                                    linkVideo.Clear();
                                    nameVideo.Clear();
                                    timeVideo.Clear();

                                    while (true)
                                    {
                                        Int64 dataFromJSNew = (Int64)js.ExecuteScript("return document.documentElement.scrollHeight;");
                                        if (dataFromJSNew != dataFromJS)
                                        {
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    while (kq < linkVideo.Count)
                                    {
                                        linkVideo.Remove(linkVideo[kq]);
                                    }
                                    Next = false;
                                }
                                #endregion
                            }

                            #region Hợp nhất lại thành list
                            for (int k = 0; k < linkVideo.Count; k++)
                            {
                                listvideo.Add(new VideoInfo()
                                {
                                    IDVideo = linkVideo[k],
                                    NameVideo = nameVideo[k],
                                    Time = timeVideo[k],
                                    NameChannel = nameChannel
                                });
                            }
                            #endregion                                                        

                            #region Ghi vào file.
                            Invoke((Action)(() =>
                            {
                                using (StreamWriter sw = new StreamWriter(tbPathOutput.Text + @"\AllVideo.txt", true))
                                {
                                    foreach (var item in listvideo)
                                    {
                                        sw.WriteLine("{0}, {1}, {2}, {3}", item.IDVideo, item.NameVideo, item.NameChannel, item.Time);
                                    }
                                }
                            }));
                            #endregion

                            #region Xoá toàn bộ Video trong List, để chuẩn bị quét page khác
                            if (listvideo.Count >= 1)
                            {
                                while (listvideo.Count != 0)
                                {
                                    listvideo.RemoveAt(0);
                                }
                            }
                            #endregion
                        }
                        #region Chạy xong Page rồi thì tắt Sele và xoá trong mảng để cho hệ thống biết mà dừng Thread sang bước tiếp theo
                        listChrome[copyi].Quit();
                        listChrome.Remove(listChrome[copyi]);
                        #endregion
                    });
                    thr.Start();
                }
                else
                {
                    int copyi = i;
                    int cs_video = 1;
                    List<VideoInfo> listvideo = new List<VideoInfo>();
                    Thread thr = new Thread(() =>
                    {
                        for (int z = pc[i - 2]; z < pc[i - 1]; z++)
                        {
                            #region Tách dữ liệu tạo ra 2 trường Page và List chứa những video trước đó
                            string link = page[z].Substring(0, page[z].IndexOf(','));
                            string videoPrevious = page[z].Substring(page[z].IndexOf(',') + 1, page[z].Length - page[z].IndexOf(',') - 1);
                            #endregion

                            #region Đi đến trang cần tìm. Tiện lấy tên kênh luôn.
                            if (link.IndexOf("https://") == -1)
                            {
                                listChrome[copyi].Navigate().GoToUrl("https://" + link);
                            }
                            else
                            {
                                listChrome[copyi].Navigate().GoToUrl(link);
                            }
                            string nameChannel = Class_Step1.Get_Channel_Name(listChrome[copyi].PageSource.ToString());
                            #endregion

                            #region Tạo list chứa các thông tin: link, name, time, name channel
                            List<string> linkVideo = new List<string>();
                            List<string> nameVideo = new List<string>();
                            List<string> timeVideo = new List<string>();
                            #endregion

                            bool Next = true;
                            while (Next)
                            {
                                #region Thực thi lấy thông tin: link, name, time, name channel
                                Class_Step1.Get_Link_Video(listChrome[copyi].PageSource.ToString(), ref linkVideo);
                                Class_Step1.Get_Page_Video(listChrome[copyi].PageSource.ToString(), ref nameVideo);
                                Class_Step1.Get_Time_Video(listChrome[copyi].PageSource.ToString(), ref timeVideo);
                                #endregion

                                #region Xác nhận ra được video cũ, video mới
                                List<string> listVideoPre = new List<string>();
                                string[] step = videoPrevious.Split(',');
                                foreach (var item in step)
                                {
                                    listVideoPre.Add(item);
                                }
                                int kq = Class_Step1.Scan_2_List(linkVideo, listVideoPre, cs_video);
                                if (kq == -1)
                                {
                                    IJavaScriptExecutor js = listChrome[copyi] as IJavaScriptExecutor;
                                    Int64 dataFromJS = (Int64)js.ExecuteScript("return document.documentElement.scrollHeight;");
                                    listChrome[copyi].ExecuteScript("window.scrollTo(0, " + dataFromJS + ");");

                                    cs_video = linkVideo.Count;

                                    linkVideo.Clear();
                                    nameVideo.Clear();
                                    timeVideo.Clear();

                                    while (true)
                                    {
                                        Int64 dataFromJSNew = (Int64)js.ExecuteScript("return document.documentElement.scrollHeight;");
                                        if (dataFromJSNew != dataFromJS)
                                        {
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    while (kq < linkVideo.Count)
                                    {
                                        linkVideo.Remove(linkVideo[kq]);
                                    }
                                    Next = false;
                                }
                                #endregion
                            }

                            #region Hợp nhất lại thành list
                            for (int k = 0; k < linkVideo.Count; k++)
                            {
                                listvideo.Add(new VideoInfo()
                                {
                                    IDVideo = linkVideo[k],
                                    NameVideo = nameVideo[k],
                                    Time = timeVideo[k],
                                    NameChannel = nameChannel
                                });
                            }
                            #endregion                                                        

                            #region Ghi vào file.
                            Invoke((Action)(() =>
                            {
                                using (StreamWriter sw = new StreamWriter(tbPathOutput.Text + @"\AllVideo.txt", true))
                                {
                                    foreach (var item in listvideo)
                                    {
                                        sw.WriteLine("{0}, {1}, {2}, {3}", item.IDVideo, item.NameVideo, item.NameChannel, item.Time);
                                    }
                                }
                            }));
                            #endregion

                            #region Xoá toàn bộ Video trong List, để chuẩn bị quét page khác
                            if (listvideo.Count >= 1)
                            {
                                while (listvideo.Count != 0)
                                {
                                    listvideo.RemoveAt(0);
                                }
                            }
                            #endregion
                        }
                        #region Chạy xong Page rồi thì tắt Sele và xoá trong mảng để cho hệ thống biết mà dừng Thread sang bước tiếp theo
                        listChrome[copyi].Quit();
                        listChrome.Remove(listChrome[copyi]);
                        #endregion
                    });
                    thr.Start();
                }
            }

            while (listChrome.Count != 0)
            {
               
            }


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
                ////Lưu file lại
                //StreamWriter stream = new StreamWriter(tbPathOutput.Text + @"\AllPage.txt");
                //stream.WriteLine(rtbListPage.Text);
                //stream.Close();

                ////Đếm dòng - Chia từng phần cho từng thread. Vừa ghi mảng link luôn
                //int countLine = 0;
                //List<String> listdata = new List<string>();
                //StreamReader streread = new StreamReader(tbPathOutput.Text + @"\AllPage.txt");
                //string res = streread.ReadLine();
                //while (res != null)
                //{
                //    if (res != "")
                //    {
                //        countLine++;
                //        listdata.Add(res);
                //    }
                //    res = streread.ReadLine();
                //}
                //streread.Close();
                //int[] pc = new int[50];
                //for (int i = 0; i < 50; i++)
                //{
                //    pc[i] = 0;
                //}
                //Class_Root.Chiaphan(countLine, (int)npdNumberThread.Value, ref pc);

                ////Xoá sạch dữ liệu video, video có và không có SBlock, danh sách SBlocker

                //StreamWriter stream1 = new StreamWriter(tbPathOutput.Text + @"\AllVideo.txt");
                //stream1.Close();

                ////Thực thi đa luồng 
                //Thread thr = new Thread(() =>
                //{
                //    RunningPage(listdata, pc);
                //});
                //thr.Start();


                Class_Step1.Get_UUID_SBlock_In_Video("cbacblacnlns");
            }   
        }
    }
}

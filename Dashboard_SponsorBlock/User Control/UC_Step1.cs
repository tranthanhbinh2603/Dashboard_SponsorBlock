using Dashboard_SponsorBlock.Function;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Dashboard_SponsorBlock.User_Control
{
    public partial class UC_Step1 : UserControl
    {
        #region Định nghĩa hàm liên quan
        class VideoInfo
        {
            public string IDVideo { get; set; }
            public string Time { get; set; }
            public string NameVideo { get; set; }
            public string NameChannel { get; set; }
        }       
        #endregion

        public UC_Step1()
        {
            InitializeComponent();
            //Khởi tạo form lúc ban đầu

            //Khoá tuỳ chọn & Sửa đổi Textbox
            tbPathOutput.Enabled = false;
            rtbListPage.Enabled = true;
            npdNumberThread.Enabled = true;

            //Bật backup and restore
            btPasteClipboard.Enabled = true;
            btImportFile.Enabled = true;
            btRewriteFilePage.Enabled = true;
        }

        void RunningPage(List<String> page, int[]pc)
        {
            if (rbChooseCrawl.Checked == true)
            {
                #region Tạo các trình Selenium
                List<Boolean> listChrome = new List<Boolean>();
                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                ChromeOptions option = new ChromeOptions();
                option.AddExcludedArgument("enable-automation");
                option.AddAdditionalCapability("useAutomationExtension", false);
                option.AddArguments("--disable-notifications");
                for (int i = 1; i <= npdNumberThread.Value; i++)
                {
                    //ChromeDriver driver = new ChromeDriver(driverService, option);
                    //listChrome.Add(driver);
                    listChrome.Add(true);
                }
                #endregion

                #region Thực thi lấy toàn bộ video mới
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
                                ChromeDriver chrome = new ChromeDriver(driverService, option);
                                listvideo.Clear();
                                cs_video = 1;

                                #region Tách dữ liệu tạo ra 2 trường Page và List chứa những video trước đó
                                string link = page[z].Substring(0, page[z].IndexOf(','));
                                string videoPrevious = page[z].Substring(page[z].IndexOf(',') + 1, page[z].Length - page[z].IndexOf(',') - 1);
                                #endregion

                                #region Đi đến trang cần tìm. Tiện lấy tên kênh luôn.
                                if (link.IndexOf("https://") == -1)
                                {
                                    chrome.Navigate().GoToUrl("https://" + link);
                                }
                                else
                                {
                                    chrome.Navigate().GoToUrl(link);
                                }
                                string nameChannel = Class_Step1.Get_Channel_Name(chrome.PageSource.ToString());
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
                                    Class_Step1.Get_Link_And_Name_Video(chrome.PageSource.ToString(), ref linkVideo, ref nameVideo);
                                    Class_Step1.Get_Time_Video(chrome.PageSource.ToString(), ref timeVideo);
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
                                        IJavaScriptExecutor js = chrome as IJavaScriptExecutor;
                                        Int64 dataFromJS = (Int64)js.ExecuteScript("return document.documentElement.scrollHeight;");
                                        chrome.ExecuteScript("window.scrollTo(0, " + dataFromJS + ");");

                                        cs_video = linkVideo.Count;

                                        linkVideo.Clear();
                                        nameVideo.Clear();
                                        timeVideo.Clear();

                                        var sw = Stopwatch.StartNew();
                                        while (true)
                                        {                                            
                                            Int64 dataFromJSNew = (Int64)js.ExecuteScript("return document.documentElement.scrollHeight;");
                                            if ((dataFromJSNew != dataFromJS) || (sw.ElapsedMilliseconds >= 15000))
                                            {
                                                sw.Stop();
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

                                #region Loại bỏ các video không có thời gian
                                listvideo.RemoveAll(r => r.Time == "0:0");
                                #endregion

                                #region Ghi vào file.
                                Invoke((Action)(() =>
                                {
                                    if (listvideo.Count > 0)
                                    {
                                        using (StreamWriter sw1 = new StreamWriter(tbPathOutput.Text + @"\AllPage.txt", true))
                                        {
                                            string strLinkVideo = "";
                                            for (int a = 0; a < listvideo.Count - 1; a++)
                                            {
                                                strLinkVideo += listvideo[a].IDVideo + ",";
                                            }
                                            strLinkVideo += listvideo[listvideo.Count - 1].IDVideo;
                                            sw1.WriteLine("{0},{1}", link, strLinkVideo);
                                        }
                                        using (StreamWriter sw = new StreamWriter(tbPathOutput.Text + @"\AllVideo.txt", true))
                                        {
                                            foreach (var item in listvideo)
                                            {
                                                sw.WriteLine("{0}, {1}, {2}, {3}", item.IDVideo, item.NameVideo, item.NameChannel, item.Time);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        using (StreamWriter sw1 = new StreamWriter(tbPathOutput.Text + @"\AllPage.txt", true))
                                        {                                            
                                            sw1.WriteLine("{0}", page[z]);
                                        }
                                    }
                                    #endregion
                                }));

                                #region Xoá toàn bộ Video trong List, để chuẩn bị quét page khác. Đóng trực tiếp Selenium tránh bị disconnect
                                listvideo.Clear();
                                chrome.Quit();
                                #endregion
                            }
                            #region Chạy xong Page rồi thì tắt Sele và xoá trong mảng để cho hệ thống biết mà dừng Thread sang bước tiếp theo
                            listChrome[copyi] = false;
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
                            for (int z = pc[copyi - 1]; z < pc[copyi]; z++)
                            {
                                ChromeDriver chrome = new ChromeDriver(driverService, option);
                                #region Tách dữ liệu tạo ra 2 trường Page và List chứa những video trước đó
                                string link = page[z].Substring(0, page[z].IndexOf(','));
                                string videoPrevious = page[z].Substring(page[z].IndexOf(',') + 1, page[z].Length - page[z].IndexOf(',') - 1);
                                #endregion

                                #region Đi đến trang cần tìm. Tiện lấy tên kênh luôn.
                                if (link.IndexOf("https://") == -1)
                                {
                                    chrome.Navigate().GoToUrl("https://" + link);
                                }
                                else
                                {
                                    chrome.Navigate().GoToUrl(link);
                                }
                                string nameChannel = Class_Step1.Get_Channel_Name(chrome.PageSource.ToString());
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
                                    Class_Step1.Get_Link_And_Name_Video(chrome.PageSource.ToString(), ref linkVideo, ref nameVideo);
                                    Class_Step1.Get_Time_Video(chrome.PageSource.ToString(), ref timeVideo);
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
                                        IJavaScriptExecutor js = chrome as IJavaScriptExecutor;
                                        Int64 dataFromJS = (Int64)js.ExecuteScript("return document.documentElement.scrollHeight;");
                                        chrome.ExecuteScript("window.scrollTo(0, " + dataFromJS + ");");

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

                                #region Loại bỏ các video không có thời gian
                                listvideo.RemoveAll(r => r.Time == "0:0");
                                #endregion

                                #region Ghi vào file.
                                Invoke((Action)(() =>
                                {
                                    if (listvideo.Count > 0)
                                    {
                                        using (StreamWriter sw1 = new StreamWriter(tbPathOutput.Text + @"\AllPage.txt", true))
                                        {
                                            string strLinkVideo = "";
                                            for (int a = 0; a < listvideo.Count - 1; a++)
                                            {
                                                strLinkVideo += listvideo[a].IDVideo + ",";
                                            }
                                            strLinkVideo += listvideo[listvideo.Count - 1].IDVideo;
                                            sw1.WriteLine("{0},{1}", link, strLinkVideo);
                                        }
                                        using (StreamWriter sw = new StreamWriter(tbPathOutput.Text + @"\AllVideo.txt", true))
                                        {
                                            foreach (var item in listvideo)
                                            {
                                                sw.WriteLine("{0}, {1}, {2}, {3}", item.IDVideo, item.NameVideo, item.NameChannel, item.Time);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        using (StreamWriter sw1 = new StreamWriter(tbPathOutput.Text + @"\AllPage.txt", true))
                                        {
                                            sw1.WriteLine("{0}", page[z]);
                                        }
                                    }
                                    #endregion

                                }));

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
                            listChrome[copyi] = false;
                            #endregion
                        });
                        thr.Start();
                    }
                }
                #endregion

                #region Kiểm tra để sang bước tiếp theo
                bool nextStep2 = true;
                while (nextStep2)
                {
                    int countOff = 0;

                    for (int i = 0; i < listChrome.Count; i++)
                    {
                        if (listChrome[i] == false)
                        {
                            countOff++;
                        }
                    }

                    if (countOff == npdNumberThread.Value)
                    {
                        nextStep2 = false;
                    }
                }
                #endregion
            }

            #region Tạo 1 list chứa toàn bộ ID Video. Cần cho bước tiếp theo
            List<string> IDVideo = new List<string>();
            List<string> AllInfoVideo = new List<string>();
            StreamReader streread1 = new StreamReader(tbPathOutput.Text + @"\AllVideo.txt");
            string res2 = streread1.ReadLine();
            while (res2 != null)
            {
                AllInfoVideo.Add(res2);
                IDVideo.Add(res2.Substring(0, res2.IndexOf(',')));
                res2 = streread1.ReadLine();
            }
            #endregion

            #region Thực thi lấy toàn bộ UUID cho tất cả các video
            #region Thiết lập cơ bản
            int countThread = 4;
            List<bool?> list = new List<bool?>(countThread);
            for (int i = 0; i < countThread; i++)
            {
                list.Add(false);
            }

            int[] pc2 = new int[countThread];
            Class_Root.Chiaphan(IDVideo.Count, countThread, ref pc2);
            #endregion

            if (IDVideo.Count <= countThread)
            {
                #region Nếu số lượng video ít hơn số luồng
                bool haveRes = false;
                for (int z = 0; z < IDVideo.Count; z++)
                {
                    haveRes = Class_Step1.Get_UUID_SBlock_In_Video(IDVideo[z]);
                    if (haveRes == true)
                    {
                        Invoke((Action)(() =>
                        {
                            using (StreamWriter sw = new StreamWriter(tbPathOutput.Text + @"\VideoWithSBlock.txt", true))
                            {
                                sw.WriteLine("{0}", AllInfoVideo[z]);
                            }
                        }));
                    }
                    else
                    {
                        Invoke((Action)(() =>
                        {
                            using (StreamWriter sw = new StreamWriter(tbPathOutput.Text + @"\VideoNoSBlock.txt", true))
                            {
                                sw.WriteLine("{0}", AllInfoVideo[z]);
                            }
                        }));
                    }
                }
                for (int i = 0; i < list.Count; i++)
                {
                    list[i] = null;
                }
                #endregion
            }
            else
            {
                for (int i = 0; i < countThread; i++)
                {
                    if (i == 0)
                    {
                        int copyi = i;
                        bool haveRes = false;
                        Thread thr = new Thread(() => 
                        {
                            #region Thực thi lấy toàn bộ UUID                            
                            for (int z = 0; z < pc2[copyi]; z++)
                            {
                                haveRes = Class_Step1.Get_UUID_SBlock_In_Video(IDVideo[z]);
                                if (haveRes == true)
                                {
                                    Invoke((Action)(() =>
                                    {
                                        using (StreamWriter sw = new StreamWriter(tbPathOutput.Text + @"\VideoWithSBlock.txt", true))
                                        {
                                            sw.WriteLine("{0}", AllInfoVideo[z]);
                                        }
                                    }));
                                }
                                else
                                {
                                    Invoke((Action)(() =>
                                    {
                                        using (StreamWriter sw = new StreamWriter(tbPathOutput.Text + @"\VideoNoSBlock.txt", true))
                                        {
                                            sw.WriteLine("{0}", AllInfoVideo[z]);
                                        }
                                    }));
                                }
                            }
                            list[copyi] = null;
                            #endregion
                        });
                        thr.Start();
                    }
                    else
                    {
                        int copyi = i;
                        bool haveRes = false;
                        Thread thr = new Thread(() =>
                        {
                            #region Thực thi lấy toàn bộ UUID                           
                            for (int z = pc2[copyi - 1]; z < pc2[copyi]; z++)
                            {
                                haveRes = Class_Step1.Get_UUID_SBlock_In_Video(IDVideo[z]);
                                if (haveRes == true)
                                {
                                    Invoke((Action)(() =>
                                    {
                                        using (StreamWriter sw = new StreamWriter(tbPathOutput.Text + @"\VideoWithSBlock.txt", true))
                                        {
                                            sw.WriteLine("{0}", AllInfoVideo[z]);
                                        }
                                    }));
                                }
                                else
                                {
                                    Invoke((Action)(() =>
                                    {
                                        using (StreamWriter sw = new StreamWriter(tbPathOutput.Text + @"\VideoNoSBlock.txt", true))
                                        {
                                            sw.WriteLine("{0}", AllInfoVideo[z]);
                                        }
                                    }));
                                }
                            }
                            list[copyi] = null;
                            #endregion
                        });
                        thr.Start();
                    }
                }
            }

            bool nextStep = true;
            while (nextStep)
            {
                int countOff = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == null)
                    {
                        countOff++;
                    }
                }

                if (countOff == countThread)
                {
                    nextStep = false;
                }
            }
            #endregion

            #region Mở khoá control lại
            if (rbChooseCrawl.Checked == true)
            {
                Invoke((Action)(() =>
                {
                    tbPathOutput.Enabled = false;
                    rtbListPage.Enabled = true;
                    npdNumberThread.Enabled = true;
                    btPasteClipboard.Enabled = true;
                    btImportFile.Enabled = true;
                    btRewriteFilePage.Enabled = true;
                    rbChooseCrawl.Enabled = true;
                    rbChooseImportListVideo.Enabled = true;
                }));                
            }
            else
            {
                Invoke((Action)(() =>
                {
                    rtbListPage.Enabled = false;
                    npdNumberThread.Enabled = false;
                    btPasteClipboard.Enabled = false;
                    btImportFile.Enabled = false;
                    btRewriteFilePage.Enabled = false;
                    rbChooseCrawl.Enabled = true;
                    rbChooseImportListVideo.Enabled = true;
                }));               
            }
            #endregion
        }

        private void btChoosePathOutput_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFolder("Chọn vị trí mà bạn muốn lưu toàn bộ kết quả trả ra (Tổng cộng là 3 - 4 file)");
            tbPathOutput.Text = Path;
        }

        private void btSaveAsFilePage_Click(object sender, System.EventArgs e)
        {

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
            btPasteClipboard.Enabled = true;
            btImportFile.Enabled = true;
            btRewriteFilePage.Enabled = true;
        }

        private void rbChooseImportListVideo_CheckedChanged(object sender, System.EventArgs e)
        {
            rtbListPage.Enabled = false;
            npdNumberThread.Enabled = false;
            btPasteClipboard.Enabled = false;
            btImportFile.Enabled = false;
            btRewriteFilePage.Enabled = false;
        }

        private void btCopyListPage_Click(object sender, System.EventArgs e)
        {

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
                #region Khoá toàn bộ control
                rtbListPage.Enabled = false;
                npdNumberThread.Enabled = false;
                btPasteClipboard.Enabled = false;
                btImportFile.Enabled = false;
                btRewriteFilePage.Enabled = false;
                rbChooseCrawl.Enabled = false;
                rbChooseImportListVideo.Enabled = false;
                #endregion

                List<String> listdata = new List<string>();
                int[] pc = new int[50];
                if (rbChooseCrawl.Checked == true)
                {                    
                    #region Lưu file lại
                    StreamWriter stream = new StreamWriter(tbPathOutput.Text + @"\AllPage_Backup.txt");
                    stream.WriteLine(rtbListPage.Text);
                    stream.Close();
                    #endregion

                    #region Đếm dòng - Chia từng phần cho từng thread. Vừa ghi mảng link luôn
                    int countLine = 0;
                    StreamReader streread = new StreamReader(tbPathOutput.Text + @"\AllPage_Backup.txt");
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
                    for (int i = 0; i < 50; i++)
                    {
                        pc[i] = 0;
                    }
                    Class_Root.Chiaphan(countLine, (int)npdNumberThread.Value, ref pc);
                    #endregion
                }

                #region Xoá sạch dữ liệu video, video có và không có SBlock, danh sách SBlocker
                Invoke((Action)(() =>
                {
                    StreamWriter stream1;
                    if (rbChooseCrawl.Checked == true)
                    {
                        stream1 = new StreamWriter(tbPathOutput.Text + @"\AllVideo.txt");
                        stream1.Close();
                        stream1 = new StreamWriter(tbPathOutput.Text + @"\AllPage.txt");
                        stream1.Close();
                    }               
                    stream1 = new StreamWriter(tbPathOutput.Text + @"\VideoNoSBlock.txt");
                    stream1.Close();
                    stream1 = new StreamWriter(tbPathOutput.Text + @"\VideoWithSBlock.txt");
                    stream1.Close();
                }));
                #endregion

                #region Thực thi đa luồng lấy toàn bộ video
                Thread thr = new Thread(() =>
                {
                    RunningPage(listdata, pc);
                });
                thr.Start();
                #endregion
            }
            else
            {

            }
        }

        private void btOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", tbPathOutput.Text);
        }
    }
}
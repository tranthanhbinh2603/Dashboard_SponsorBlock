using Dashboard_SponsorBlock.Function;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Dashboard_SponsorBlock.User_Control
{
    public partial class UC_Step4 : UserControl
    {
        List<OneScene> list = new List<OneScene>();
        List<VideoInfo2> listVideo = new List<VideoInfo2>();
        int cs = 0;
        ChromeDriver chromeDriver = null;

        public UC_Step4()
        {
            InitializeComponent();
            tbProfileSelenium.Text = @"D:\Test Dashboard SponsorBlock\Profile Sele1";
            tbOutputStep3.Text = @"D:\Out Synce";
            tbPathListVideo.Text = @"D:\Test Dashboard SponsorBlock\VideoNoSBlock.txt";


            dgvSubmissions.DefaultCellStyle.Font = new Font("Segoe UI", 10.5F);
            dgvSubmissions.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10.5F);
            dgvSubmissions.AllowUserToAddRows = false;

            btNextVideo.Enabled = false;
            btNextVideoandProcessing.Enabled = false;
            cbChooseTimeVideo.Enabled = false;
        }

        private void btChooseOutoutStep3_Click(object sender, System.EventArgs e)
        {
            string path = Class_Root.ChooseFile("Chọn địa chỉ nơi chứa kết quả phân đoạn chuyển cảnh");
            tbOutputStep3.Text = path;
        }

        private void btChooseProfileSele_Click(object sender, System.EventArgs e)
        {
            string path = Class_Root.ChooseFolder("Chọn địa chỉ nơi chứa profile Chrome đã được setup. Nếu chưa có thì chọn nút \"Copy mẫu\" để copy bản mẫu. Nhớ là phải có ID Private");
            tbProfileSelenium.Text = path;
        }

        private void btChooseListVideo_Click(object sender, System.EventArgs e)
        {
            string path = Class_Root.ChooseFolder("Chọn địa chỉ nơi chứa file video. Có thể tạo nó ngay tại bước 1");
            tbPathListVideo.Text = path;
        }

        private void btCopyProfile_Click(object sender, System.EventArgs e)
        {
            StringCollection paths = new StringCollection();
            paths.Add(Application.StartupPath + @"/Profile.zip");
            Clipboard.SetFileDropList(paths);
        }

        private void tbNumberSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbNumberSearch.Text == "")
                {
                    Class_Step4.DeleteAllRow(dgvSubmissions);
                    Class_Step4.AddRow(list, dgvSubmissions);
                }
                else
                {
                    Class_Step4.DeleteAllRow(dgvSubmissions);
                    Class_Step4.AddRow(list, dgvSubmissions, int.Parse(tbNumberSearch.Text));
                }                
            }
        }

        private void btCopyStartSeaTB_Click(object sender, System.EventArgs e)
        {
            string text = "";
            if (dgvSubmissions.RowCount == 1)
            {
                text = dgvSubmissions.Rows[0].Cells[1].Value.ToString();
            }
            else
            {
                int rowId = dgvSubmissions.CurrentCell.RowIndex;
                text = dgvSubmissions.Rows[rowId].Cells[1].Value.ToString();
            }
            Clipboard.SetText(text);
        }

        private void btCopyEndSeaTB_Click(object sender, System.EventArgs e)
        {
            string text = "";
            if (dgvSubmissions.RowCount == 1)
            {
                text = dgvSubmissions.Rows[0].Cells[3].Value.ToString();
            }
            else
            {
                int rowId = dgvSubmissions.CurrentCell.RowIndex;
                text = dgvSubmissions.Rows[rowId].Cells[3].Value.ToString();
            }
            Clipboard.SetText(text);
        }

        private void btDeleteFilter_Click(object sender, System.EventArgs e)
        {
            Class_Step4.DeleteAllRow(dgvSubmissions);
            Class_Step4.AddRow(list, dgvSubmissions);
        }

        private void btRun_Click(object sender, System.EventArgs e)
        {
            string pathOutput = tbPathListVideo.Text.Remove(tbPathListVideo.Text.LastIndexOf(@"\"));
            StreamWriter stream = new StreamWriter(pathOutput + @"\Done.txt");
            stream.Close();
            stream = new StreamWriter(pathOutput + @"\NotDone.txt");
            stream.Close();

            btNextVideo.Enabled = true;
            btNextVideoandProcessing.Enabled = true;
            btRun.Enabled = false;

            #region Khởi tạo profile
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("--lang=vi-VN");
            option.AddExcludedArgument("enable-automation");
            option.AddAdditionalCapability("useAutomationExtension", false);
            option.AddArguments("--disable-notifications");
            option.AddArgument(@"user-data-dir=" + tbProfileSelenium.Text);
            chromeDriver = new ChromeDriver(driverService, option);
            #endregion

            #region Đọc listvideo
            StreamReader streread = new StreamReader(tbPathListVideo.Text);
            string res = streread.ReadLine();
            while (res != null)
            {
                string[] temp = res.Split(',');
                string nameVideoTemp = "";
                for (int i = 1; i < temp.Length - 2; i++)
                {
                    if (i == 1)
                    {
                        nameVideoTemp += temp[i];
                    }
                    else
                    {
                        nameVideoTemp += "," + temp[i];
                    }

                }
                listVideo.Add(new VideoInfo2() { IDVideo = temp[0].Trim(), NameVideo = nameVideoTemp.Trim(), NameChannel = temp[temp.Length - 2].Trim(), Time = temp[temp.Length - 1].Trim() });
                res = streread.ReadLine();
            }
            #endregion

            #region Thực thi load thông tin cho video đầu tiên. Tăng chỉ số.
            Class_Step4.DeleteAllRow(dgvSubmissions);
            lbNameVideo.Text = listVideo[cs].NameVideo;
            lbLongVideo.Text = listVideo[cs].Time;

            chromeDriver.Navigate().GoToUrl("https://www.youtube.com/watch?v=" + listVideo[cs].IDVideo);

            string pathscene = tbOutputStep3.Text + @"\" + listVideo[cs].IDVideo + ".mp4";

            if (Directory.Exists(pathscene) == false)
            {
                if (cbNotFoundFolder.Checked == true)
                {
                    chromeDriver.ExecuteScript("alert('Không có thư mục');");
                }
            }
            else
            {
                string[] subdirectoryEntries = Directory.GetDirectories(pathscene);
                if (subdirectoryEntries.Length > 0)
                {
                    cbChooseTimeVideo.Enabled = true;
                    foreach (string item in subdirectoryEntries)
                    {
                        cbChooseTimeVideo.Items.Add(item.Substring(item.LastIndexOf(@"\") + 1));
                    }                    
                }
                else
                {
                    Class_Step4.ChangeFolder(pathscene);
                    cbChooseTimeVideo.Enabled = false;
                    cbChooseTimeVideo.Items.Clear();
                    string pathFileCSV = pathscene + @"/" + listVideo[cs].IDVideo + "-Scenes.csv";
                    Class_Step4.LoadList(ref list, pathFileCSV);
                    Class_Step4.AddRow(list, dgvSubmissions);
                }
            }
            #endregion
        }

        private void btExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btNextVideo_Click(object sender, System.EventArgs e)
        {
            string pathOutput = tbPathListVideo.Text.Remove(tbPathListVideo.Text.LastIndexOf(@"\"));
            using (StreamWriter stream = new StreamWriter(pathOutput + @"\Done.txt", true))
            {
                stream.WriteLine("{0}, {1}, {2}, {3}", listVideo[cs].IDVideo, listVideo[cs].NameVideo, listVideo[cs].NameChannel, listVideo[cs].Time);
            }
            cs++;
            if (cs < listVideo.Count)
            {

                Class_Step4.DeleteAllRow(dgvSubmissions);
                lbNameVideo.Text = listVideo[cs].NameVideo;
                lbLongVideo.Text = listVideo[cs].Time;

                chromeDriver.Navigate().GoToUrl("https://www.youtube.com/watch?v=" + listVideo[cs].IDVideo);

                string pathscene = tbOutputStep3.Text + @"\" + listVideo[cs].IDVideo + ".mp4";

                if (Directory.Exists(pathscene) == false)
                {
                    if (cbNotFoundFolder.Checked == true)
                    {
                        chromeDriver.ExecuteScript("alert('Không có thư mục');");
                    }
                }
                else
                {
                    string[] subdirectoryEntries = Directory.GetDirectories(pathscene);
                    if (subdirectoryEntries.Length > 0)
                    {
                        cbChooseTimeVideo.Enabled = true;
                        foreach (string item in subdirectoryEntries)
                        {
                            cbChooseTimeVideo.Items.Add(item.Substring(item.LastIndexOf(@"\") + 1));
                        }
                    }
                    else
                    {
                        Class_Step4.ChangeFolder(pathscene);
                        cbChooseTimeVideo.Enabled = false;
                        cbChooseTimeVideo.Items.Clear();
                        string pathFileCSV = pathscene + @"/" + listVideo[cs].IDVideo + "-Scenes.csv";
                        Class_Step4.LoadList(ref list, pathFileCSV);
                        Class_Step4.AddRow(list, dgvSubmissions);
                    }
                }
            }
            else
            {
                btNextVideoandProcessing.Enabled = false;
                btNextVideo.Enabled = false;
            }
        }

        private void btNextVideoandProcessing_Click(object sender, System.EventArgs e)
        {
            string pathOutput = tbPathListVideo.Text.Remove(tbPathListVideo.Text.LastIndexOf(@"\"));
            using (StreamWriter stream = new StreamWriter(pathOutput + @"\NotDone.txt", true))
            {
                stream.WriteLine("{0}, {1}, {2}, {3}", listVideo[cs].IDVideo, listVideo[cs].NameVideo, listVideo[cs].NameChannel, listVideo[cs].Time);
            }
            cs++;
            if (cs < listVideo.Count) 
            {
                Class_Step4.DeleteAllRow(dgvSubmissions);
                lbNameVideo.Text = listVideo[cs].NameVideo;
                lbLongVideo.Text = listVideo[cs].Time;

                chromeDriver.Navigate().GoToUrl("https://www.youtube.com/watch?v=" + listVideo[cs].IDVideo);

                string pathscene = tbOutputStep3.Text + @"\" + listVideo[cs].IDVideo + ".mp4";

                if (Directory.Exists(pathscene) == false)
                {
                    if (cbNotFoundFolder.Checked == true)
                    {
                        chromeDriver.ExecuteScript("alert('Không có thư mục');");
                    }
                }
                else
                {
                    string[] subdirectoryEntries = Directory.GetDirectories(pathscene);
                    if (subdirectoryEntries.Length > 0)
                    {
                        cbChooseTimeVideo.Enabled = true;
                        foreach (string item in subdirectoryEntries)
                        {
                            cbChooseTimeVideo.Items.Add(item.Substring(item.LastIndexOf(@"\") + 1));
                        }
                    }
                    else
                    {
                        Class_Step4.ChangeFolder(pathscene);
                        cbChooseTimeVideo.Enabled = false;
                        cbChooseTimeVideo.Items.Clear();
                        string pathFileCSV = pathscene + @"/" + listVideo[cs].IDVideo + "-Scenes.csv";
                        Class_Step4.LoadList(ref list, pathFileCSV);
                        Class_Step4.AddRow(list, dgvSubmissions);
                    }
                }
            }
            else
            {
                btNextVideoandProcessing.Enabled = false;
                btNextVideo.Enabled = false;
            }
        }

        private void cbChooseTimeVideo_SelectedValueChanged(object sender, System.EventArgs e)
        {
            string pathscene = tbOutputStep3.Text + @"\" + listVideo[cs].IDVideo + @".mp4\" + cbChooseTimeVideo.Text;            
            Class_Step4.ChangeFolder(pathscene);
            string pathFileCSV = pathscene + @"\" + listVideo[cs].IDVideo + "-Scenes.csv";
            Class_Step4.LoadList(ref list, pathFileCSV);
            Class_Step4.AddRow(list, dgvSubmissions);
        }
    }
}

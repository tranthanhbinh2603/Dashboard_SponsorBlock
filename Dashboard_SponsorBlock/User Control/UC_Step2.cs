using Dashboard_SponsorBlock.Function;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Dashboard_SponsorBlock.User_Control
{
    public partial class UC_Step2 : UserControl
    {
        List<VideoInfo> listVideo = new List<VideoInfo>();

        public void Download(int countThread)
        {
            bool[] running = new bool[50];
            for (int i = 0; i < countThread; i++)
            {
                running[i] = true;
            }

            for (int i = 0; i < countThread; i++)
            {
                if (i == 0)
                {
                    int copyi = i;
                    string pathPyCode = Application.StartupPath + @"\Thread" + (copyi + 1) + ".py";
                    string pathPyCompile = tbPathCompile.Text + @"\python.exe";
                    Thread thr = new Thread(() =>
                    {
                        running[copyi] = Class_Step2.RunPyCode(pathPyCode, pathPyCompile);
                    });
                    thr.Start();
                }
                else
                {
                    int copyi = i;
                    string pathPyCode = Application.StartupPath + @"\Thread" + (copyi + 1) + ".py";
                    string pathPyCompile = tbPathCompile.Text + @"\python.exe";
                    Thread thr = new Thread(() =>
                    {
                        running[copyi] = Class_Step2.RunPyCode(pathPyCode, pathPyCompile);
                    });
                    thr.Start();
                }
            }

            bool nextStep = true;
            while (nextStep)
            {
                int countOff = 0;
                for (int i = 0; i < countThread; i++)
                {
                    if (running[i] == false)
                    {
                        countOff++;
                    }
                }

                if (countOff == countThread)
                {
                    nextStep = false;
                }
            }
        }

        public UC_Step2()
        {
            InitializeComponent();

            //Cài đặt 1 số cái cần trong việc khởi động
            tbPathFiletxt.Enabled = false;
            tbPathOutFileDownload.Enabled = false;
            tbPathCompile.Enabled = false;
            dgvListVideo.AllowUserToAddRows = false;
            btDeleteVideo.Enabled = false;

            //Hiển thị trong Textbox
            tbPathFiletxt.Text = @"D:\Test Dashboard SponsorBlock\VideoNoSBlock.txt";
            tbPathOutFileDownload.Text = @"D:\Test Dashboard SponsorBlock\VideoDownload";
            tbPathCompile.Text = @"C:\Users\Binh\AppData\Local\Programs\Python\Python38";
        }

        private void btChooseFileListVideo_Click(object sender, System.EventArgs e)
        {
            #region Chọn file & reset list
            string path = Class_Root.ChooseFile("Chọn file chứa toàn bộ video ở bước 1.");
            tbPathFiletxt.Text = path;

            if (dgvListVideo.RowCount != 0)
            {
                dgvListVideo.Rows.Clear();
            }
            if (listVideo.Count >= 1)
            {
                while (listVideo.Count != 0)
                {
                    listVideo.RemoveAt(0);
                }
            }
            #endregion

            #region Tạo list video
            if (tbPathFiletxt.Text != "")
            {
                StreamReader streread = new StreamReader(tbPathFiletxt.Text);
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
                    listVideo.Add(new VideoInfo() { IDVideo = temp[0].Trim(), NameVideo = nameVideoTemp, NameChannel = temp[temp.Length - 2].Trim(), Time = temp[temp.Length - 1].Trim() });
                    res = streread.ReadLine();
                }
            }
            #endregion

            #region Truyền vào DataGridView
            int count = 0;
            foreach (var item in listVideo)
            {
                dgvListVideo.Rows.Add();
                dgvListVideo.Rows[count].Cells[0].Value = item.IDVideo;
                dgvListVideo.Rows[count].Cells[1].Value = item.NameVideo;
                dgvListVideo.Rows[count].Cells[2].Value = item.NameChannel;
                dgvListVideo.Rows[count].Cells[3].Value = item.Time;
                count++;
            }
            #endregion
        }

        private void btGetOutFileDownload_Click(object sender, System.EventArgs e)
        {
            string path = Class_Root.ChooseFolder("Chọn vị trí để tải xuống video.");
            tbPathOutFileDownload.Text = path;
        }

        private void btRefreshList_Click(object sender, System.EventArgs e)
        {
            #region Reset list
            if (dgvListVideo.RowCount != 0)
            {
                dgvListVideo.Rows.Clear();
            }
            if (listVideo.Count >= 1)
            {
                while (listVideo.Count != 0)
                {
                    listVideo.RemoveAt(0);
                }
            }
            #endregion

            #region Tạo list video
            if (tbPathFiletxt.Text != "")
            {
                StreamReader streread = new StreamReader(tbPathFiletxt.Text);
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
                    listVideo.Add(new VideoInfo() { IDVideo = temp[0].Trim(), NameVideo = nameVideoTemp, NameChannel = temp[temp.Length - 2].Trim(), Time = temp[temp.Length - 1].Trim() });
                    res = streread.ReadLine();
                }
            }
            #endregion

            #region Truyền vào DataGridView
            int count = 0;
            foreach (var item in listVideo)
            {
                dgvListVideo.Rows.Add();
                dgvListVideo.Rows[count].Cells[0].Value = item.IDVideo;
                dgvListVideo.Rows[count].Cells[1].Value = item.NameVideo;
                dgvListVideo.Rows[count].Cells[2].Value = item.NameChannel;
                dgvListVideo.Rows[count].Cells[3].Value = item.Time;
                count++;
            }
            #endregion
        }

        private void btExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btDeleteVideo_Click(object sender, System.EventArgs e)
        {
            int rowId = dgvListVideo.CurrentCell.RowIndex;
            string ID = dgvListVideo.Rows[rowId].Cells[0].Value.ToString();
            dgvListVideo.Rows.RemoveAt(rowId);
            listVideo.RemoveAll(r => r.IDVideo == ID);
            if (rowId == dgvListVideo.RowCount)
            {
                btDeleteVideo.Enabled = false;
            }
        }

        private void btRun_Click(object sender, System.EventArgs e)
        {
            int countThread = int.Parse(nmudCountThread.Value.ToString());
            int[] pc = new int[50];
            Class_Root.Chiaphan(listVideo.Count, countThread, ref pc);
            #region Tạo các file py để chạy code
            for (int i = 0; i < countThread; i++)
            {
                if (i == 0)
                {
                    StreamWriter sw1 = new StreamWriter("Thread1.py");
                    sw1.WriteLine("from pytube import YouTube");
                    for (int z = 0; z < pc[i]; z++)
                    {
                        string url = "https://www.youtube.com/watch?v=" + listVideo[z].IDVideo;
                        string output = tbPathOutFileDownload.Text;
                        string filename = listVideo[z].IDVideo + ".mp4";
                        sw1.WriteLine("YouTube(\"" + url + "\").streams.filter(resolution='360p', progressive=True, file_extension='mp4').first().download(output_path=\"" + output + "\", filename=\"" + filename + "\")");
                    }
                    sw1.Close();
                }
                else
                {
                    StreamWriter sw1 = new StreamWriter("Thread" + (i + 1) + ".py");
                    sw1.WriteLine("from pytube import YouTube");
                    for (int z = pc[i - 1]; z < pc[i]; z++)
                    {
                        string url = "https://www.youtube.com/watch?v=" + listVideo[z].IDVideo;
                        string output = tbPathOutFileDownload.Text;
                        string filename = listVideo[z].IDVideo + ".mp4";
                        sw1.WriteLine("YouTube(\"" + url + "\").streams.filter(resolution='360p', progressive=True, file_extension='mp4').first().download(output_path=\"" + output + "\", filename=\"" + filename + "\")");
                    }
                    sw1.Close();
                }
            }
            #endregion

            #region Thực thi tải về đa luồng
            Thread thr = new Thread(() =>
            {
                Download(countThread);
            });
            thr.IsBackground = true;
            thr.Start();
            #endregion

           
        }

        private void btGetPathCompile_Click(object sender, System.EventArgs e)
        {
            string path = Class_Root.ChooseFolder("Chọn thư mục chứa trình biên dịch Python");
            tbPathCompile.Text = tbPathCompile.Text;
        }

        private void btInstallPytube_Click(object sender, System.EventArgs e)
        {
            Process.Start("CMD.exe", "/C" + "pip install pytube");
        }

        private void dgvListVideo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btDeleteVideo.Enabled = true;
        }
    }
}

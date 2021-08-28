using Dashboard_SponsorBlock.Function;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Dashboard_SponsorBlock.User_Control
{
    public partial class UC_Step3 : UserControl
    {
        List<OneVideo> listVideo = new List<OneVideo>();

        public void RunFileBat()
        {
            bool next = true;
            Process.Start(Application.StartupPath + @"\Code.bat").WaitForExit();
            next = false;

            while (next)
            {

            }

            MessageBox.Show("Đã xong");
        }

        public UC_Step3()
        {
            InitializeComponent();

            tbPathTimeVideo.Enabled = false;
            btGetPathTimeVideo.Enabled = false;
            dgvListVideo.AllowUserToAddRows = false;
            dgvListVideo.ScrollBars = ScrollBars.Vertical;
            rbAllVideo.Enabled = false;
            rbNotAllVideo.Enabled = false;
            cbExportImage.Enabled = false;
            btDelete.Enabled = false;
            btSave.Enabled = false;
            dgvListVideo.DefaultCellStyle.Font = new Font("Segoe UI", 10.5F);
            dgvListVideo.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F);
            tbPathVideo.Enabled = false;
            tbOutput.Enabled = false;

            tbPathVideo.Text = @"D:\Test Dashboard SponsorBlock\VideoDownload";
            tbOutput.Text = @"D:\Out Synce";
        }

        private void btGetPathVideo_Click(object sender, System.EventArgs e)
        {
            string path = Class_Root.ChooseFolder("Chọn thư mục chứa các video đã tải về");
            tbPathVideo.Text = path;
            Class_Step3.Deleteallrow(dgvListVideo);           
            if (listVideo.Count >= 1)
            {
                while (listVideo.Count != 0)
                {
                    listVideo.RemoveAt(0);
                }
            }

            string[] files = Directory.GetFiles(path, "*.mp4", SearchOption.TopDirectoryOnly);
            int count = 0;
            string[] namefiles = new string[files.Length];
            foreach (var item in files)
            {
                string tempnamefiles = item.Remove(0, item.LastIndexOf(@"\") + 1);
                namefiles[count] = tempnamefiles;
                count++;
            }
            count = 0;
            foreach (var item in namefiles)
            {
                dgvListVideo.Rows.Add();
                dgvListVideo.Rows[count].Cells[0].Value = item;
                dgvListVideo.Rows[count].Cells[1].Value = true;
                dgvListVideo.Rows[count].Cells[2].Value = true;
                listVideo.Add(new OneVideo() { nameVideo = item, haveExportImage = true, scanAllVideo = true, pathTimeVideo = "" });
                count++;
            }
        }

        private void btPathOutput_Click(object sender, System.EventArgs e)
        {
            string path = Class_Root.ChooseFolder("Chọn thư mục chứa toàn bộ hình ảnh sẽ xuất ra");
            tbOutput.Text = path;
        }

        private void btGetPathTimeVideo_Click(object sender, System.EventArgs e)
        {
            string path = Class_Root.ChooseFile("Chọn file chứa toàn bộ dữ liệu về mốc thời gian");
            tbPathTimeVideo.Text = path;
        }

        private void btRefreshVideo_Click(object sender, System.EventArgs e)
        {
            Class_Step3.Deleteallrow(dgvListVideo);
            if (listVideo.Count >= 1)
            {
                while (listVideo.Count != 0)
                {
                    listVideo.RemoveAt(0);
                }
            }

            string[] files = Directory.GetFiles(tbPathVideo.Text, "*.mp4", SearchOption.TopDirectoryOnly);
            int count = 0;
            string[] namefiles = new string[files.Length];
            foreach (var item in files)
            {
                string tempnamefiles = item.Remove(0, item.LastIndexOf(@"\") + 1);
                namefiles[count] = tempnamefiles;
                count++;
            }
            count = 0;
            foreach (var item in namefiles)
            {
                dgvListVideo.Rows.Add();
                dgvListVideo.Rows[count].Cells[0].Value = item;
                dgvListVideo.Rows[count].Cells[1].Value = true;
                dgvListVideo.Rows[count].Cells[2].Value = true;
                listVideo.Add(new OneVideo() { nameVideo = item, haveExportImage = true, scanAllVideo = true, pathTimeVideo = "" });
                count++;
            }
        }

        private void dgvListVideo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbExportImage.Enabled = true;
            rbAllVideo.Enabled = true;
            rbNotAllVideo.Enabled = true;
            btDelete.Enabled = true;
            btSave.Enabled = true;
            tbPathTimeVideo.Text = "";
            int rowId = dgvListVideo.CurrentCell.RowIndex;
            lbNameVideo.Text = (string)dgvListVideo.Rows[rowId].Cells[0].Value;
            if ((bool)dgvListVideo.Rows[rowId].Cells[1].Value == true)
            {
                cbExportImage.Checked = true;
            }
            else
            {
                cbExportImage.Checked = false;
            }

            if ((bool)dgvListVideo.Rows[rowId].Cells[2].Value == true)
            {
                rbAllVideo.Checked = true;
            }
            else
            {
                rbNotAllVideo.Checked = true;
                tbPathTimeVideo.Text = (string)dgvListVideo.Rows[rowId].Cells[3].Value;
            }
        }

        private void btDelete_Click(object sender, System.EventArgs e)
        {
            int rowId = dgvListVideo.CurrentCell.RowIndex;
            string idVideo = (string)dgvListVideo.Rows[rowId].Cells[0].Value;
            dgvListVideo.Rows.RemoveAt(rowId);
            listVideo.RemoveAll(r => r.nameVideo == idVideo);
            if (rowId != dgvListVideo.RowCount)
            {
                lbNameVideo.Text = (string)dgvListVideo.Rows[rowId].Cells[0].Value;
                if ((bool)dgvListVideo.Rows[rowId].Cells[1].Value == true)
                {
                    cbExportImage.Checked = true;
                }
                else
                {
                    cbExportImage.Checked = false;
                }

                if ((bool)dgvListVideo.Rows[rowId].Cells[2].Value == true)
                {
                    rbAllVideo.Checked = true;
                }
                else
                {
                    rbNotAllVideo.Checked = true;
                    tbPathTimeVideo.Text = (string)dgvListVideo.Rows[rowId].Cells[3].Value;
                }
            }
            else
            {
                lbNameVideo.Text = "";
                rbAllVideo.Enabled = false;
                rbNotAllVideo.Enabled = false;
                cbExportImage.Enabled = false;
                btDelete.Enabled = false;
                btSave.Enabled = false;
            }
        }

        private void rbAllVideo_CheckedChanged(object sender, System.EventArgs e)
        {
            tbPathTimeVideo.Enabled = false;
            btGetPathTimeVideo.Enabled = false;
        }

        private void btExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void rbNotAllVideo_CheckedChanged(object sender, System.EventArgs e)
        {
            tbPathTimeVideo.Enabled = true;
            btGetPathTimeVideo.Enabled = true;
        }

        private void btSave_Click(object sender, System.EventArgs e)
        {
            int rowId = dgvListVideo.CurrentCell.RowIndex;
            int index = listVideo.FindIndex(r => r.nameVideo == lbNameVideo.Text);
            if (cbExportImage.Checked == true)
            {
                dgvListVideo.Rows[rowId].Cells[1].Value = true;
                listVideo[index].haveExportImage = true;
            }
            else
            {
                dgvListVideo.Rows[rowId].Cells[1].Value = false;
                listVideo[index].haveExportImage = false;
            }

            if (rbAllVideo.Checked == true)
            {
                dgvListVideo.Rows[rowId].Cells[2].Value = true;
                dgvListVideo.Rows[rowId].Cells[3].Value = "";
                listVideo[index].scanAllVideo = true;
                listVideo[index].pathTimeVideo = "";
            }
            else
            {
                dgvListVideo.Rows[rowId].Cells[2].Value = false;
                dgvListVideo.Rows[rowId].Cells[3].Value = tbPathTimeVideo.Text;
                listVideo[index].scanAllVideo = false;
                listVideo[index].pathTimeVideo = tbPathTimeVideo.Text;
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://www.python.org/downloads/");
        }

        private void btInstallPythonWin7_Click(object sender, System.EventArgs e)
        {
            Process.Start(Application.StartupPath + @"/installpython.exe");
        }

        private void btInstallLib_Click(object sender, System.EventArgs e)
        {
            Process.Start("CMD.exe", "/C" + "pip install scenedetect[opencv]").WaitForExit();
            Process.Start("CMD.exe", "/C" + "pip install scenedetect[opencv-headless]").WaitForExit();
        }

        private void btRun_Click(object sender, System.EventArgs e)
        {
            if (tbOutput.Text != "" && tbPathVideo.Text != "")
            {
                #region Tạo thư mục chứa sản phẩm đầu ra
                foreach (var item in listVideo)
                {
                    string pathParent = tbOutput.Text + @"/" + item.nameVideo;
                    Directory.CreateDirectory(pathParent);
                    if (item.pathTimeVideo != "")
                    {
                        StreamReader streread = new StreamReader(item.pathTimeVideo);
                        string res = streread.ReadLine();
                        while (res != null)
                        {
                            string[] time = res.Split(' ');
                            if (time.Length == 2)
                            {
                                string path = pathParent + (@"\From " + time[0] + " to " + time[1]).Replace(':', '-');
                                Directory.CreateDirectory(path);
                            }
                            else
                            {
                                string path = pathParent + (@"\From " + time[0] + " to end video").Replace(':', '-');
                                Directory.CreateDirectory(path);
                            }
                            res = streread.ReadLine();
                        }
                    }
                }
                #endregion

                #region Tạo file bat để chạy code
                StreamWriter stream = new StreamWriter(Application.StartupPath + @"\Code.bat");
                stream.WriteLine("@echo off");
                foreach (var item in listVideo)
                {
                    if (item.scanAllVideo == true)
                    {
                        if (item.haveExportImage == true)
                        {
                            stream.WriteLine("scenedetect --input \"" + tbPathVideo.Text + @"\" + item.nameVideo + "\" --output \"" + tbOutput.Text + @"\" + item.nameVideo + "\" detect-content list-scenes save-images");
                        }
                        else
                        {
                            stream.WriteLine("scenedetect --input \"" + tbPathVideo.Text + @"\" + item.nameVideo + "\" --output \"" + tbOutput.Text + @"\" + item.nameVideo + "\" detect-content list-scenes");
                        }
                    }
                    else
                    {
                        if (item.haveExportImage == true)
                        {
                            StreamReader streread = new StreamReader(item.pathTimeVideo);
                            string res = streread.ReadLine();
                            while (res != null)
                            {
                                string[] time = res.Split(' ');
                                if (time.Length == 2)
                                {
                                    stream.WriteLine("scenedetect --input \"" + tbPathVideo.Text + @"\" + item.nameVideo + "\" --output \"" + tbOutput.Text + @"\" + item.nameVideo + (@"\From " + time[0] + " to " + time[1]).Replace(':', '-') + "\" time --start " + time[0] + " --end " + time[1] + " detect-content list-scenes save-images");  
                                }
                                else
                                {
                                    stream.WriteLine("scenedetect --input \"" + tbPathVideo.Text + @"\" + item.nameVideo + "\" --output \"" + tbOutput.Text + @"\" + item.nameVideo + (@"\From " + time[0] + " to end video").Replace(':', '-') + "\" time --start " + time[0] + " detect-content list-scenes save-images");
                                }
                                res = streread.ReadLine();
                            }
                        }
                        else
                        {
                            StreamReader streread = new StreamReader(item.pathTimeVideo);
                            string res = streread.ReadLine();
                            while (res != null)
                            {
                                string[] time = res.Split(' ');
                                if (time.Length == 2)
                                {
                                    stream.WriteLine("scenedetect --input \"" + tbPathVideo.Text + @"\" + item.nameVideo + "\" --output \"" + tbOutput.Text + @"\" + item.nameVideo + (@"\From " + time[0] + " to " + time[1]).Replace(':', '-') + "\" time --start " + time[0] + " --end " + time[1] + " detect-content list-scenes");
                                }
                                else
                                {
                                    stream.WriteLine("scenedetect --input \"" + tbPathVideo.Text + @"\" + item.nameVideo + "\" --output \"" + tbOutput.Text + @"\" + item.nameVideo + (@"\From " + time[0] + " to end video").Replace(':', '-') + "\" time --start " + time[0] + " detect-content list-scenes");
                                }
                                res = streread.ReadLine();
                            }
                        }                        
                    }                    
                }
                stream.Close();
                #endregion

                #region Chạy file bat. Phải đợi cho đến khi xong
                bool next = true;
                Thread thr = new Thread(() =>
                {
                    RunFileBat();
                });
                thr.IsBackground = true;
                thr.Start();                
                #endregion

                
            }
        }
        #region Code copy lại để tái sử dụng
        /*
            * if (tbPathOutput.Text != "" && tbPathVideo.Text != "")
        {
            Directory.CreateDirectory(tbPathOutput.Text + @"\Output");
            foreach (var item in listVideo)
            {
                #region Tạo thư mục
                string pathParent = tbPathOutput.Text + LocDau(@"\Output\" + item.nameVideo);
                rtbOutput.Text += "Thêm Folder " + pathParent + "\n";
                Directory.CreateDirectory(pathParent);
                DirectoryInfo dinfo = new DirectoryInfo(pathParent);
                DirectorySecurity dSecurity = dinfo.GetAccessControl();
                dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
                dinfo.SetAccessControl(dSecurity);

                if (item.pathTimeVideo != "")
                {
                    StreamReader streread = new StreamReader(item.pathTimeVideo);
                    string res = streread.ReadLine();
                    while (res != null)
                    {
                        string[] time = res.Split(' ');
                        if (time.Length == 2)
                        {
                            string path = pathParent + (@"\From " + time[0] + " to " + time[1]).Replace(':', '-');
                            Directory.CreateDirectory(path);
                            rtbOutput.Text += "Thêm Folder " + path + "\n";
                        }
                        else
                        {
                            string path = pathParent + (@"\From " + time[0] + " to end video").Replace(':', '-');
                            Directory.CreateDirectory(path);
                            rtbOutput.Text += "Thêm Folder " + path + "\n";
                        }
                        res = streread.ReadLine();
                    }
                }
            }
            #endregion

            #region Chạy code từng file
            foreach (var item in listVideo)
            {
                if (item.scanAllVideo == true)
                {
                    if (item.haveExportImage == true)
                    {
                        rtbOutput.Text += "Đang thực thi quét cho video " + item.nameVideo + "\n";
                        Process.Start("CMD.exe", "/C" + "scenedetect --input \"" + tbPathVideo.Text + @"\" + item.nameVideo + "\" --output \"" + tbPathOutput.Text + LocDau(@"\Output\" + item.nameVideo) + "\" detect-content list-scenes save-images");

                        IntPtr hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                        Thread.Sleep(5000);
                        while (hdle.ToString() != "0")
                        {
                            Thread.Sleep(500);
                            hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                        }
                    }
                    else
                    {
                        rtbOutput.Text += "Đang thực thi quét cho video " + item.nameVideo + "\n";
                        Process.Start("CMD.exe", "/C" + "scenedetect --input \"" + tbPathVideo.Text + @"\" + item.nameVideo + "\" --output \"" + tbPathOutput.Text + LocDau(@"\Output\" + item.nameVideo) + "\" detect-content list-scenes");

                        IntPtr hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                        Thread.Sleep(5000);
                        while (hdle.ToString() != "0")
                        {
                            Thread.Sleep(500);
                            hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                        }
                    }
                }
                else
                {
                    if (item.haveExportImage == true)
                    {
                        StreamReader streread = new StreamReader(item.pathTimeVideo);
                        string res = streread.ReadLine();
                        while (res != null)
                        {
                            string[] time = res.Split(' ');
                            if (time.Length == 2)
                            {                                   
                                rtbOutput.Text += "Đang thực thi quét cho video " + item.nameVideo + "\n";
                                Process.Start("CMD.exe", "/C" + "scenedetect --input \"" + tbPathVideo.Text + @"\" + item.nameVideo + "\" --output \"" + tbPathOutput.Text + LocDau(@"\Output\" + item.nameVideo) + (@"\From " + time[0] + " to " + time[1]).Replace(':', '-') + "\" time --start " + time[0] + " --end " + time[1] + " detect-content list-scenes save-images");

                                IntPtr hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                                Thread.Sleep(5000);
                                while (hdle.ToString() != "0")
                                {
                                    Thread.Sleep(500);
                                    hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                                }
                            }
                            else
                            {
                                //Quét video có điểm cuối là cuối video
                                rtbOutput.Text += "Đang thực thi quét cho video " + item.nameVideo + "\n";
                                Process.Start("CMD.exe", "/C" + "scenedetect --input \"" + tbPathVideo.Text + @"\" + item.nameVideo + "\" --output \"" + tbPathOutput.Text + LocDau(@"\Output\" + item.nameVideo) + (@"\From " + time[0] + " to end video").Replace(':', '-') + "\" time --start " + time[0] + " detect-content list-scenes save-images");

                                IntPtr hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                                Thread.Sleep(5000);
                                while (hdle.ToString() != "0")
                                {
                                    Thread.Sleep(500);
                                    hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                                }
                            }
                            res = streread.ReadLine();
                        }
                    }
                    else
                    {
                        //Quét theo từng phân đoạn và không xuất ra hình ảnh
                        StreamReader streread = new StreamReader(item.pathTimeVideo);
                        string res = streread.ReadLine();
                        while (res != null)
                        {
                            string[] time = res.Split(' ');
                            if (time.Length == 2)
                            {                                   
                                //Trường hợp quét mà điểm đầu cuối không xác định
                                rtbOutput.Text += "Đang thực thi quét cho video " + item.nameVideo + "\n";
                                Process.Start("CMD.exe", "/C" + "scenedetect --input \"" + tbPathVideo.Text + @"\" + item.nameVideo + "\" --output \"" + tbPathOutput.Text + LocDau(@"\Output\" + item.nameVideo) + (@"\From " + time[0] + " to " + time[1]).Replace(':', '-') + "\" time --start " + time[0] + " --end " + time[1] + " detect-content list-scenes");

                                IntPtr hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                                Thread.Sleep(5000);
                                while (hdle.ToString() != "0")
                                {
                                    Thread.Sleep(500);
                                    hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                                }
                            }
                            else
                            {
                                //Quét video có điểm cuối là cuối video
                                rtbOutput.Text += "Đang thực thi quét cho video " + item.nameVideo + "\n";
                                Process.Start("CMD.exe", "/C" + "scenedetect --input \"" + tbPathVideo.Text + @"\" + item.nameVideo + "\" --output \"" + tbPathOutput.Text + LocDau(@"\Output\" + item.nameVideo) + (@"\From " + time[0] + " to end video").Replace(':', '-') + "\" time --start " + time[0] + " detect-content list-scenes");

                                IntPtr hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                                Thread.Sleep(5000);
                                while (hdle.ToString() != "0")
                                {
                                    Thread.Sleep(500);
                                    hdle = AutoControl.FindWindowHandle("ConsoleWindowClass", null);
                                }
                            }
                            res = streread.ReadLine();
                        }
                    }
                }
            }
        }
        #endregion


        else
        {
            MessageBox.Show("Thiếu đường dẫn chứa file gốc hoặc (và) đường dẫn đầu ra");
        }
            #endregion
            */
        #endregion
    }
}

using Dashboard_SponsorBlock.Function;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Dashboard_SponsorBlock.User_Control
{
    public partial class UC_Step2 : UserControl
    {
        List<VideoInfo> listVideo = new List<VideoInfo>();
        public UC_Step2()
        {
            InitializeComponent();

            //Tắt điều khiển Text Box 
            tbPathFiletxt.Enabled = false;
            tbPathOutFileDownload.Enabled = false;

            //Hiển thị trong Textbox
            tbPathFiletxt.Text = @"D:\Test Dashboard SponsorBlock\VideoNoSBlock.txt";
            tbPathOutFileDownload.Text = @"D:\Test Dashboard SponsorBlock\VideoDownload";
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

        private void dgvListVideo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

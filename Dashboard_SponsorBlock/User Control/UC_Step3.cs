using Dashboard_SponsorBlock.Function;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Dashboard_SponsorBlock.User_Control
{
    public partial class UC_Step3 : UserControl
    {
        List<OneVideo> listVideo = new List<OneVideo>();
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
            //int rowId = dgvListVideo.CurrentCell.RowIndex;\
            //string idVideo = dgvListVideo
            //dgvListVideo.Rows.RemoveAt(rowId);
            //listVideo.RemoveAt(rowId);
            //if (rowId != dgvListVideo.RowCount)
            //{
            //    lbNameVideo.Text = (string)dgvListVideo.Rows[rowId].Cells[0].Value;
            //    if ((bool)dgvListVideo.Rows[rowId].Cells[1].Value == true)
            //    {
            //        cbExportImage.Checked = true;
            //    }
            //    else
            //    {
            //        cbExportImage.Checked = false;
            //    }

            //    if ((bool)dgvListVideo.Rows[rowId].Cells[2].Value == true)
            //    {
            //        rbAllVideo.Checked = true;
            //    }
            //    else
            //    {
            //        rbNotAllVideo.Checked = true;
            //        tbPathTimeVideo.Text = (string)dgvListVideo.Rows[rowId].Cells[3].Value;
            //    }
            //}
            //else
            //{
            //    lbNameVideo.Text = "";
            //    rbAllVideo.Enabled = false;
            //    rbNotAllVideo.Enabled = false;
            //    cbExportImage.Enabled = false;
            //    btDelete.Enabled = false;
            //    btSave.Enabled = false;
            //}
        }
    }
}

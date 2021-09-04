using Dashboard_SponsorBlock.Function;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Windows.Forms;

namespace Dashboard_SponsorBlock.User_Control
{
    public partial class UC_Step4 : UserControl
    {
        List<OneScene> list = new List<OneScene>();

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
            //Class_Step4.LoadList(ref list, @"D:\Project\Project_PySceneDetect_GUI\bin\Debug\test-Scenes.csv");
            //Class_Step4.AddRow(list, dgvSubmissions);
        }

        private void btExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}

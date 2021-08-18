using Dashboard_SponsorBlock.Function;
using System.Windows.Forms;

namespace Dashboard_SponsorBlock.User_Control
{
    public partial class UC_Step2 : UserControl
    {
        public UC_Step2()
        {
            InitializeComponent();
        }

        private void btChooseFileListVideo_Click(object sender, System.EventArgs e)
        {
            string path = Class_Root.ChooseFile("Chọn file chứa toàn bộ video ở bước 1.");
        }

        private void btGetOutFileDownload_Click(object sender, System.EventArgs e)
        {
            string path = Class_Root.ChooseFolder("Chọn vị trí để tải xuống video.");
        }
    }
}

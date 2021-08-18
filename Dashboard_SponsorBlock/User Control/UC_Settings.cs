using Dashboard_SponsorBlock.Function;
using System.Windows.Forms;

namespace Dashboard_SponsorBlock.User_Control
{
    public partial class UC_Settings : UserControl
    {
        public UC_Settings()
        {
            InitializeComponent();
        }

        private void btSavePage_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFolder("Hãy chọn thư mục bạn muốn lưu file");
        }

        private void btImportPage_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFile();
        }

        private void btChooseRestAllVideo_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFile();
        }

        private void btChooseRestVideonoSBlock_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFile();
        }

        private void btChooseRestVideoyesSBlock_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFile();
        }

        private void btChooseRestSBlocker_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFile();
        }

        private void btChooseFolderSelenium_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFolder("Hãy chọn thư mục muốn lưu trữ profile Selenium");
        }

        private void btChooseFileUserID_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFile("Hãy chọn file chứa User ID");
        }

        private void btChooseFileAllOptions_Click(object sender, System.EventArgs e)
        {
            string Path = Class_Root.ChooseFile("Hãy chọn file chứa toàn bộ cài đặt SponsorBlock");
        }
    }
}

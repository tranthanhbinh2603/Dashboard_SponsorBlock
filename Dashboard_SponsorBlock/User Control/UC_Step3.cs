using Dashboard_SponsorBlock.Function;
using System.Windows.Forms;

namespace Dashboard_SponsorBlock.User_Control
{
    public partial class UC_Step3 : UserControl
    {
        public UC_Step3()
        {
            InitializeComponent();
        }

        private void btGetPathVideo_Click(object sender, System.EventArgs e)
        {
            string path = Class_Root.ChooseFolder("Chọn thư mục chứa các video đã tải về");
        }

        private void btPathOutput_Click(object sender, System.EventArgs e)
        {
            string path = Class_Root.ChooseFolder("Chọn thư mục chứa toàn bộ hình ảnh sẽ xuất ra");
        }

        private void btGetPathTimeVideo_Click(object sender, System.EventArgs e)
        {
            string path = Class_Root.ChooseFile("Chọn file chứa toàn bộ dữ liệu về mốc thời gian");
        }
    }
}

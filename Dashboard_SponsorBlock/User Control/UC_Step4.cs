using Dashboard_SponsorBlock.Function;
using System.Windows.Forms;

namespace Dashboard_SponsorBlock.User_Control
{
    public partial class UC_Step4 : UserControl
    {
        public UC_Step4()
        {
            InitializeComponent();
        }

        private void btChooseOutoutStep3_Click(object sender, System.EventArgs e)
        {
            string path = Class_Root.ChooseFolder("Chọn địa chỉ nơi chứa kết quả phân đoạn chuyển cảnh");
        }

        private void btChooseProfileSele_Click(object sender, System.EventArgs e)
        {
            string path = Class_Root.ChooseFolder("Chọn địa chỉ nơi chứa profile Chrome đã được setup. Nếu chưa setup thì vào Cài đặt -> Settings Selenium");
        }

        private void btChooseListVideo_Click(object sender, System.EventArgs e)
        {
            string path = Class_Root.ChooseFolder("Chọn địa chỉ nơi chứa file video. Có thể tạo nó ngay tại bước 1");
        }
    }
}

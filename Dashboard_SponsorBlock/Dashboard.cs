using Dashboard_SponsorBlock.Function;
using Dashboard_SponsorBlock.User_Control;
using System;
using System.Windows.Forms;

namespace Dashboard_SponsorBlock
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            UC_Step1 uc = new UC_Step1();
            Class_Root.AddUserControl(uc, pnMain);
        }

        private void btStep1_Click(object sender, EventArgs e)
        {
            UC_Step1 uc = new UC_Step1();
            Class_Root.AddUserControl(uc,pnMain);
        }

        public void btStep2_Click(object sender, EventArgs e)
        {
            UC_Step2 uc = new UC_Step2();
            Class_Root.AddUserControl(uc, pnMain);
        }

        private void btStep3_Click(object sender, EventArgs e)
        {
            UC_Step3 uc = new UC_Step3();
            Class_Root.AddUserControl(uc, pnMain);
        }

        private void btStep4_Click(object sender, EventArgs e)
        {
            UC_Step4 uc = new UC_Step4();
            Class_Root.AddUserControl(uc, pnMain);
        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            UC_Settings uc = new UC_Settings();
            Class_Root.AddUserControl(uc, pnMain);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

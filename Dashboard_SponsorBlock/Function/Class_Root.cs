using Dashboard_SponsorBlock.Message_Box;
using System.IO;
using System.Net.Mail;
using System.Windows.Forms;

namespace Dashboard_SponsorBlock.Function
{
    class Class_Root
    {
        public static void AddUserControl(UserControl uc, Panel pn)
        {
            uc.Dock = DockStyle.Fill;
            pn.Controls.Clear();
            pn.Controls.Add(uc);
            uc.BringToFront();
        }

        public static string ChooseFile(string title = "Hãy chọn file", string filter = "Text files (*.txt)|*.txt")
        {
            string res = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = filter;
            dialog.Title = title;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                res = dialog.FileName;
            }
            else
            {
                res = "";
            }
            return res;
        }

        public static string ChooseFolder(string messsage = "Hãy chọn thư mục")
        {
            string res = "";
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = messsage;
            if (folder.ShowDialog() == DialogResult.OK)
            {
                res = folder.SelectedPath.ToString();
            }
            return res;
        }

        public static void MessageBox1Button(System.Drawing.Color bcolortitle, System.Drawing.Color fcolortitle, System.Drawing.Color fcolorcontent, System.Drawing.Color bcolorbt, string title, string content, string textbt)
        {
            Fr_1Button fr = new Fr_1Button();
            fr.panelTitle.BackColor = bcolortitle;
            fr.lbTitle.ForeColor = fcolortitle;
            fr.lbTitle.Text = title;

            fr.lbContent.ForeColor = fcolorcontent;
            fr.lbContent.Text = content;

            fr.bt1.BackColor = bcolorbt;
            fr.bt1.Text = textbt;

            fr.ShowDialog();
        }

        public static void MessageBox2Button(System.Drawing.Color bcolortitle, System.Drawing.Color fcolortitle, System.Drawing.Color fcolorcontent, System.Drawing.Color bcolorbt, string title, string content, string textbt1, string textbt2)
        {
            Fr_2Button fr = new Fr_2Button();
            fr.panelTitle.BackColor = bcolortitle;
            fr.lbTitle.ForeColor = fcolortitle;
            fr.lbTitle.Text = title;

            fr.lbContent.ForeColor = fcolorcontent;
            fr.lbContent.Text = content;

            fr.bt1.BackColor = bcolorbt;
            fr.bt2.BackColor = bcolorbt;
            fr.bt1.Text = textbt1;
            fr.bt2.Text = textbt2;

            fr.ShowDialog();
        }

        public static void SendMail(string mailto, string passwordto, string mailfrom, string title, string content)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress(mailto);
            mail.To.Add(mailfrom);
            mail.Subject = title;
            mail.Body = content;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(mailto, passwordto);
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }

        public static bool CheckFile(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Chiaphan(int n, int sophan, ref int[] kq)
        {
            int ph_nguyen = n / sophan;
            int ph_du = n % sophan;
            int cs = 0;
            int hien_tai = 0;
            for (int i = 1; i <= sophan; i++)
            {
                if (cs < ph_du)
                {
                    kq[i - 1] = hien_tai + ph_nguyen + 1;
                    cs += 1;
                    hien_tai = kq[i - 1];
                }
                else
                {
                    kq[i - 1] = hien_tai + ph_nguyen;
                    hien_tai = kq[i - 1];
                }
            }
        }
    }
}

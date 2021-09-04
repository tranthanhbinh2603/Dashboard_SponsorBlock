using KAutoHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Dashboard_SponsorBlock.Function
{
    class OneScene
    {
        public string ID { get; set; }
        public string StartSec { get; set; }
        public string StartHour { get; set; }
        public string EndSec { get; set; }
        public string EndHour { get; set; }
    }

    class VideoInfo2
    {
        public string IDVideo { get; set; }
        public string NameVideo { get; set; }
        public string NameChannel { get; set; }
        public string Time { get; set; }
    }

    class Class_Step4
    {
        public static void AddRow(List<OneScene> list, DataGridView dgv)
        {
            int count = 0;
            foreach (var item in list)
            {
                dgv.Rows.Add();
                dgv.Rows[count].Cells[0].Value = item.ID;
                dgv.Rows[count].Cells[1].Value = item.StartSec;
                dgv.Rows[count].Cells[2].Value = item.StartHour;
                dgv.Rows[count].Cells[3].Value = item.EndSec;
                dgv.Rows[count].Cells[4].Value = item.EndHour;
                count++;
            }
            
        }

        public static void LoadList(ref List<OneScene> list, string pathFile)
        {
            list.Clear();

            StreamReader streread = new StreamReader(pathFile);
            string res = streread.ReadLine();
            while (res != null)
            {
                if ((res.IndexOf("Timecode List:") == -1) && (res.IndexOf("Scene Number") == -1))
                {
                    string[] word = res.Split(',');
                    list.Add(new OneScene() { ID = word[0], StartHour = word[2], StartSec = word[3], EndHour = word[5], EndSec = word[6] });
                }
                res = streread.ReadLine();
            }            
        }

        public static void DeleteAllRow(DataGridView dgv)
        {
            if (dgv.RowCount != 0)
            {
                dgv.Rows.Clear();
            }
        }

        public static void AddRow(List<OneScene> list, DataGridView dgv, int cs)
        {           
            dgv.Rows.Add();
            dgv.Rows[0].Cells[0].Value = list[cs - 1].ID;
            dgv.Rows[0].Cells[1].Value = list[cs - 1].StartSec;
            dgv.Rows[0].Cells[2].Value = list[cs - 1].StartHour;
            dgv.Rows[0].Cells[3].Value = list[cs - 1].EndSec;
            dgv.Rows[0].Cells[4].Value = list[cs - 1].EndHour;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        private const UInt32 WM_CLOSE = 0x0010;

        public static void CloseWindow(IntPtr hwnd)
        {
            SendMessage(hwnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
        }

        public static void ChangeFolder(string path)
        {
            IntPtr hdle = AutoControl.FindWindowHandle("CabinetWClass", null);
            CloseWindow(hdle);
            Process.Start("explorer.exe", path);
        }
    }
}

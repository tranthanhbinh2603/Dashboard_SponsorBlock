using System.Collections.Generic;
using System.IO;
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
    }
}

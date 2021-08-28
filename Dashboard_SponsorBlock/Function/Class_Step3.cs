using System.Windows.Forms;

namespace Dashboard_SponsorBlock.Function
{
    class OneVideo
    {
        public string nameVideo { get; set; }
        public bool haveExportImage { get; set; }
        public bool scanAllVideo { get; set; }
        public string pathTimeVideo { get; set; }

    }

    class Class_Step3
    {

        public static void Deleteallrow(DataGridView dgv)
        {
            if (dgv.RowCount != 0)
            {
                dgv.Rows.Clear();
            }
        }
    }
}

using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Dashboard_SponsorBlock.Function
{
    class VideoInfo
    {
        public string IDVideo { get; set; }
        public string NameVideo { get; set; }
        public string NameChannel { get; set; }
        public string Time { get; set; }
    }

    class Class_Step2
    {
        public static bool RunPyCode(string pathPycode, string pathPyCompile)
        {
            var psi = new ProcessStartInfo();
            psi.FileName = pathPyCompile;
            string Script = pathPycode;
            psi.Arguments = $"\"{Script}\"";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            Process prc = new Process();
            prc.StartInfo = psi;
            prc.Start();
            prc.WaitForExit();
            return false;
            
        }
    }
}

using System;

namespace NodeRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var info = System.Diagnostics.Process.GetCurrentProcess();
            var proc = new System.Diagnostics.ProcessStartInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + @"\nodejs\node.exe", "\"" + info.ProcessName + ".js\" " + String.Join(" ", args));
            proc.UseShellExecute = false;
            System.Diagnostics.Process.Start(proc);
        }
    }
}

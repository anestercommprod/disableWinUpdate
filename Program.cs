using System.Diagnostics;
using System.Threading;

namespace disableWinUpdate
{
    class Program
    {
        static void Main()
        {
            Process.Start("cmd.exe", "/K cls && sc config wuauserv start=disabled && sc stop wuauserv && sc stop WaaSMedicSvc && echo 'updates paused, at least, for now...' && pause && exit");
            Thread.Sleep(1);
            System.Environment.Exit(1);
        }
    }
}

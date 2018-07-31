using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using Microsoft.Win32;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using System.Timers;
using System.Threading;

namespace uninstall
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Process[] myProcesses2;
            myProcesses2 = System.Diagnostics.Process.GetProcessesByName("fgsocks");
            foreach (System.Diagnostics.Process instance2 in myProcesses2)
            {
                instance2.CloseMainWindow();
            }
            System.Diagnostics.Process[] myProcesses3;
            myProcesses3 = System.Diagnostics.Process.GetProcessesByName("launcher");
            foreach (System.Diagnostics.Process instance3 in myProcesses3)
            {
                instance3.CloseMainWindow();
            }
            RegistryKey mykey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            mykey.SetValue("ProxyEnable", 0x0);
            mykey.SetValue("ProxyServer", "");
            Process.Start("IExplore.exe");
            Thread.Sleep(3000);
            System.Diagnostics.Process[] myProcesses;
            myProcesses = System.Diagnostics.Process.GetProcessesByName("IEXPLORE");
            foreach (System.Diagnostics.Process instance in myProcesses)
            {
                instance.CloseMainWindow();
            }
        }
    }
}

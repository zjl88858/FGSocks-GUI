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

namespace set_proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistryKey proxykey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            proxykey.SetValue("ProxyEnable", 0x1);
            proxykey.SetValue("ProxyServer", "127.0.0.1:1080");
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
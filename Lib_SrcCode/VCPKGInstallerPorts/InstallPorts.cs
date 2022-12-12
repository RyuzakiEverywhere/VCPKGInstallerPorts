using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCPKGInstallerPorts
{
    public class InstallPorts
    {
        public void InstallViaString(string ports_name, string x64_or_x86, string os_name)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "cmd.exe";
            start.Arguments = $"/c vcpkg install {ports_name}:{x64_or_x86}-{os_name}";
            start.Verb = "runas";
            start.WindowStyle = ProcessWindowStyle.Normal;
            Process.Start(start);
        }
        public bool DetectVCPKG()
        {
            if (Directory.Exists("C:\\vcpkg"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

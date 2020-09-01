using System.Reflection;
using Microsoft.Build.Utilities;

namespace SteamKit.pull912
{
    public class Test : Task
    {
        public override bool Execute()
        {
            Assembly.LoadFrom("bin/Debug/netcoreapp3.1/SteamKit.pull912.dll");
            Program.Main();
            return true;
        }
    }
}
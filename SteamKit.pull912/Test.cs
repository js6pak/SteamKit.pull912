using System.IO;
using System.Reflection;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace SteamKit.pull912
{
    public class Test : Task
    {
        public override bool Execute()
        {
            var path = Path.Combine("bin", "Debug", "netcoreapp3.1", "SteamKit.pull912.dll");
            Log.LogMessage(MessageImportance.High, path);
            Assembly.LoadFrom(path);
            Program.Main();
            return true;
        }
    }
}
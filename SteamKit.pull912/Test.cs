using System;
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
            var path = Path.Combine("bin", "Debug", "net472", "SteamKit2.dll");
            Log.LogMessage(MessageImportance.High, path);
            Console.WriteLine(Assembly.LoadFrom(path));
            Program.Main();
            return true;
        }
    }
}
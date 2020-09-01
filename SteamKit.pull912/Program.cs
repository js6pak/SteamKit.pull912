using System;

namespace SteamKit.pull912
{
    public class Program
    {
        public static void Main()
        {
            var type = Type.GetType("SteamKit2.MachineInfoProvider, SteamKit2")!;
            var provider = type.GetMethod("GetProvider")!.Invoke(null, new object[0])!;
            Console.WriteLine(provider);
            Console.WriteLine(type.GetMethod("GetMachineGuid")!.Invoke(provider, new object[0]));
        }
    }
}
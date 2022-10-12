using System;

using KeLi.DynamicExtension.Tool;

namespace KeLi.DynamicExtension.Plugin.SystemInfo
{
    public class SystemInfoGetCommand : BaseCommand
    {
        public override void Start()
        {
            Console.WriteLine("Getting System Information...");
        }

        public override void Close()
        {
            Console.WriteLine("Closing...");
        }
    }
}

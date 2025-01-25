using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyRemap
{
    public class CommandParser
    {
        public static void Parse(string[] args)
        {
            if (args.Length == 0)
            {
                DisplayHelp();
                return;
            }

            switch (args[0].ToLower())
            {
                case "remap":
                    KeyMapper.StartRemapping();
                    break;
                default:
                    DisplayHelp();
                    break;
            }
        }

        private static void DisplayHelp()
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("  keyremap.exe remap            - Start the key remapping process.");
        }
    }

}

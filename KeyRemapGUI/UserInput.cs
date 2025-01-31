using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyRemap
{
    public class UserInput
    {
        public static string CaptureKey()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true); // capture without printing the key
            return keyInfo.Key.ToString();
        }

        public static string Prompt(string message) // prompt for input
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static bool Confirm()
        {
            string response = Console.ReadLine();
            return response?.ToLower() == "y";
        }
    }

}

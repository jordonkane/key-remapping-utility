using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyRemap
{
    public class UserInput
    {
        // Capture the user's key press and return the key name
        public static string CaptureKey()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true); // Capture without printing the key
            return keyInfo.Key.ToString();
        }

        // Prompt for input (without interception)
        public static string Prompt(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        // Confirmation prompt
        public static bool Confirm()
        {
            string response = Console.ReadLine();
            return response?.ToLower() == "y";
        }
    }

}

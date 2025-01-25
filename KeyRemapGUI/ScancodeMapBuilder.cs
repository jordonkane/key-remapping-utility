using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyRemap
{
    public class ScancodeMapBuilder
    {
        // Private dictionary to store key names and their corresponding scancodes
        private static Dictionary<string, int> keyNameToScancode = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
            { "Letter: A (0x1E)", 0x1E }, { "Letter: B (0x30)", 0x30 }, { "Letter: C (0x2E)", 0x2E }, { "Letter: D (0x20)", 0x20 }, { "Letter: E (0x12)", 0x12 },
            { "Letter: F (0x21)", 0x21 }, { "Letter: G (0x22)", 0x22 }, { "Letter: H (0x23)", 0x23 }, { "Letter: I (0x17)", 0x17 }, { "Letter: J (0x24)", 0x24 },
            { "Letter: K (0x25)", 0x25 }, { "Letter: L (0x26)", 0x26 }, { "Letter: M (0x32)", 0x32 }, { "Letter: N (0x31)", 0x31 }, { "Letter: O (0x18)", 0x18 },
            { "Letter: P (0x19)", 0x19 }, { "Letter: Q (0x10)", 0x10 }, { "Letter: R (0x13)", 0x13 }, { "Letter: S (0x1F)", 0x1F }, { "Letter: T (0x14)", 0x14 },
            { "Letter: U (0x16)", 0x16 }, { "Letter: V (0x2F)", 0x2F }, { "Letter: W (0x11)", 0x11 }, { "Letter: X (0x2D)", 0x2D }, { "Letter: Y (0x15)", 0x15 },
            { "Letter: Z (0x2C)", 0x2C }, { "Num: 1 (0x02)", 0x02 }, { "Num: 2 (0x03)", 0x03 }, { "Num: 3 (0x04)", 0x04 }, { "Num: 4 (0x05)", 0x05 },
            { "Num: 5 (0x06)", 0x06 }, { "Num: 6 (0x07)", 0x07 }, { "Num: 7 (0x08)", 0x08 }, { "Num: 8 (0x09)", 0x09 }, { "Num: 9 (0x0A)", 0x0A },
            { "Num: 0 (0x0B)", 0x0B }, { "Special: Space (0x39)", 0x39 }, { "Special: Enter (0x1C)", 0x1C }, { "Special: Esc (0x01)", 0x01 }
        };


        // Public method to expose the keyNameToScancode dictionary
        public static Dictionary<string, int> GetKeyNameToScancode()
        {
            return keyNameToScancode;
        }

        // Get scancode from key name
        public static int GetScancodeFromKeyName(string keyName)
        {
            if (keyNameToScancode.TryGetValue(keyName, out int scancode))
            {
                return scancode;
            }
            return -1; // invalid key
        }

        // Display all key names to the user
        public static void DisplayAvailableKeyNames()
        {
            Console.WriteLine("Available key names:");
            foreach (var keyName in keyNameToScancode.Keys)
            {
                Console.WriteLine(keyName);
            }
        }

        // Build the scancode map byte array
        public static byte[] BuildScancodeMap(int originalScancode, int newScancode)
        {
            return new byte[]
            {
                0x00, 0x00, 0x00, 0x00,  // header
                0x00, 0x00, 0x00, 0x00,  // header cont.
                0x02, 0x00, 0x00, 0x00,  // number of mappings (1 remap + terminator)
                (byte)newScancode, 0x00, (byte)originalScancode, 0x00,  // mapping new key to old key
                0x00, 0x00, 0x00, 0x00   // terminator
            };
        }
    }
}

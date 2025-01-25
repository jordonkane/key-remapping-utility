using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyRemap
{
    public class KeyMapper
    {
        public static void StartRemapping()
        {
            RegistryManager registryManager = new RegistryManager();

            // capture the key the user wants to remap
            Console.WriteLine("Press the key you want to remap:");
            string originalKey = UserInput.CaptureKey();

            // get scancode from key name
            int originalScancode = ScancodeMapBuilder.GetScancodeFromKeyName(originalKey);
            if (originalScancode == -1)
            {
                Console.WriteLine($"Invalid key: {originalKey}. Aborting.");
                return;
            }

            // ask for confirmation
            Console.WriteLine($"You pressed: {originalKey}. Do you want to remap this key? (y/n)");
            if (!UserInput.Confirm())
            {
                Console.WriteLine("Remapping cancelled.");
                return;
            }

            // display available keys
            ScancodeMapBuilder.DisplayAvailableKeyNames();

            // get the new key
            string newKeyName = UserInput.Prompt("Type the name of the key you want to remap it to:");
            int newScancode = ScancodeMapBuilder.GetScancodeFromKeyName(newKeyName);
            if (newScancode == -1)
            {
                Console.WriteLine($"Invalid key: {newKeyName}. Remapping cancelled.");
                return;
            }

            // final confirmation
            Console.WriteLine($"Are you sure you want to remap {originalKey} to {newKeyName}? (y/n)");
            if (!UserInput.Confirm())
            {
                Console.WriteLine("Remapping cancelled.");
                return;
            }

            // build the scancode map and perform key remapping in the registry
            byte[] scancodeMap = ScancodeMapBuilder.BuildScancodeMap(originalScancode, newScancode);
            registryManager.RemapKeyInRegistry(scancodeMap);
            Console.WriteLine("Key remapped. Please restart your computer for the changes to take effect.");
        }
    }
}

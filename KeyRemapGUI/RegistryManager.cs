using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyRemap.Interface;
using Microsoft.Win32;

namespace KeyRemap
{

    public class RegistryManager : IRegistryManager
    {
        private string registryPath = @"SYSTEM\CurrentControlSet\Control\Keyboard Layout";

        // write a new scancode map to the registry
        public void RemapKeyInRegistry(byte[] scancodeMap)
        {
            // open the registry key with write access
            RegistryKey key = Registry.LocalMachine.OpenSubKey(registryPath, writable: true);
            if (key != null)
            {
                // write the scancode map to the registry
                key.SetValue("Scancode Map", scancodeMap, RegistryValueKind.Binary);
                key.Close();
                Console.WriteLine("Key remapping successful. Please restart your computer.");
            }
            else
            {
                Console.WriteLine("Error accessing the registry.");
            }
        }

        // reset the key mappings (reset the scancode map)
        public void ResetKeyMappings()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(registryPath, writable: true);
            if (key != null)
            {
                // delete the scancode map value
                key.DeleteValue("Scancode Map", false);
                key.Close();
                Console.WriteLine("Key mappings reset. Please restart your computer.");
            }
        }
    }


}

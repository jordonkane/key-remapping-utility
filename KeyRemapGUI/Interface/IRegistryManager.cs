using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyRemap.Interface
{
    public interface IRegistryManager
    {
        void RemapKeyInRegistry(byte[] scancodeMap);
        void ResetKeyMappings();
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideoTwo.Services
{
    public class HardcodedMessageService : IMessageservice
    {
        public string GetMessage()
        {
            return "Hardcoded message from a service.";
        }
    }
}

using Microsoft.Azure.IoT.Gateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleCSSender
{
    public class TKSender : IGatewayModule, IGatewayModuleStart
    {
        public void Create(Broker broker, byte[] configuration)
        {
        }

        public void Destroy()
        {
        }

        public void Receive(Message received_message)
        {
            throw new NotImplementedException();
        }

        public void Start()
        {

        }
    }
}

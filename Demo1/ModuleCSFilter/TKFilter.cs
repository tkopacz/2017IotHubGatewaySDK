using Microsoft.Azure.IoT.Gateway;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleCSFilter
{
    public class TKFilter : IGatewayModule, IGatewayModuleStart
    {
        private Broker m_broker;
        private string m_configurationStr;

        public void Create(Broker broker, byte[] configuration)
        {
            this.m_broker = broker;
            this.m_configurationStr = System.Text.Encoding.UTF8.GetString(configuration);
        }
         
        public void Destroy()
        {
        }

        public void Receive(Message received_message)
        {
            if (received_message.Properties.ContainsKey("filterprop")) return;
            var str = Encoding.UTF8.GetString(received_message.Content);

            JObject cfg = JObject.Parse(str);
            if (cfg.TryGetValue("ADC7", out JToken jADC7))
            {
                if ((int)jADC7 < 10) return;
            }
            m_broker.Publish(received_message);
        }

        public void Start()
        {
        }
    }
}

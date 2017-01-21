using Microsoft.Azure.IoT.Gateway;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ModuleCSSender
{
    public class TKSender : IGatewayModule, IGatewayModuleStart
    {
        private Broker broker;
        private string configuration;

        public void Create(Broker broker, byte[] configuration)
        {
            this.broker = broker;
            this.configuration = System.Text.Encoding.UTF8.GetString(configuration);
        }

        public void Destroy()
        {
        }

        public void Receive(Message received_message)
        {
            //throw new NotImplementedException();
        }

        public void Start()
        {
            Thread oThread = new Thread(new ThreadStart(this.threadBody));
            // Start the thread
            oThread.Start();
        }

        static Random rnd = new Random();

        private void threadBody()
        {
            Random r = new Random();
            int n = r.Next();

            while (true)
            {
                Dictionary<string, string> msgProp= new Dictionary<string, string>();
                DateTime now = DateTime.Now;
                TimeSpan ts = new TimeSpan(now.Year, now.Minute, now.Second, now.Millisecond);
                MAllNum mallnum = new MAllNum()
                {
                    DeviceName = "PC",
                    Light = 1000 * Math.Cos(ts.TotalMilliseconds / 175) * Math.Sin(ts.TotalMilliseconds / 360) + rnd.Next(30),
                    Potentiometer1 = 1000 * Math.Cos(ts.TotalMilliseconds / 275) * Math.Sin(ts.TotalMilliseconds / 560) + rnd.Next(30),
                    Potentiometer2 = 1000 * Math.Cos(ts.TotalMilliseconds / 60) * Math.Sin(ts.TotalMilliseconds / 120) + rnd.Next(30),
                    Pressure = (float)(1000 * Math.Cos(ts.TotalMilliseconds / 180) * Math.Sin(ts.TotalMilliseconds / 110) + rnd.Next(30)),
                    Temperature = (float)(1000 * Math.Cos(ts.TotalMilliseconds / 180) * Math.Sin(ts.TotalMilliseconds / 110) + rnd.Next(30)),
                    ADC3 = rnd.Next(1000),
                    ADC4 = rnd.Next(1000),
                    ADC5 = rnd.Next(1000),
                    ADC6 = rnd.Next(1000),
                    ADC7 = rnd.Next(1000),
                    Altitude = (float)(1000 * Math.Cos(ts.TotalMilliseconds / 480) * Math.Sin(ts.TotalMilliseconds / 2000) + rnd.Next(30)),
                };
                if (rnd.NextDouble() > 0.8) { msgProp.Add("direction", "eventhub"); }
                if (rnd.NextDouble() > 0.9) { msgProp.Add("status", "error"); }


                Message messageToPublish = new Message(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(mallnum)), msgProp);
                this.broker.Publish(messageToPublish);

                Thread.Sleep(5000);

            }
        }
    }
    public class MIoTBase
    {
        public DateTime Dt { get; } = DateTime.Now;
        public string MsgType { get; set; }
        public string DeviceName { get; set; }
        protected MIoTBase(string msgType)
        {
            Dt = DateTime.Now;
            MsgType = msgType;
        }
    }
    public class MSPI : MIoTBase
    {
        public double Potentiometer1 { get; set; }
        public double Potentiometer2 { get; set; }
        public double Light { get; set; }
        public MSPI() : base("MSPI") { }
        public MSPI(string msgType) : base(msgType) { }
    }
    public class MAllNum : MSPI
    {
        public double ADC3 { get; internal set; }
        public double ADC4 { get; internal set; }
        public double ADC5 { get; internal set; }
        public double ADC6 { get; internal set; }
        public double ADC7 { get; internal set; }
        public float Altitude { get; internal set; }
        public float Pressure { get; internal set; }
        public float Temperature { get; internal set; }
        public MAllNum() : base("MAllNum") { }
    }

}
